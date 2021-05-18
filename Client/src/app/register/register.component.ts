import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter;
  model: any = {};
  registerForm!: FormGroup;

  constructor(
    private accountService: AccountService,
    private toastrService: ToastrService
  ) { }

  ngOnInit(): void {
    this.initializeForm();
  }

  initializeForm(): void {
    this.registerForm = new FormGroup({
      username: new FormControl('Hello', Validators.required),
      password: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(8)]),
      confirmPassword: new FormControl('', Validators.required),
    })
  }

  register() {
    console.log(this.registerForm.value);
    /*this.accountService.register(this.model).subscribe(response => {
      console.log(response);
      this.cancel();
    }, error => {
        console.log(error);
        this.toastrService.error(error.error);
    });*/
  }

  cancel() {
    this.cancelRegister.emit(false);
  }

}
