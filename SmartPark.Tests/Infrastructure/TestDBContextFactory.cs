using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPark.Tests.Infrastructure
{
    internal class TestDBContextFactory
    {
        public static string NewDatabaseName() => $"SmartParkTests_{Guid.NewGuid()}";

        public static SmartparkContext CreateContext(string databaseName)
        {
            var options = new DbContextOptionsBuilder<SmartparkContext>()
                .UseInMemoryDatabase(databaseName)
                .Options;

            return new InMemorySmartparkContext(options);
        }

        private sealed class InMemorySmartparkContext(DbContextOptions<SmartparkContext> options)
            : SmartparkContext(options)
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // Intentionally empty: tests provide InMemory provider through options.
            }
        }
    }
}
