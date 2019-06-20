import { Component } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { StatusProvider } from './providers/StatusProvider';
import { Meta, Title } from '@angular/platform-browser';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'UHype Project';


  constructor(private jwt: JwtHelperService, private sp: StatusProvider, meta: Meta, title: Title) {
    title.setTitle("U-Hype Home Page");
    meta.addTags([
      { name: 'author', content: 'Dr. Phyllis Tawiah (Principal Investigator); Mr. Ibrahim Duah Kwaku (Data Manager)' },
      { name: 'description', content: 'Project website for the U-Hype Project' },
      { name: 'keywords', content: 'Hypertension, Chronic Disease, Hypertension Management' },
      { name: 'abstract', content: "This projects seeks to evaluate the care given to hypertensive patients at the various hospitals in Ghana" }
    ]);
    let token = localStorage.getItem("jwt");
    if (token) {
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
    }
  }
}
