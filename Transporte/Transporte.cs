﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public abstract class Transporte : ITransporte
    {

        private int cantPasajeros;
        private string tipo;

        public Transporte(int cantPasajeros, string tipo) {

            this.cantPasajeros = cantPasajeros;
            this.tipo = tipo;
        
        }

        public int CantPasajeros() {

            return cantPasajeros;
        }

        public string Tipo()
        {

            return tipo;
        }


        public abstract string Avanzar();
        public virtual string Detenerse() {

            return "Me estoy deteniendo";
        
        }

    }
}
