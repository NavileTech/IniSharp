using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniSharpBox.Test
{
    public static class Commons
    {

        public static FileInfo GetOutputFile(String filename)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());

            String FullpathOutputDirectory = di.Parent.Parent.Parent.FullName + "\\Files\\output";

            if(Directory.Exists(FullpathOutputDirectory) == false)
            {
                Directory.CreateDirectory(FullpathOutputDirectory);
            }

            String fullPathFile = FullpathOutputDirectory + "\\" + filename;

            return new FileInfo(fullPathFile);
        }

        public static void DeleteOutputFile(String filename)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            String fullPathFile = di.Parent.Parent.Parent.FullName + "\\Files\\output\\" + filename;
            if(File.Exists(fullPathFile) == true)
            {
                File.Delete(fullPathFile);
            }          
        }

        public static String GetInputText(String filename)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            String fullPathFile = di.Parent.Parent.Parent.FullName + "\\Files\\" + filename;
            return File.ReadAllText(fullPathFile);
        }

        public static String[] GetInputLines(String filename)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            String fullPathFile = di.Parent.Parent.Parent.FullName + "\\Files\\" + filename;
            return File.ReadLines(fullPathFile).ToArray();
        }


        public static IniSharp LoadWithFileName(String filename,IniConfig config )
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            String fullPathFile = di.Parent.Parent.Parent.FullName + "\\Files\\" + filename;


            IniSharp iniSharp = new IniSharp(fullPathFile,config);
            //iniSharp.Config =  config;
            iniSharp.Read();
            return iniSharp;
        }

        public static IniSharp LoadWithFileName(FileInfo fi, IniConfig config)
        {
            IniSharp iniSharp = new IniSharp(fi.FullName,config);
            //iniSharp.Config =  config;
            iniSharp.Read();
            return iniSharp;
        }

        public static IniSharp LoadWithAllText(String filename, IniConfig config)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            String fullPathFile = di.Parent.Parent.Parent.FullName + "\\Files\\" + filename;
            IniSharp iniSharp = new IniSharp(config);

            iniSharp.Read(File.ReadAllText(fullPathFile));
            return iniSharp;
        }

        public static IniSharp LoadWithAllLines(String filename, IniConfig config)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            String fullPathFile = di.Parent.Parent.Parent.FullName + "\\Files\\" + filename;
            IniSharp iniSharp = new IniSharp(config);

            iniSharp.Read(File.ReadAllLines(fullPathFile));
            return iniSharp;
        }


        public static Boolean TestActual001(IniSharp iniSharp)
        {

            return iniSharp.Success;
        }


        public static Boolean TestActual002(IniSharp iniSharp)
        {

            Boolean actual = (iniSharp.Sections[0].Name == "SEZIONE_1") &&
                                (iniSharp.Sections[1].Name == "SEZIONE_2") &&
                                (iniSharp.Sections[2].Name == "SEZIONE_3") &&
                                (iniSharp.Sections[3].Name == "SEZIONE_4") &&
                                (iniSharp.Sections[4].Name == "SEZIONE_5");

            return actual;
        }

        public static Boolean TestActual003(IniSharp iniSharp)
        {

            Boolean actual = (iniSharp.Sections[0].Fields[0].Name == "campo001") &&
                                (iniSharp.Sections[0].Fields[1].Name == "Campo2") &&
                                (iniSharp.Sections[1].Fields[0].Name == "Campo2") &&
                                (iniSharp.Sections[1].Fields[1].Name == "campo4") &&
                                (iniSharp.Sections[2].Fields.Count == 0) &&
                                (iniSharp.Sections[3].Fields.Count == 0) &&
                                (iniSharp.Sections[4].Fields[0].Name == "campo6");

            return actual;
        }


        public static Boolean TestActual004(IniSharp iniSharp)
        {

            Boolean actual = (iniSharp.Sections[0].Fields[0].Lines[0] == "valore1") &&
                                (iniSharp.Sections[0].Fields[1].Lines[0] == "valore002") &&
                                (iniSharp.Sections[1].Fields[0].Lines[0] == "valore002") &&
                                (iniSharp.Sections[1].Fields[0].Lines[1] == "valoreacapo") &&
                                (iniSharp.Sections[1].Fields[1].Lines[0] == "") &&
                                (iniSharp.Sections[4].Fields[0].Lines[0] == "000");

            return actual;
        }

        public static IniConfig Config()
        {
            return new IniConfig();
        }
    }
}
