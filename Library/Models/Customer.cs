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
    
    public partial class Customer
    {
        public Customer()
        {
            this.BorrowedBooks = new HashSet<BorrowedBook>();
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public string address { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<BorrowedBook> BorrowedBooks { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}