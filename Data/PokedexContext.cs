using Microsoft.EntityFrameworkCore;
using POKEDEX.Models;

namespace POKEDEX.Data
{
    public class PokedexContext : DbContext
    {
        public DbSet<Pokemon> Pokemones { get; set; }

        public PokedexContext(DbContextOptions dco) : base(dco) {

        }
    }
}