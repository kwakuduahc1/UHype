import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';
import { IUsers } from 'src/app/model/IUsers';
import { HttpService } from 'src/app/http/HttpService';
import { ActivityProvider } from 'src/app/providers/ActivityProvider';
import { log } from 'util';
import { ToastrService } from 'ngx-toastr';
import { facilities, teams } from 'src/app/model/constants';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  ngOnInit(): void {

  }

  facs = facilities;
  teams = teams;
  form: FormGroup;
  constructor(fb: FormBuilder, private htpp: HttpService, private router: Router, private toast: ToastrService, public act: ActivityProvider) {
    this.form = this.InitForm(fb);
  }


  InitForm(fb: FormBuilder): FormGroup {
    return fb.group({
      userName: ["", Validators.compose([Validators.required, Validators.minLength(5), Validators.maxLength(50)])],
      password: ["", Validators.compose([Validators.required, Validators.minLength(6), Validators.maxLength(20)])],
      confirmPassword: ["", Validators.compose([Validators.required, Validators.minLength(6), Validators.maxLength(20)])],
      facility: ['', Validators.compose([Validators.required])],
      team: ['', Validators.compose([Validators.required])]
    })
  }

  register(login: IUsers) {
    if (login.confirmPassword === login.password) {
      this.htpp.register(login).subscribe((res: IUsers) => {
        this.router.navigate(['/login'])
      })
    }
    else {
      this.toast.error("Password do not match");
    }
  }

}
