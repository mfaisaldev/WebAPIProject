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
    
    public partial class PPA_SLABS
    {
        public double SLAB_ID_PK { get; set; }
        public Nullable<double> HEADER_ID_FK { get; set; }
        public string SLAB_TITLE { get; set; }
        public Nullable<double> SLAB_LIMIT { get; set; }
        public string SLAB_COMPONENT { get; set; }
        public Nullable<double> ORGANIZATION_ID { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<double> CREATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public Nullable<double> LAST_UPDATED_BY { get; set; }
        public Nullable<double> LAST_UPDATE_LOGIN { get; set; }
    }
}
