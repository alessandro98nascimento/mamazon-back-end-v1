/*
using MamazonApi.Repository;
using MamazonApi.Repository.DTO;
using MamazonApi.Services.DTO;

namespace MamazonApi.Services
{
    public class ForgetPasswordService
    {
        private readonly UsersTable _context;
        public ForgetPasswordService()
        {
            _context = new UsersTable();
        }

        public UserEmailRequestDTO? PostUserByEmail(UserEmailRequestDTO request)
        {
            var responseDb = _context.GetUserByEmail(request);

            if (responseDb == null) return null;

            return request;

        }

        public UserNewPasswordRequestDTO? PutPassword(UserNewPasswordRequestDTO request)
        {
            var responseDb = _context.PutUserPassword(request);
            if (request.Password != responseDb.Password) return null;
            return request;
        }
    }

    
}
*/