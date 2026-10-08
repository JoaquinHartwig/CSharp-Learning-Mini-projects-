using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignaG1_Hartwig_Joaquín
{
    public class Paciente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Prioridad { get; set; }

        public override string ToString()
        {
            return $"DNI: {DNI} - {Nombre} ({Prioridad})";
        }
    }
}
