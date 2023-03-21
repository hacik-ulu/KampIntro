using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesReCapCalısma
{
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
