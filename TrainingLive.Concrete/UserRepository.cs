using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingLive.IRepository;
using TrainingLive.Models;
using TrainingLive.ViewModels;

namespace TrainingLive.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;

        public UserRepository(ApplicationDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<User> AddUserAsync(UserViewModel userViewModel)
        {
            var userDM = this.mapper.Map<User>(userViewModel);
                            this.context.Users.AddAsync(userDM);
                            await this.context.SaveChangesAsync();
            return userDM;
        }

        public async Task<bool> DeleteUserAsync(int UserId)
        {
            var userDetails = this.context.Users.Where(x => x.UserId == UserId).FirstOrDefault();
            if (userDetails != null)
            {
                this.context.Users.Remove(userDetails);
                if(await this.context.SaveChangesAsync()>0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
