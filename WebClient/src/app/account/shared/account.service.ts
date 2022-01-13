import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { Product } from '../../shared/models';
import { AccountStat } from './models';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  constructor(private http: HttpClient) {}

  getAccountStat(): Observable<AccountStat> {
    return this.http
      .get(environment.accountApiUrl + '/Account/GetAccountStat')
      .pipe(map((result) => result as AccountStat));
  }

  getProducts(): Observable<Product[]> {
    return this.http
      .get(environment.accountApiUrl + '/Account/GetProducts')
      .pipe(map((result) => result as Product[]));
  }
}
