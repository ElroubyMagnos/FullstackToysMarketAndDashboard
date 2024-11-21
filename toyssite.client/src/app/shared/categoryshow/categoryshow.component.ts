import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Product } from '../../models/product';
import { ActivatedRoute } from '@angular/router';
import { Category } from '../../models/category';

@Component({
  selector: 'app-categoryshow',
  templateUrl: './categoryshow.component.html',
  styleUrl: './categoryshow.component.css'
})
export class CategoryshowComponent {
  Loading: boolean = false;
  ProductsIDs: number[] = [];
  CatProducts: Product[] = [];
  Category!: Category;

  constructor(private http: HttpClient, private arouter: ActivatedRoute)
  {
    this.http.get<Category>(`/Base/GetCatInfo/${this.arouter.snapshot.paramMap.get('id')}`)
    .subscribe(x => this.Category = x);

    this.GetProductsCat();

    window.onscroll = async () => 
    {
      if ((window.innerHeight + Math.round(window.scrollY)) >= document.body.offsetHeight) 
      {
        await this.GetProductsCat();
      }
    };
  }

  GetProductsCat()
  {
    if (this.Loading)
      return;

    this.Loading = true;

    this.http.post<Product[]>(`/Base/GetProductByCategoryID/${this.arouter.snapshot.paramMap.get('id')}`, this.ProductsIDs)
    .subscribe(x =>
    {
      x.forEach(x => this.ProductsIDs.push(x.id));

      this.CatProducts.push(...x);

      this.Loading = false;
    });
  }
}
