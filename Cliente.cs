using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2U3_NumeroControlED3B
{
    internal class Cliente
    {
        

        public int NumTurno { get; set; }
        public int NumCliente { get; set; }
        public string Nombre { get; set; }
        public  string Operacion{ get; set; }
        public DateTime HoraLLegada { get; set; }

        public Cliente(int numTurno, int numCliente, string nombre, string operacion, DateTime horaLLegada)
        {
            NumTurno = numTurno;
            NumCliente = numCliente;
            Nombre = nombre;
            Operacion = operacion;
            HoraLLegada = horaLLegada;
        }

    }
}
