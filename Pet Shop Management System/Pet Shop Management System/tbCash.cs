//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet_Shop_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCash
    {
        public int cashid { get; set; }
        public string transno { get; set; }
        public string pcode { get; set; }
        public string pname { get; set; }
        public Nullable<int> qty { get; set; }
        public decimal price { get; set; }
        public Nullable<decimal> total { get; set; }
        public string cid { get; set; }
        public string cashier { get; set; }
    }
}