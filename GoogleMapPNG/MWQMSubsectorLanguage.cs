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
    
    public partial class MWQMSubsectorLanguage
    {
        public int MWQMSubsectorLanguageID { get; set; }
        public int MWQMSubsectorID { get; set; }
        public int Language { get; set; }
        public string SubsectorDesc { get; set; }
        public int TranslationStatusSubsectorDesc { get; set; }
        public string LogBook { get; set; }
        public Nullable<int> TranslationStatusLogBook { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual MWQMSubsector MWQMSubsector { get; set; }
    }
}
