//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAP_Back
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comentario_Classificacao
    {
        public int ID { get; set; }
        public Nullable<int> Utilizador { get; set; }
        public Nullable<int> Local1 { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public string Comentarios { get; set; }
        public Nullable<int> Classificacao { get; set; }
    
        public virtual Local Local { get; set; }
        public virtual Local Local2 { get; set; }
    }
}
