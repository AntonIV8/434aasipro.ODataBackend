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
    /// Service_spec_acl.
    /// </summary>
    //  *** Start programmer edit section *** (service_spec_acl CustomAttributes)

    //  *** End programmer edit section *** (service_spec_acl CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("service_spec_aclE", new string[] {
            "a_create as \'A_create\'",
            "a_read as \'A_read\'",
            "a_update as \'A_update\'",
            "a_delete as \'A_delete\'",
            "service_spec_id as \'Service_spec_id\'",
            "service_spec_id.enum as \'Enum\'",
            "group_id as \'Group_id\'",
            "group_id.name as \'Name\'"})]
    [View("service_spec_aclL", new string[] {
            "a_create as \'A_create\'",
            "a_read as \'A_read\'",
            "a_update as \'A_update\'",
            "a_delete as \'A_delete\'",
            "service_spec_id.enum as \'Enum\'",
            "group_id.name as \'Name\'"})]
    public class service_spec_acl : ICSSoft.STORMNET.DataObject
    {
        
        private bool fa_create;
        
        private bool fa_read;
        
        private bool fa_update;
        
        private bool fa_delete;
        
        private DataLine.434aasipro.grp fgroup_id;
        
        private DataLine.434aasipro.service_spec fservice_spec_id;
        
        //  *** Start programmer edit section *** (service_spec_acl CustomMembers)

        //  *** End programmer edit section *** (service_spec_acl CustomMembers)

        
        /// <summary>
        /// a_create.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec_acl.a_create CustomAttributes)

        //  *** End programmer edit section *** (service_spec_acl.a_create CustomAttributes)
        [NotNull()]
        public virtual bool a_create
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_create Get start)

                //  *** End programmer edit section *** (service_spec_acl.a_create Get start)
                bool result = this.fa_create;
                //  *** Start programmer edit section *** (service_spec_acl.a_create Get end)

                //  *** End programmer edit section *** (service_spec_acl.a_create Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_create Set start)

                //  *** End programmer edit section *** (service_spec_acl.a_create Set start)
                this.fa_create = value;
                //  *** Start programmer edit section *** (service_spec_acl.a_create Set end)

                //  *** End programmer edit section *** (service_spec_acl.a_create Set end)
            }
        }
        
        /// <summary>
        /// a_read.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec_acl.a_read CustomAttributes)

        //  *** End programmer edit section *** (service_spec_acl.a_read CustomAttributes)
        [NotNull()]
        public virtual bool a_read
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_read Get start)

                //  *** End programmer edit section *** (service_spec_acl.a_read Get start)
                bool result = this.fa_read;
                //  *** Start programmer edit section *** (service_spec_acl.a_read Get end)

                //  *** End programmer edit section *** (service_spec_acl.a_read Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_read Set start)

                //  *** End programmer edit section *** (service_spec_acl.a_read Set start)
                this.fa_read = value;
                //  *** Start programmer edit section *** (service_spec_acl.a_read Set end)

                //  *** End programmer edit section *** (service_spec_acl.a_read Set end)
            }
        }
        
        /// <summary>
        /// a_update.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec_acl.a_update CustomAttributes)

        //  *** End programmer edit section *** (service_spec_acl.a_update CustomAttributes)
        [NotNull()]
        public virtual bool a_update
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_update Get start)

                //  *** End programmer edit section *** (service_spec_acl.a_update Get start)
                bool result = this.fa_update;
                //  *** Start programmer edit section *** (service_spec_acl.a_update Get end)

                //  *** End programmer edit section *** (service_spec_acl.a_update Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_update Set start)

                //  *** End programmer edit section *** (service_spec_acl.a_update Set start)
                this.fa_update = value;
                //  *** Start programmer edit section *** (service_spec_acl.a_update Set end)

                //  *** End programmer edit section *** (service_spec_acl.a_update Set end)
            }
        }
        
        /// <summary>
        /// a_delete.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec_acl.a_delete CustomAttributes)

        //  *** End programmer edit section *** (service_spec_acl.a_delete CustomAttributes)
        [NotNull()]
        public virtual bool a_delete
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_delete Get start)

                //  *** End programmer edit section *** (service_spec_acl.a_delete Get start)
                bool result = this.fa_delete;
                //  *** Start programmer edit section *** (service_spec_acl.a_delete Get end)

                //  *** End programmer edit section *** (service_spec_acl.a_delete Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec_acl.a_delete Set start)

                //  *** End programmer edit section *** (service_spec_acl.a_delete Set start)
                this.fa_delete = value;
                //  *** Start programmer edit section *** (service_spec_acl.a_delete Set end)

                //  *** End programmer edit section *** (service_spec_acl.a_delete Set end)
            }
        }
        
        /// <summary>
        /// Service_spec_acl.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec_acl.group_id CustomAttributes)

        //  *** End programmer edit section *** (service_spec_acl.group_id CustomAttributes)
        [PropertyStorage(new string[] {
                "group_id"})]
        [NotNull()]
        public virtual DataLine.434aasipro.grp group_id
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec_acl.group_id Get start)

                //  *** End programmer edit section *** (service_spec_acl.group_id Get start)
                DataLine.434aasipro.grp result = this.fgroup_id;
                //  *** Start programmer edit section *** (service_spec_acl.group_id Get end)

                //  *** End programmer edit section *** (service_spec_acl.group_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec_acl.group_id Set start)

                //  *** End programmer edit section *** (service_spec_acl.group_id Set start)
                this.fgroup_id = value;
                //  *** Start programmer edit section *** (service_spec_acl.group_id Set end)

                //  *** End programmer edit section *** (service_spec_acl.group_id Set end)
            }
        }
        
        /// <summary>
        /// Service_spec_acl.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec_acl.service_spec_id CustomAttributes)

        //  *** End programmer edit section *** (service_spec_acl.service_spec_id CustomAttributes)
        [PropertyStorage(new string[] {
                "service_spec_id"})]
        [NotNull()]
        public virtual DataLine.434aasipro.service_spec service_spec_id
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec_acl.service_spec_id Get start)

                //  *** End programmer edit section *** (service_spec_acl.service_spec_id Get start)
                DataLine.434aasipro.service_spec result = this.fservice_spec_id;
                //  *** Start programmer edit section *** (service_spec_acl.service_spec_id Get end)

                //  *** End programmer edit section *** (service_spec_acl.service_spec_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec_acl.service_spec_id Set start)

                //  *** End programmer edit section *** (service_spec_acl.service_spec_id Set start)
                this.fservice_spec_id = value;
                //  *** Start programmer edit section *** (service_spec_acl.service_spec_id Set end)

                //  *** End programmer edit section *** (service_spec_acl.service_spec_id Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "service_spec_aclE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View service_spec_aclE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("service_spec_aclE", typeof(DataLine.434aasipro.service_spec_acl));
                }
            }
            
            /// <summary>
            /// "service_spec_aclL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View service_spec_aclL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("service_spec_aclL", typeof(DataLine.434aasipro.service_spec_acl));
                }
            }
        }
    }
}
