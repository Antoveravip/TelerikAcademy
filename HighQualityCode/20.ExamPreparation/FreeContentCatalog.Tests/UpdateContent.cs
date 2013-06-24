using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.IO;

namespace FreeContentCatalog.Tests
{
    [TestClass]
    public class UpdateContent
    {
        [TestMethod]
        [Timeout(10000)]
        public void TestUpdatePerformance()
        {
            int addsCount = 6000;
            int updatesCount = 3000;

            // Prepare the input commands 
            StringBuilder input = new StringBuilder();
            input.AppendLine("Add movie: mov; au; 42323723; http://movie.com");

            for (int i = 0; i < addsCount; i++)
            {
                input.AppendLine("Add application: app; a; 12345; http://oldurl");
            }

            input.AppendLine("Update: http://newmovie.com; http://othermovie.com");
            input.AppendLine("Update: http://movie.com; http://newmovie.com");
            input.AppendLine("Update: http://movie.com; http://newmovie.com");

            for (int i = 0; i < updatesCount; i++)
            {
                input.AppendLine("Update: http://oldurl; http://newurl");
                input.AppendLine("Update: http://newurl; http://oldurl");
            }

            input.AppendLine("Update: http://newurl; http://otherurl");
            input.AppendLine("Update: http://movie.com; http://newmovie.com");
            input.AppendLine("Update: http://newmovie.com; http://otherurl");
            input.AppendLine("End");

            // Prepare the expected result 
            StringBuilder expectedOutput = new StringBuilder();
            expectedOutput.AppendLine("Movie added");

            for (int i = 0; i < addsCount; i++)
            {
                expectedOutput.AppendLine("Application added");
            }

            expectedOutput.AppendLine("0 items updated");
            expectedOutput.AppendLine("1 items updated");
            expectedOutput.AppendLine("0 items updated");

            for (int i = 0; i < 2 * updatesCount; i++)
            {
                expectedOutput.AppendLine(addsCount + " items updated");
            }

            expectedOutput.AppendLine("0 items updated");
            expectedOutput.AppendLine("0 items updated");
            expectedOutput.AppendLine("1 items updated");

            // Redirect the console input / output and invoke the Main() method
            Console.SetIn(new StringReader(input.ToString()));
            StringWriter consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            CatalogEngine.Main();

            // Assert that the program execution result is correct
            string expected = expectedOutput.ToString();
            string actual = consoleOutput.ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
