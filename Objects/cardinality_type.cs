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
    /// Cardinality_type.
    /// </summary>
    //  *** Start programmer edit section *** (cardinality_type CustomAttributes)

    //  *** End programmer edit section *** (cardinality_type CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("cardinality_typeE", new string[] {
            "description as \'Description\'"})]
    [View("cardinality_typeL", new string[] {
            "description as \'Description\'"})]
    public class cardinality_type : ICSSoft.STORMNET.DataObject
    {
        
        private string fdescription;
        
        //  *** Start programmer edit section *** (cardinality_type CustomMembers)

        //  *** End programmer edit section *** (cardinality_type CustomMembers)

        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (cardinality_type.description CustomAttributes)

        //  *** End programmer edit section *** (cardinality_type.description CustomAttributes)
        [StrLen(255)]
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (cardinality_type.description Get start)

                //  *** End programmer edit section *** (cardinality_type.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (cardinality_type.description Get end)

                //  *** End programmer edit section *** (cardinality_type.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (cardinality_type.description Set start)

                //  *** End programmer edit section *** (cardinality_type.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (cardinality_type.description Set end)

                //  *** End programmer edit section *** (cardinality_type.description Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "cardinality_typeE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View cardinality_typeE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("cardinality_typeE", typeof(DataLine.434aasipro.cardinality_type));
                }
            }
            
            /// <summary>
            /// "cardinality_typeL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View cardinality_typeL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("cardinality_typeL", typeof(DataLine.434aasipro.cardinality_type));
                }
            }
        }
    }
}
