using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject
{
    public class Client
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        public Client (string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
    }
}
