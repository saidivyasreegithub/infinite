//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Miniproject_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class cancellation
    {
        public int cancel_id { get; set; }
        public Nullable<int> booking_id { get; set; }
        public Nullable<int> train_No { get; set; }
        public string @class { get; set; }
        public System.DateTime cancel_date { get; set; }
        public Nullable<int> no_of_seats { get; set; }
        public Nullable<int> refund { get; set; }
        public string remarks { get; set; }
    
        public virtual booking booking { get; set; }
        public virtual train train { get; set; }
    }
}