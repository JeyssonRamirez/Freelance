namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorAplicacion
    {
        public int ErrorAplicacionId { get; set; }
        public string Aplicacion { get; set; }
        public string Error { get; set; }
        public string Excepcion { get; set; }
        public string Interna { get; set; }
        public Nullable<System.DateTime> Registrado { get; set; }
    }
}
