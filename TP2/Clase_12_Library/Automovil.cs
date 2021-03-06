﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Clase_12_Library_2;
namespace Clase_12_Library
{
    public class Automovil:Vehiculo
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Automovil.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Automovil( EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
        }
        /// <summary>
        /// Los automoviles tienen 4 ruedas
        /// </summary>
        public override short CantidadRuedas
        {
            get
            {
                return 4;
            }
            set
            {
            }
        }
        /// <summary>
        /// Mostrara la informacion del Automovil: Patente, color, marca y cantidad de ruedas.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("RUEDAS : {0}", this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
