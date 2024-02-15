namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //void QuerySubject9Randomly(List<Student> studentList)
            //{
            //    var result = from student in studentList
            //                 where student.Score >= 8
            //                 select student;
            //    foreach (Student student in result)
            //    {
                    
            //    }
            //}
        }
    }
}