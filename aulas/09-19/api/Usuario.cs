using System;
using Microsoft.EntityFrameworkCore;

namespace Models {
  class Usuario
	{
		public long? id {get; set;};
		public string? nome {get; set;};
		public string? email {get; set;};
		public string? hash {get; set;};
	}

  class BaseUsuarios : DbContext {
    public BaseUsuarios(DbContextOptions options) : base(options) {}
    public DbSet<Usuario> Usuarios { get; set; } = null;
  }
}