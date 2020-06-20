import { Component, OnInit } from '@angular/core';
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-buy-sell',
  templateUrl: './buy-sell.component.html',
  styleUrls: ['./buy-sell.component.css']
})
export class BuySellComponent implements OnInit {

  currentJustify = 'justified';

  constructor(private homeService: HomeService) { }

  public enterAmount: number;
  public price: number;
  public commission: number;
  public totalPrice: number;

  calOption(event: any) {
    this.price = event.target.value * this.enterAmount;
    this.commission = 25 / 100 * this.price;
    this.totalPrice = this.price + this.commission;
  }
  userBuyData = {}
  //buyRequest() {
  //  this.homeService.buyRequest(this.userBuyData)
  //    .subscribe(
  //      res => console.log(res),
  //      err => console.log(err)
  //    )
  //}
  ngOnInit() {
  }
}
