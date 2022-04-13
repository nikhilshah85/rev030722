import { Component, OnInit } from '@angular/core';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-productlist',
  templateUrl: './productlist.component.html',
  styleUrls: ['./productlist.component.css']
})
export class ProductlistComponent implements OnInit {

  _prodService:ProductsService;

  constructor(_prodServiceRef:ProductsService)
   {
      this._prodService = _prodServiceRef;

    }

  ngOnInit(): void {
  }

}
