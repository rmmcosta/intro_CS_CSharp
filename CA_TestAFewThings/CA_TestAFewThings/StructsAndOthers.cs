using System;
using System.Linq;
using System.IO;
using System.Reflection;

namespace CA_TestAFewThings
{
    class StructsAndOthers
    {
        struct Point
        {

            public int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Point operator +(Point p1, Point p2) =>
                new Point(p1.x + p2.x, p1.y + p2.y);
        }

        static void alterMyPoint(Point pw)
        {
            pw.x = 5;
            pw.y = 7;
        }

        static void alterMyPoint(ref Point pw)
        {
            pw.x = 5;
            pw.y = 7;
        }

        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3);
            Console.WriteLine("{0},{1}", p1.x, p1.y);

            alterMyPoint(p1);
            Console.WriteLine("{0},{1}", p1.x, p1.y);

            alterMyPoint(ref p1);
            Console.WriteLine("{0},{1}", p1.x, p1.y);

            Point p2 = new Point(3, 4);
            Point p3 = p1 + p2;
            Console.WriteLine("{0},{1}", p3.x, p3.y);

            Arrays a1 = new Arrays("Ana", "Ricardo", "Rui");
            a1.showValues3();

            string[] a2 = { "Ana", "Ricardo" };
            string[] a3 = { "Rui", "Manuel", "Costa" };

            Arrays.showValues(a2);
            Arrays.showValues(a3);

            string[][] partyPeople = new string[3][];

            partyPeople[0] = new string[] { "Ana", "Ricardo" };

            Arrays.printArray(partyPeople[0]);
            Arrays.printArray(partyPeople[0].Reverse());

            Array.Sort(a3);

            Arrays.printArray(a3);

            Console.WriteLine(Arrays.Day.Fri);

            foreach (var value in Enum.GetValues(typeof(Arrays.Day)))
            {
                Console.WriteLine("{0,3}     0x{0:x8}     {1}",
                                  (int)value, ((Arrays.Day)value));
                //Console.Write(value);
            }

            try
            {
                Console.WriteLine(1);
                Assembly assem = Assembly.ReflectionOnlyLoadFrom("CL_Pets.dll");
                Console.WriteLine("2: {0}", assem);
                Type[] typs = assem.GetTypes();
                foreach (Type t in typs)
                {
                    Console.WriteLine("Cosio:" + t);
                }
                Type typ = assem.GetType("ThirdPartyDll.Pets");
                Console.WriteLine("3: {0}",typ);
                FieldInfo[] fields = typ.GetFields();
                Console.WriteLine(4);

                foreach (var field in fields)
                {
                    if (field.Name.Equals("value__")) continue;

                    Console.WriteLine("{0,-9} {1}", field.Name + ":",
                                                    field.GetRawConstantValue());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            string root = Path.GetPathRoot("CL_Pets.dll");
            Console.WriteLine(root);

            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            Console.WriteLine(codeBase);
            UriBuilder uri = new UriBuilder(codeBase);
            Console.WriteLine(uri);
            string path = Uri.UnescapeDataString(uri.Path);
            Console.WriteLine(path);
            Console.WriteLine(Path.GetDirectoryName(path));

            foreach (string path1 in args)
            {
                if (File.Exists(path1))
                {
                    // This path is a file
                    ProcessFile(path1);
                }
                else if (Directory.Exists(path1))
                {
                    // This path is a directory
                    ProcessDirectory(path1);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", path);
                }
            }

            ProcessDirectory(@".\");
        }
    }
}
