import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LinkerService } from '../../linker.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})
export class FooterComponent {

  constructor(private linker: LinkerService, private toast: ToastrService)
  {

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
