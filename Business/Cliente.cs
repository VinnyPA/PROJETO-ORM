﻿using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD =true, UsaBusca = true)]
        public int ID { get; set; }
        [OpcoesBase(UsaBD =true)]
        public string Nome { get; set; }
        [OpcoesBase(UsaBD =true)]
        public string Celular { get; set; }
        [OpcoesBase(UsaBD =true)]
        public string CPF { get; set; }

    }
}
