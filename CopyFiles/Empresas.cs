using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CopyFiles
{
    class Empresas 
    {
        /*public void gravarArquivo(string nomeArquivo, List<int> lista)
        {
            FileStream file = new FileStream(nomeArquivo, FileMode.Append);
            BinaryWriter bw = new BinaryWriter(file);
            bw.Write();
            bw.Close();

        }*/
        public List<int> empresasECF = new List<int>();

        public void AddEmpresa(List<int> empresas, int numEmpresa)
        {
            empresas.Add(numEmpresa);
        }

        public void RemoveEmpresa(List<int> empresas, int numEmpresa)
        {
            empresas.Remove(numEmpresa);
        }


    }
}
