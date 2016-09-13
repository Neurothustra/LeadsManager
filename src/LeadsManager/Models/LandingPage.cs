using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeadsManager.Models
{
    [Table("Leads")]
    public class LandingPage
    {
        public int Id { get; set; }

        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Is Synced")]
        public bool? IsSynced { get; set; }

        public DateTime? DateSynced { get; set; }

        [MaxLength(255)]
        public string Prefix { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(255)]
        public string City { get; set; }

        [MaxLength(255)]
        public string State { get; set; }

        [MaxLength(255)]
        public string Country { get; set; }

        [Display(Name = "Zip Code")]
        [MaxLength(255)]
        public string ZipCode { get; set; }

        [MaxLength(255)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [Display(Name = "Program Interest")]
        [MaxLength(255)]
        public string ProgramInterest { get; set; }

        [Display(Name = "Highest Level of Education")]
        [MaxLength(255)]
        public string HighestEduCompleted { get; set; }

        [Display(Name = "High School Graduation Year")]
        [MaxLength(255)]
        public string HSGradYear { get; set; }

        [MaxLength(255)]
        public string Age { get; set; }

        [Display(Name = "Preferred Method of Contact")]
        [MaxLength(255)]
        public string PreferredContact { get; set; }

        [Display(Name = "Military Affiliation")]
        [MaxLength(255)]
        public string MilitaryAffiliation { get; set; }

        [Display(Name = "Desired Start Date")]
        [MaxLength(255)]
        public string DesiredStart { get; set; }

        [Display(Name = "Opt-in Consent")]
        [MaxLength(255)]
        public string OptInConsent { get; set; }

        [Display(Name = "Vendor Name")]
        [MaxLength(255)]
        public string VendorName { get; set; }

        [MaxLength(255)]
        public string Key { get; set; }

        [Display(Name = "Form Name")]
        [MaxLength(255)]
        public string FormName { get; set; }
    }
}