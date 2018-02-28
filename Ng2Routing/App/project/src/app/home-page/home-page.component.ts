import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {
  protected _data: any;

  constructor(
      private _http: HttpClient
  ) { }

  ngOnInit() {
  }

  callApi(){
      this._http.get('api/policy/get').subscribe(data => {
          this._data = data;
      });
  }

}
