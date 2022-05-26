using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompetentionId { get; set; }
        public Competention Competention { get; set; }

    }
}
