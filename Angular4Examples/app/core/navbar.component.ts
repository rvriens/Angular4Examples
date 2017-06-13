import {
    Component,
    Input
} from '@angular/core';
import { Subject } from 'rxjs'

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
    @Input() navElements: Subject<NavElement[]>;

}