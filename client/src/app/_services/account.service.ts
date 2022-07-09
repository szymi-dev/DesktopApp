import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = "https://localhost:5001/api/";

  constructor(private http: HttpClient) { }

  login(model: any)
  {
    return this.http.post(this.baseUrl + "account/login", model).pipe(
      map((response:any) => {
        const user = response;
        localStorage.setItem('user', JSON.stringify(user));
      })
    )
  }

  logout(){
    localStorage.removeItem('user');
  }
}
