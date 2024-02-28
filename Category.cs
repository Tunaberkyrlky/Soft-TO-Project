using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; } = "";

        public int RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
		public Restaurant? Restaurant { get; set; }

        public byte StatusId { get; set; }
        [ForeignKey("StatusId")]
		public Status? Status { get; set; }

		public List<Food> foods;
	}
}

