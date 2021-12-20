using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserData: ConnectionToSql
    {
        public void editProfile(int id ,string user, string password, string name, string lastName, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Users set loginName=@user, Password=@pass, FirstName=@name, LastName=@lastName, Email=@mail where UserId=@id";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@mail",mail );
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.LoginName = reader.GetString(1);
                            UserLoginCache.Password = reader.GetString(2);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + "," + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM MOSA_Client: Solicitud de recuperación de contraseña",
                            body: "Hola, " + userName +" ." +
                            "\nTu has solicitado un cambio de contraseña." +
                            "\nTu contraseña actual es: " + accountPassword +
                            "\nLe recomendamos que cambia la cambie la contraseña la proxima vez que ingrese.",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hola, " + userName + " ." +
                            "\nTu has solicitado un cambio de contraseña." +
                            "\nPor favor revisa tu correo: " + userMail +
                            "\nLe recomendamos que cambia la cambie la contraseña la proxima vez que ingrese.";
                    }
                    else
                    {
                        return "Lo sentimos, esta cuenta no existe intentelo de nuevo.";
                    }
                }
            }
        }
    }
}
