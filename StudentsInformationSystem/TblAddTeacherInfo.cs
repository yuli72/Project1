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
    
    public partial class TblAddTeacherInfo
    {
        public int add_info_record { get; set; }
        public Nullable<int> teacher_id { get; set; }
        public string teacher_address { get; set; }
        public string contact_info { get; set; }
        public string email { get; set; }
    
        public virtual TblTeacherInfo TblTeacherInfo { get; set; }
    }
}
