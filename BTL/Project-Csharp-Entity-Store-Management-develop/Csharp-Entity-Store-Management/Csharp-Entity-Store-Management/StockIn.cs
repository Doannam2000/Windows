//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Csharp_Entity_Store_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockIn
    {
        public int productID { get; set; }
        public int supplierID { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
