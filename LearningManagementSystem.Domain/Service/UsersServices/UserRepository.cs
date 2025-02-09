using LearningManagementSystem.DataBase.Data;
using LearningManagementSystem.DataBase.Migrations;
using LearningManagementSystem.DataBase.Models;
using LearningManagementSystem.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users = LearningManagementSystem.DataBase.Models.Users;

namespace LearningManagementSystem.Domain.Service.UsersServices
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;

        public UserRepository(AppDbContext db)
        {
            _db = db;
        }

        public UsersViewModels CreateUser(UsersViewModels user)
        {
            var userModel = new Users 
            {
                UserId = Guid.NewGuid(),
                Name = user.Name,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                UserName = user.UserName,
                Phone = user.Phone,
                Address = user.Address,
                CreatedDate = user.CreatedDate,
                UpdatedDate = user.UpdatedDate,
                DeleteFlag = false
            };

            _db.Users.Add(userModel);
            _db.SaveChanges();

            return user;
        }
    }

    
}
