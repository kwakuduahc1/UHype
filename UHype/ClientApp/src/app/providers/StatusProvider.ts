import { Injectable } from "@angular/core";
import { IUsers } from '../model/IUsers';

@Injectable()
export class StatusProvider {
  roles: string[] = [];

  user: IUsers | undefined;

  isLoggedIn() {
    if (this.user)
      return true;
    return false;
  }

  isAdmin() {
    if (Array.isArray(this.roles))
      return this.roles.some(x => x === "Researcher");
    else return false;
  }

  isRegular() {
    if (Array.isArray(this.roles))
      return this.isAdmin() ? this.isAdmin() : this.roles.some(x => x === 'User');
    else return false;
  }

  isAssistant() {
    if(Array.isArray(this.roles))
      return this.roles.some(n => n === "Assistant");
    return false;
  }

  getAsyncToken() {
    return this.jwt
  }

  private jwt: string;
  constructor() {
    this.jwt = localStorage.getItem("jwt");

  }
}
