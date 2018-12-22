﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class DairyEntity
    {
        public double HEADER_ID_PK { get; set; }
        public string DOCUMENT_NO { get; set; }
        public Nullable<System.DateTime> DOCUMENT_DATE { get; set; }
        public Nullable<double> VENDOR_ID_FK { get; set; }
        public Nullable<double> VENDOR_SITE_ID_FK { get; set; }
        public string REC_DOC_TYPE { get; set; }
        public string REC_INVOICE_TYPE { get; set; }
        public string REC_INV_LTR_NO { get; set; }
        public string REC_INV_MONTH { get; set; }
        public Nullable<double> REC_INV_AMOUNT { get; set; }
        public Nullable<double> REC_INV_GST_AMOUNT { get; set; }
        public string REC_OTHER_REMARKS { get; set; }
        public Nullable<System.DateTime> RECEIVING_DATE { get; set; }
        public Nullable<System.DateTime> NOTIFICATION_SENT_DATE { get; set; }
        public string APPROVAL_STATUS { get; set; }
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
        public Nullable<System.DateTime> GL_DATE { get; set; }
        public string INTERFACE_STATUS { get; set; }
        public Nullable<double> GST_PER { get; set; }
        public Nullable<System.DateTime> INVOICE_PERIOD_FROM { get; set; }
        public Nullable<System.DateTime> INVOICE_PERIOD_TO { get; set; }
        public string IS_DIFFERENTIAL { get; set; }
        public Nullable<double> PARENT_DIARY_ID { get; set; }
        public string CURRENCY { get; set; }
        public Nullable<System.DateTime> IPP_INV_DATE { get; set; }
        public Nullable<double> ADJ_AMOUNT_SUM { get; set; }
    }
}
