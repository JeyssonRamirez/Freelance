namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Membresia
    {
        public int MembresiaId { get; set; }
        public int AplicacionId { get; set; }
        public int UsuarioId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PreguntaPassword { get; set; }
        public string RespuestaPassword { get; set; }
        public string Comentario { get; set; }
        public System.DateTime UltimaActividad { get; set; }
        public System.DateTime UltimaSesion { get; set; }
        public System.DateTime UltimoCambioDePassword { get; set; }
        public int CantidadIntentosFallidosPassword { get; set; }
        public System.DateTime InicioIntentosFallidosPassword { get; set; }
        public int CantidadIntentosFallidosPregunta { get; set; }
        public System.DateTime InicioIntentosFallidosPregunta { get; set; }
        public bool EstaAprobado { get; set; }
        public bool EstaBloqueado { get; set; }
        public System.DateTime UltimoBloqueo { get; set; }
        public System.DateTime Registrado { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
