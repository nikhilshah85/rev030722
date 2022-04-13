import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  appName = "Amazon Shopping APP";
  productList = [
    {pId:101, pName:'Pepsi',pCategory:'Cold-Drinks',pPrice:5,pIsInStock:true},
    {pId:102, pName:'Fossil',pCategory:'Watch',pPrice:550,pIsInStock:true},
    {pId:103, pName:'Trailhawk',pCategory:'SUV',pPrice:50000,pIsInStock:false},
    {pId:104, pName:'Dell',pCategory:'Electronics',pPrice:2100,pIsInStock:true},
    {pId:105, pName:'Ipad',pCategory:'Electronics',pPrice:750,pIsInStock:false},
    {pId:106, pName:'Surface Pro',pCategory:'Electronics',pPrice:2700,pIsInStock:true},
  ]

  addProduct(newProduct:any)
  {
    this.productList.push(newProduct);
  }

  greetUser()
  {
    return "Enjoy Shopping with exciting offers";
  }
  constructor() { }
}
