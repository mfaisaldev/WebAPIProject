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
    
    public partial class PRESENT_RATE_LINES
    {
        public double LINE_ID_PK { get; set; }
        public Nullable<double> HEADER_ID_FK { get; set; }
        public string COMPONENT_NAME { get; set; }
        public Nullable<double> RATE { get; set; }
        public Nullable<System.DateTime> DATE_FROM { get; set; }
        public Nullable<System.DateTime> DATE_TO { get; set; }
        public string HOUR_FROM { get; set; }
        public string HOUR_TO { get; set; }
        public string LINE_ATTRIBUTE1 { get; set; }
        public string LINE_ATTRIBUTE2 { get; set; }
        public string LINE_ATTRIBUTE3 { get; set; }
        public string LINE_ATTRIBUTE4 { get; set; }
        public string LINE_ATTRIBUTE5 { get; set; }
        public string LINE_ATTRIBUTE6 { get; set; }
        public string LINE_ATTRIBUTE7 { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
        public Nullable<double> ORGANIZATION_ID { get; set; }
        public Nullable<double> INVTYPE_ID_FK { get; set; }
        public string ALLOW_GROUPING { get; set; }
        public Nullable<double> PPA_BLK_FUEL_ID_FK { get; set; }
    }
}