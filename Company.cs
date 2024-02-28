using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
	public class Company
	{
		public int Id { get; set; }
		public string Name { get; set; } = "";
		public string PostalCode { get; set; } = "";
		public string Address { get; set; } = "";
        public string EMail { get; set; } = "";
        public string Phone { get; set; } = "";
        public string TaxNumber { get; set; } = "";
        public DateTime RegisterationDate { get; set; }
		public string? Web { get; set; }

        public byte StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status? Status { get; set; }

	}
}

