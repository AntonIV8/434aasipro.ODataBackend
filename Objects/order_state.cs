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
    /// Order_state.
    /// </summary>
    //  *** Start programmer edit section *** (order_state CustomAttributes)

    //  *** End programmer edit section *** (order_state CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("order_stateE", new string[] {
            "description as \'Description\'"})]
    [View("order_stateL", new string[] {
            "description as \'Description\'"})]
    public class order_state : ICSSoft.STORMNET.DataObject
    {
        
        private string fdescription;
        
        //  *** Start programmer edit section *** (order_state CustomMembers)

        //  *** End programmer edit section *** (order_state CustomMembers)

        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (order_state.description CustomAttributes)

        //  *** End programmer edit section *** (order_state.description CustomAttributes)
        [StrLen(255)]
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (order_state.description Get start)

                //  *** End programmer edit section *** (order_state.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (order_state.description Get end)

                //  *** End programmer edit section *** (order_state.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (order_state.description Set start)

                //  *** End programmer edit section *** (order_state.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (order_state.description Set end)

                //  *** End programmer edit section *** (order_state.description Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "order_stateE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View order_stateE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("order_stateE", typeof(DataLine.434aasipro.order_state));
                }
            }
            
            /// <summary>
            /// "order_stateL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View order_stateL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("order_stateL", typeof(DataLine.434aasipro.order_state));
                }
            }
        }
    }
}
