import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { Observable, Subscription } from "rxjs";
import { IProduct } from '../interfaces/i-product';
import { ICategory } from '../interfaces/i-category';
import { ProductService } from '../services/products/product.service';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/auth/auth.service';
import { IAddItemToCart } from 'src/app/cart/interfaces/i-add-item-to-cart';
import { AddToCartService } from 'src/app/cart/services/add-to-cart.service';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  public category: ICategory;
  public product: IProduct;
  public productId: number;
  protected subscription: Subscription = new Subscription();
  isLoggedIn$ : Observable<boolean>
  errorMessage: string;
  quantity: number = 1;

  @ViewChild("quantityField") quantityField: ElementRef;

  constructor(
    private productService: ProductService,
    private cartServie: AddToCartService,
    private route: ActivatedRoute,
    private auth: AuthService,
    private router: Router
  ) { }

  ngOnInit(): void{
    this.route.params.subscribe(params => {
      this.productId = params['id'];
    })
    this.auth.getIsLoggedIn.subscribe((data: any) => {this.isLoggedIn$ = data});
    this.loadData();
  }

  loadData(): void{
    this.productService.findData(this.productId).subscribe({
      next: (data: any) => {
        console.log(data)
        this.product = data;
      },
      error: (err: any) => {
        console.log(err)
      }
    })
  }

  incrementValue() {
    if(this.quantity != 10){
      this.quantity++;
    }
  }
  decrementValue() {
    if(this.quantity > 0){
      this.quantity--;
    }
  }

  addProductToCart(): void{
    console.log(this.isLoggedIn$)
    if(!this.isLoggedIn$){
      this.errorMessage = "You need to be logged in to add product to cart!";
      return;
    }
    let cartItem: IAddItemToCart = {
      productId: this.productId,
      quantity: this.quantityField.nativeElement.value
    }
    this.cartServie.sendData(cartItem).subscribe({
      next: (data: any) => {
        this.router.navigate(["/cart"])
      },
      error: (err: any) => {
        console.log(err)
      }
    })
  }

}
