using workshop2.Managers;

namespace workshop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            JobSeekerManager seekerManager = new JobSeekerManager();
            while (!exitProgram)
            {
                Console.WriteLine(" Welcome To Hire Me Now! \n The jobseeker portal!");
                seekerManager.ShowMainMenu();
            }
        }
    }
}
