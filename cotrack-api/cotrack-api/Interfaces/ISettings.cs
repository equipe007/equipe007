using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cotrack_webApi.Interfaces
{
    public interface ISettings
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}
