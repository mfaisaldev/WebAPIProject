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
    
    public partial class INTEREST_DETAILS
    {
        public double INT_DET_ID_PK { get; set; }
        public Nullable<double> PRIM_INV_ID_FK { get; set; }
        public Nullable<double> HEADER_ID_FK { get; set; }
        public Nullable<System.DateTime> PAYMENT_DATE { get; set; }
        public Nullable<double> NO_OF_DAYS { get; set; }
        public Nullable<double> AMOUNT_PAID { get; set; }
        public Nullable<double> INTEREST_RATE { get; set; }
        public Nullable<double> INTEREST_AMOUNT { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public Nullable<double> AMOUNT_OUTSTANDING { get; set; }
        public Nullable<System.DateTime> FROM_DATE { get; set; }
        public Nullable<System.DateTime> TO_DATE { get; set; }
        public string REMARKS { get; set; }
    }
}
