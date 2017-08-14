using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFiles
{
    class copiarArquivo
    {
        
        static string nomeArquivo = "NectarECF 5.0.3.37 Update.exe";
        static string sourcePath = @"N:\Arquivos temporários\NectarECF";
        static string targetPath = @"N:\Download para clientes\";
        string caminho = targetPath;

        string sourceFile = System.IO.Path.Combine(sourcePath, nomeArquivo);
        string destFile = System.IO.Path.Combine(targetPath, nomeArquivo);

        public string getSourceFile()
        {
            sourceFile = this.sourceFile;
            return sourceFile;
        }

        public string getDestFile()
        {
            destFile = this.destFile;
            return destFile;
        }

        public string getCaminho()
        {
            caminho = this.caminho;
            return caminho;
        }

        public void executarCopia()
        {
            string caminho;
            string pastaEmpresa;
            caminho = getCaminho();

            if (!Directory.Exists(getCaminho()))
            {
                Directory.CreateDirectory(getCaminho());
            }
            System.IO.File.Copy(getSourceFile(), caminho);
        }
        
    }

}
