//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Viking_Rejser_Eksamen.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rejsearrangementer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rejsearrangementer()
        {
            this.RejseTilmeldinger1 = new HashSet<RejseTilmeldinger>();
        }
    
        public int Id { get; set; }
        public string Titel { get; set; }
        public string By { get; set; }
        public System.DateTime StartDato { get; set; }
        public System.DateTime SlutDato { get; set; }
        public Nullable<int> MaxDeltagere { get; set; }
        public Nullable<int> Transportoer { get; set; }
        public decimal PrisPrDeltager { get; set; }
        public Nullable<int> RejseTilmeldinger { get; set; }
        public string Beskrivelse { get; set; }
    
        public virtual Transportoer Transportoer1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejseTilmeldinger> RejseTilmeldinger1 { get; set; }
    }
}
