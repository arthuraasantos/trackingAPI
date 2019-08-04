import { Component, OnInit } from '@angular/core';
import { CampaignsService } from '../services/campaigns.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-campaigns',
  templateUrl: './campaigns.component.html',
  styleUrls: ['./campaigns.component.css']
})
export class CampaignsComponent implements OnInit {
  campaigns: any;
  constructor(private campaignsService: CampaignsService) { }

  ngOnInit() {
    this.campaignsService.getCampaigns().subscribe((campaignsResult) =>  {
      this.campaigns = campaignsResult;
    })
  }



}
