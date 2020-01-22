using Api.Domain.Entities;
using Domain.Interfaces.Services.User;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {

        private IUserRepository _repository;
        
        public async Task<object> FindByLogin(UserEntity user)
        {
            var baseUser = new UserEntity();



            //if(baseUser != null && !string.IsNullOrWhiteSpace(user.Email)) {

            //    baseUser = await _repository.FindByLogin(user.Email);
            //}

            return baseUser != null && !string.IsNullOrWhiteSpace(user.Email) 
                ? await _repository.FindByLogin(user.Email) 
                : null;           

            
        }
    }
}
