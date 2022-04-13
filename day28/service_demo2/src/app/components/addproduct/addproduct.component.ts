import { Component, OnInit } from '@angular/core';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent implements OnInit {

  _prodSer:ProductsService;


  constructor(_prodSerRef:ProductsService)
   {
     this._prodSer = _prodSerRef;
    }

  ngOnInit(): void {
  }

}
