//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_kursovaya_wpf.AppDataFiles
{
    using System;
    using System.Collections.Generic;
    
    public partial class transport
    {
        public int id_auto { get; set; }
        public string marka { get; set; }
        public string gosNomer { get; set; }
        public string model { get; set; }
        public Nullable<int> id_status { get; set; }
        public Nullable<int> id_sotrudnik { get; set; }
        public Nullable<int> rashod { get; set; }
        public Nullable<int> id_type { get; set; }
    
        public virtual sotrudniki sotrudniki { get; set; }
        public virtual status status { get; set; }
        public virtual type_of_transport type_of_transport { get; set; }
    }
}
