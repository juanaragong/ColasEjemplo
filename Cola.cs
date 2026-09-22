using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2U3_NumeroControlED3B
{
    internal class Cola
    {
        int frente;
        int final;
        int max;
        Cliente[] clientes;

        public Cola(int tamanio)
        {
            frente = -1;
            final = -1;
            max = tamanio;
            clientes = new Cliente[max];
        }

        public bool EstaVacio()
        {
            if (frente == -1)
                return true;
            else
                return false;

        }
        public bool EstaLleno()
        {
            return final == max - 1;
        }

        public Cliente[] Encolar(Cliente clientito)
        {
            if (!EstaLleno())
            {
                final++;
                clientes[final] = clientito;
                if (final == 0)
                {
                    frente = final;
                }
                return clientes;
            }
            else
            {
                MessageBox.Show("La cola esta llena");
                return null;
            }

        }

        public Cliente[] DesEncolar()
        {
            if (!EstaVacio())
            {
                clientes[frente] = null;
                if (frente == final)
                {
                    frente = -1;
                    final = -1;
                   
                }
                else
                {
                   
                    frente++;
                    
                }
                return clientes;
            }

            return null;
        }
    }
}
  
