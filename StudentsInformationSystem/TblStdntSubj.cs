//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsInformationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblStdntSubj
    {
        public int stdnt_subj_record { get; set; }
        public Nullable<int> stdnt_id { get; set; }
        public string offercode { get; set; }
    
        public virtual TblStdntInfo TblStdntInfo { get; set; }
        public virtual TblSubjInfo TblSubjInfo { get; set; }
    }
}
