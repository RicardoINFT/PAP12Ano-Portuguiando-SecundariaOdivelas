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
    
    public partial class Local
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Local()
        {
            this.Comentario_Classificacao = new HashSet<Comentario_Classificacao>();
            this.Comentario_Classificacao1 = new HashSet<Comentario_Classificacao>();
            this.Comidas = new HashSet<Comida>();
            this.Fotoes = new HashSet<Foto>();
            this.Segues = new HashSet<Segue>();
            this.Segues1 = new HashSet<Segue>();
            this.Visitars = new HashSet<Visitar>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Utilizador { get; set; }
        public string Nome { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidade { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Longitude { get; set; }
        public string Foto { get; set; }
        public string Video { get; set; }
        public string Latitude { get; set; }
        public string What3Words { get; set; }
        public string Morada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario_Classificacao> Comentario_Classificacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario_Classificacao> Comentario_Classificacao1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comida> Comidas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Foto> Fotoes { get; set; }
        public virtual Utilizador Utilizador1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Segue> Segues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Segue> Segues1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitar> Visitars { get; set; }
    }
}
