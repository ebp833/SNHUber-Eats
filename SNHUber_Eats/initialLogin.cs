using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SNHUber_Eats
{
    class initialLogin
    {
        public initialLogin(string a)
        {
            File.AppendAllText(@"User_Info.txt", a);
        }
    }
}
