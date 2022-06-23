import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { UserRoutes } from '../routing/routing.user';
import {UserComponent } from './user.component';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
   UserComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forChild(UserRoutes)
  ],
  providers: [],
  bootstrap: [UserComponent]
})
export class UserModule { }