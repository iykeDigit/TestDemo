using FinalAPIDemo.Core.Pagination;
using FinalAPIDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAPIDemo.Core
{
    public interface IPlayersService
    {
        Task<Player> GetPlayerAsync(string id);
        Task<PagedResponse<IEnumerable<Player>>> GetAllPlayersAsync(PaginationFilter filter);
      //  Task AddNewPlayer(Player player);
        //Task<bool> DeletePlayer(int id);
        //Task UpdatePlayer(int playerId, UpdatePlayerDto player);
    }
}
