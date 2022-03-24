using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace product_webapi.Models
{
    public class ProductDetailsModel
    {
        #region Columns - Properties
        public int productId { get; set; }
        public string productName   { get; set; }

        public string productCategory { get; set; }

        public int productQty { get; set; }
        public double productPrice { get; set; }
        public bool productIsInStock { get; set; }
        #endregion

        SqlConnection con = new SqlConnection("server= DESKTOP-H5HFUEB\\TRAINERINSTANCE; database= shoppingAPP; integrated security=true");

        #region Read Data
        public List<ProductDetailsModel> GetProductList()
        {
            SqlCommand cmd_allproducts = new SqlCommand("select * from productdetails", con);
            List<ProductDetailsModel> plist = new List<ProductDetailsModel>();
            SqlDataReader readAllProducts = null;
            try
            {
                con.Open();
                readAllProducts = cmd_allproducts.ExecuteReader();

                while (readAllProducts.Read())
                {
                    plist.Add(new ProductDetailsModel()
                    {
                        productId = Convert.ToInt32(readAllProducts[0]),
                        productName = readAllProducts[1].ToString(),
                        productCategory = readAllProducts[2].ToString(),
                        productQty = Convert.ToInt32(readAllProducts[3]),
                        productPrice = Convert.ToInt32(readAllProducts[4]),
                        productIsInStock = Convert.ToBoolean(readAllProducts[5])
                    });
                }               

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                readAllProducts.Close();
                con.Close();
            }
            return plist;


        }


        public ProductDetailsModel GetProductDetails(int pid)
        {

            SqlCommand cmd_searchById = new SqlCommand("select * from productdetails where pid=@id", con);
            cmd_searchById.Parameters.AddWithValue("@id", pid);
            SqlDataReader read_product = null;
            ProductDetailsModel pr = new ProductDetailsModel();
            try
            {
                con.Open();
                read_product = cmd_searchById.ExecuteReader();
                
                if (read_product.Read())
                {
                    pr.productId = Convert.ToInt32(read_product[0]);
                    pr.productName = read_product[1].ToString();
                    pr.productCategory = read_product[2].ToString();
                    pr.productQty = Convert.ToInt32(read_product[3]);
                    pr.productPrice = Convert.ToInt32(read_product[4]);
                    pr.productIsInStock = Convert.ToBoolean(read_product[5]);
                }
                else
                {
                    throw new Exception("Product Not Found");
                }
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);              
            }
            finally
            {
                read_product.Close();
                con.Close();
            }
            return pr;
        }
        #endregion

        public string Addproduct(ProductDetailsModel newProduct)
        {
            SqlCommand cmd_addProduct = new SqlCommand("insert into ProductDetails values(@pName,@pCategoty,@pQty,@pPrice,@pIsInStock)",con);
            //cmd_addProduct.Parameters.AddWithValue("@pId",newProduct.productId); -- identity Column
            cmd_addProduct.Parameters.AddWithValue("@pName",newProduct.productName);
            cmd_addProduct.Parameters.AddWithValue("@pCategoty",newProduct.productCategory);
            cmd_addProduct.Parameters.AddWithValue("@pQty",newProduct.productQty);
            cmd_addProduct.Parameters.AddWithValue("@pPrice",newProduct.productPrice);
            cmd_addProduct.Parameters.AddWithValue("@pIsInStock",newProduct.productIsInStock);

            try
            {
                con.Open();
                cmd_addProduct.ExecuteNonQuery();
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);
                
            }
            finally
            {
                con.Close();
            }
            return "Product Added Successfully";
        }

        public string DeleteProduct(int pId)
        {
            SqlCommand cmd_delete = new SqlCommand("delete from ProductDetails where pid = @pId", con);
            cmd_delete.Parameters.AddWithValue("@pId", pId);
            try
            {
                con.Open();
                cmd_delete.ExecuteNonQuery();
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                con.Close();
            }
            return "Product Deleted Successfully";
        }

        public string UpdateProduct(ProductDetailsModel updates)
        {

            SqlCommand cmd_update = new SqlCommand("update ProductDetails set pName=@pName,pCategoty=@pcategory, pQty= @qty, pPrice=@price, pIsInStock=@isInstock where pId =@pid", con);
            cmd_update.Parameters.AddWithValue("@pName",updates.productName);
            cmd_update.Parameters.AddWithValue("@pcategory",updates.productCategory);
            cmd_update.Parameters.AddWithValue("@qty",updates.productQty);
            cmd_update.Parameters.AddWithValue("@price",updates.productPrice);
            cmd_update.Parameters.AddWithValue("@isInstock",updates.productIsInStock);
            cmd_update.Parameters.AddWithValue("@pid",updates.productId);

            try
            {
                con.Open();
                cmd_update.ExecuteNonQuery();
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);                
            }
            finally
            {
                con.Close();
            }
            return "product update successfull";
        }

    }
}
