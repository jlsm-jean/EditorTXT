using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXT_EDITOR
{
    public static class Gerenciador
    {
        // Valores Padrão
        public static string DefaulFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";

        public static string DefaulFileName => "arquivos";
        public static string DefaulFileExt => ".txt";
        
        // Valores Atribuidos ao uso
        public static string FolderPath { get; set; } = DefaulFolderPath;
        public static string FileName { get; set; } = DefaulFileName;
        public static string FileExt { get; set; } = DefaulFileExt;
        public static string FilePath => FolderPath + FileName + FileExt;
    }
}
