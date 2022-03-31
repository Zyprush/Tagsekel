#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tagsekel.classpage;

namespace Tagsekel.Data
{
    public class TagsekelContext : DbContext
    {
        public TagsekelContext (DbContextOptions<TagsekelContext> options)
            : base(options)
        {
        }

        public DbSet<Tagsekel.classpage.Class> Class { get; set; }
    }
}
