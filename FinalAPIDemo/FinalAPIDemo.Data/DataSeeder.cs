using FinalAPIDemo.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAPIDemo.Data
{
    public class DataSeeder : IDataSeeder
    {
        private readonly AppDbContext _context;

        public DataSeeder(AppDbContext context)
        {
            _context = context;
        }

        public async Task SeedDataAsync()
        {
            var baseDir = Directory.GetCurrentDirectory();

            if (!_context.Players.Any())
            {
                var dir = "C:\\Users\\IKECHUKWU\\Desktop\\INTUIT\\APIs\\FinalAPIDemo\\FinalAPIDemo.Data";
                var filePath = File.ReadAllText(FilePath(dir, "player.json"));
                var players = JsonConvert.DeserializeObject<List<Player>>(filePath);

                await _context.Players.AddRangeAsync(players);
            }

            await _context.SaveChangesAsync();
        }

        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }

    }
}
