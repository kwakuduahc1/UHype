import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { finalize, tap } from 'rxjs/operators'
import { bsHandler } from '../model/bsHandler';
import { ActivityProvider } from '../providers/ActivityProvider';
import { TokenProvider } from '../providers/TokenProvider';

@Injectable({ providedIn: 'root' })
export class AuthInterceptorService implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    this.act.beginProc();
    let nreq = req.clone({ headers: this.token.getHeader() });
    return next.handle(nreq).pipe(
      tap(() => { }, err => this.hand.onError(err)), finalize(() => this.act.endProc()));
  }
  constructor(private token: TokenProvider, private act: ActivityProvider, private hand: bsHandler) {
  }
}
