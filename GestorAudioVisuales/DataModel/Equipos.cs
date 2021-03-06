//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipos()
        {
            this.Rentas = new HashSet<Rentas>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int No_Serial { get; set; }
        public string Service_tag { get; set; }
        public int IdTipoEquipo { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdTipoTecnologiaConexion { get; set; }
        public int Estado { get; set; }
    
        public virtual Marcas Marcas { get; set; }
        public virtual Tecnologias_Conexion Tecnologias_Conexion { get; set; }
        public virtual TipoEquipos TipoEquipos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rentas> Rentas { get; set; }
        public virtual Modelos Modelos { get; set; }
    }
}
