import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Category } from '../../models/category';
import { LinkerService } from '../../linker.service';
import { Product } from '../../models/product';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  AllCats: Category[] = [];
  AllProducts: Product[] = [];

  constructor(private linker: LinkerService, private http: HttpClient)
  {
    this.linker.GetAllCats().subscribe(x => this.AllCats = x);

    this.linker.GetHomePagePro().subscribe(x =>
      { 
        this.AllProducts = x;
      });
  }
}
