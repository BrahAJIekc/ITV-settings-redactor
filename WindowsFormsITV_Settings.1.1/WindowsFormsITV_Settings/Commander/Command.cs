using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsITV_Settings.Commander
{
    class Command:ICommand
    {
	   Receiver r;
	    public Command(Receiver Set)
    {
        r = Set;
    }
    public void Execute()
    {
        r.Operation();
    }
    public void Undo()
    {}

    }
}
