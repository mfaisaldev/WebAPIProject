//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOCREC_COMPS
    {
        public double COMP_ID_PK { get; set; }
        public Nullable<double> DOCREC_BLKFUEL_ID_FK { get; set; }
        public Nullable<double> HEADER_ID_FK { get; set; }
        public string COMP_NAME { get; set; }
        public string COMP_TYPE { get; set; }
        public string COMP_UNIT { get; set; }
        public Nullable<double> COMP_VALUE { get; set; }
        public string REMARKS { get; set; }
        public string ATTRIBUTE1 { get; set; }
        public string ATTRIBUTE2 { get; set; }
        public string ATTRIBUTE3 { get; set; }
        public string ATTRIBUTE4 { get; set; }
        public string ATTRIBUTE5 { get; set; }
        public string ATTRIBUTE6 { get; set; }
        public string ATTRIBUTE7 { get; set; }
        public string ATTRIBUTE8 { get; set; }
        public string ATTRIBUTE9 { get; set; }
        public string ATTRIBUTE10 { get; set; }
        public Nullable<double> ORGANIZATION_ID { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public string COMP_ZONE { get; set; }
        public string COMP_FORMULA { get; set; }
        public string INC_IN_TOT { get; set; }
        public Nullable<double> DIFF_PAR_ID_FK { get; set; }
        public string EXEMPT { get; set; }
    }
}
