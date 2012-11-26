using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTTANE
{
    class InvalidMoveException : System.Exception
    {
        public InvalidMoveException(string format, params object[] args) :base(string.Format(format, args))
        {
            //Ef við erum komin hingað þá var nú þegar 'X' eða 'O' í reitnum sem um var beðið
        }
        
    }
}
