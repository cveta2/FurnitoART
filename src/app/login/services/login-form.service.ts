import { Injectable } from '@angular/core';
import { FormControl, Validators, FormGroup  } from "@angular/forms";
import { ApiService } from 'src/app/shared/services/api-service.service';
import { UserForLogin } from '../interfaces/user-for-login';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class LoginFormService extends ApiService<UserForLogin> {

  form: FormGroup;

  constructor( http: HttpClient ) {
    super(http, "login") 
    this.initializeForm();
  }

  initializeForm(): void{
    this.form = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern('(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}')])
    });
  }
}
