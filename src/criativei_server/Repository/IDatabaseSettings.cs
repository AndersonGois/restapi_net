using System;
using System.Collections.Generic;
using System.Text;

namespace criativei_server.Repository
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CollectionName { get; set; }
    }
}
