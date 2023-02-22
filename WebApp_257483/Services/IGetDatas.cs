using WebApp_257483.Models;

namespace WebApp_257483.Services
{
    public interface IGetDatas
    {
        Task<Union> GetDataAssets(string id, string radius);

    }
}
