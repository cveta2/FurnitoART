import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RequestInterceptorService implements HttpInterceptor{

  constructor() { }

  intercept(req: HttpRequest<any>, next: HttpHandler) {
    let jwtToken = req.clone({
      setHeaders: {
        Authorization: "bearer " + localStorage.getItem("token")
      }
    })
    return next.handle(jwtToken)
  }
}
