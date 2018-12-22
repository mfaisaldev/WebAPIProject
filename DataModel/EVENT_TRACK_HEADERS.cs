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
    
    public partial class EVENT_TRACK_HEADERS
    {
        public double HEADER_ID_PK { get; set; }
        public string DOCUMENT_NO { get; set; }
        public Nullable<System.DateTime> DOCUMENT_DATE { get; set; }
        public Nullable<double> PPA_HEADER_ID_FK { get; set; }
        public Nullable<double> INVOICE_ID { get; set; }
        public string INVOICE_NUM { get; set; }
        public Nullable<double> INVOICE_ID_FK { get; set; }
        public string POWER_POLICY { get; set; }
        public Nullable<double> VENDOR_ID_FK { get; set; }
        public Nullable<double> VENDOR_SITE_ID_FK { get; set; }
        public string HEADER_ATTRIBUTE1 { get; set; }
        public string HEADER_ATTRIBUTE2 { get; set; }
        public string HEADER_ATTRIBUTE3 { get; set; }
        public string HEADER_ATTRIBUTE4 { get; set; }
        public string HEADER_ATTRIBUTE5 { get; set; }
        public string HEADER_ATTRIBUTE6 { get; set; }
        public string HEADER_ATTRIBUTE7 { get; set; }
        public Nullable<System.DateTime> EFFECTIVE_FROM { get; set; }
        public Nullable<System.DateTime> EFFECTIVE_TO { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public Nullable<double> ORGANIZATION_ID { get; set; }
        public Nullable<double> DOC_REC_ID_FK { get; set; }
        public string INTERFACE_STATUS { get; set; }
        public string TRANSFER_GL { get; set; }
    }
}
