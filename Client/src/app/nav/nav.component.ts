import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { take } from 'rxjs/operators';
import { AccountService } from './../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
  isAuth!: boolean;
  user: any;

  constructor(
    public accountService: AccountService,
    private router: Router,
    private toastrService: ToastrService
  ) {
    accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);
  }

  ngOnInit(): void {
    this.isAuth = localStorage.getItem('user') != null ? true : false;
  }

  login() {
    return this.accountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/members');
      this.isAuth = true;
    });
  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
    this.isAuth = false;
  }

}
