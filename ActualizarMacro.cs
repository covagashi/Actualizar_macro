//Eplan electric

using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        CommandLineInterpreter oCLI = new CommandLineInterpreter();     

        oCLI.Execute("XGedUpdateMacroAction");

        return;
    }
}



