using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class UsingProperties
    {
        [Fact]
        public void DefiningAndUsingProperties()
        {
            var customer = new BankCustomer() { Name = "Joe", AccountNumber = 123 };

        }
    }
    public class BankCustomer
    {
        private int _accountNumber;
        public string Name { get; set; }

        private string _phonenumber;
        public string GetPhoneNUmber()
        {
            return _phonenumber;
        }
        public void SetPhone(string newValue)
        {
            _phonenumber = newValue;
        }
        
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string GetInfo()
        {
            return $"Name: {Name} has the accoutnumber {AccountNumber}";
        }
    }
}
