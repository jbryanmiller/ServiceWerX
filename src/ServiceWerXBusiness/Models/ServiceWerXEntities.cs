using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace ServiceWerXBusiness
{    
    public class Business
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int EmployeeCount { get; set; }
        public int FederalTaxid { get; set; }
        public int HourlyRateShop { get; set; }
        public int HourlyRateOnSite { get; set; }
        public string Notes { get; set; }

        /// public virtual Artist Artist { get; set; }
        public virtual IList<Client> Client { get; set; }

        public Business()
        {
            //Artist = new Artist();
            Client = new List<Client>();
        }

    }
    
    public class Client
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmail { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool IsBusiness { get; set; }
        public bool IsDiscount { get; set; }
        public int DiscountPercentage { get; set; }
        public string Notes { get; set; }
    }

    public class ClientWithInvoiceCount : Client
    {
        public int InvoiceCount { get; set; }
    }

    public class CallType
    {
        public int Id { get; set; }
        public string Name { get; set; }                
  
        public override string ToString()
        {
            return Name;
        }
    }

    public class ServiceCall
    {
        public int Id { get; set; }
        public string CallType { get; set;  }
        public bool NewCustomer { get; set;  }
        public int ClientId { get; set;  }
        public string Technician { get; set; }
        public string ProblemDescription { get; set; }
        public DateTime DateRecieved { get; set; }
        public DateTime DateScheduled { get; set; }
        public DateTime TimeScheduled { get; set; }
        public string ContactNumber { get; set; }
        public int MileageIn { get; set; }
        public int MileageOut { get; set; }
        public int MileageTotal { get; set; }
        public int TimeIn { get; set; }
        public int TimeOut { get; set; }
        public bool FollowUp { get; set; }
        public int InvoiceId { get; set; }
        public string problemResolution { get; set; }
        public string Reccomendations { get; set; }
        public string Notes { get; set; }
        public bool IsComplete { get; set; }
        public bool IsInvoiced { get; set; }
        public bool IsPaid { get; set; }
        public int BusinessId { get; set; }
    }

    public class Invoice
    {   
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public DateTime DateWorked { get; set; }
        public DateTime DateBilled { get; set; }
        public DateTime DatePaid { get; set; }
        public DateTime DueDate { get; set; }
        public int ClientId { get; set; }
        public int ServiceCallId { get; set; }
        public int LaborUnit { get; set; }
        public int LaborRate { get; set; }
        public int PartsUnit { get; set; }
        public int PartsRate { get; set; }
        public int TotalBilled { get; set; }
        public int DiscountRate { get; set; }
        public string DiscountType { get; set; }
        public string PaymentType { get; set; }
        public int CheckNumber { get; set; }
        public string Notes { get; set; }
    }
}