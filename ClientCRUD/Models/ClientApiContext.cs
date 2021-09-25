using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientCRUD.Models
{
    public class ClientApiContext : DbContext
    {
        
        public ClientApiContext(DbContextOptions <ClientApiContext> options)
            :base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
    }
}
