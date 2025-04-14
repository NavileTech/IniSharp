using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniSharpBox.Test
{
    public static class Commons
    {
        public const string FILES_FOLDERNAME = "Files";
        public const string FILES_OUTPUT_FOLDERNAME = "output";
        public const string FILES_INPUT_FOLDERNAME = "input";

        public static string GetRootFolderFullPath()
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());

            return di.Parent.Parent.Parent.FullName;
        }

        public static string GetFilesFolderFullPath()
        {
            return Path.Combine(GetRootFolderFullPath(), FILES_FOLDERNAME);
        }

        public static string GetFilesOutputFolderFullPath()
        {
            return Path.Combine(GetFilesFolderFullPath(), FILES_OUTPUT_FOLDERNAME);
        }

        public static string GetFilesOutputFileFullPath(string filename)
        {
            return Path.Combine(GetFilesOutputFolderFullPath(), filename);
        }

        public static string GetFilesInputFolderFullPath()
        {
            return Path.Combine(GetFilesFolderFullPath(), FILES_INPUT_FOLDERNAME);
        }

        public static string GetFilesInputFileFullPath(string filename)
        {
            return Path.Combine(GetFilesInputFolderFullPath(), filename);
        }

        public static FileInfo GetOutputFile(string filename)
        {
            string FullpathOutputDirectory = GetFilesOutputFolderFullPath();

            if (Directory.Exists(FullpathOutputDirectory) == false)
            {
                Directory.CreateDirectory(FullpathOutputDirectory);
            }

            string fullPathFile = GetFilesOutputFileFullPath(filename);

            return new FileInfo(fullPathFile);
        }

        public static void ClearOutputFolder()
        {
            string FullpathOutputDirectory = GetFilesOutputFolderFullPath();
            DirectoryInfo di = new DirectoryInfo(FullpathOutputDirectory);
            FileInfo[] fis = di.GetFiles();

            for (int i = 0; i < fis.Length; i++)
            {
                File.Delete(fis[i].FullName);
            }
        }

        public static void DeleteOutputFolder()
        {
            ClearOutputFolder();
            string FullpathOutputDirectory = GetFilesOutputFolderFullPath();
            if (Directory.Exists(FullpathOutputDirectory) == true)
            {
                Directory.Delete(FullpathOutputDirectory);
            }
        }

        public static FileInfo GetInputFile(string filename)
        {
            return new FileInfo(GetFilesInputFileFullPath(filename));
        }

        public static void DeleteOutputFile(String filename)
        {
            String fullPathFile = GetFilesOutputFileFullPath(filename);
            if (File.Exists(fullPathFile) == true)
            {
                File.Delete(fullPathFile);
            }
        }

        public static String GetInputText(String filename)
        {
            return File.ReadAllText(GetFilesInputFileFullPath(filename));
        }

        public static String[] GetInputLines(String filename)
        {
            return File.ReadLines(GetFilesInputFileFullPath(filename)).ToArray();
        }

        public static IniSharp LoadWithFileName(String filename, IniConfig config)
        {
            IniSharp iniSharp = new IniSharp(GetFilesInputFileFullPath(filename), config);
            iniSharp.Read();
            return iniSharp;
        }

        public static IniSharp LoadWithFileName(FileInfo fi, IniConfig config)
        {
            IniSharp iniSharp = new IniSharp(fi.FullName, config);
            //iniSharp.Config =  config;
            iniSharp.Read();
            return iniSharp;
        }

        public static IniSharp LoadWithAllText(String filename, IniConfig config)
        {
            IniSharp iniSharp = new IniSharp(config);

            iniSharp.Read(File.ReadAllText(GetFilesInputFileFullPath(filename)));
            return iniSharp;
        }

        public static IniSharp LoadWithAllLines(String filename, IniConfig config)
        {
            IniSharp iniSharp = new IniSharp(config);

            iniSharp.Read(File.ReadAllLines(GetFilesInputFileFullPath(filename)));
            return iniSharp;
        }

        public static Boolean TestActual001(IniSharp iniSharp)
        {
            return iniSharp.Success;
        }

        public static Boolean TestActual002(IniSharp iniSharp)
        {
            Boolean actual = (iniSharp.Body[0].Name == "SEZIONE_1") &&
                                (iniSharp.Body[1].Name == "SEZIONE_2") &&
                                (iniSharp.Body[2].Name == "SEZIONE_3") &&
                                (iniSharp.Body[3].Name == "SEZIONE_4") &&
                                (iniSharp.Body[4].Name == "SEZIONE_5");

            return actual;
        }

        public static Boolean TestActual003(IniSharp iniSharp)
        {
            Boolean actual = (iniSharp.Body[0].Fields[0].Name == "campo001") &&
                                (iniSharp.Body[0].Fields[1].Name == "Campo2") &&
                                (iniSharp.Body[1].Fields[0].Name == "Campo2") &&
                                (iniSharp.Body[1].Fields[1].Name == "campo4") &&
                                (iniSharp.Body[2].Fields.Count == 0) &&
                                (iniSharp.Body[3].Fields.Count == 0) &&
                                (iniSharp.Body[4].Fields[0].Name == "campo6");

            return actual;
        }

        public static Boolean TestActual004(IniSharp iniSharp)
        {
            Boolean actual = (iniSharp.Body[0].Fields[0].Lines[0] == "valore1") &&
                                (iniSharp.Body[0].Fields[1].Lines[0] == "valore002") &&
                                (iniSharp.Body[1].Fields[0].Lines[0] == "valore002") &&
                                (iniSharp.Body[1].Fields[0].Lines[1] == "valoreacapo") &&
                                (iniSharp.Body[1].Fields[1].Lines[0] == "") &&
                                (iniSharp.Body[4].Fields[0].Lines[0] == "000");

            return actual;
        }

        public static IniConfig Config()
        {
            return new IniConfig();
        }
    }
}