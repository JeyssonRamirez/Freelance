namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class SiteMap
    {
        public int SiteMapId { get; set; }
        public int AplicacionId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public string Roles { get; set; }
        public Nullable<int> PadreId { get; set; }
        public bool Activo { get; set; }
    }
}
