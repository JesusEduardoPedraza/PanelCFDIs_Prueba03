using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PanelCFDIs.Models
{
    public partial class Sellos
    {
        public int? IdEmpresa { get; set; }
        public string Certificado { get; set; }
        public string Serie { get; set; }
        public string CertificadoBase64 { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public string LlavePrivada { get; set; }
        public string Clave { get; set; }
        public int? NoAprobacion { get; set; }
        public int? AnoAprobacion { get; set; }
        public string LlaveUso { get; set; }
    }
}
