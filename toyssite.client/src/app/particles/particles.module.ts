import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { CartComponent } from './cart/cart.component';
import { FloatingchatComponent } from './floatingchat/floatingchat.component';
import { RouterModule } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { DecimalfixerPipe } from '../decimalfixer.pipe';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    CartComponent,
    FloatingchatComponent,
    ProductComponent,
    DecimalfixerPipe
  ],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule
  ],
  exports: [
    HeaderComponent,
    FooterComponent,
    CartComponent,
    FloatingchatComponent,
    ProductComponent
  ]
})
export class ParticlesModule { }
