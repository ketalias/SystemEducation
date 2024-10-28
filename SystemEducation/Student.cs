using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemEducation
{
    class Student : Human
    {
        public int Course { get; set; }
        public string SpecialtyCode { get; set; }
        public string SpecialtyName { get; set; }

        public override void Accept(IParticipantVisitor visitor)
        {
            visitor.VisitStudent(this);
        }
    }
}
