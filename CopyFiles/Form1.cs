using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFiles
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var oCopiarArquivo = new copiarArquivo();

            if (empresasNFCE.Checked)
            {
                
            }

            oCopiarArquivo.executarCopia();

        }

        private void empresasNFCE_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
