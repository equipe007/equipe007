import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FindComponent } from './find/find.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { RegisterComponent } from './register/register.component';
import { ReportComponent } from './report/report.component';


const routes: Routes = [
  { path: '', component: LoginComponent},
  { path: 'find', component: FindComponent},
  { path: 'profile', component: ProfileComponent},
  { path: 'register', component: RegisterComponent},
  { path: 'report', component: ReportComponent},
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
