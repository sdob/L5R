using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Reader
{
    public class Program
    {

        public Program()
        {
            this.fileContents = new List<string>();
        }
        
        public static void Main(string[] args)
        {
            Program test = new Program();
            test.ReadFile("C:\\TEMP\\FileReader\\File Reader\\File Reader\\testFile.txt");
        }

        public void ReadFile(string filename)
        {

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fileContents.Add(line);
                }
            
            }
            ParseFile();
        }

        public void ParseFile()
        {

            foreach (string parseString in fileContents)
            {
                if (parseString.Contains("Name") == true)
                {
                    string[] words=parseString.Split(':');
                    Console.WriteLine("Name of the cards is:"+words[1]);
                }
            }
            
            
            OutputFile();
        }

        public void OutputFile()
        {
            Console.WriteLine("Test output");

            foreach (string outputString in fileContents)
            {
                Console.WriteLine(outputString);
                
            }

            Console.ReadLine();
        
        }

        List<string> fileContents;
    }
}
