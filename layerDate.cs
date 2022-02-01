using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudSql
{   
    public class layerDate
    {
        private modelsContact models = new modelsContact(); 
        private SqlConnection connectionSql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = MyFirstData; Data Source = DESKTOP-F32FCTD\\SQLEXPRESS");
        public void Connectar()
        {
            try
            {
                connectionSql.Open();
                MessageBox.Show("Connection Succesfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la conexion"+ex.Message);    
            }
            finally
            {
                connectionSql.Close();
            }
        }

        public void userCreate(modelsContact models)
        {
            try
            {
                connectionSql.Open();
                string query = "INSERT INTO userDate(nameFirst,nameLast,phone,addres) VALUES (@nameFirst,@nameLast,@phone,@addres) ";

                SqlParameter parameterName = new SqlParameter("@nameFirst", models.nameFirst);
                SqlParameter parameterLast = new SqlParameter("@nameLast", models.nameLast);
                SqlParameter parameterPhone = new SqlParameter("@phone", models.phone);
                SqlParameter parameterAddres = new SqlParameter("@addres", models.addres);

                SqlCommand command = new SqlCommand(query, connectionSql);
                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterLast);
                command.Parameters.Add(parameterPhone);
                command.Parameters.Add(parameterAddres);
                command.ExecuteNonQuery();
                MessageBox.Show("Record Succesfully");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectionSql.Close();
            }
        }

        public List<modelsContact> mostrarActualizar(string search = null)
        {
            List<modelsContact> models = new List<modelsContact>();
            try 
            {
                connectionSql.Open();
                string query = " SELECT Id,nameFirst,nameLast,phone,addres FROM userDate";
                SqlCommand command = new SqlCommand();

                    if (!string.IsNullOrEmpty(search))
                    {
                        query += " WHERE nameFirst like @search OR nameLast LIKE @search OR phone LIKE @search OR addres LIKE @search ";
                        command.Parameters.Add(new SqlParameter("@search",$"%{search}%"));
                    }
                
                command.CommandText = query;
                command.Connection = connectionSql;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    models.Add(new modelsContact
                    {
                        id = int.Parse(reader["Id"].ToString()),
                        nameFirst = reader["nameFirst"].ToString(),
                        nameLast = reader["nameLast"].ToString(),
                        phone = reader["phone"].ToString(),
                        addres = reader["addres"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un errorNO: " + ex.Message);
            }
            finally
            {
                connectionSql.Close();
            }
            return models;
        }

        public void UserUpdate(modelsContact models)
        {
            try
            {
                connectionSql.Open();
                string query = "UPDATE userDate SET nameFirst=@nameFirst,nameLast=nameLast,phone=@phone,addres=@addres WHERE Id=@id";

                SqlParameter parameterId = new SqlParameter("@id", models.id);
                SqlParameter parameterName = new SqlParameter("@nameFirst", models.nameFirst);
                SqlParameter parameterLast = new SqlParameter("@nameLast", models.nameLast);
                SqlParameter parameterPhone = new SqlParameter("@phone", models.phone);
                SqlParameter parameterAddres = new SqlParameter("@addres", models.addres);
                
                SqlCommand command = new SqlCommand(query,connectionSql);
                command.Parameters.Add(parameterId);
                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterLast);
                command.Parameters.Add(parameterPhone);
                command.Parameters.Add(parameterAddres);
                command.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha actualizado los datos: "+ex);
            }
            finally
            {
                connectionSql.Close();
            }
        }

        public void UserDelete(int id)
        {
            try
            {
                connectionSql.Open();
                string query = "DELETE FROM userDate WHERE Id=@id";

                var parameterId = new SqlParameter("@id",id);
                var command = new SqlCommand(query, connectionSql);
                command.Parameters.Add(parameterId);
                command.ExecuteNonQuery();
                MessageBox.Show("Record Delete"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: "+ex);
            }
            finally
            {
                connectionSql.Close();
            }
        }

        
    }   
}
