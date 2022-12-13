using AzureDeployment.Data;
using AzureDeployment.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AzureDeployment.Services;

public class UserService : IUserService
{
    private readonly MediumDbContext _context;

    public UserService(MediumDbContext context)
    {
        this._context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public async Task<object> GetAllUsers()
    {
        try
        {
            return await _context.Users.ToListAsync();
        }
        catch (Exception excp)
        {
            // if you have a logging mechanism, implement here
            throw;
        }
    }
}
