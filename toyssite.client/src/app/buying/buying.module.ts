import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BillComponent } from './bill/bill.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    BillComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path: '', component: BillComponent}
    ]),
    FormsModule
  ]
})
export class BuyingModule { }
