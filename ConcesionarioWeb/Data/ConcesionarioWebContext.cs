using Microsoft.EntityFrameworkCore;

public class ConcesionarioWebContext(DbContextOptions<ConcesionarioWebContext> options) : DbContext(options)
{
    public DbSet<ConcesionarioWeb.Models.Vehiculo> Vehiculo { get; set; } = default!;
}
