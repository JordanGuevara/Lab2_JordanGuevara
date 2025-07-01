using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Lab2_JordanGuevara.Models
{
    public class FacturaContext : DbContext
    {
        public FacturaContext() : base("name=FacturaContext") { }
        public DbSet<Cliente> Clientes { get; set; }
    }

    public class Cliente
    {
        [Key]  
        public int id_cli { get; set; }

        public string nombre_cli { get; set; }
        public string cedula_cli { get; set; }
        public string correo_cli { get; set; }
        public DateTime fechaNacimiento_cli { get; set; }
        public string FotoPath { get; set; }
    }
}
