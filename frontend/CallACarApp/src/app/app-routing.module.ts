import { InvoiceComponent } from './components/invoice/invoice.component';
import { NewComponent } from './components/book/new/new.component';
import { ConfirmationComponent } from './components/book/confirmation/confirmation.component';
import { BookComponent } from './components/book/book.component';
import { AuthenticatedGuard } from './services/authenticated.guard';
import { HistoryComponent } from './components/history/history.component';
import { RegisterComponent } from './components/register/register.component';
import { AdminGuard } from './services/admin.guard';
import { AdminComponent } from './components/admin/admin.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [

  {path: 'home', component: HomeComponent, canActivate:[AuthenticatedGuard]},
  {path: 'book', component: BookComponent, canActivate:[AuthenticatedGuard]},
  {path: 'book/confirmation', component: ConfirmationComponent, canActivate:[AuthenticatedGuard]},
  {path: 'book/new', component: NewComponent, canActivate:[AuthenticatedGuard]},
  {path: 'pay', component: InvoiceComponent, canActivate:[AuthenticatedGuard]},
  {path: 'history', component: HistoryComponent, canActivate:[AuthenticatedGuard]},
  {path: 'login', component: LoginComponent},
  {path: 'register', component: RegisterComponent},
  {path: 'admin', component: AdminComponent, canActivate:[AdminGuard]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})


export class AppRoutingModule { 
}
