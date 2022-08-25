using System;

namespace InternetExplorerLauncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type IEType = Type.GetTypeFromProgID("InternetExplorer.Application");
            dynamic IEInst = Activator.CreateInstance(IEType);
            IEInst.Visible = true;
            if (args.Length > 0)
            {
                string URL = args[0];
                IEInst.Navigate(ref URL);
            }
            else 
            {
                IEInst.GoHome();
            }
        }
    }
}
