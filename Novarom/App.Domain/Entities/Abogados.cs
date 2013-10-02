namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Abogados
    {
        public Abogados()
        {
            this.DamandasAbogados = new HashSet<DamandasAbogados>();
        }
    
        public int IdAbogado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string CiudadExpedicion { get; set; }
        public string TarjetaProfesional { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public string UsuarioCrea { get; set; }
        public System.DateTime FechaCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual ICollection<DamandasAbogados> DamandasAbogados { get; set; }
    }
}
