//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockMan.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class stock_category_map : EntityBase
    {
        public string cate_code { get; set; }
        public string stock_code { get; set; }
        public string stock_name { get; set; }
    
        public virtual stock stock { get; set; }
        public virtual stockcategory stockcategory { get; set; }
    }
}