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
    
    public partial class INV_LINES_TL
    {
        public double LINE_ID_PK { get; set; }
        public double HEADER_ID_FK { get; set; }
        public string FUEL_SUPPLIER { get; set; }
        public string INVOICE_NUMBER { get; set; }
        public Nullable<System.DateTime> INVOICE_DATE { get; set; }
        public Nullable<System.DateTime> ISS_REC_DATE { get; set; }
        public Nullable<double> RECEIVE_QTY { get; set; }
        public Nullable<double> FUEL_RATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> ISS_QTY { get; set; }
        public string CARGO_NO { get; set; }
        public Nullable<double> HOUR { get; set; }
    }
}
