﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLine.434aasipro
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Catalog.
    /// </summary>
    //  *** Start programmer edit section *** (catalog CustomAttributes)

    //  *** End programmer edit section *** (catalog CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("catalogE", new string[] {
            "code as \'Code\'",
            "svc as \'Svc\'",
            "svc_type as \'Svc_type\'",
            "data_version as \'Data_version\'",
            "dt_sync as \'Dt_sync\'",
            "descr as \'Descr\'",
            "vat as \'Vat\'",
            "is_actual as \'Is_actual\'",
            "dt_creation as \'Dt_creation\'",
            "parent_key as \'Parent_key\'",
            "measure as \'Measure\'",
            "measure_key as \'Measure_key\'",
            "status as \'Status\'",
            "formula_key as \'Formula_key\'",
            "billing_object_type_guid as \'Billing_object_type_guid\'"})]
    [View("catalogL", new string[] {
            "code as \'Code\'",
            "svc as \'Svc\'",
            "svc_type as \'Svc_type\'",
            "data_version as \'Data_version\'",
            "dt_sync as \'Dt_sync\'",
            "descr as \'Descr\'",
            "vat as \'Vat\'",
            "is_actual as \'Is_actual\'",
            "dt_creation as \'Dt_creation\'",
            "parent_key as \'Parent_key\'",
            "measure as \'Measure\'",
            "measure_key as \'Measure_key\'",
            "status as \'Status\'",
            "formula_key as \'Formula_key\'",
            "billing_object_type_guid as \'Billing_object_type_guid\'"})]
    public class catalog : ICSSoft.STORMNET.DataObject
    {
        
        private string fcode;
        
        private string fsvc;
        
        private string fsvc_type;
        
        private string fdata_version;
        
        private System.DateTime fdt_sync;
        
        private string fdescr;
        
        private string fvat;
        
        private bool fis_actual;
        
        private System.DateTime fdt_creation;
        
        private System.Guid fparent_key;
        
        private string fmeasure;
        
        private System.Guid fmeasure_key;
        
        private string fstatus;
        
        private System.Guid fformula_key;
        
        private System.Guid fbilling_object_type_guid;
        
        //  *** Start programmer edit section *** (catalog CustomMembers)

        //  *** End programmer edit section *** (catalog CustomMembers)

        
        /// <summary>
        /// code.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.code CustomAttributes)

        //  *** End programmer edit section *** (catalog.code CustomAttributes)
        [StrLen(32)]
        [NotNull()]
        public virtual string code
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.code Get start)

                //  *** End programmer edit section *** (catalog.code Get start)
                string result = this.fcode;
                //  *** Start programmer edit section *** (catalog.code Get end)

                //  *** End programmer edit section *** (catalog.code Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.code Set start)

                //  *** End programmer edit section *** (catalog.code Set start)
                this.fcode = value;
                //  *** Start programmer edit section *** (catalog.code Set end)

                //  *** End programmer edit section *** (catalog.code Set end)
            }
        }
        
        /// <summary>
        /// svc.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.svc CustomAttributes)

        //  *** End programmer edit section *** (catalog.svc CustomAttributes)
        [NotNull()]
        public virtual string svc
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.svc Get start)

                //  *** End programmer edit section *** (catalog.svc Get start)
                string result = this.fsvc;
                //  *** Start programmer edit section *** (catalog.svc Get end)

                //  *** End programmer edit section *** (catalog.svc Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.svc Set start)

                //  *** End programmer edit section *** (catalog.svc Set start)
                this.fsvc = value;
                //  *** Start programmer edit section *** (catalog.svc Set end)

                //  *** End programmer edit section *** (catalog.svc Set end)
            }
        }
        
        /// <summary>
        /// svc_type.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.svc_type CustomAttributes)

        //  *** End programmer edit section *** (catalog.svc_type CustomAttributes)
        [StrLen(32)]
        public virtual string svc_type
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.svc_type Get start)

                //  *** End programmer edit section *** (catalog.svc_type Get start)
                string result = this.fsvc_type;
                //  *** Start programmer edit section *** (catalog.svc_type Get end)

                //  *** End programmer edit section *** (catalog.svc_type Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.svc_type Set start)

                //  *** End programmer edit section *** (catalog.svc_type Set start)
                this.fsvc_type = value;
                //  *** Start programmer edit section *** (catalog.svc_type Set end)

                //  *** End programmer edit section *** (catalog.svc_type Set end)
            }
        }
        
        /// <summary>
        /// data_version.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.data_version CustomAttributes)

        //  *** End programmer edit section *** (catalog.data_version CustomAttributes)
        [StrLen(32)]
        public virtual string data_version
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.data_version Get start)

                //  *** End programmer edit section *** (catalog.data_version Get start)
                string result = this.fdata_version;
                //  *** Start programmer edit section *** (catalog.data_version Get end)

                //  *** End programmer edit section *** (catalog.data_version Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.data_version Set start)

                //  *** End programmer edit section *** (catalog.data_version Set start)
                this.fdata_version = value;
                //  *** Start programmer edit section *** (catalog.data_version Set end)

                //  *** End programmer edit section *** (catalog.data_version Set end)
            }
        }
        
        /// <summary>
        /// dt_sync.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.dt_sync CustomAttributes)

        //  *** End programmer edit section *** (catalog.dt_sync CustomAttributes)
        public virtual System.DateTime dt_sync
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.dt_sync Get start)

                //  *** End programmer edit section *** (catalog.dt_sync Get start)
                System.DateTime result = this.fdt_sync;
                //  *** Start programmer edit section *** (catalog.dt_sync Get end)

                //  *** End programmer edit section *** (catalog.dt_sync Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.dt_sync Set start)

                //  *** End programmer edit section *** (catalog.dt_sync Set start)
                this.fdt_sync = value;
                //  *** Start programmer edit section *** (catalog.dt_sync Set end)

                //  *** End programmer edit section *** (catalog.dt_sync Set end)
            }
        }
        
        /// <summary>
        /// descr.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.descr CustomAttributes)

        //  *** End programmer edit section *** (catalog.descr CustomAttributes)
        public virtual string descr
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.descr Get start)

                //  *** End programmer edit section *** (catalog.descr Get start)
                string result = this.fdescr;
                //  *** Start programmer edit section *** (catalog.descr Get end)

                //  *** End programmer edit section *** (catalog.descr Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.descr Set start)

                //  *** End programmer edit section *** (catalog.descr Set start)
                this.fdescr = value;
                //  *** Start programmer edit section *** (catalog.descr Set end)

                //  *** End programmer edit section *** (catalog.descr Set end)
            }
        }
        
        /// <summary>
        /// vat.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.vat CustomAttributes)

        //  *** End programmer edit section *** (catalog.vat CustomAttributes)
        [StrLen(31)]
        public virtual string vat
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.vat Get start)

                //  *** End programmer edit section *** (catalog.vat Get start)
                string result = this.fvat;
                //  *** Start programmer edit section *** (catalog.vat Get end)

                //  *** End programmer edit section *** (catalog.vat Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.vat Set start)

                //  *** End programmer edit section *** (catalog.vat Set start)
                this.fvat = value;
                //  *** Start programmer edit section *** (catalog.vat Set end)

                //  *** End programmer edit section *** (catalog.vat Set end)
            }
        }
        
        /// <summary>
        /// is_actual.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.is_actual CustomAttributes)

        //  *** End programmer edit section *** (catalog.is_actual CustomAttributes)
        [NotNull()]
        public virtual bool is_actual
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.is_actual Get start)

                //  *** End programmer edit section *** (catalog.is_actual Get start)
                bool result = this.fis_actual;
                //  *** Start programmer edit section *** (catalog.is_actual Get end)

                //  *** End programmer edit section *** (catalog.is_actual Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.is_actual Set start)

                //  *** End programmer edit section *** (catalog.is_actual Set start)
                this.fis_actual = value;
                //  *** Start programmer edit section *** (catalog.is_actual Set end)

                //  *** End programmer edit section *** (catalog.is_actual Set end)
            }
        }
        
        /// <summary>
        /// dt_creation.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.dt_creation CustomAttributes)

        //  *** End programmer edit section *** (catalog.dt_creation CustomAttributes)
        public virtual System.DateTime dt_creation
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.dt_creation Get start)

                //  *** End programmer edit section *** (catalog.dt_creation Get start)
                System.DateTime result = this.fdt_creation;
                //  *** Start programmer edit section *** (catalog.dt_creation Get end)

                //  *** End programmer edit section *** (catalog.dt_creation Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.dt_creation Set start)

                //  *** End programmer edit section *** (catalog.dt_creation Set start)
                this.fdt_creation = value;
                //  *** Start programmer edit section *** (catalog.dt_creation Set end)

                //  *** End programmer edit section *** (catalog.dt_creation Set end)
            }
        }
        
        /// <summary>
        /// parent_key.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.parent_key CustomAttributes)

        //  *** End programmer edit section *** (catalog.parent_key CustomAttributes)
        public virtual System.Guid parent_key
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.parent_key Get start)

                //  *** End programmer edit section *** (catalog.parent_key Get start)
                System.Guid result = this.fparent_key;
                //  *** Start programmer edit section *** (catalog.parent_key Get end)

                //  *** End programmer edit section *** (catalog.parent_key Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.parent_key Set start)

                //  *** End programmer edit section *** (catalog.parent_key Set start)
                this.fparent_key = value;
                //  *** Start programmer edit section *** (catalog.parent_key Set end)

                //  *** End programmer edit section *** (catalog.parent_key Set end)
            }
        }
        
        /// <summary>
        /// measure.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.measure CustomAttributes)

        //  *** End programmer edit section *** (catalog.measure CustomAttributes)
        public virtual string measure
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.measure Get start)

                //  *** End programmer edit section *** (catalog.measure Get start)
                string result = this.fmeasure;
                //  *** Start programmer edit section *** (catalog.measure Get end)

                //  *** End programmer edit section *** (catalog.measure Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.measure Set start)

                //  *** End programmer edit section *** (catalog.measure Set start)
                this.fmeasure = value;
                //  *** Start programmer edit section *** (catalog.measure Set end)

                //  *** End programmer edit section *** (catalog.measure Set end)
            }
        }
        
        /// <summary>
        /// measure_key.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.measure_key CustomAttributes)

        //  *** End programmer edit section *** (catalog.measure_key CustomAttributes)
        public virtual System.Guid measure_key
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.measure_key Get start)

                //  *** End programmer edit section *** (catalog.measure_key Get start)
                System.Guid result = this.fmeasure_key;
                //  *** Start programmer edit section *** (catalog.measure_key Get end)

                //  *** End programmer edit section *** (catalog.measure_key Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.measure_key Set start)

                //  *** End programmer edit section *** (catalog.measure_key Set start)
                this.fmeasure_key = value;
                //  *** Start programmer edit section *** (catalog.measure_key Set end)

                //  *** End programmer edit section *** (catalog.measure_key Set end)
            }
        }
        
        /// <summary>
        /// status.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.status CustomAttributes)

        //  *** End programmer edit section *** (catalog.status CustomAttributes)
        [StrLen(10)]
        public virtual string status
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.status Get start)

                //  *** End programmer edit section *** (catalog.status Get start)
                string result = this.fstatus;
                //  *** Start programmer edit section *** (catalog.status Get end)

                //  *** End programmer edit section *** (catalog.status Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.status Set start)

                //  *** End programmer edit section *** (catalog.status Set start)
                this.fstatus = value;
                //  *** Start programmer edit section *** (catalog.status Set end)

                //  *** End programmer edit section *** (catalog.status Set end)
            }
        }
        
        /// <summary>
        /// formula_key.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.formula_key CustomAttributes)

        //  *** End programmer edit section *** (catalog.formula_key CustomAttributes)
        public virtual System.Guid formula_key
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.formula_key Get start)

                //  *** End programmer edit section *** (catalog.formula_key Get start)
                System.Guid result = this.fformula_key;
                //  *** Start programmer edit section *** (catalog.formula_key Get end)

                //  *** End programmer edit section *** (catalog.formula_key Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.formula_key Set start)

                //  *** End programmer edit section *** (catalog.formula_key Set start)
                this.fformula_key = value;
                //  *** Start programmer edit section *** (catalog.formula_key Set end)

                //  *** End programmer edit section *** (catalog.formula_key Set end)
            }
        }
        
        /// <summary>
        /// billing_object_type_guid.
        /// </summary>
        //  *** Start programmer edit section *** (catalog.billing_object_type_guid CustomAttributes)

        //  *** End programmer edit section *** (catalog.billing_object_type_guid CustomAttributes)
        public virtual System.Guid billing_object_type_guid
        {
            get
            {
                //  *** Start programmer edit section *** (catalog.billing_object_type_guid Get start)

                //  *** End programmer edit section *** (catalog.billing_object_type_guid Get start)
                System.Guid result = this.fbilling_object_type_guid;
                //  *** Start programmer edit section *** (catalog.billing_object_type_guid Get end)

                //  *** End programmer edit section *** (catalog.billing_object_type_guid Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (catalog.billing_object_type_guid Set start)

                //  *** End programmer edit section *** (catalog.billing_object_type_guid Set start)
                this.fbilling_object_type_guid = value;
                //  *** Start programmer edit section *** (catalog.billing_object_type_guid Set end)

                //  *** End programmer edit section *** (catalog.billing_object_type_guid Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "catalogE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View catalogE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("catalogE", typeof(DataLine.434aasipro.catalog));
                }
            }
            
            /// <summary>
            /// "catalogL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View catalogL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("catalogL", typeof(DataLine.434aasipro.catalog));
                }
            }
        }
    }
}
