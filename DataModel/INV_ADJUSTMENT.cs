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
    
    public partial class INV_ADJUSTMENT
    {
        public double ADJ_ID_PK { get; set; }
        public Nullable<double> HEADER_ID_FK { get; set; }
        public Nullable<double> REF_INV_ID { get; set; }
        public string REF_INV_TYPE { get; set; }
        public Nullable<double> REF_INV_AMOUNT { get; set; }
        public Nullable<double> ADJ_AMOUNT { get; set; }
        public string REMARKS { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public string ADJ_TYPE { get; set; }
        public Nullable<double> ADJ_AMOUNT_CL { get; set; }
    }
}
