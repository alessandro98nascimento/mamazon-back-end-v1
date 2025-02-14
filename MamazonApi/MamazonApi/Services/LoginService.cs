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
        public Tuple<UserDTO?, string> PostEmailPassword(RequestLogin data)
        {
            Email? emailExist = _contextEmail.PostEmail(data);
            Password? passwordExist = _contextPassword.PostPassword(data);

            if (emailExist == null || passwordExist == null) return new Tuple<UserDTO?, string>(null, "Email ou senha invalida!");

            User? userValid = _contextUser.PostUser(emailExist, passwordExist);

            if (userValid == null) return new Tuple<UserDTO?, string>(null, "Usuário não encontrado!");

            UserDTO? user = new UserDTO
            {
                UserId = userValid.UserId,
                UserName = userValid.UserName,
                ActiveUser = userValid.ActiveUser,
            };

            if (user.ActiveUser == 0)
            {
                return new Tuple<UserDTO?, string>(null, "Conta desativada!");
            }

            return new Tuple<UserDTO?, string>(user, "Ok!");
            
        }
    }
}
