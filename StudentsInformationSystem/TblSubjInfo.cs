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
    
    public partial class TblSubjInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblSubjInfo()
        {
            this.TblStdntSubjs = new HashSet<TblStdntSubj>();
        }
    
        public string offercode { get; set; }
        public string subj_name { get; set; }
        public Nullable<int> teacher_id { get; set; }
        public Nullable<int> schedule { get; set; }
    
        public virtual TblSchedule TblSchedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblStdntSubj> TblStdntSubjs { get; set; }
        public virtual TblTeacherInfo TblTeacherInfo { get; set; }
    }
}
