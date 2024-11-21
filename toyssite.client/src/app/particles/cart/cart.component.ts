import { Component } from '@angular/core';
import { LinkerService } from '../../linker.service';
import { Product } from '../../models/product';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrl: './cart.component.css'
})
export class CartComponent {
  

  constructor(public linker: LinkerService, private router: Router)
  {
    if (localStorage.getItem('paidproducts'))
    {
      var AllPros: Product[] = JSON.parse(localStorage.getItem('paidproducts')!);
      this.linker.AddedProducts.push(...AllPros);
    }

    this.linker.AddToCartThrough.subscribe(x => 
    {
      var Found = false;

      this.linker.AddedProducts.forEach(pro => 
      {
        if (x.id === pro.id)
        {
          pro.price += x.price;
          Found = true;
          return;
        }
      });

      if (!Found)
        this.linker.AddedProducts.push(x);

      localStorage.setItem('paidproducts', JSON.stringify(this.linker.AddedProducts));
    });
  }

  GoToBill()
  {
    this.router.navigate(['/bill/'])
  }
}
