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
    
    public partial class DOCREC_BLKSFUEL
    {
        public double DOCREC_BLKFUEL_ID_PK { get; set; }
        public Nullable<double> HEADER_ID_FK { get; set; }
        public string BLK_COMPLEX { get; set; }
        public string FUEL_TYPE { get; set; }
        public string COMP_NAME { get; set; }
        public Nullable<System.DateTime> DATE_FROM { get; set; }
        public Nullable<System.DateTime> DATE_TO { get; set; }
        public Nullable<double> COMP_VALUE { get; set; }
        public Nullable<double> TOTAL { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public Nullable<double> PPA_BLK_FUEL_ID_FK { get; set; }
        public Nullable<double> ADV_ALREADY_PAID { get; set; }
        public Nullable<double> REMAINING_CUR_MONTH { get; set; }
        public Nullable<double> ADV_NEXT_MONTH { get; set; }
        public Nullable<double> PAYABLE_CUR_MONTH { get; set; }
        public Nullable<double> TOTAL_CL { get; set; }
        public Nullable<double> TOTAL_VER { get; set; }
        public Nullable<double> ADV_ALREADY_PAID_CL { get; set; }
        public Nullable<double> ADV_ALREADY_PAID_VER { get; set; }
        public Nullable<double> ADV_NEXT_MONTH_RATE { get; set; }
        public Nullable<double> ADV_NEXT_MONTH_CAP { get; set; }
        public Nullable<double> ADV_NEXT_MONTH_CL { get; set; }
        public Nullable<double> ADV_NEXT_MONTH_VER { get; set; }
        public Nullable<double> ADV_NEXT_MONTH_DAYS { get; set; }
        public Nullable<double> ADV_NEXT_MONTH_PER { get; set; }
        public Nullable<double> ADV_NEXT_DAYS_IN_MON { get; set; }
    }
}
