//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockMan.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class reco_stock_category_index : EntityBase
    {
        public string code { get; set; }
        public string cate_code { get; set; }
        public string index_code { get; set; }
        public string object_code { get; set; }
        public Nullable<int> day { get; set; }
        public Nullable<int> week { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<int> last_day { get; set; }
        public Nullable<int> last_week { get; set; }
        public Nullable<int> last_month { get; set; }
        public string cate_name { get; set; }
        public string index_name { get; set; }
        public string object_name { get; set; }
        public Nullable<decimal> pe { get; set; }
        public Nullable<decimal> pb { get; set; }
        public Nullable<decimal> mv { get; set; }
        public Nullable<decimal> fv { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> yestclose { get; set; }
    }
}
