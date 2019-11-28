using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Framework
{
    public class DataAccess
    {
        string connectionString = "Data Source=DESKTOP-7G5IUPG;Initial Catalog=POS_System;Persist Security Info=True;User ID=sa;Password=12345";

        public int ExecuteLogin(SqlCommand command)
        {
            string temp;
            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                temp = command.ExecuteScalar().ToString();
                connection.Close();
                return Convert.ToInt32(temp);
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public string Execute(SqlCommand command)
        {
            
            string temp;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                temp = command.ExecuteScalar().ToString();
                connection.Close();
                return temp;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }
            
        }
        
        public DataTable ExecuteInsert(SqlCommand command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }

        }   

        public DataTable Query(SqlCommand query)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                query.Connection = connection;
                SqlDataAdapter da = new SqlDataAdapter(query);
                connection.Open();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void InventoryExecute(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            
        }

        public int QuantityQuery(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            int temp;
            try
            {
                command.Connection = connection;
                connection.Open();
                temp = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return temp;
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /*
                DataAccess _da = new DataAccess();
        public bool checklog(Login _log)
        {
            int count = 0;
            string insertCommand = "select count(*) from Login where Id= '"+_log.Id+ "' and Password = '"+_log.Password+"'";
            SqlCommand command = new SqlCommand(insertCommand);

            count = _da.ExecuteLogin(command);
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string checkTitle(Login _log)
        {
            string insertCommand = "select EmployeeTitle from Login where Id= '" + _log.Id + "' and Password = '" + _log.Password + "'";
            SqlCommand command = new SqlCommand(insertCommand);
            return _da.Execute(command);
        }

        public Product getDetail(string id, Product product)
        {
            DataTable ds = new DataTable();
            string insertCommand = "select Product_Name,Sell_price from Product_Details where Product_Id=" +"'"+id+"'";
            SqlCommand command = new SqlCommand(insertCommand);

            ds=_da.ExecuteInsert(command);
            product.name = ds.Rows[0][0].ToString();
            product.sell_price = Convert.ToDouble(ds.Rows[0][1]);

            return product;
        }

        public DataTable GetCatagory()
        {
            string insertCommand = "select distinct Catagory from Product_Details";
            SqlCommand command = new SqlCommand(insertCommand);
            return _da.ExecuteInsert(command);
        }
        public DataTable GetAllData()
        {
            string insertCommand = "select * from Product_Details";
            SqlCommand command = new SqlCommand(insertCommand);
            return _da.ExecuteInsert(command);
        }
        public DataTable GetTableData(string catagory)
        {
            string insertCommand = "select * from Product_Details where Catagory= '"+catagory+"' order by Product_Id";
            SqlCommand command = new SqlCommand(insertCommand);

            return _da.Query(command);
        }

        public int GetQuantityData(int id)
        {
            string quantityCommand = "select Stocked from Product_Details where Product_Id='"+id+"'";
            SqlCommand command = new SqlCommand(quantityCommand);
            return _da.QuantityQuery(command);
        }

        public void UpdateQuery(int id, int quantity)
        {
            string stockedCommand = "UPDATE Product_Details SET Stocked = "+quantity+" WHERE Product_Id = '"+id+"'";
            SqlCommand command = new SqlCommand(stockedCommand);
            _da.InventoryExecute(command);
        }
                 string connectionString = "Data Source=DESKTOP-7G5IUPG;Initial Catalog=POS_System;Persist Security Info=True;User ID=sa;Password=12345";

        public int ExecuteLogin(SqlCommand command)
        {
            string temp;
            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                temp = command.ExecuteScalar().ToString();
                connection.Close();
                return Convert.ToInt32(temp);
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public string Execute(SqlCommand command)
        {
            
            string temp;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                temp = command.ExecuteScalar().ToString();
                connection.Close();
                return temp;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }
            
        }
        
        public DataTable ExecuteInsert(SqlCommand command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }

        }   

        public DataTable Query(SqlCommand query)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                query.Connection = connection;
                SqlDataAdapter da = new SqlDataAdapter(query);
                connection.Open();
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void InventoryExecute(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            
        }

        public int QuantityQuery(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            int temp;
            try
            {
                command.Connection = connection;
                connection.Open();
                temp = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return temp;
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
         */

    }
}
