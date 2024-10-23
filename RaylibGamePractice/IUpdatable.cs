using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaylibGamePractice
{
    internal interface IUpdatable
    {
        public static List<IUpdatable> updatables = new List<IUpdatable>();
        public void Update();
    }
}
