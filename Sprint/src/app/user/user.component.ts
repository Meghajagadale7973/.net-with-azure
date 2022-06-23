import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import {User } from './user.model';

@Component({
  templateUrl: './user.component.html'
})
export class UserComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'Sprint';
  myname = 'megha'
  UserModel: User = new User();
  UserModels: Array<User> = new Array<User>();
  AddUser() {
    console.log(this.UserModel);
    //this.UserModels.push(this.UserModel);

    var userdto={
      orderId:this.UserModel.orderId,
      orderName:this.UserModel. orderName,
      orderPrice:Number(this.UserModel.orderPrice),
    }
    this.httpc.post('https://localhost:44308/api/User_', userdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.UserModel = new User();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditUser(input: User) {
    this.UserModel = input;
  }
  DeleteUser(input:User) {
    var index=this.UserModels.indexOf(input);
    this.UserModels.splice(index,1);
  }
  
  getData(){
    console.log("Hi");
    this.httpc.get('https://localhost:44308/api/User_').subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.UserModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}


