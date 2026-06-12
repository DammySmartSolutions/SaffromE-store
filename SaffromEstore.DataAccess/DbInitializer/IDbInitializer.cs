using System;
using System.Collections.Generic;
using System.Text;

namespace SaffromEstore.DataAccess.DbInitializer
{
    public interface IDbInitializer
    {
        Task InitializeAsync();
    }
}
