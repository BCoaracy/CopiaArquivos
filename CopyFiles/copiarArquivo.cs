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
        static string sourcePath = @"N:\Arquivos temporários\NectarECF\ArquivosAtualizacao\";
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

        public void executarCopia(List<int> empresasList)
        {
            string caminho;
            string pastaEmpresa;
            caminho = getCaminho();
            foreach (var EMPRESA in empresasList)
            {
                string novoCaminho = caminho + EMPRESA;
                if (!Directory.Exists(novoCaminho))
                {
                    Directory.CreateDirectory(novoCaminho);
                }
                System.IO.File.Copy(novoCaminho, getSourceFile());
            }
            
        }

        public void executarCopia(string numEmpresa)
        {
            string caminho;
            caminho = getCaminho();
            string novoCaminho = caminho + numEmpresa;
            if (!Directory.Exists(novoCaminho))
            {
                Directory.CreateDirectory(novoCaminho);
            }
            string sFile = getSourceFile();
            System.IO.File.Copy(novoCaminho, sFile, true);
        }
        
    }

}
