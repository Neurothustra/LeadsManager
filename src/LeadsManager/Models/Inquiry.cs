using System;
using System.ComponentModel.DataAnnotations;

namespace LeadsManager.Models
{
    public class Inquiry
    {
        public Guid id { get; set; }

        [StringLength(255)]
        public string zip_code { get; set; }

        [StringLength(255)]
        public string suffix { get; set; }

        [StringLength(255)]
        public string street_address { get; set; }

        [StringLength(255)]
        public string state_name { get; set; }

        [StringLength(255)]
        public string stte { get; set; }

        [StringLength(255)]
        public string secondary_phone_type { get; set; }

        [StringLength(255)]
        public string secondary_phone { get; set; }

        [StringLength(255)]
        public string referred_by_whom { get; set; }

        [StringLength(255)]
        public string referred_by { get; set; }

        [StringLength(255)]
        public string referral_source { get; set; }

        [StringLength(255)]
        public string referral_school { get; set; }

        [StringLength(255)]
        public string referral_other_school { get; set; }

        [StringLength(255)]
        public string referral_other_employer { get; set; }

        [StringLength(255)]
        public string referral_employer { get; set; }

        [StringLength(255)]
        public string programs_interested { get; set; }

        [StringLength(255)]
        public string program_degree { get; set; }

        [StringLength(255)]
        public string program_concentration { get; set; }

        [StringLength(255)]
        public string primary_phone_type { get; set; }

        [StringLength(255)]
        public string primary_phone { get; set; }

        [StringLength(255)]
        public string previously_attended { get; set; }

        [StringLength(255)]
        public string other_country { get; set; }

        [StringLength(255)]
        public string name_of_event { get; set; }

        [StringLength(255)]
        public string military { get; set; }

        [StringLength(255)]
        public string middle_name { get; set; }

        [StringLength(255)]
        public string maiden_name { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(255)]
        public string how_soon_start { get; set; }

        [StringLength(255)]
        public string how_did_you_hear { get; set; }

        [StringLength(255)]
        public string first_name { get; set; }

        [StringLength(255)]
        public string evaluation { get; set; }

        [StringLength(255)]
        public string diploma_or_ged { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        [StringLength(255)]
        public string apartment_number { get; set; }

        [StringLength(255)]
        public string ad_type { get; set; }

        [StringLength(255)]
        public string email_address { get; set; }

        [StringLength(255)]
        public string confirm_email { get; set; }

        [Display(Name = "Is Synced")]
        public bool? IsSynced { get; set; }

        public DateTime DateSynced { get; set; }
    }
}
