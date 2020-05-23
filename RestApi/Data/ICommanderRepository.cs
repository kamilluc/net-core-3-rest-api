using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
