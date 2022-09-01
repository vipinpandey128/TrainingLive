using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingLive.Models;
using TrainingLive.ViewModels;

namespace TrainingLive.IRepository
{
    public interface IUserRepository
    {
        public Task<User> AddUserAsync(UserViewModel userViewModels);
        public Task<bool> DeleteUserAsync(int UserId);
    }
}
