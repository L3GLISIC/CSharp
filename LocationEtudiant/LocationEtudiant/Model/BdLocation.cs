using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace LocationEtudiant.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdLocationContext : DbContext
    {
        public BdLocationContext() : base("bdLocationContext") { }

        public DbSet<Appartement> appartements { get; set; }
        public DbSet<Personne> personnes { get; set; }
        public DbSet<Locataire> locataires { get; set; }
        public DbSet<Proprietaire> proprietaires { get; set; }
    }
}
