import { Component } from '@angular/core';
import { Product } from '../../models/product';
import { NgForm } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-searchfilter',
  templateUrl: './searchfilter.component.html',
  styleUrl: './searchfilter.component.css'
})
export class SearchfilterComponent {
  AllProducts: Product[] = [];
  MaxCountShow: number = 6;

  constructor(private http: HttpClient)
  {
    this.http.get<Product[]>(`/Search/GetRandomProducts/`)
    .subscribe(x => this.AllProducts = x);
  }

  SearchFor(f: NgForm, select: HTMLSelectElement)
  {
    this.http.get<Product[]>(`/Search/GetOrderedProducts/${f.value.SearchWord.length > 0 ? f.value.SearchWord : 'All'}/${select.value}/${this.MaxCountShow}`)
    .subscribe(x => this.AllProducts = x);
  }
}
