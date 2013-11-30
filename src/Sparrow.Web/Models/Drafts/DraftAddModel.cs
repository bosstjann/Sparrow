using System;
using System.ComponentModel.DataAnnotations;

namespace Sparrow.Web.Models.Drafts
{
    public class DraftAddModel
    {
        [Required]
        public string Title { get; set; }
        public Guid OwnerId { get; set; }
        public Guid CustomerId { get; set; }
    }
}