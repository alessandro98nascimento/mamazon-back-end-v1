using MamazonApi.Context;
using MamazonApi.Controllers.DTORequest;
using MamazonApi.Models;
using MamazonApi.Repository;
using MamazonApi.Services.DTO;
using Microsoft.EntityFrameworkCore;

namespace MamazonApi.Services
{
    public class LoginService
    {
        private readonly UsersTable _contextUser;
        private readonly EmailsTable _contextEmail;
        private readonly PasswordsTable _contextPassword;

        public LoginService()
        {
            _contextUser = new UsersTable();
            _contextEmail = new EmailsTable();
            _contextPassword = new PasswordsTable();
        }
        public ResponseDTOLogin PostEmailPassword(RequestLogin data)
        {
            ResponseDTOLogin response = new ResponseDTOLogin();
            Email? emailExist = _contextEmail.PostEmail(data);

            if (emailExist == null)
            {
                response.Message = "Email ou senha invalida!";
                return response;
            };

            User? userValid = _contextUser.PostUser(emailExist);

            if (userValid.ActiveUser == 0)
            {
                response.Message = "Conta desativada!";
                return response;
            }

            Password? passwordExist = _contextPassword.PostPassword(userValid.PasswordId);


            if (passwordExist.UserPassword != data.Password)
            {
                response.Message = "Email ou senha invalida!";
                return response; 
            }

            UserDTO? user = new UserDTO
            {
                UserId = userValid.UserId,
                UserName = userValid.UserName,
                ActiveUser = userValid.ActiveUser,
            };

            response.User = user;
            return response;
        }
    }
}
