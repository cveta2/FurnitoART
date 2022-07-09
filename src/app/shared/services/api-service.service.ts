import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ApiService<T> {

  baseUrl = "http://localhost:5000/api/";
  constructor(protected http: HttpClient, @Inject("path") protected path: string) { }

  getData(): Observable<T[]> {
    return this.http.get<T[]>(this.baseUrl + this.path);
  }
  getLinks(): Observable<T[]>{
    return this.http.get<T[]>("http://localhost:4200/assets/data/nav-links.json");
  }
  findData(id: number): Observable<T>{
    return this.http.get<T>(this.baseUrl + this.path + "/" + id);
  }
  sendData(data: T): Observable<any>{
    return this.http.post<T>(this.baseUrl + this.path, data);
  }
  updateData(data: T): Observable<any>{
    return this.http.put<T>(this.baseUrl + this.path, data);
  }
  deleteData(id: number): Observable<any>{
    return this.http.delete(this.baseUrl + this.path + "/" + id);
  }
  removeItemsFromCart(): Observable<any>{
    return this.http.delete(this.baseUrl + 'removeCarts');
  }
}
