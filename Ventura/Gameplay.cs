using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventura
{
    public class Gameplay
    {
        private static Gameplay instancia;

        private Gameplay() { }

        public static Gameplay Instance => instancia ??= new Gameplay();

        
    }
}
