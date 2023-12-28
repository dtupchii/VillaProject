using VillaProject_Web.Models;

namespace VillaProject_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse ResponceModel { get; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
