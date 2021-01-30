import { Component, OnInit } from '@angular/core';
import { ICricketDetails } from './CricketDetails';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DatePipe } from '@angular/common'

@Component({
    selector: 'app-cricket',
    templateUrl: './cricket.component.html',
})

export class CricketComponent implements OnInit {
    currentDate: string;
    constructor(private http: HttpClient, public datepipe: DatePipe) { }
    cricketDetails: ICricketDetails;

    cricketURL: string; 

    //Assign the current Date as a string object, the user shouldn't be able to alter this
    ngOnInit() {
        this.currentDate = new Date().toLocaleDateString();
    }

    //Mock up of method to POST the user data to the backend
    saveDetails(cricketDetails: ICricketDetails): Observable<ICricketDetails> {
        return this.http.post<ICricketDetails>(this.cricketURL, cricketDetails)
            .pipe();
    }
}
