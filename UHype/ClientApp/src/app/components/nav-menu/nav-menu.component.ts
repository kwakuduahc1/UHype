import { Component } from '@angular/core';
import { StatusProvider } from 'src/app/providers/StatusProvider';
import { HttpService } from 'src/app/http/HttpService';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  constructor(public status: StatusProvider, private http: HttpService, private router: Router) {

  }

  signout() {
    this.http.signout().subscribe(() => {
      localStorage.removeItem('jwt');
      this.status.user = null;
      this.status.roles = null;
      this.router.navigate(['/login']);
    })
  }
}
