using System;
namespace SystemEducation
{
    class Program
    {
        static void Main()
        {
            List<Human> participants = new List<Human>
        {
            new Teacher { FullName = "Андрашко Ю.В.", AcademicDegree = "к.т.н.", Title = "доцент", Department = "САТО" },
            new Student { FullName = "Іваненко І.І.", Course = 3, SpecialtyCode = "113", SpecialtyName = "прикладна математика" },
            new Teacher { FullName = "Маринець В.В.", AcademicDegree = "д.ф.-м.н.", Title = "професор", Department = "диференціальних рівнянь" },
            new TechnicalStaff { FullName = "Роля М.Ю.", Position = "лаборант" }
        };

            DisplayInfoVisitor displayVisitor = new DisplayInfoVisitor();

            foreach (var participant in participants)
            {
                participant.Accept(displayVisitor);
            }
        }
    }
}
