import { Component, OnInit, ViewChild } from '@angular/core';
import { LoginFormService } from './services/login-form.service';
import { ActivatedRoute, Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { AuthService } from '../auth/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  errorMessage: string = "";

  @ViewChild("formDirective") private formDirective: NgForm;

  constructor(
    public service: LoginFormService,
    private auth: AuthService,
    private route: ActivatedRoute,
    private router: Router,
  ) { }

  ngOnInit(): void {
    this.service.initializeForm();
  }

  onSubmit(): void {
    this.service.sendData(this.service.form.value).subscribe({
      next: (data: any) => {
        this.errorMessage = "";
        localStorage.setItem("token", data.token)
        this.auth.login();
        this.formDirective.resetForm();
        this.router.navigate(["/"], { relativeTo: this.route })
      },
      error: (err: any) => {
        if (err.status == 401) {
          this.errorMessage = "Sorry, your password or email is incorrect. Please try again.";
        }
      }
    });
    
  }
}
