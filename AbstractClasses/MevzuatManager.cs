using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class MevzuatManager
    {
        public void Kaydet(MevzuatBase mevzuatBase)
        {
            mevzuatBase.Kaydet();
        }
    }
}
