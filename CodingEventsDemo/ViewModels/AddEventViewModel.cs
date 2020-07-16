﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Location must be between 1 and 100 characters")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Attendees is required.")]
        [Range(0, 100000, ErrorMessage = "Attendees must be between 0 and 100000")]
        public int Attendees { get; set; }
    }
}
