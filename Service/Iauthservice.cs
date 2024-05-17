using MOCKAPP.Server.Model;

namespace MOCKAPP.Server.Service
{
    public interface Iauthservice
    {
        Task<(int, string)> Registeration(Register model, string role);
        Task<(int, string)> Login(Login model);
    }

}
