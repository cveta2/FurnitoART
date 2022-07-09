import { Component, OnInit } from '@angular/core';
import { RegisterFormServiceService } from './services/register-form-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  errorMessage: string = "";
  constructor(
    public service: RegisterFormServiceService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.service.initializeForm();
  }

  onSubmit(): void{
    this.service.sendData(this.service.form.value).subscribe({
      next: (data: any) => {
        this.router.navigate(['/login'])
      },
      error: (err: any) => {
        if(err.status == 422){
          for(let er of err.error.errors){
            this.errorMessage += er.message
          }
        }
      }
    })
  }

}
