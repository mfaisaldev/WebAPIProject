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
    
    public partial class CPPA_USER_ACCESS_LINES
    {
        public double LINE_ID_PK { get; set; }
        public Nullable<double> HEADER_ID_FK { get; set; }
        public string INVOICE_TYPE { get; set; }
        public Nullable<double> VENDOR_ID_FK { get; set; }
        public Nullable<double> VENDOR_SITE_ID_FK { get; set; }
        public Nullable<System.DateTime> EFFECTIVE_FROM { get; set; }
        public Nullable<System.DateTime> EFFECTIVE_TO { get; set; }
        public string INQUIRY_ALLOW { get; set; }
        public string UPDATE_ALLOW { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public Nullable<double> ORGANIZATION_ID { get; set; }
        public string U_FLAG { get; set; }
    }
}
