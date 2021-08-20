using Microsoft.EntityFrameworkCore;

namespace OnlineStore.DataAccessLayer.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> contextOptions):base(contextOptions)
        {
            
        }
    }
}
