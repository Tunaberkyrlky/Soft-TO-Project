﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Menu.Models
{
    public class RestaurantUser
    {
        public int RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        public Restaurant? Restaurant { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }



    }
}

