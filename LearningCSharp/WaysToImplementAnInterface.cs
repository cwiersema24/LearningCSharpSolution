using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class WaysToImplementAnInterface
    {
        [Fact]
        public void MakingARegistration()
        {
            var invite = new SpecialEventRegistration(new Emailer())
            {
                DateofEvent = new DateTime(2021, 4, 20),
                Employee = new Employee("Ben", "Dev", 280000),
                Event = "Jeffs birthday bash"
            };
            invite.Invite();
        }

    }
    public enum ContentType { Plain, Html, Rtf }
    public class Emailer:IEmailPartyInvitation
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public ContentType ContentType { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            // actuall send the email.
        }

        void IEmailPartyInvitation.Invite(string to, string message)
        {
            Recipient = to;
            Content = message;
            ContentType = ContentType.Plain;
            From = "partyhost@hypertheory.com";
            Send();
        }
    }
    public class SpecialEventRegistration
    {
        private IEmailPartyInvitation _emailer;

        public SpecialEventRegistration(IEmailPartyInvitation emailer)
        {
            _emailer = emailer;
        }

        public Employee Employee { get; set; }
        public string Event { get; set; }
        public DateTime DateofEvent { get; set; }
        public void Invite()
        {
            
            _emailer.Invite(Employee.Name + "@company.com", $"You are invited to {Event} on {DateofEvent}");
            
        }
    }
}
