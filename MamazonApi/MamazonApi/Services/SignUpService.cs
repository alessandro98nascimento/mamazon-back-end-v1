using MamazonApi.Controllers.DTORequest;
using MamazonApi.Repository;

namespace MamazonApi.Services
{
    public class SignUpService
    {
        private readonly UsersTable _contextUser;
        private readonly PasswordsTable _contextPassword;
        private readonly EmailsTable _contextEmail;

        public SignUpService()
        {
            _contextUser = new UsersTable();
            _contextPassword = new PasswordsTable();
            _contextEmail = new EmailsTable();
        }

        public object AddNewUser(RequestNewUser newUser)
        {

        }

        public object AddPassword(string userPassword)
        {

        }
    }
}
