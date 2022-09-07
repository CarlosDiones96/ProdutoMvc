using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProdutoMvc.Models;

    public class ProdutoMvcContext : DbContext
    {
        public ProdutoMvcContext (DbContextOptions<ProdutoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ProdutoMvc.Models.Produto> Produto { get; set; } = default!;
    }
