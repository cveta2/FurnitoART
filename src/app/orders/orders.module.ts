import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrdersRoutingModule } from './orders-routing.module';
import { OrdersComponent } from './orders/orders.component';
import { PreviousOrderComponent } from './components/previous-order/previous-order.component';


@NgModule({
  declarations: [
    OrdersComponent,
    PreviousOrderComponent
  ],
  imports: [
    CommonModule,
    OrdersRoutingModule
  ]
})
export class OrdersModule { }
