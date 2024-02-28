using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
	public class User
	{
        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string Name { get; set; } = "";
        public string EMail { get; set; } = "";
        public string Phone { get; set; } = "";
        public DateTime RegisterationDate { get; set; }

        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        [ForeignKey("StatusId")]
        public byte StatusId { get; set; }
        public Status? Status { get; set; }
    }
}

