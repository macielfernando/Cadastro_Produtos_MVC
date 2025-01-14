﻿using Microsoft.EntityFrameworkCore;

namespace CadastroDeProdutoAPI.Models
{
    public class Contexto : DbContext
    {
        public Contexto (DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
