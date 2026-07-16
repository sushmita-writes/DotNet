using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public partial class Marksheet
    {
        private string[] courseCodes = new string[5];

        public string this[int i] 
        {
            get { return courseCodes[i]; } set { courseCodes[i] = value; }
        }

        public char this[int i, string s]
        {
            get { return grades[i]; } set { grades[i] = value; }
        }

        
    }
}
