import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ProfileService {

  constructor(private httpClient: HttpClient) { }

  getProfile(): Observable<any> {
    return this.httpClient.get("http://localhost:44384/api/Profiles/3")
  }

  private _saveProfile = "http://localhost:44384/api/Profiles/3"
  saveProfile(profile) {
    return this.httpClient.post<any>(this._saveProfile, profile)
  }

  private _updateProfile = "http://localhost:44384/api/Profiles/3"
  updateProfile(profile) {
    return this.httpClient.put<any>(this._updateProfile, profile)
  }
}
