using cotrack_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cotrack_api.Interfaces
{
    public interface IUserService
    {
        User Save(User usuario);
    }
}
