import { Injectable } from '@angular/core';
import { Observable, Subject, subscribeOn } from 'rxjs';
import { Category } from './models/category';
import { HttpClient } from '@angular/common/http';
import { Product } from './models/product';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class LinkerService {
  NotInBill: boolean = true;

  AddedProducts: Product[] = [];
  
  AddToCartThrough: Subject<Product> = new Subject<Product>();

  constructor(private http: HttpClient) { }

  public GetAllCats() : Observable<Category[]>
  {
    return this.http.get<Category[]>(`/Base/GetallCats/`);
  }

  public GetHomePagePro() : Observable<Product[]>
  {
    return this.http.get<Product[]>(`/Base/GetHomePagePro/`);
  }

  public SendEmailMessage(f: NgForm) : Observable<boolean>
  {
    return this.http.post<boolean>(`/Email/ReceiveMsg/`, f.value);
  }
}
