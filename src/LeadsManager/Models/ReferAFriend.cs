using System;
using System.ComponentModel.DataAnnotations;

namespace LeadsManager.Models
{
    public class ReferAFriend
    {
        public Guid id { get; set; }

        [Display(Name = "Friend's Email")]
        [StringLength(255)]
        public string text_field_controller_4 { get; set; }

        [Display(Name = "Friend's Last Name")]
        [StringLength(255)]
        public string text_field_controller_3 { get; set; }

        [Display(Name = "Friend's First Name")]
        [StringLength(255)]
        public string text_field_controller_2 { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string text_field_controller_1 { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(255)]
        public string text_field_controller_0 { get; set; }

        [Display(Name = "First Name")]
        [StringLength(255)]
        public string text_field_controller { get; set; }

        [Display(Name = "Message")]
        [StringLength(255)]
        public string pragraph_text_field_controller { get; set; }

        [Display(Name = "Is Synced")]
        public bool? IsSynced { get; set; }

        public DateTime DateSynced { get; set; }
    }
}
