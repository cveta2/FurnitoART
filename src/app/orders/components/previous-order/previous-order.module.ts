import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PreviousOrderRoutingModule } from './previous-order-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { PreviousOrderComponent } from './previous-order.component';


@NgModule({
  declarations: [
    PreviousOrderComponent
  ],
  imports: [
    CommonModule,
    PreviousOrderRoutingModule,
    SharedModule
  ]
})
export class PreviousOrderModule { }
