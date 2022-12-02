using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente : Persona
    {
        string diagnostico;
        int diasIngresado;
        string pronostico;
        List<string> pruebasMedicas;

        public Paciente(string diagnostico, int diasIngresado, string pronostico, List<string> pruebasMedicas)
        {
            this.diagnostico = diagnostico;
            this.diasIngresado = diasIngresado;
            this.pronostico = pronostico;
            this.pruebasMedicas = pruebasMedicas;
        }
    }
}
