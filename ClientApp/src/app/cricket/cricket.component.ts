import { Component } from '@angular/core';
import { ICricketDetails } from './CricketDetails';

@Component({
    selector: 'app-cricket',
    templateUrl: './cricket.component.html',
})

export class CricketComponent {
    cricketDetails: ICricketDetails;
}
