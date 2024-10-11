import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  generalFormGroup = this._signUpFormBuilder.group({
    firstName: ['', Validators.required],
    lastName: [],
    email: ['', Validators.required],
    userName: ['', Validators.required],
    password: ['', Validators.required],
    confirmPassword: ['', Validators.required]
  });



  constructor(private _signUpFormBuilder: FormBuilder) { }

  ngOnInit(): void {
  }

}
