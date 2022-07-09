import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { CartService } from './services/cart.service';
import { ICart } from './interfaces/i-cart';
import { OrderFormService } from '../orders/services/order-form.service';
import { IOrderItem } from '../orders/interfaces/i-order-item';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  cartItems: ICart[];
  totalCartPrice: number = 0;
  message: string = "";
  errorMessage: string = ""
  isFormVisible: boolean = true;
  constructor(
    private service: CartService,
    public form: OrderFormService
  ) { }

  ngOnInit(): void {
    this.loadCartItems();
    this.form.initializeForm();
  }

  loadCartItems(): void{
    this.service.getData().subscribe({
      next: (data: ICart[]) => {
          this.cartItems = data;
          this.totalCartPrice = 0
          for(let item of data){
            let number = item.quantity * item.productPrice
            this.totalCartPrice += number
          }
      },
      error: (err: any) => {
        console.log(err)
      }
    })
  } 

  removeFromCart(id: number): void{
    this.service.deleteData(id).subscribe({
      next: (data: any) => {
        this.loadCartItems()
      },
      error: (err: any) => {
        console.log(err)
      }
    })
  }

  makeOrder(): void{
      var order = this.form.form.value;
      var orderItems: IOrderItem[] = [];
      for(let item of this.cartItems){
        orderItems.push({
          productId: item.productId,
          quantity: item.quantity
        });
      }
      order.orderItems = orderItems;
      this.form.sendData(order).subscribe({
        next: (data: any) => {
          this.service.removeItemsFromCart().subscribe({
            next: (data: any) => {
              console.log("uslo u remove")
              this.loadCartItems();
            },
            error: (err: any) => {
              console.log(err)
            }
          })
          this.isFormVisible = false;
          this.message = "Your order has been successfully created."
        },
        error: (err: any) => {
          console.log(err)
          this.errorMessage = err.message
        }
      })
  }
}
