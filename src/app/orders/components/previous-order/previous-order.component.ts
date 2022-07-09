import { Component, OnInit } from '@angular/core';
import { OrderFormService } from '../../services/order-form.service';
import { INewOrder } from '../../interfaces/i-new-order';

@Component({
  selector: 'app-previous-order',
  templateUrl: './previous-order.component.html',
  styleUrls: ['./previous-order.component.css']
})
export class PreviousOrderComponent implements OnInit {

  orders: INewOrder[] = [];
  constructor(
    private service: OrderFormService
  ) { }

  ngOnInit(): void {
    this.loadOrders();
  }

  loadOrders(): void{
    this.service.getData().subscribe({
      next: (data: any) => {
        this.orders = data;
        console.log(this.orders)
      },
      error: (err: any) => {
        console.log(err)
      }
    })
  }

}
