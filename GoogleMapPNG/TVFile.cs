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
    
    public partial class TVFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TVFile()
        {
            this.TVFileLanguages = new HashSet<TVFileLanguage>();
        }
    
        public int TVFileID { get; set; }
        public int TVFileTVItemID { get; set; }
        public int TemplateTVType { get; set; }
        public Nullable<int> ReportTypeID { get; set; }
        public string Parameters { get; set; }
        public int Language { get; set; }
        public int FilePurpose { get; set; }
        public int FileType { get; set; }
        public int FileSize_kb { get; set; }
        public string FileInfo { get; set; }
        public System.DateTime FileCreatedDate_UTC { get; set; }
        public Nullable<bool> FromWater { get; set; }
        public string ClientFilePath { get; set; }
        public string ServerFileName { get; set; }
        public string ServerFilePath { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual ReportType ReportType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVFileLanguage> TVFileLanguages { get; set; }
        public virtual TVItem TVItem { get; set; }
    }
}
