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
    
    public partial class INV_DIFF_PARENT
    {
        public double DIFF_PAR_ID_PK { get; set; }
        public Nullable<double> INV_ID_FK { get; set; }
        public Nullable<double> PAR_INV_ID_FK { get; set; }
        public Nullable<System.DateTime> PAR_INV_PER_FRM { get; set; }
        public Nullable<System.DateTime> PAR_INV_PER_TO { get; set; }
        public Nullable<double> PAR_INV_AMOUNT { get; set; }
        public Nullable<double> PAR_INV_PROCESSED { get; set; }
        public Nullable<double> PAR_INV_DIFF_VER { get; set; }
        public Nullable<double> PAR_INV_DIFF_CL { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public string IPP_INV_NO { get; set; }
        public string PRE_POST { get; set; }
        public Nullable<double> BALANCE_AMOUNT { get; set; }
    }
}
