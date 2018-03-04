// ===============================
// info@ebenmonney.com
// www.ebenmonney.com/quickapp-pro
// ===============================

import { Component } from '@angular/core';
import { fadeInOut } from '../../services/animations';

@Component({
    selector: 'not-found',
    templateUrl: './not-found.component.html',
    styleUrls: ['./not-found.component.scss'],
    animations: [fadeInOut]
})
export class NotFoundComponent {
}