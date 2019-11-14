using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritanceConsoleApp1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // The code provided will print ‘Hello World’ to the console.
    //        // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
    //        Console.WriteLine("Hello World!");
    //        Console.ReadKey();

    //        // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
    //    }
    //}
    public interface IProcessMath
    {
        string MarksMath();
    }
    public interface IProcessHindi
    {
        string MarksHindi();
    }
    public interface IProcessEnglish
    {
        string MarksEnglish();
    }
    public interface IProcessPhysics
    {
        string MarksPhysics();
    }

    // =====> Classess
    class TestSubjectProcess   : IProcessHindi, IProcessEnglish, IProcessMath, IProcessPhysics
    {

        protected int x=1;
        protected int y=11;
        protected string txt="RCD";

        public string MarksHindi()
        {
            return "Hindi=====> 4/10";
        }
        public string MarksEnglish()
        {
            return "English====> 7/10";
        }
        public string MarksMath()
        {
            return "Maths=====>9/10";
        }

        public string MarksPhysics()
        {
            return "Physics====>8/10";
        }

    }
    //=====> Main class 
    class Program //: TestSubjectProcess
    {
        public static void Main(string[] args)
        {
            TestSubjectProcess testSubject = new TestSubjectProcess();

            string Eng = testSubject.MarksEnglish();
            string Mat = testSubject.MarksMath();
            string Hin = testSubject.MarksHindi();
            string Phy = testSubject.MarksPhysics();

            Console.WriteLine(Eng);
            Console.WriteLine(Mat);
            Console.WriteLine(Hin);
            Console.WriteLine(Phy);

            Console.ReadKey();  
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFileUpload
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}


// This file is clone from rqmesh111291 repo anf pufpufe of fhis file is just checking cmnt 2 =============================This is TESTTTTTTTTTTTTTTTTTTTTTTTTT brznch


