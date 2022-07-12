using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Data
{
    public class DataContextSeed
    {
        public static async Task SeedData(DataContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.Users.Any())
                {
                    var usersData = File.ReadAllText("C:/Users/szzie/OneDrive/Pulpit/.NET CORE/ProjektWakacje/API/Data/SeedData/users.json");

                    var users = JsonSerializer.Deserialize<IReadOnlyList<User>>(usersData);

                    foreach (var user in users)
                    {
                        context.Users.Add(user);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<DataContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}