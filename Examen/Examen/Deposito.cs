
using System;


//namespace EDexamenT6a8


namespace Deposito
{
    /*Clase que representa la gestión de los depósitos de una granja.
     * Tiene dos depósitos: pienso y agua. 
     * La propiedad devuelve el nivel de agua y pienso. 
     * Los métodos permiten reponer o consumir tanto pienso como agua.
     * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
     */
    class Deposito
    {
        private decimal NivelDeAgua;
        private decimal NivelDePienso;
        private decimal CantidadMaxima;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal CantidadMaxima2;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        public decimal Niveldeagua
        {
            get { return NivelDeAgua; }
        }

        public decimal Niveldepienso
        {
            get { return NivelDePienso; }
        }

        public void FReponerAgua(decimal CantidadAReponerDeAgua)
        {
            CantidadMaxima = CantidadAReponerDeAgua + NivelDeAgua;
            if (CantidadAReponerDeAgua > 0 && CantidadMaxima < 10000)
            {
                NivelDeAgua = NivelDeAgua + CantidadAReponerDeAgua;
            } //Tamaño del depósito de pienso es de 1000 l.           
        }

        public void FReponerPienso(decimal CantidadAReponerDePienso)
        {
            CantidadMaxima2 = CantidadAReponerDePienso + NivelDePienso;
            if (CantidadAReponerDePienso > 0 && CantidadMaxima2 < 5000)
            {
                NivelDePienso = NivelDePienso + CantidadAReponerDePienso;
            } //Tamaño del depósito de pienso es de 5000 kg.                
        }

        public decimal FConsumoAgua(decimal CantidadARetirarDeAgua)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (CantidadARetirarDeAgua > 0 && CantidadARetirarDeAgua <= NivelDeAgua)
            {
                retirado1 = CantidadARetirarDeAgua;
                NivelDeAgua = NivelDeAgua - CantidadARetirarDeAgua;
            }
            return retirado1;
        }

        public decimal FConsumoPienso(decimal CantidadARetirarDePienso)
        {
            decimal retirado2 = 0; //Cantidad que se retira
            if (CantidadARetirarDePienso > 0 && CantidadARetirarDePienso <= NivelDePienso)
            {
                retirado2 = CantidadARetirarDePienso;
                NivelDePienso = NivelDePienso - CantidadARetirarDePienso;
            }
            return retirado2;
        }
    }
}