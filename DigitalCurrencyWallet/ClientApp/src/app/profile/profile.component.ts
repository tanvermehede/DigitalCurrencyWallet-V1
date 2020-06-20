import { Component, OnInit } from '@angular/core';
import { ProfileService } from '../services/profile.service';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  userProfileData = {}
  user;
  constructor(private profileService: ProfileService, private service: AuthService) { }

  ngOnInit() {
    this.profileService.getProfile()
      .subscribe(data => {
        this.userProfileData = data;
      });
    //Get user id
    this.service.getUserProfile().subscribe(
      res => {
        this.user = res;
      },
      err => {
        console.log(err);
      },
    );
  }

  saveProfile() {
    this.profileService.saveProfile(this.userProfileData)
      .subscribe(
        res => console.log(res),
        err => console.log(err)
      )
  }

  updateProfile() {
    this.profileService.updateProfile(this.userProfileData)
      .subscribe(
        res => console.log(res),
        err => console.log(err)
      )
  }
}
