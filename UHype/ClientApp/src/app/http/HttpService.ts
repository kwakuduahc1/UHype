import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { IUsers } from "../model/IUsers";
import { Observable } from "rxjs";

@Injectable({ providedIn: 'root' })
export class HttpService {

  constructor(private http: HttpClient) { }


  login(st: IUsers): Observable<IUsers> {
    return this.http.post<IUsers>(`/Auth/Login`, st)
  }

  register(st: IUsers): Observable<IUsers> {
    return this.http.post<IUsers>(`/Auth/Register`, st);
  }

  signout() {
    return this.http.post("/Auth/Signout", {})
  }
}
