using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rengifo_Alexander_MVC_Code_First.Models;

namespace Rengifo_Alexander_MVC_Code_First.Data
{
    public class Rengifo_Alexander_MVC_Code_FirstContext : DbContext
    {
        public Rengifo_Alexander_MVC_Code_FirstContext (DbContextOptions<Rengifo_Alexander_MVC_Code_FirstContext> options)
            : base(options)
        {
        }

        public DbSet<Rengifo_Alexander_MVC_Code_First.Models.EstudianteUdla> EstudianteUdla { get; set; } = default!;
    }
}
