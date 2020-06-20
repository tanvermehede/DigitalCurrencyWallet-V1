import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private httpClient: HttpClient) { }

  getUserFinance(): Observable<any> {
    return this.httpClient.get("http://localhost:44384/api/Finances/1")
  }

  private _depositRequest = "http://localhost:44384/api/DepositRequests"
  depositRequest(value) {
    return this.httpClient.post<any>(this._depositRequest, value)
  }

  buyRequest() {

  }

  depositApprove() {

  }
}
