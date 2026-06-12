using SaffromEstore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaffromEstore.Business.Services.IServices
{
    public interface IApplicationUserService
    {
        Task<ApplicationUser?> GetUserByIdAsync(string userId);
        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();
    }
}
