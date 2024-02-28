using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
	public class Status
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]  // Db otomatik Id atamaması için EF kodu. Byte Id'leri otomatik Primary Key olarak görmez
		public byte Id { get; set; }
		[Column(TypeName ="nvarchar(10)")]
		public string Description { get; set; } = "";

	}
}

