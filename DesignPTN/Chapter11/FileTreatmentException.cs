using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class FileTreatmentException : Exception
    {
        public  FileTreatmentException() { }

        public FileTreatmentException(string msg) : base(msg) { }
    }
}
