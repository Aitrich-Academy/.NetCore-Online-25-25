using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class JobProviderCompany
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string LegalName { get; set; }

        public string Summary { get; set; }

        [Required]
        public Guid IndustryId { get; set; }

        public Industry Industry { get; set; }

        [Required]
        public string Email { get; set; }

        public long Phone { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        [Required]
        public Guid LocationId { get; set; }

        public Location LocationNavigation { get; set; }

        public ICollection<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();
    }
}