//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RESERVATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESERVATION()
        {
            this.GUEST_BOOKING = new HashSet<GUEST_BOOKING>();
            this.INVOICEs = new HashSet<INVOICE>();
            this.ROOM_BOOKED = new HashSet<ROOM_BOOKED>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public Nullable<System.DateTime> arrival { get; set; }
        public Nullable<System.DateTime> departure { get; set; }
        public string status { get; set; }
        public string main_guest { get; set; }
        public Nullable<bool> early_checkin { get; set; }
        public Nullable<bool> late_checkout { get; set; }
    
        public virtual GUEST GUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GUEST_BOOKING> GUEST_BOOKING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVOICE> INVOICEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOM_BOOKED> ROOM_BOOKED { get; set; }
    }
}
