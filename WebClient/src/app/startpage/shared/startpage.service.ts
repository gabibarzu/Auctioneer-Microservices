import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Bid } from '../../shared/models';
import { LatestDeals, SearchCriteria } from './models';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class StartpageService {
  constructor(private http: HttpClient) {}

  getCategories() {
    return this.http.get(environment.productsApiUrl + '/Category/');
  }

  getProducts() {
    return this.http.get(environment.productsApiUrl + '/Product/');
  }

  getProductById(productId: string) {
    return this.http.get(environment.productsApiUrl + '/Product/' + productId);
  }

  getProductsBySearchCriteria(request: SearchCriteria) {
    return this.http.post(environment.productsApiUrl + '/Product/', request);
  }

  getLatestDealsForCategory(request: LatestDeals) {
    return this.http.post(
      environment.productsApiUrl + '/Deals/LatestDeals/',
      request
    );
  }

  getCurrentBidValue(productId: string) {
    return this.http.get(
      environment.productsApiUrl + '/Bid/GetCurrentBidValue/' + productId
    );
  }

  getAllBidsForProduct(productId: string) {
    return this.http.get(
      environment.productsApiUrl + '/Bid/GetAllBidsForProduct/' + productId
    );
  }

  bid(bid: Bid) {
    return this.http.post(environment.productsApiUrl + '/Bid/Bid/', bid);
  }

  buy(bid: Bid) {
    return this.http.post(environment.productsApiUrl + '/Bid/Buy/', bid);
  }
}
