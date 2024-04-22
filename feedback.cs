using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Feedback
    {
        [Key]
        public string FeedbackId { get; set; }

        [Required]
        public string StudentId { get; set; }

        [Required]
        public bool SatisfactionChecked { get; set; }

        [Required]
        public bool PreferenceChecked { get; set; }

        [Required]
        public bool SkillDevelopmentChecked { get; set; }

        [Required]
        public bool CommunicationEffectivenessChecked { get; set; }

        [Required]
        public bool ProfessionalDevelopmentChecked { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public DateTime FeedbackDate { get; set; }

        // Navigation property
        public virtual User Student { get; set; }
    }
}
