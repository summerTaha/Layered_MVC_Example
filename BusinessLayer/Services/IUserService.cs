using MVC_Example.DataAccessLayer.Models;
using MVC_Example.Dtos;

namespace BusinessLayer.Services
{
    public interface IUserService : ICrudService<UserDto> 
    {
        Task SendEmail(User user);
    }
}
