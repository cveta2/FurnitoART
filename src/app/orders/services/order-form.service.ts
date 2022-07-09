import { Injectable } from '@angular/core';
import { ApiService } from 'src/app/shared/services/api-service.service';
import { INewOrder } from '../interfaces/i-new-order';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class OrderFormService extends ApiService<INewOrder>{

  form: FormGroup
  constructor(http : HttpClient) { 
    super(http, "orders") 
    this.initializeForm();
  }

  initializeForm(): void{
    this.form = new FormGroup({
      address: new FormControl('', [Validators.required]),
      city: new FormControl('', [Validators.required]),
      country: new FormControl('', [Validators.required]),
      phone: new FormControl('', [Validators.required, Validators.pattern("^0[0-9]{8,9}$")])
    });
  }

}
