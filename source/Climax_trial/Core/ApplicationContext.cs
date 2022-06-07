using Microsoft.EntityFrameworkCore;
using Climax_trial.MVVM.Model;



namespace Climax_trial.Core
{
    public class ApplicationContext : DbContext
        {
            public DbSet <Expenses> Expenses { get; set; }
         

            public string DbPath { get; }

            public ApplicationContext()
            {
                //var folder = Environment.SpecialFolder.LocalApplicationData;
                //var path = Environment.GetFolderPath(folder);
                DbPath = "ClimaxFinance.db";
            }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite($"Data Source={DbPath}");
        }
    }

