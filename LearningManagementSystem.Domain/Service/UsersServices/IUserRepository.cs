using LearningManagementSystem.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain.Service.UsersServices
{
    public interface IUserRepository
    {
        UsersViewModels CreateUser(UsersViewModels user);
    }
}
