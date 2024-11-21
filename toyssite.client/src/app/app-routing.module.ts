import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

@NgModule({
  imports: [RouterModule.forRoot([
    {path: '', redirectTo: '/home', pathMatch: 'full'},
    {path: 'bill', loadChildren: () => import('./buying/buying.module').then(x => x.BuyingModule)}
  ])],
  exports: [RouterModule]
})
export class AppRoutingModule { }
