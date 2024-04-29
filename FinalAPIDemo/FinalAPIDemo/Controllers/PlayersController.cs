using FinalAPIDemo.Core;
using FinalAPIDemo.Core.Pagination;
using FinalAPIDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayersService _playerService;

        public PlayersController(IPlayersService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("players")]
        public async Task<IActionResult> GetAllPlayersAsync([FromQuery] PaginationFilter filter)
        {
            try
            {
                return Ok(await _playerService.GetAllPlayersAsync(filter));
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("players/{playerID}")]
        public async Task<IActionResult> GetplayerById(string playerID)
        {
            try
            {
                return Ok(await _playerService.GetPlayerAsync(playerID));
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //[HttpPost("players/addPlayer")]
        //public async Task<IActionResult> AddNewPlayer(PlayerDto player)
        //{
        //    try
        //    {
        //        await _playerService.AddNewPlayer(player);
        //        return Ok();

        //    }
        //    catch (ArgumentException)
        //    {
        //        return BadRequest();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500);
        //    }
        //}

        //[HttpDelete]
        //public async Task<IActionResult> Delete(int userId)
        //{
        //    try
        //    {
        //        await _playerService.DeletePlayer(userId);
        //        return NoContent();

        //    }
        //    catch (ArgumentNullException ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500);
        //    }
        //}

        //[HttpPut]
        //public async Task<IActionResult> Update(int id, [FromBody] UpdatePlayerDto player)
        //{
        //    try
        //    {
        //        await _playerService.UpdatePlayer(id, player);
        //        return NoContent();
        //    }
        //    catch (ArgumentNullException ex)
        //    {
        //        return NotFound(ex.Message);

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500);
        //    }
        //}
    }
}
