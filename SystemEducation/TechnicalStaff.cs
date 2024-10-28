using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemEducation
{
    class TechnicalStaff : Human
    {
        public string Position { get; set; }

        public override void Accept(IParticipantVisitor visitor)
        {
            visitor.VisitTechnicalStaff(this);
        }
    }
}
