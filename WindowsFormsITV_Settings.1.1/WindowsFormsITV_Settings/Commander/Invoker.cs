using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsITV_Settings.Commander
{
    class Invoker
    {
	   ICommand command;
 
    public Invoker() { }
 
    public void SetCommand(ICommand com)
    {
        command = com;
    }
 
    public void PressButton()
    {
        command.Execute();
    }
    public void PressUndo()
    {
        command.Undo();
    }
    }
}
