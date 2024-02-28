using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
	public class Restaurant
	{
		public int Id { get; set; }
		public string Name { get; set; } = "";
		public string Phone { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string AddressDetails { get; set; } = "";
        public DateTime RegisterationDate { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company? Company { get; set; }

        public byte StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status? Status { get; set; }
        
    }
}

