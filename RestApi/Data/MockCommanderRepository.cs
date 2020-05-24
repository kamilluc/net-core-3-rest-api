using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>();
            for (var i = 0; i < 4; ++i)
            {
                commands.Add(new Command
                {
                    Id = i,
                    HowTo = "Boil an egg",
                    Line = $"Boil water {i}",
                    Platform = "Kettle & Pan"
                });
            }
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "Boil an egg",
                Line = "Boil water",
                Platform = "Kettle & Pan"
            };
        }
    }
}
