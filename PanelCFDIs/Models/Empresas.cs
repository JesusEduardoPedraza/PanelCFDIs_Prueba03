using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PanelCFDIs.Models
{
    public partial class Empresas
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int? Cp { get; set; }
        public string Referencia { get; set; }
        public bool ModoPrueba { get; set; }
        public string RutaTrabajo { get; set; }
        public string RutaLogo { get; set; }
        public string Clave { get; set; }
        public string Regimen { get; set; }
        public double? Cfdi { get; set; }
        public DateTime? Daterecord { get; set; }
        public bool? ModoDebug { get; set; }
        public string Mailfrom { get; set; }
        public int? Status { get; set; }
        public string Bd { get; set; }
        public int? IdPadre { get; set; }
        public int? CantFolios { get; set; }
        public int? TimbresRest { get; set; }
    }
}
