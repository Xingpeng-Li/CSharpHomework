using System;

namespace OrderManagement
{
    //客户类
    class Customer
    {
        private String name;
        private String address;


        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }


        public override string ToString()
        {
            return $"Customer name:{Name}   Customer address:{Address}";
        }
    }
}
