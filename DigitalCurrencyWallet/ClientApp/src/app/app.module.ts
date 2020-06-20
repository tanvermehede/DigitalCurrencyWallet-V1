import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { MatSidenavModule, MatToolbarModule, MatIconModule, MatListModule, MatTableModule } from '@angular/material';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { BuySellComponent } from './buy-sell/buy-sell.component';

import { AuthGuard } from './auth.guard';
import { AuthInterceptor } from './auth.interceptor';
import { AuthService } from './services/auth.service';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NavDashboardComponent } from './nav-dashboard/nav-dashboard.component';
import { ProfileComponent } from './profile/profile.component';
import { NavProfileComponent } from './nav-profile/nav-profile.component';
import { HomeService } from './services/home.service';
import { ExchangeComponent } from './exchange/exchange.component';
import { FinanceComponent } from './finance/finance.component';
import { ProfileService } from './services/profile.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    NavProfileComponent,
    DashboardComponent,
    NavDashboardComponent,
    RegisterComponent,
    LoginComponent,
    HomeComponent,
    ProfileComponent,
    BuySellComponent,
    ExchangeComponent,
    FinanceComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    NgbModule.forRoot(),
    ToastrModule.forRoot({
      progressBar: true
    }),
    RouterModule.forRoot([
      //anonymousUser
      { path: '', component: HomeComponent, pathMatch: 'full'},
      { path: 'register', component: RegisterComponent },
      { path: 'login', component: LoginComponent },
      //user
      { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard] },
      { path: 'buy-sell', component: BuySellComponent, canActivate: [AuthGuard] },
      { path: 'exchange', component: ExchangeComponent, canActivate: [AuthGuard] },
      { path: 'finance', component: FinanceComponent, canActivate: [AuthGuard] },
      //admin
      { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard] },
    ]),
    MatSidenavModule,
    MatToolbarModule,
    MatIconModule,
    MatListModule,
    MatTableModule
  ],
  providers: [
    HomeService,
    ProfileService,
    AuthService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
