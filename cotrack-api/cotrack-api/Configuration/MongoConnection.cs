using cotrack_api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cotrack_api.Configuration
{
    public class Settings : IOptions
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }

    public interface IOptions
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}
