import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LinkerService } from '../../linker.service';
import { Toast, ToastrModule, ToastrService } from 'ngx-toastr';
import { BasicInfo } from '../../models/basicinfo';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-callus',
  templateUrl: './callus.component.html',
  styleUrl: './callus.component.css'
})
export class CallusComponent {

  basicinfo!: BasicInfo;

  constructor(private linker: LinkerService, private toast: ToastrService, private http: HttpClient)
  {
    this.http.get<BasicInfo>(`/Base/GetCallInfo`)
    .subscribe(x => this.basicinfo = x);
  }

  ShowAddress()
  {
    this.toast.success(this.basicinfo.addressOfUs);
  }

  SendEmailMsg(f: NgForm)
  {
    if (f.valid)
    {
      this.linker.SendEmailMessage(f).subscribe(x => 
      {
        if (x)
        {
          this.toast.success('تم الارسال بنجاح');
        }  
        else
        {
          this.toast.error('يتعذر الارسال');
        }

        f.reset();
      });
    }
  }
}
