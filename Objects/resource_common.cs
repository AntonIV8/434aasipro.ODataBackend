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
    /// Resource_common.
    /// </summary>
    //  *** Start programmer edit section *** (resource_common CustomAttributes)

    //  *** End programmer edit section *** (resource_common CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("resource_commonE", new string[] {
            "external_id as \'External_id\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "category as \'Category\'",
            "type as \'Type\'",
            "dt_created as \'Dt_created\'",
            "dt_modified as \'Dt_modified\'"})]
    [View("resource_commonL", new string[] {
            "external_id as \'External_id\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "category as \'Category\'",
            "type as \'Type\'",
            "dt_created as \'Dt_created\'",
            "dt_modified as \'Dt_modified\'"})]
    public class resource_common : ICSSoft.STORMNET.DataObject
    {
        
        private string fexternal_id;
        
        private string fname;
        
        private string fdescription;
        
        private string fcategory;
        
        private string ftype;
        
        private System.DateTime fdt_created;
        
        private System.DateTime fdt_modified;
        
        //  *** Start programmer edit section *** (resource_common CustomMembers)

        //  *** End programmer edit section *** (resource_common CustomMembers)

        
        /// <summary>
        /// external_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_common.external_id CustomAttributes)

        //  *** End programmer edit section *** (resource_common.external_id CustomAttributes)
        [StrLen(128)]
        public virtual string external_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_common.external_id Get start)

                //  *** End programmer edit section *** (resource_common.external_id Get start)
                string result = this.fexternal_id;
                //  *** Start programmer edit section *** (resource_common.external_id Get end)

                //  *** End programmer edit section *** (resource_common.external_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_common.external_id Set start)

                //  *** End programmer edit section *** (resource_common.external_id Set start)
                this.fexternal_id = value;
                //  *** Start programmer edit section *** (resource_common.external_id Set end)

                //  *** End programmer edit section *** (resource_common.external_id Set end)
            }
        }
        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (resource_common.name CustomAttributes)

        //  *** End programmer edit section *** (resource_common.name CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (resource_common.name Get start)

                //  *** End programmer edit section *** (resource_common.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (resource_common.name Get end)

                //  *** End programmer edit section *** (resource_common.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_common.name Set start)

                //  *** End programmer edit section *** (resource_common.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (resource_common.name Set end)

                //  *** End programmer edit section *** (resource_common.name Set end)
            }
        }
        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (resource_common.description CustomAttributes)

        //  *** End programmer edit section *** (resource_common.description CustomAttributes)
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (resource_common.description Get start)

                //  *** End programmer edit section *** (resource_common.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (resource_common.description Get end)

                //  *** End programmer edit section *** (resource_common.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_common.description Set start)

                //  *** End programmer edit section *** (resource_common.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (resource_common.description Set end)

                //  *** End programmer edit section *** (resource_common.description Set end)
            }
        }
        
        /// <summary>
        /// category.
        /// </summary>
        //  *** Start programmer edit section *** (resource_common.category CustomAttributes)

        //  *** End programmer edit section *** (resource_common.category CustomAttributes)
        [StrLen(32)]
        [NotNull()]
        public virtual string category
        {
            get
            {
                //  *** Start programmer edit section *** (resource_common.category Get start)

                //  *** End programmer edit section *** (resource_common.category Get start)
                string result = this.fcategory;
                //  *** Start programmer edit section *** (resource_common.category Get end)

                //  *** End programmer edit section *** (resource_common.category Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_common.category Set start)

                //  *** End programmer edit section *** (resource_common.category Set start)
                this.fcategory = value;
                //  *** Start programmer edit section *** (resource_common.category Set end)

                //  *** End programmer edit section *** (resource_common.category Set end)
            }
        }
        
        /// <summary>
        /// type.
        /// </summary>
        //  *** Start programmer edit section *** (resource_common.type CustomAttributes)

        //  *** End programmer edit section *** (resource_common.type CustomAttributes)
        [StrLen(32)]
        [NotNull()]
        public virtual string type
        {
            get
            {
                //  *** Start programmer edit section *** (resource_common.type Get start)

                //  *** End programmer edit section *** (resource_common.type Get start)
                string result = this.ftype;
                //  *** Start programmer edit section *** (resource_common.type Get end)

                //  *** End programmer edit section *** (resource_common.type Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_common.type Set start)

                //  *** End programmer edit section *** (resource_common.type Set start)
                this.ftype = value;
                //  *** Start programmer edit section *** (resource_common.type Set end)

                //  *** End programmer edit section *** (resource_common.type Set end)
            }
        }
        
        /// <summary>
        /// dt_created.
        /// </summary>
        //  *** Start programmer edit section *** (resource_common.dt_created CustomAttributes)

        //  *** End programmer edit section *** (resource_common.dt_created CustomAttributes)
        [NotNull()]
        public virtual System.DateTime dt_created
        {
            get
            {
                //  *** Start programmer edit section *** (resource_common.dt_created Get start)

                //  *** End programmer edit section *** (resource_common.dt_created Get start)
                System.DateTime result = this.fdt_created;
                //  *** Start programmer edit section *** (resource_common.dt_created Get end)

                //  *** End programmer edit section *** (resource_common.dt_created Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_common.dt_created Set start)

                //  *** End programmer edit section *** (resource_common.dt_created Set start)
                this.fdt_created = value;
                //  *** Start programmer edit section *** (resource_common.dt_created Set end)

                //  *** End programmer edit section *** (resource_common.dt_created Set end)
            }
        }
        
        /// <summary>
        /// dt_modified.
        /// </summary>
        //  *** Start programmer edit section *** (resource_common.dt_modified CustomAttributes)

        //  *** End programmer edit section *** (resource_common.dt_modified CustomAttributes)
        [NotNull()]
        public virtual System.DateTime dt_modified
        {
            get
            {
                //  *** Start programmer edit section *** (resource_common.dt_modified Get start)

                //  *** End programmer edit section *** (resource_common.dt_modified Get start)
                System.DateTime result = this.fdt_modified;
                //  *** Start programmer edit section *** (resource_common.dt_modified Get end)

                //  *** End programmer edit section *** (resource_common.dt_modified Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_common.dt_modified Set start)

                //  *** End programmer edit section *** (resource_common.dt_modified Set start)
                this.fdt_modified = value;
                //  *** Start programmer edit section *** (resource_common.dt_modified Set end)

                //  *** End programmer edit section *** (resource_common.dt_modified Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "resource_commonE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_commonE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_commonE", typeof(DataLine.434aasipro.resource_common));
                }
            }
            
            /// <summary>
            /// "resource_commonL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_commonL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_commonL", typeof(DataLine.434aasipro.resource_common));
                }
            }
        }
    }
}
