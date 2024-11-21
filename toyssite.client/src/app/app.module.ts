import { provideHttpClient, withInterceptors } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { golinkInterceptor } from './linking.interceptor'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SharedModule } from './shared/shared.module';
import { ParticlesModule } from './particles/particles.module';
import { DecimalfixerPipe } from './decimalfixer.pipe';
import { ToastrModule } from 'ngx-toastr';
import { provideAnimations } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SharedModule,
    ParticlesModule,
    ToastrModule.forRoot()
  ],
  providers: [provideHttpClient(withInterceptors([golinkInterceptor])), provideAnimations()],
  bootstrap: [AppComponent]
})
export class AppModule { }
