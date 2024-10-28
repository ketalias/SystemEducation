using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemEducation
{
    class DisplayInfoVisitor : IParticipantVisitor
    {
        public void VisitTeacher(Teacher teacher)
        {
            Console.WriteLine($"{teacher.AcademicDegree}, {teacher.FullName}, {teacher.Title} кафедри {teacher.Department}");
        }

        public void VisitStudent(Student student)
        {
            Console.WriteLine($"{student.FullName}, студент {student.Course} курсу, спеціальність {student.SpecialtyCode} – {student.SpecialtyName}");
        }

        public void VisitTechnicalStaff(TechnicalStaff staff)
        {
            Console.WriteLine($"{staff.FullName}, {staff.Position}");
        }
    }
}
