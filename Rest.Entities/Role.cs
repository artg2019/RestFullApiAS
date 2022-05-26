using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOrganizer { get; set; }
        public List<Participant> Participants { get; set; }

    }
}
