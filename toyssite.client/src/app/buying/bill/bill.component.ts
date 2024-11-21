import { Component, isDevMode } from '@angular/core';
import { Product } from '../../models/product';
import { LinkerService } from '../../linker.service';
import { ToastrService } from 'ngx-toastr';
import { BasicInfo } from '../../models/basicinfo';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';
import { PaidProduct } from '../../models/paidproduct';
import { Bill } from '../../models/bill';

@Component({
  selector: 'app-bill',
  templateUrl: './bill.component.html',
  styleUrl: './bill.component.css'
})
export class BillComponent {
  ReceivedBillNumber: number = 0;
  Address!: BasicInfo;
  IsDelivery: boolean = false;

  CurrentBill!: Bill;
  CurrentProducts: PaidProduct[] = [];
  FullPrice: number = 0;

  constructor(public linker: LinkerService, public toast: ToastrService, private http: HttpClient)
  {
    this.http.get<Bill>(`/Base/GetBill/`)
    .subscribe(x => this.CurrentBill = x);

    this.http.get<PaidProduct[]>(`/Base/GetCurrentProducts/`)
    .subscribe(x => 
    {
      this.CurrentProducts = x;
      
      this.CurrentProducts.forEach(x => this.FullPrice += x.price);
    }
    );

    this.http.get<BasicInfo>(`/Base/GetCallInfo/`)
    .subscribe(x => this.Address = x);
  }

  ChangeState()
  {
    this.IsDelivery = !this.IsDelivery;
    if (this.IsDelivery)
    {
      this.toast.success('توصيل للمنزل');
    }
    else
    {
      this.toast.error('استلام من المقر');
    }
  }

  SubmitBill(f: NgForm)
  {
    if (f.valid)
    {
      this.http.post<number>(`/Base/SignBill`, 
      {
        IsDelivery: this.IsDelivery,
        CPhone: f.value.CustomerPhone != null ? f.value.CustomerPhone : 'none',
        CAddress: f.value.CustomerAddress != null ? f.value.CustomerAddress : 'none',
        PaidProducts: this.linker.AddedProducts 
      }).subscribe(x => 
      {
        if (x != 0)
        {
          this.toast.success('تم تسجيل الطلب')
          this.ReceivedBillNumber = x;
          this.linker.AddedProducts = [];
          this.IsDelivery = false;
          localStorage.clear();
        }  
        else this.toast.error('حدث خطأ ما');
      });
    }  
  }

  Copy()
  {
    navigator.clipboard.writeText(this.ReceivedBillNumber.toString());
    this.toast.success('تم نسخ الرقم');
  }
}
