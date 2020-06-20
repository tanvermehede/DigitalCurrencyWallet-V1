import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { UserFinanceService } from '../services/user-finance.service';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-finance',
  templateUrl: './finance.component.html',
  styleUrls: ['./finance.component.css']
})
export class FinanceComponent implements OnInit {

  constructor(private modalService: NgbModal, private userFinanceService: UserFinanceService) { }

  //Open Model
  openDepositModel(deposit) {
    this.modalService.open(deposit, { centered: true });
  }
  openWithdrawModel(withdraw) {
    this.modalService.open(withdraw, { centered: true });
  }
  openGiveOfferModel(giveOffer) {
    this.modalService.open(giveOffer, { centered: true });
  }
  finance = {};
  depositRequest = {};

  ngOnInit() {
    //Get user finance
    this.userFinanceService.getUserFinance()
      .subscribe(data => {
        this.finance = data;
      });
  }
  //Save deposit data
  depositNow() {
    this.userFinanceService.depositRequest(this.depositRequest)
      .subscribe(
        res => console.log(res),
        err => console.log(err)
      )
  }
}
