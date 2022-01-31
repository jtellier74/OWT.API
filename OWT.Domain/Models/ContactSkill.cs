using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWT.Domain.Models
{
    public class ContactSkill
    {
        public int ContactId { get; set; }
        [ForeignKey("ContactId")]
        public ContactModel Contact { get; set; }
       
        public int SkillId { get; set; }
        [ForeignKey("SkillId")]
        public SkillModel Skill { get; set; }
    }
}
