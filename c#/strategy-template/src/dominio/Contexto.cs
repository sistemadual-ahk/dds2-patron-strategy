using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_template.src.dominio
{
    using estrategias;
    class Contexto
    {
        private Estrategia estrategia;

        public void actuar()
        {
            this.estrategia.ejecutar();
        }

        public void cambiarEstrategia(Estrategia estrategia)
        {
            this.estrategia = estrategia;
        }
    }
}
