import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../services/api-service.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-load-data',
  templateUrl: './load-data.component.html',
  styleUrls: ['./load-data.component.css']
})
export class LoadDataComponent<T> implements OnInit {

  public  data: T[] = [];
  protected subscription: Subscription = new Subscription();

  constructor(private api: ApiService<T>) { }

  ngOnInit(): void {
    this.loadData();
  }

  loadData(): void {
    this.subscription.add(this.api.getLinks().subscribe({
      next: (data: T[]) => {
        this.data = data;
      },
      error: (err) => {
        console.error(err);
      }
    }));
  }

  ngOnDestroy(): void{
    this.subscription.unsubscribe();
  }
}
