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
    
    public partial class rule : EntityBase
    {
        public rule()
        {
            this.rulecondition = new HashSet<rulecondition>();
        }
    
        public string code { get; set; }
        public string name { get; set; }
        public string user_id { get; set; }
        public Nullable<int> state { get; set; }
        public string description { get; set; }
    
        public virtual users users { get; set; }
        public virtual ICollection<rulecondition> rulecondition { get; set; }
    }
}
