using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritanceConsoleApp1
{
    class InheritClass //: ProcessPhysics
    {
        ProcessPhysics process = new ProcessPhysics();
       //string str = ProcessMath.().ToString();
        public  void Main(string[] args)
        {
            Console.WriteLine("");
            Console.Beep(); //process.
            Console.ReadKey();
        }
    }
    class ProcessMath : InheritClass
    {
        public string Marks()
        {
            return "test Marks";
        }
    }
    class ProcessHindi : ProcessMath
    {
        public string Marks()
        {
            return "test Marks2";
        }
    }
    class ProcessEnglish : ProcessHindi
    {
        public string MarksEnglish()
        {
            return "test Marks English";
        }
    }
    class ProcessPhysics : ProcessEnglish
    {
        public string MarksPhysics()
        {
            return "test Marks Physics";
        }
    }

}
// This file is clone from rqmesh111291 repo anf pufpufe of fhis file is just checking cmnt 3
