//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PH02886.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_detail
    {
        public int oddt_id { get; set; }
        public Nullable<int> oddt_price { get; set; }
        public Nullable<int> prod_id { get; set; }
        public Nullable<int> oddt_quanlity { get; set; }
        public Nullable<int> order_id { get; set; }
    
        public virtual order order { get; set; }
        public virtual Product Product { get; set; }
    }
}
