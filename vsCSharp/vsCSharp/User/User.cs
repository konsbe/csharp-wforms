using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsCSharp
{
    public class User : IUser
    {
        string IUser.userName(string name)
        {
            name = "Babis";
            return name;
        }

        void IUser.userMsg()
        {
            throw new NotImplementedException();
        }
    }
}
