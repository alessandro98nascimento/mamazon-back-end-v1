/*
using MamazonApi.Context;
using MamazonApi.Models;
using MamazonApi.Repository.DTO;

namespace MamazonApi.Repository
{
    public class UsersTable
    {
        private readonly AppDbContext _context;
        public UsersTable() 
        {
            _context = new AppDbContext();        
        }

        public User? GetUser(UserDTORequestLogin request)
        {
            User? dbResponse = _context.Users.FirstOrDefault(user => user.Email == request.Email && user.Password == request.Password);
            return dbResponse;
        }

        public User? GetUserByEmail(UserEmailRequestDTO request)
        {
            User? dbResponse = _context.Users.FirstOrDefault(user => user.Email == request.Email);

            return dbResponse;
        }

        public User? PutUserPassword(UserNewPasswordRequestDTO request)
        {
            User? dbResponse = _context.Users.FirstOrDefault(userDb => userDb.Email == request.Email);
            dbResponse.Password = request.Password;

            _context.Users.Update(dbResponse);

            _context.SaveChanges();

            return dbResponse;
        }

        public User? PostNewUser(User request)
        {
            _context.Users.Add(request);
            _context.SaveChanges();
            User? newUser = _context.Users.FirstOrDefault(user => user.Password == request.Password);
            return newUser;
        }
    }   
} */
