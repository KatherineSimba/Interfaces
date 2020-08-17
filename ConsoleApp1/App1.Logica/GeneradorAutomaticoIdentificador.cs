using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace App1.Logica
{
    public class GeneradorAutomaticoIdentificador
    {
        readonly Random random = new Random();

        public int Id { get; set; }
        public GeneradorAutomaticoIdentificador()
        {
            Id = random.Next();
        }

    }
}
