import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';



@Injectable({
  providedIn: 'root'
})
export class CampaignsService {

  constructor(private httpClient: HttpClient) { }

  public getCampaigns(){
    return this.httpClient.get(`${environment.trackingApi}/campaigns`);
  }
}
