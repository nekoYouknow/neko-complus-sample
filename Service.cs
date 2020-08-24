
//A
using System.EnterpriseServices;
using System.Runtime.InteropServices;

//B
[assembly: ApplicationName("NEKO")]
[assembly: ApplicationActivation(ActivationOption.Server)]
namespace NekoComPlus
{
    //C
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]

    //D : extend ServicedComponent
    public class Service : ServicedComponent      
    {
        public string Hello(string name)
        {
            return "Hello " + name;
        }
    }
}
