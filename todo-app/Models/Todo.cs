﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
namespace todo_app.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a description")]
        public string Description { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please enter a due date.")]
        public string CategoryId { get; set; } = String.Empty ;

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = String.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;   


    }

}
