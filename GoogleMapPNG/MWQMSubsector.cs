//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoogleMapPNG
{
    using System;
    using System.Collections.Generic;
    
    public partial class MWQMSubsector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MWQMSubsector()
        {
            this.MWQMSubsectorLanguages = new HashSet<MWQMSubsectorLanguage>();
        }
    
        public int MWQMSubsectorID { get; set; }
        public int MWQMSubsectorTVItemID { get; set; }
        public string SubsectorHistoricKey { get; set; }
        public string TideLocationSIDText { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMSubsectorLanguage> MWQMSubsectorLanguages { get; set; }
        public virtual TVItem TVItem { get; set; }
    }
}
