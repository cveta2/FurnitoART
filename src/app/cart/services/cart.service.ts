import { Injectable } from '@angular/core';
import { ApiService } from '../../shared/services/api-service.service';
import { ICart } from '../interfaces/i-cart';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CartService extends ApiService<ICart>{

  constructor(http: HttpClient) { super(http, 'carts') }


}
