using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserData userData = new UserData();
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;

        public UserModel(int idUser, string loginName, string password, string firstName, string lastName, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.email = email;
        }

        public UserModel()
        {

        }

        public string editUserProfile()
        {
            try
            {
                userData.editProfile(idUser, loginName, password, firstName, lastName, email);
                LoginUser(loginName, password);
                return "Se actulizo correctamente";
            }
            catch (Exception)
            {
                return "El usuario con este nombre ya existe, prueba con otro";
            }
        }
        public string CreateUser()
        {
            try
            {
                userData.editProfile(idUser, loginName, password, firstName, lastName, email);
                LoginUser(loginName, password);
                return "Se actulizo correctamente";
            }
            catch (Exception)
            {
                return "El usuario con este nombre ya existe, prueba con otro";
            }
        }

        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }
        public string RecoverPassword(string userRequesting)
        {
            return userData.recoverPassword(userRequesting);
        }
        public void AnyMethod()
        {
            if (UserLoginCache.Position == "Administrador")
            {

            }
            if (UserLoginCache.Position == "Usuario")
            {

            }
        }
    }
}
