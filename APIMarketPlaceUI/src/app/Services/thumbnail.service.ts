import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Api } from '../Models/Api';

@Injectable({
  providedIn: 'root'
})
export class ThumbnailService {
  public apiUrl = "http://localhost:5216/api/ApiBox/LoadInfo"
  constructor(private http: HttpClient) { 
  }
  public getApiInfo() : Observable<Api> {
    return this.http.get<Api>(this.apiUrl);
  }

}
