import { Component, Input, input } from '@angular/core';
import { Product } from '../../models/product';
import { LinkerService } from '../../linker.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  @Input() pro!: Product;

  AddToCart()
  {
    this.linker.AddToCartThrough.next(this.pro);
  }

  constructor(private linker: LinkerService)
  {

  }
}
