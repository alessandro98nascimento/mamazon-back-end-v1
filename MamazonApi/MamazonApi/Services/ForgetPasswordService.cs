using MamazonApi.Controllers.DTORequest;
using MamazonApi.Models;
using MamazonApi.Repository;

namespace MamazonApi.Services
{
    public class ForgetPasswordService
    {
        private readonly UsersTable _contextUser;
        private readonly PasswordsTable _contextPassword;
        private readonly EmailsTable _contextEmail;

        public ForgetPasswordService()
        {
            _contextUser = new UsersTable();
            _contextPassword = new PasswordsTable();
            _contextEmail = new EmailsTable();
        }

        public bool ExistEmail(RequestEmail request)
        {
            Email? emailExist = _contextEmail.PostEmail(request.Email);
            if (emailExist == null) return false;
            return true;
        }

        public bool UpdatePassword(RequestUpdatePassword request)
        {
            Email? emailUser = _contextEmail.PostEmail(request.Email);
            if (emailUser == null) return false;
            User? user = _contextUser.PostUser(emailUser);
            if (user == null) return false;
            Password? newPassword = _contextPassword.PutPassword(user.PasswordId ,request.Password);
            if(newPassword == null) return false;
            return true;
        }
    }
}
