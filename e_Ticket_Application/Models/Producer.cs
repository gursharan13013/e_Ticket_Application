﻿using System.ComponentModel.DataAnnotations;

namespace e_Ticket_Application.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }
    }
}