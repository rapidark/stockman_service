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
    
    public partial class related_object_define : EntityBase
    {
        public related_object_define()
        {
            this.related_object_fields = new HashSet<related_object_fields>();
        }
    
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<double> value { get; set; }
        public Nullable<double> last_value { get; set; }
    
        public virtual ICollection<related_object_fields> related_object_fields { get; set; }
    }
}
