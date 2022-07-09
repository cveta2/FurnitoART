import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CartComponent } from './cart.component';
import { AuthGuard } from '../auth/auth.guard';
import { PreviousOrderComponent } from '../orders/components/previous-order/previous-order.component';

const routes: Routes = [
  {
    path: "",
    component: CartComponent,
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CartRoutingModule { }
