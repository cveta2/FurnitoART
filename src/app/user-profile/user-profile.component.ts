import { Component, OnInit } from '@angular/core';
import { IUser } from '../register/interfaces/i-user';
import { UserProfileService } from './services/user-profile.service';
import { RegisterFormServiceService } from '../register/services/register-form-service.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})
export class UserProfileComponent implements OnInit {

  user: IUser;
  errorMessage: string = ""
  isVisibleForm: boolean = false
  constructor(
    public service: UserProfileService,
    public userService: RegisterFormServiceService
  ) { }

  ngOnInit(): void {
    this.loadData();
    this.service.initializeForm();
  }

  loadData(): void{
    this.service.getData().subscribe({
      next: (data: any) => {
        this.user = data
      },
      error: (err: any) => {
        console.log(err)
      }
    })
  }
  showFormForUpdateInfo(): void{
      this.service.form.setValue({
        firstName: this.user.firstName,
        lastName: this.user.lastName,
        email: this.user.email
      })
      this.isVisibleForm = true;
  }

  onSubmit(): void{
    this.userService.updateData(this.service.form.value).subscribe({
      next: (data: any) =>{
        this.isVisibleForm = false;
        this.loadData();
      },
      error: (err: any) => {
        this.errorMessage = err.Message
      }
    })
    
  }
}
