using System;
using Microsoft.EntityFrameworkCore;

namespace Wallet.DB
{
    public class DbBase<T> : DbContext where T: class, new()
    {
        public DbBase()
        {
        }
    }
}
