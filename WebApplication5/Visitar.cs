//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visitar
    {
        public int id { get; set; }
        public Nullable<int> local1 { get; set; }
        public Nullable<int> user1 { get; set; }
    
        public virtual Local Local { get; set; }
        public virtual Utilizador Utilizador { get; set; }
    }
}
