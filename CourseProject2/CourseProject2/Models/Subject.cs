//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseProject2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int Id { get; set; }
        public Nullable<int> SubjectType { get; set; }
        public string InventoryNumber { get; set; }
        public int AmountSubjects { get; set; }
    
        public virtual SubjectType SubjectType1 { get; set; }
    }
}
