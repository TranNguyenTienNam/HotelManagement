//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class INVOICE
    {
        public int id { get; set; }
        public int reservation_id { get; set; }
        public Nullable<decimal> total_money { get; set; }
        public Nullable<double> surcharge { get; set; }
        public Nullable<double> early_checkin_fee { get; set; }
        public Nullable<double> late_checkout_fee { get; set; }
    
        public virtual RESERVATION RESERVATION { get; set; }
    }
}
