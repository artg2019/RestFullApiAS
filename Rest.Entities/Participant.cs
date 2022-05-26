using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int CompetentionId { get; set; }
        public Competention Competention { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
