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
    
    public partial class VPScenarioLanguage
    {
        public int VPScenarioLanguageID { get; set; }
        public int VPScenarioID { get; set; }
        public int Language { get; set; }
        public string VPScenarioName { get; set; }
        public int TranslationStatus { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual VPScenario VPScenario { get; set; }
    }
}
