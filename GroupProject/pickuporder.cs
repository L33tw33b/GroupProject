//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class pickuporder
    {
        public int orderID { get; set; }
        public string edeID { get; set; }
        public System.DateTime pickupDate { get; set; }
        public System.TimeSpan pickupTime { get; set; }
    
        public virtual edeaccount edeaccount { get; set; }
    }
}
