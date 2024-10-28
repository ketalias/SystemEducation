using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemEducation
{
    class Teacher : Human
    {
        public string AcademicDegree { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }

        public override void Accept(IParticipantVisitor visitor)
        {
            visitor.VisitTeacher(this);
        }
    }
}
