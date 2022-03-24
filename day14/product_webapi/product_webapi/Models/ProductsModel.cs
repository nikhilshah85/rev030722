using System.Collections.Generic;

namespace product_webapi.Models
{
    public class ProductsModel
    {
        #region Product Properties
        public int pId { get; set; }
        public string pName { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }
        public string pCategory { get; set; }
        public int pAvailableQty { get; set; }
        
        #endregion

        public ProductsModel GetProductInfo()
        {
            //we will get the values from database
            return new ProductsModel()
            {
                pId = 101,
                pName = "Green Tea",
                pPrice = 8,
                pIsInStock = true,
                pCategory = "Health Drink",
                pAvailableQty = 20
            };
        }



        public List<ProductsModel> GetProductlist()
        {
            List<ProductsModel> products = new List<ProductsModel>();
            products.Add(new ProductsModel() { pId=101, pName="Pepsi", pCategory="Cold-Drink", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=102, pName="Coke", pCategory="Cold-Drink", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=103, pName="Maggie Noodles", pCategory="Fast-Food", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=104, pName="Burger", pCategory="Fast-Food", pAvailableQty=20, pIsInStock=false, pPrice=50 });
            products.Add(new ProductsModel() { pId=105, pName="Pizza", pCategory="Fast-Food", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=106, pName="Iphone", pCategory="Smart-Phone", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=107, pName="Mac book Pro", pCategory="Smart-PC", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=108, pName="Ipad Air", pCategory="Handy Pad", pAvailableQty=20, pIsInStock=false, pPrice=50 });
            products.Add(new ProductsModel() { pId=109, pName="Airpods", pCategory="Wireless", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=110, pName="Dell", pCategory="Laptop", pAvailableQty=20, pIsInStock=true, pPrice=50 });
            products.Add(new ProductsModel() { pId=111, pName="Green Tea", pCategory="Health-Drink", pAvailableQty=20, pIsInStock=false, pPrice=50 });
            return products;
        }
        
    }


}
