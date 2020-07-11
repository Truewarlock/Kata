using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1.ProductionCode
{
    internal class Greeting
    {
        public Greeting()
        {
        }
        internal string Greet(string[] name)
        {
            if ((name == null) || (name.Length == 0))
            {
                return "Hello, my friend.";
            }
            if (name.GetLength(0) == 1)
            {
                if (name[0] == name[0].ToUpper())
                {
                    return $"HELLO, {name[0].ToUpper()}!";
                }
                return $"Hello, {name[0]}.";
            }
            else {
                string aux = "Hello, ";
                string[] upper = new string[name.GetLength(0)];
                int upprNr = 0;
                for (int i = 0; i < name.GetLength(0); i++)
                {
                    if (name[i]== name[i].ToUpper())
                    {
                        upper[upprNr] = name[i];
                        upprNr += 1;
                    }
                    else {
                        if (i == 0)
                        {
                            aux = aux + name[i];
                        }
                        if ((i == name.GetLength(0) - 1))
                        {
                            aux = aux + " and " + name[i];
                        }
                        if ((i != 0) && (i != name.GetLength(0) - 1))
                        {
                            aux = aux + ", " + name[i];
                        }
                    }

                }
                if (upprNr > 0)
                { aux = aux + ".";
                    for (int i = 0; i<upprNr;i++)
                        {
                        aux = aux + " AND " + upper[i];
                        }
                    aux = aux + "!";
                }
                
                return aux;
                
            }
            return "Ce naiba nu merge";
        }

    }


}


