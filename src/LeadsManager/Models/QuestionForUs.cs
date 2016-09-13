using System;
using System.ComponentModel.DataAnnotations;

namespace LeadsManager.Models
{
    public class QuestionForUs
    {
        public Guid id { get; set; }

        [Display(Name = "Phone")]
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

        [Display(Name = "Comments")]
        [StringLength(255)]
        public string pragraph_text_field_controller { get; set; }

        [Display(Name = "How may we help")]
        [StringLength(255)]
        public string dropdown_list_field_controller { get; set; }

        [Display(Name = "Is Synced")]
        public bool? IsSynced { get; set; }

        public DateTime DateSynced { get; set; }
    }
}
