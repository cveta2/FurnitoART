import { Injectable } from '@angular/core';
import { ApiService } from 'src/app/shared/services/api-service.service';
import { IUser } from 'src/app/register/interfaces/i-user';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class UserProfileService extends ApiService<IUser>{

  form: FormGroup;
  constructor(http: HttpClient) { super(http, "usersProfile"), this.initializeForm() }
  initializeForm(): void{
     this.form = new FormGroup({
      firstName: new FormControl('', [Validators.required]),
      lastName: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
    });
  }
}
