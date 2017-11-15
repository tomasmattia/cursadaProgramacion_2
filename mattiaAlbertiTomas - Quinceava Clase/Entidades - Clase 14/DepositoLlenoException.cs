using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades___Clase_14
{
    public class DepositoLlenoException:Exception
    {
        public override string Message
        {
	        get 
	        { 
		        return "El deposito esta lleno";
	        }
        }
    }
}
