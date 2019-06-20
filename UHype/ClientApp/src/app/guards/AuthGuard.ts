import { CanActivate, Router } from "@angular/router";
import { Injectable } from "@angular/core";
import { JwtHelperService } from '@auth0/angular-jwt';
import { StatusProvider } from '../providers/StatusProvider';


@Injectable()
export class AuthGuard implements CanActivate {
  constructor(private jwt: JwtHelperService, private router: Router, private status: StatusProvider) {
  }

  canActivate() {
    var token = localStorage.getItem("jwt");
    if (token && !this.jwt.isTokenExpired(token)) {
      var roles = this.jwt.decodeToken(token);
      let user = {
        roles: roles['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'],
        user: {
          password: '',
          confirmPassword: '',
          usersID: roles['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier'],
          userName: roles['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name']
        }
      }
      this.status.roles = user.roles;
      this.status.user = user.user;
      return true;
    }
    else {
      this.router.navigate(["/login"]);
      return false;
    }
  }
}
