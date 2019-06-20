import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { IUsers } from 'src/app/model/IUsers';
import { StatusProvider } from 'src/app/providers/StatusProvider';
import { ActivityProvider } from 'src/app/providers/ActivityProvider';
import { HttpService } from 'src/app/http/HttpService';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: []
})
export class LoginComponent {
  form: FormGroup;
  processing: boolean = true;
  token: IUsers | undefined;

  constructor(fb: FormBuilder, private htpp: HttpService, private router: Router, private status: StatusProvider, private jwt: JwtHelperService, public nav: ActivityProvider) {
    this.form = this.InitForm(fb);
  }


  InitForm(fb: FormBuilder): FormGroup {
    return fb.group({
      userName: ["", Validators.compose([Validators.required, Validators.minLength(5), Validators.maxLength(30)])],
      password: ["", Validators.compose([Validators.required, Validators.minLength(6), Validators.maxLength(20)])],
    })
  }

  register(login: IUsers) {
    this.nav.beginProc();
    this.htpp.login(login).subscribe((res: IUsers) => {
      let token = (<any>res).token;
      localStorage.setItem("jwt", token);
      var roles = this.jwt.decodeToken(token);
      let user = {
        roles: roles['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'],
        user: {
          password: '',
          confirmPassword:'',
          usersID: roles['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier'],
          userName: roles['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name']
        }
      }
      this.status.roles = user.roles;
      this.status.user = user.user;
      this.nav.endProc();
      this.router.navigate(['/home']);
    }, () => {
      this.nav.endProc();
    });
  }
}
