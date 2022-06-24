using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrito
{

    public class MCQUEEN
    {
        public String marca { get; set; }  //Getters and Setters
        public String matricula { get; set; }
        public int anio { get; set; }
        
        public MCQUEEN () { } //CONSTRUCTORES DE LA CLASE POR DEFECTO

        public MCQUEEN (String marca, String matricula, int anio) //CONSTRUCTORES DE LA CLASE
        {
            this.marca = marca;
            this.matricula = matricula;
            this.anio = anio;

        }

        
        public String Mostrar()
        {
            return "Marca: " + marca + "Matricula: " + matricula + "Anio " + anio;
        }



        class Class1
        {
        }
    }
}
