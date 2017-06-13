import {
    Component,
    Input
} from '@angular/core';
import { Subject } from 'rxjs/Subject';

interface NavElement
{
    link: string;
    name: string;
}

@Component({
    selector: 'nav-bar',
    templateUrl: './navbar.component.html'
})
export class NavBarComponent {
    @Input() navElements: NavElement[]; //Subject<NavElement[]>;
}