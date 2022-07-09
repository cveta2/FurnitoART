import { Injectable } from '@angular/core';
import { ApiService } from 'src/app/shared/services/api-service.service';
import { IUser } from '../interfaces/i-user';
import { HttpClient } from '@angular/common/http';
import { FormGroup, Validators, FormControl } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class RegisterFormServiceService extends ApiService<IUser> {

  form: FormGroup;
  constructor(http: HttpClient) 
  { 
    super(http, "users")
    this.initializeForm();
  }

  initializeForm(): void{
    this.form = new FormGroup({
      firstName: new FormControl('', Validators.required),
      lastName: new FormControl('', Validators.required),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}')])
    });
  }
}
