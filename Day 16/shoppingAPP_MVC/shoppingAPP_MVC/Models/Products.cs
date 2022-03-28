using System.Collections.Generic;

namespace shoppingAPP_MVC.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public int pAvailableQty { get; set; }


        public Products GetProducts()
        {
            return new Products()
            {
                pId = 101,
                pName = "Pepsi",
                pCategory = "Cold-Drink",
                pAvailableQty = 23,
                pPrice = 10
            };
        }


        public List<Products> ProductList()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products() { pId=101, pName="Pepsi", pAvailableQty=23, pPrice=10, pCategory="Cold-Drink" });
            products.Add(new Products() { pId=102, pName="IPhone", pAvailableQty=23, pPrice=10, pCategory="Cold-Drink" });
            products.Add(new Products() { pId=103, pName="MacBook Pro", pAvailableQty=23, pPrice=10, pCategory="Cold-Drink" });
            products.Add(new Products() { pId=104, pName="Fossil", pAvailableQty=23, pPrice=10, pCategory="Cold-Drink" });
            products.Add(new Products() { pId=105, pName="Trailhawk", pAvailableQty=23, pPrice=10, pCategory="Cold-Drink" });
            products.Add(new Products() { pId=106, pName="Bosch", pAvailableQty=23, pPrice=10, pCategory="Cold-Drink" });
            products.Add(new Products() { pId=107, pName="Dell", pAvailableQty=23, pPrice=10, pCategory="Cold-Drink" });
            return products;
        }
        
            
    }
}
