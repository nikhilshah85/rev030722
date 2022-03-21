using System;
using System.Collections.Generic;

namespace shoppingAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDetails prDetails = new ProductDetails();
    

            bool continueShopping  = true;
            bool isLoggedIn = false;

            if (isLoggedIn == false)
            {
                System.Console.WriteLine("Enter Your User Name");
                string username = Console.ReadLine();
                System.Console.WriteLine("Enter Your Password");
                string password = Console.ReadLine();
                Security sObj = new Security();
                
                bool loginResult = sObj.Login(username,password);
                if(loginResult == false)
                {   
                        System.Console.WriteLine("Invalid Credentials");
                }
                else
                {

                    isLoggedIn = true;
               
            while (continueShopping)
             {
             Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~ Welcome to Online Shopping APP ~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("1. Add New Product");
            System.Console.WriteLine("2. Edit Product");
            System.Console.WriteLine("3. Delete Product");
            System.Console.WriteLine("4. Search Product By Prodct ID");
            System.Console.WriteLine("5. Product List");
            System.Console.WriteLine("6. Log out");
              int choice = Convert.ToInt32(Console.ReadLine());


              switch (choice)
              {
                case 1:
                #region  Add new Product 
                    System.Console.WriteLine("Enter Product Name");
                    string name =Console.ReadLine();
                    System.Console.WriteLine("Enter Product Category");
                    string category = Console.ReadLine();
                    System.Console.WriteLine("Enter Product Qty");
                    int qty = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter Product Price");
                    int price = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter Product Is In Stock");
                    bool isInStock = Convert.ToBoolean(Console.ReadLine());

                    ProductDetails newProduct = new ProductDetails();
                    newProduct.pName = name;
                    newProduct.pCategory = category;
                    newProduct.pPrice = price;
                    newProduct.pQty = qty;
                    newProduct.pIsInStock = isInStock;
                   System.Console.WriteLine(prDetails.AddNewProduct(newProduct));
                    break;
                    #endregion
                case 2:
                #region Edit product with ID
                 System.Console.WriteLine("Enter Product Name");
                    string name2 =Console.ReadLine();
                    System.Console.WriteLine("Enter Product Category");
                    string category2 = Console.ReadLine();
                    System.Console.WriteLine("Enter Product Qty");
                    int qty2 = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter Product Price");
                    int price2 = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter Product Is In Stock");
                    bool isInStock2 = Convert.ToBoolean(Console.ReadLine());

                    System.Console.WriteLine("Enter Product Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    ProductDetails productChange = new ProductDetails();
                    productChange.pId = id;
                    productChange.pName = name2;
                    productChange.pCategory = category2;
                    productChange.pPrice = price2;
                    productChange.pQty = qty2;
                    productChange.pIsInStock = isInStock2;
                   
                   System.Console.WriteLine(prDetails.EditProduct(productChange));
                    break;
                    #endregion
                case 3:
                #region Delete product
                    System.Console.WriteLine("Enter Product Id to delete the product");
                    int pid = Convert.ToInt32(Console.ReadLine());

                   System.Console.WriteLine(prDetails.DeleteProduct(pid));
                #endregion
                    break;
                case 4:
                   System.Console.WriteLine("Enter Product Id to search the product");
                    int pid2 = Convert.ToInt32(Console.ReadLine());
                    ProductDetails pr = prDetails.GetProductById(pid2);
                    System.Console.WriteLine("Product ID " + pr.pId);
                    System.Console.WriteLine("Product Name " + pr.pName);
                    System.Console.WriteLine("Product Category " + pr.pCategory);
                    System.Console.WriteLine("Product Price " + pr.pPrice);
                    System.Console.WriteLine("Product Quantity " + pr.pQty);
                    System.Console.WriteLine("Product Is In Stock " + pr.pIsInStock);
                    break;
                case 5:
                    List<ProductDetails> lst =  prDetails.GetProductList();
                    foreach (var item in lst)
                    {
                        System.Console.WriteLine("___________________________________________");
                        System.Console.WriteLine("Product Id "            + item.pId);
                        System.Console.WriteLine("Product Name "          + item.pName);
                        System.Console.WriteLine("Product Category "      + item.pCategory);
                        System.Console.WriteLine("Product Qty "           + item.pQty);
                        System.Console.WriteLine("Product Price "         + item.pPrice);
                        System.Console.WriteLine("Product Is In Stock ? " + item.pIsInStock);
                    }


                    break;
                case 6:
                 continueShopping = false;
                 isLoggedIn = false;
                    break;
                default:
                        System.Console.WriteLine("Please Enter A Correct Choice");
                        break;
              }
                
             }

           

                }
            }
            






        }
    }
}
