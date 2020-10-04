using cotrack_webApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cotrack_webApi.Interfaces
{
    public interface IUserService
    {
        User Save(User usuario);
    }
}
