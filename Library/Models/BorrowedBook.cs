//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BorrowedBook
    {
        public int bookId { get; set; }
        public int refNo { get; set; }
        public int copyId { get; set; }
        public int customerId { get; set; }
        public System.DateTime borrowDate { get; set; }
        public System.DateTime dueDate { get; set; }
        public int renewNo { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Copy Copy { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
