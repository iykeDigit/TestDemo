using FinalAPIDemo.Core.Pagination;
using FinalAPIDemo.Data;
using FinalAPIDemo.Model;
using FinalAPIDemo.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAPIDemo.Core
{
    public class PlayersService : IPlayersService
    {
        private readonly AppDbContext _dbContext;

        public PlayersService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public async Task AddNewPlayer(PlayerDto player)
        //{
        //    var checkPlayerExists = await _dbContext.Players.Where(x => x.Name == player.Name).FirstOrDefaultAsync();
        //    if (checkPlayerExists == null)
        //    {
        //        try
        //        {
        //            var data = new Player()
        //            {
        //                Name = player.Name,
        //                Score = player.Score
        //            };
        //            await _dbContext.Players.AddAsync(data);

        //            await _dbContext.SaveChangesAsync();

        //        }
        //        catch (Exception)
        //        {

        //            throw new ArgumentException("An error occurred");
        //        }
        //    }
        //    else
        //    {
        //        throw new ArgumentException("This user already exists");
        //    }

        //}

        //public async Task<bool> DeletePlayer(string id)
        //{
        //    var player = await _dbContext.Players.Where(x => x.PlayerID == id).FirstOrDefaultAsync();
        //    if (player != null)
        //    {
        //        var result = _dbContext.Players.Remove(player);
        //        await _dbContext.SaveChangesAsync();
        //        return true;
        //    }
        //    throw new ArgumentNullException("Player not found");
        //}

        public async Task<PagedResponse<IEnumerable<Player>>> GetAllPlayersAsync(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var totalRecords = await _dbContext.Players.CountAsync();
            if(totalRecords > 0)
            {
                var data = await _dbContext.Players
                                     .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                                     .Take(validFilter.PageSize)
                                     .ToListAsync();
                return PaginationHelper.CreatePagedReponse<Player>(data, validFilter, totalRecords);
            }            
            throw new ArgumentNullException("No user exists");
        }

        public async Task<Player> GetPlayerAsync(string id)
        {
            var player = await _dbContext.Players.Where(x => x.PlayerID == id).FirstOrDefaultAsync();
            if (player != null) return player;
            throw new ArgumentNullException("User not found");

        }

        //public async Task UpdatePlayer(int playerId, UpdatePlayerDto updatePlayerDto)
        //{
        //    var player = await _dbContext.Players.Where(x => x.Id == playerId).FirstOrDefaultAsync();
        //    if (player != null)
        //    {
        //        player.Name = string.IsNullOrWhiteSpace(updatePlayerDto.Name) ? player.Name : updatePlayerDto.Name;
        //        player.Score = string.IsNullOrWhiteSpace(updatePlayerDto.Score) ? player.Score : updatePlayerDto.Score;

        //        _dbContext.Update(player);
        //        await _dbContext.SaveChangesAsync();
        //    }
        //    else throw new ArgumentNullException("Player Not Found");
        //}
    }
}
