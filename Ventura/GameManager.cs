using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventura
{
    public class GameManager
    {

        static private GameManager instance;
        public static GameManager Instance = instance ??= new GameManager();


        public void IniciaMenu()
        {
            MenuGame.Instance.ChamaMenu();
        }
    }
}
