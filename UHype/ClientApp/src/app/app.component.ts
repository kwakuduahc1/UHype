import { Component } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { StatusProvider } from './providers/StatusProvider';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'UHype Project';

  constructor(private jwt: JwtHelperService, private sp: StatusProvider) {
    let token = localStorage.getItem("jwt");
    let roles = this.jwt.decodeToken(token);
    let user = {
      roles: roles['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'],
      user: {
        password: '',
        confirmPassword: '',
        usersID: roles['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier'],
        userName: roles['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name']
      }
    }
    this.sp.roles = user.roles;
    this.sp.user = user.user;
  };
}
