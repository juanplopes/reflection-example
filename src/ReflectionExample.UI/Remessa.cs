using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionExample.UI
{
    public class Remessa
    {
        [Field(1, 5)]
        public int BancoOrigem { get; set; }
        [Field(6, 10)]
        public int AgenciaOrigem { get; set; }
        [Field(11, 20)]
        public int ContaOrigem { get; set; }

        [Field(21, 25)]
        public int BancoDestino { get; set; }
        [Field(26, 30)]
        public int AgenciaDestino { get; set; }
        [Field(31, 40)]
        public int ContaDestino { get; set; }

        [Field(41, 50)]
        public decimal Valor { get; set; }
        [DateField(51, 58, "ddMMyyyy")]
        public DateTime Data { get; set; }
    }
}
