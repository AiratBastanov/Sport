//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfSport
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSupplier
    {
        public ProductSupplier()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int ProductSupplierID { get; set; }
        public string ProductSupplierName { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}
