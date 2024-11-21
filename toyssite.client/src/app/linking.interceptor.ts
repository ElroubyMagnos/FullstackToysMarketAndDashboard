import { HttpInterceptorFn } from '@angular/common/http';

export const golinkInterceptor: HttpInterceptorFn = (req, next) => {
  var NewReq = req.clone({url: 'http://localhost:5221' + req.url});
  
  return next(NewReq);
};
