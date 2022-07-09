import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PreviousOrderComponent } from './previous-order.component';
import { AuthGuard } from 'src/app/auth/auth.guard';

const routes: Routes = [
  {
    path: "",
    component: PreviousOrderComponent,
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PreviousOrderRoutingModule { }
