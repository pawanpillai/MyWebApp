import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    objMyClientModel = new MyClientModel;
    BaseUrl: string;
    EndPoint: string;

    constructor(private http: HttpClient) {
        this.BaseUrl = "http://localhost:56949/api";
    }

    ngOnInit() {
        this.objMyClientModel.FirstName = "Pawan";
        this.objMyClientModel.LastName = "Pillai";
        
        this.EndPoint = "/values";
        const headers = new HttpHeaders()
            .set('Content-Type', 'application/json');
            //.set('Authorization', 'Basic loremlorem'); //we can add more headers like this


        this.http.post(this.BaseUrl + this.EndPoint, this.objMyClientModel, { headers })
            .subscribe(
                res => {
                    console.log(res);
                },
                err => {
                    console.log("Error occured");
                }
            );
    }


}

class MyClientModel{
    FirstName: string;
    LastName: string;
}
