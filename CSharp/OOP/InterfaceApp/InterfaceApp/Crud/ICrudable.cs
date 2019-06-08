using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
     interface ICrudable
    {
        void CreateDb();
        void ReadDb();
        void UpdateDb();
        void DeleteDb();
    }
}
