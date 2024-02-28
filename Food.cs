using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
	public class Food
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public double Price { get; set; }
		public string? Description { get; set; }

		public int CategoryId { get; set; }
		[ForeignKey("CategotyId")]
		public Category? Category { get; set; }

		public byte StatusId { get; set; }
		[ForeignKey("StatusId")]
		public Status? Status { get; set; }
	}
}

