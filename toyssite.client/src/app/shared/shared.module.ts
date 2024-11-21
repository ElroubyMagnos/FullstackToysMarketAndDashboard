import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { SearchfilterComponent } from './searchfilter/searchfilter.component';
import { ShopComponent } from './shop/shop.component';
import { CallusComponent } from './callus/callus.component';
import { RouterModule } from '@angular/router';
import { CategoryshowComponent } from './categoryshow/categoryshow.component';
import { ParticlesModule } from '../particles/particles.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    HomeComponent,
    SearchfilterComponent,
    ShopComponent,
    CallusComponent,
    CategoryshowComponent
  ],
  imports: [
    CommonModule,
    ParticlesModule,
    RouterModule.forChild([
      {path: '', redirectTo: '/home', pathMatch: 'full'},
      {path: 'home', component: HomeComponent},
      {path: 'shop', component: ShopComponent},
      {path: 'search', component: SearchfilterComponent},
      {path: 'callus', component: CallusComponent},
      {path: 'catshow/:id', component: CategoryshowComponent}
    ]),
    FormsModule
  ]
})
export class SharedModule { }
