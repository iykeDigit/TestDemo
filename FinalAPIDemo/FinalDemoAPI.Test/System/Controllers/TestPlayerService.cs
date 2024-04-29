using FinalAPIDemo.Core;
using FinalAPIDemo.Data;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDemoAPI.Test.System.Controllers
{
    public class TestPlayerService : IDisposable
    {
        protected readonly AppDbContext _context;

        public TestPlayerService()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

            _context = new AppDbContext(options);
            _context.Database.EnsureCreated();

        }

        [Fact]
        public async Task Should_GetPlayer_By_Id()
        {
            //Arraynge
            _context.Players.AddRange(MockData.DemoMockData.GetPlayers());
            _context.SaveChanges();
            var sut = new PlayersService(_context);

            //Act
            var result = await sut.GetPlayerAsync("1");

            //Assert
            result.Should().NotBeNull();
        }
        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
            //}
        }
    }
}
