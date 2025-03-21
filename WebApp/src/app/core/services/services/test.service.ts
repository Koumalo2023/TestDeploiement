import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TestService {

  private readonly apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  checkBackendConnection(): Observable<any> {
    return this.http.get(`${this.apiUrl}/connection`);
  }
}
