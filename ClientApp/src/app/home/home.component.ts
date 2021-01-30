import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

    data = [];

    constructor(private apiService: ApiService, private route: Router) { }

    //Currently just a mock  of a subscription service
    ngOnInit() {
        //this.apiService.get().subscribe((data: any[]) => {
        //    this.data = data;
        //})

        this.data = [{ gameName: 'AUS Vs ENG'}]
    }

    //basic navigation to switch to cricket.component screen
    cricketGame() {
        this.route.navigate(['../cricket/cricket.component']);
    }
}
