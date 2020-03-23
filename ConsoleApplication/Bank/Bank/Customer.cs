using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Customer
    {
        private readonly int _ID;
        private readonly string _Name;
        private string _Address;
        private string _Category;
        private bool _Status;

        public Customer() { }
        
        public Customer(
            string name,
            string address, 
            string category,
            bool status
        )
        {
            _Name = name;
            _Address = address;
            _Category = category;
            _Status = status;
        }

        public string Name { get { return Name; } }
        public string Address { get { return _Address; } }
        public string Category { get { return _Category; } }
        public bool Status { get { return _Status; } }


    }
}
