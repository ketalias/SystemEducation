using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemEducation
{
    interface IVisitable
    {
        void Accept(IParticipantVisitor visitor);
    }
    interface IParticipantVisitor
    {
        void VisitTeacher(Teacher teacher);
        void VisitStudent(Student student);
        void VisitTechnicalStaff(TechnicalStaff staff);
    }

}
