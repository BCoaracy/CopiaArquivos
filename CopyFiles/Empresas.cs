﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFiles
{
    class Empresas
    {
        List<int> empresasECF = new List<int>();

        public void addEmpresa(List<int> empresas, int numEmpresa)
        {
            empresas.Add(numEmpresa);
        }

    }
}