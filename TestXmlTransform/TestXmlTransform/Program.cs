using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace TestXmlTransform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class Xslt
    {
        public static Stream xml, xslt;
        public static void transform(string resultFilePath, string resultFileName, string resultFileExtension)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            // Open books.xml as an XPathDocument.
            XmlReader reader = XmlReader.Create(xml);
            //MessageBox.Show("Att count:" + reader.AttributeCount);
            /*while (reader.Read())
            {
                //MessageBox.Show("The start...");
                if (reader.IsStartElement())
                {
                    if (reader.IsEmptyElement)
                        Console.WriteLine("<{0}/>", reader.Name);
                    else
                    {
                        Console.Write("<{0}> ", reader.Name);
                        reader.Read(); // Read the start tag.
                        if (reader.IsStartElement())  // Handle nested elements.
                            Console.Write("\r\n<{0}>", reader.Name);
                        Console.WriteLine(reader.ReadString());  //Read the text content of the element.
                    }
                }
            }*/

            // Create a writer for writing the transformed file.
            string path = resultFilePath + "\\" + resultFileName + "." + resultFileExtension;
            MessageBox.Show(path);
            FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            XmlTextWriter writer = new XmlTextWriter(sw);

            // Create and load the transform with script execution enabled.
            XslCompiledTransform transform = new XslCompiledTransform();
            XsltSettings settings = new XsltSettings();
            //settings.EnableScript = true;

            transform.Load(XmlReader.Create(xslt), settings, null);

            // Execute the transformation.
            transform.Transform(reader, writer);
            fs.Flush();
            fs.Close();
            TimeSpan ts = DateTime.Now - dt;
            MessageBox.Show("File Converted in {0} seg", ts.ToString());
        }
    }

}
