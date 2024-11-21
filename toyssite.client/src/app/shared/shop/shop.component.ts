import { Component } from '@angular/core';
import { Product } from '../../models/product';
import { LinkerService } from '../../linker.service';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';
import { Category } from '../../models/category';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrl: './shop.component.css'
})
export class ShopComponent {
  AllProducts: Product[] = [];
  ProductsIDs: number[] = [];
  Loading: boolean = false;
  AllCats: Category[] = [];

  async GetProductOperation()
  {
    if (this.Loading) return;

    this.Loading = true;
    
    var Products = await firstValueFrom(this.http.post<Product[]>(`/Base/GetProWithIDs/`, this.ProductsIDs));
    
    Products.forEach(x => this.ProductsIDs.push(x.id));

    this.AllProducts.push(...Products);
    
    this.Loading = false;
  }

  constructor(private http: HttpClient, private linker: LinkerService)
  {
    this.linker.GetAllCats().subscribe(x => this.AllCats = x);

    this.GetProductOperation();
    
    window.onscroll = async () => 
    {
      if ((window.innerHeight + Math.round(window.scrollY)) >= document.body.offsetHeight) 
      {
        await this.GetProductOperation();
      }
    };
  }
}
