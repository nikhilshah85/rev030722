using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace shoppingAPP
{
    class ProductDetails
    {
        #region Product Properties
           public int pId { get; set; }
            public string pName { get; set; }
            public string pCategory { get; set; }
            public int pQty { get; set; }
            public int pPrice { get; set; }
            public bool pIsInStock { get; set; }

        #endregion
  
   SqlConnection con = new SqlConnection(@"server=DESKTOP-H5HFUEB\TRAINERINSTANCE;database=shoppingAPP;integrated security=true");
        public string AddNewProduct(ProductDetails newProduct)

            {
               
                SqlCommand cmd_addProduct = new SqlCommand("insert into ProductDetails values(@pName,@pCat,@pQty,@pPrice,@pIsInStock)",con);
                
                cmd_addProduct.Parameters.AddWithValue("@pName",newProduct.pName);
                cmd_addProduct.Parameters.AddWithValue("@pCat",newProduct.pCategory);
                cmd_addProduct.Parameters.AddWithValue("@pQty",newProduct.pQty);
                cmd_addProduct.Parameters.AddWithValue("@pPrice",newProduct.pPrice);
                cmd_addProduct.Parameters.AddWithValue("@pIsInStock",newProduct.pIsInStock);
                
                try
                {
                    con.Open();
                    cmd_addProduct.ExecuteNonQuery();                    
                }
                catch(SqlException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return "Product Added Successfully";

            }
        public string EditProduct(ProductDetails newProduct)
        {
                SqlCommand cmd_update = new SqlCommand("update ProductDetails set pPrice = @newPPrice,pName =@newPName,pCategoty = @pNewCategoty,pQty = @newPQty where pId = @pId",con);
                cmd_update.Parameters.AddWithValue("@newPPrice",newProduct.pPrice);
                cmd_update.Parameters.AddWithValue("@newPName",newProduct.pName);
                cmd_update.Parameters.AddWithValue("@pNewCategoty",newProduct.pCategory);
                cmd_update.Parameters.AddWithValue("@newPqty",newProduct.pQty);
                cmd_update.Parameters.AddWithValue("@pId",newProduct.pId);

                try
                {
                    con.Open();
                    cmd_update.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return "Product Updated";
                
        }
        public string DeleteProduct(int id)
        {
            SqlCommand cmd_deleteProduct = new SqlCommand("delete from ProductDetails where pId=@pid",con);
            cmd_deleteProduct.Parameters.AddWithValue("@pid",id);
            try
            {
                con.Open();
                cmd_deleteProduct.ExecuteNonQuery();
            }
            catch (System.Exception es)
            {
                
                System.Console.WriteLine(es.Message);
            }
            finally
            {
                con.Close();
            }
            return "Product deleted";
        }
    
        public ProductDetails GetProductById(int id)
        {
            ProductDetails pr = null;
            SqlCommand cmd_search = new SqlCommand("select * from productdetails where pId =@pId",con);
            cmd_search.Parameters.AddWithValue("@pId",id);
            SqlDataReader _read;
            try
            {
                con.Open();
                _read = cmd_search.ExecuteReader();
               
                _read.Read();

                if(_read.Read())
                {
                    
                    pr.pId = id;
                    pr.pName =Convert.ToString(_read[1]);
                    pr.pCategory =Convert.ToString(_read[2]);
                    pr.pQty =Convert.ToInt32(_read[3]);
                    pr.pPrice =Convert.ToInt32(_read[4]);
                    pr.pIsInStock =Convert.ToBoolean(_read[5]);

                    return pr;
                }

            }
            catch (System.Exception es)
            {
                
                System.Console.WriteLine(es.Message);
            }
            finally
            {
                con.Close();
            }
        return pr;
        }


        public List<ProductDetails> GetProductList()
        {

            SqlCommand cmd_allProducts = new SqlCommand("select * from ProductDetails",con);
            SqlDataReader readProducts = null;
            List<ProductDetails> lst_ProductsFromDB = new List<ProductDetails>();

            try
            {
            con.Open();
            readProducts = cmd_allProducts.ExecuteReader();
            while (readProducts.Read())
            {
                
                lst_ProductsFromDB.Add(new ProductDetails()
                {
                    pId = Convert.ToInt32(readProducts[0]),
                    pName = readProducts[1].ToString(),
                    pCategory = readProducts[2].ToString(),
                    pQty = Convert.ToInt32(readProducts[3]),
                    pPrice = Convert.ToInt32(readProducts[4]),
                    pIsInStock = Convert.ToBoolean(readProducts[5])
                });
            }





            }
            catch(SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                readProducts.Close();
                con.Close();

            }



    return lst_ProductsFromDB;



        }

    }
}