using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBookStoreManagement.Models
{
    public class booklist
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string Mrp { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }

        
    }
    public enum Author
    {
        abc,pqr,aaa
    }
}