//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusTravelsManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusInfo
    {
        public int BusID { get; set; }
        public string BoardingPoint { get; set; }
        public Nullable<System.DateTime> TravelDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Rating { get; set; }
    }
}
