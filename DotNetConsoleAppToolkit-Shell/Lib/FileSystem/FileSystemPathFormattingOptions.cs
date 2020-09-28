﻿using DotNetConsoleAppToolkit.Console;

namespace DotNetConsoleAppToolkit.Lib.FileSystem
{
    public class FileSystemPathFormattingOptions : FormattingOptions
    {
        public bool PrintAttributes = true;
        public bool ShortPath = false;
        public string Prefix = "";
        public string Postfix = "";
        public int PaddingRight = -1;
        public string LinePrefix = "";

        public FileSystemPathFormattingOptions() { }

        public FileSystemPathFormattingOptions(
            bool printAttributes=true,
            bool shortPath=false,
            string prefix="",
            string postfix="",
            int paddingRight=-1,
            string linePrefix="")
        {
            PrintAttributes = printAttributes;
            ShortPath = shortPath;
            Prefix = prefix;
            Postfix = postfix;
            PaddingRight = paddingRight;
            LinePrefix = linePrefix;
        }
    }
}
