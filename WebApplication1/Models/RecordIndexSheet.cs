using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RecordIndexSheet
    {
        public long RecordIndexSheetId { get; set; }
        public long RmsNumber { get; set; }
        public string PrimaryLocation { get; set; }
        public string SecondaryLocation { get; set; }
        public string LocalLocation { get; set; }

        public DateTime DateRetainedUntil { get; set; }
        public DateTime DateDestroyed { get; set; }
        public string IndexedBy { get; set; }
        public DateTime DateIndexed { get; set; }
        public string FileLocation { get; set; }

        public int DocTypeId { get; set; } //this will be a dropdown list
        //see this url for more information on Virtual Backing Fields for use with dropdowns
        //https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
        public int DocSubTypeId { get; set; } //this will be a dropdown list

        public bool Controlled { get; set; } //this will be a checkbox
        public bool ControlledRestrictExternalAccess { get; set; }

        public int SafetyRelated { get; set; } //this will be a checkbox
        public string Title { get; set; }
        public string DocumentNumber { get; set; } //Like: 12434-S-03
        public string SheetOrPage { get; set; }     //Like: 1

        public string RevisionVersion { get; set; }
        public DateTime DocumentDate { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public int Status { get; set; }
        public string ClientName { get; set; }
        public string ComponentName { get; set; }
        public string ComponentNumber { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string ReferenceNumber { get; set; }
        public string Company { get; set; }
        public string Supplier { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public bool Superseded { get; set; } //this will be a checkbox

        public int RetentionCodeId { get; set; } //this will be a dropdown list
        public int MediaTypeId { get; set; } //this will be a dropdown list
        public int Quantity { get; set; }
        public string Other { get; set; }


        #region //Unneeded but included for historical 'integrity'
        public bool RecordTypeMaterials { get; set; }
        public bool RecordTypeServices { get; set; }
        public bool RecordTypeProcedureChangeNotice { get; set; }
        public bool RecordTypeAddendum { get; set; }
        public bool RecordTypeAmendment { get; set; }
        public bool RecordTypeDesign { get; set; }
        public bool RecordTypeProcurement { get; set; }
        public bool RecordTypeFabrication { get; set; }
        public bool RecordTypeTest { get; set; }
        public bool RecordTypeOperation { get; set; }
        public bool RecordTypeMaintenance { get; set; }
        #endregion
    }
}