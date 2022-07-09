import { Component, OnInit } from '@angular/core';
import { IRoute } from 'src/app/shared/interfaces/i-route';
import { LoadDataComponent } from 'src/app/shared/components/load-data/load-data.component';
import { HeaderService } from './services/header.service';
import { AuthService } from 'src/app/auth/auth.service';
import { Observable } from 'rxjs';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent extends LoadDataComponent<IRoute> implements OnInit {

  isLoggedIn$: Observable<boolean>;
  constructor(
    service: HeaderService,
    private auth: AuthService,
    private router: Router
  ) {
    super(service)
  }

  override ngOnInit(): void {
    super.loadData();
    this.isLoggedIn$ = this.auth.getIsLoggedIn;
  }

  logOut(): void {
    this.auth.logout();
    localStorage.removeItem("token");
    this.router.navigate(['/login']);
  }
}
