
using System;


//namespace EDexamenT6a8


namespace Deposito
{
    /// <summary>
    ///     <para>Clase que representa la gestión de los depósitos de una granja.
    ///         <list type="bullet">
    ///             <item>
    ///                 <description>Tiene dos depósitos: pienso y agua.</description>
    ///             </item>
    ///             <item>
    ///                 <description>La propiedad devuelve el nivel de agua y pienso.</description>
    ///             </item>
    ///              <item>
    ///                 <description>Los métodos permiten reponer o consumir tanto pienso como agua.</description>
    ///             </item>
    ///         </list>
    ///     </para>
    /// </summary>
    class Deposito
    {
        private double NivelDeAgua;
        private double NivelDePienso;
        private double CantidadMaximaAgua;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private double CantidadMaximaPienso;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        public double Niveldeagua
        {
            get { return NivelDeAgua; }
        }

        public double Niveldepienso
        {
            get { return NivelDePienso; }
        }

        /// <summary>
        /// He cambiado los nombres de todas las variables unas las he cambiado a estilo PasCal para que
        /// sean más legibles y otras he modificado el nombre para saber cual es su referencia como es el caso de
        /// <paramref name="CantidadMaximaAgua"></paramref> junto a que también he cambiado el tipo de variable que estaba establecido
        /// como 'decimal' a 'double' ya que decimal no era correcto. En referencia al ejercicio 3 aparte de cambiar 
        /// </summary>
        /// <remarks>Tamaño del depósito de agua es de 10000 l.</remarks>
        /// <param name="CantidadAReponerDeAgua"></param>
        public void FReponerAgua(double CantidadAReponerDeAgua)
        {
            CantidadMaximaAgua = CantidadAReponerDeAgua + NivelDeAgua;
            if (CantidadAReponerDeAgua > 0 && CantidadMaximaAgua < 10000)
            {
                NivelDeAgua = NivelDeAgua + CantidadAReponerDeAgua;
            }           
        }

        /// <summary>
        /// He cambiado los nombres de todas las variables unas las he cambiado a estilo PasCal para que
        /// sean más legibles y otras he modificado el nombre para saber cual es su referencia como es el caso de
        /// <paramref name="CantidadMaximaPienso"></paramref> junto a que también he cambiado el tipo de variable que estaba establecido
        /// como 'decimal' a 'double' ya que decimal no era correcto.
        /// </summary>
        /// <remarks>Tamaño del depósito de pienso es de 5000 kg.</remarks>
        /// <param name="CantidadAReponerDePienso"></param>
        public void FReponerPienso(double CantidadAReponerDePienso)
        {
            CantidadMaximaPienso = CantidadAReponerDePienso + NivelDePienso;
            if (CantidadAReponerDePienso > 0 && CantidadMaximaPienso < 5000)
            {
                NivelDePienso = NivelDePienso + CantidadAReponerDePienso;
            }              
        }

        /// <summary>
        /// He cambiado los nombres de todas las variables unas las he cambiado ha estilo PasCal para que
        /// sean más legibles y otras he modificado el nombre para saber cual es su referencia como es el caso de
        /// <paramref name="AguaRetirada"></paramref> también he cambiado el tipo de variable que estaba establecido
        /// como 'decimal' a 'double' ya que decimal no era correcto.
        /// </summary>
        /// <param name="CantidadARetirarDeAgua"></param>
        /// <returns> Devuelve la cantidad de agua que ha sido retirada. <paramref name="AguaRetirada"></paramref></returns>
        public double FConsumoAgua(double CantidadARetirarDeAgua)
        {
            double AguaRetirada = 0;
            if (CantidadARetirarDeAgua > 0 && CantidadARetirarDeAgua <= NivelDeAgua)
            {
                AguaRetirada = CantidadARetirarDeAgua;
                NivelDeAgua = NivelDeAgua - CantidadARetirarDeAgua;
            }
            return AguaRetirada;
        }

        /// <summary>
        /// He cambiado los nombres de todas las variables unas las he cambiado ha estilo PasCal para que
        /// sean más legibles y otras he modificado el nombre para saber cual es su referencia como es el caso de
        /// <paramref name="PiensoRetirado"></paramref> también he cambiado el tipo de variable que estaba establecido
        /// como 'decimal' a 'double' ya que decimal no era correcto.
        /// </summary>
        /// <param name="CantidadARetirarDePienso"></param>
        /// <returns> Devuelve la cantidad de pienso que ha sido retirada. <paramref name="PiensoRetirado"></paramref> </returns>
        public double FConsumoPienso(double CantidadARetirarDePienso)
        {
            double PiensoRetirado = 0;
            if (CantidadARetirarDePienso > 0 && CantidadARetirarDePienso <= NivelDePienso)
            {
                PiensoRetirado = CantidadARetirarDePienso;
                NivelDePienso = NivelDePienso - CantidadARetirarDePienso;
            }
            return PiensoRetirado;
        }
    }
}