namespace AzureDeployment.Services;

public interface IUserService
{
    Task<object> GetAllUsers();
}
