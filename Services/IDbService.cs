using System.Threading.Tasks;

using app.Models;

namespace app.Services
{
    /// <summary>
    /// Generic Database Service Interface.
    /// </summary>
    public interface IDbService
    {
        /// <summary>
        /// Adds an item to the database.
        /// </summary>
        /// <param name="item">Item object.</param>
        /// <returns></returns>
        Task AddItemAsync(Item item);
    }
}