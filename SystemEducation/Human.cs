using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemEducation
{
    abstract class Human : IVisitable
    {
        public string FullName { get; set; }

        public abstract void Accept(IParticipantVisitor visitor);
    }
}
