import { Injectable } from '@angular/core';
import { ApiService } from 'src/app/shared/services/api-service.service';
import { IAddItemToCart } from '../interfaces/i-add-item-to-cart';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AddToCartService extends ApiService<IAddItemToCart>{

  constructor(http: HttpClient) { super(http, 'carts') }
}
