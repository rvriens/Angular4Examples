import { Component }          from '@angular/core';

@Component({
  selector: 'my-app',
  template: `
    <div class="container">
    <nav-bar [navElements]="[{link: '/dashboard', name: 'Dashboard'},{link: '/heroes', name: 'Heroes'}]"></nav-bar>
    <nav>
      <a routerLink="/dashboard" routerLinkActive="active">Dashboard</a>
      <a routerLink="/heroes" routerLinkActive="active">Heroes</a>
    </nav>
    
    <h1>{{title}}</h1>
    <router-outlet></router-outlet>
    </div>
  `,
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Tour of Heroes';
}
