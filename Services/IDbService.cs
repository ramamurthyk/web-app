using System.Threading.Tasks;
using app.Models;

namespace app.Services
{
    public interface IDbService
    {
        Task AddItemAsync(Item item);
    }
}