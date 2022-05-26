using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Entities
{
    public class Competention
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public List<Competention> Competentions { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Team> Teams { get; set; }
    }
}
