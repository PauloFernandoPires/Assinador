using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Assinador.IE
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("14BF9A73-81FB-479B-89BD-E83337ED5B22")]
    [ProgId("Assinador.IE")]
    public class Assinador : IAssinador, IObjectSafety
    {
        [Flags]
        public enum ObjectSafetyOptions
        {
            INTERFACESAFE_FOR_UNTRUSTED_CALLER = 0x00000001,
            INTERFACESAFE_FOR_UNTRUSTED_DATA = 0x00000002,
            INTERFACE_USES_DISPEX = 0x00000004,
            INTERFACE_USES_SECURITY_MANAGER = 0x00000008
        };

        public string SayHello()
        {
            var teste = new teste();
            teste.Show();
            return "Hello World 2!";
        }

        public int GetInterfaceSafetyOptions(ref Guid riid, out int pdwSupportedOptions, out int pdwEnabledOptions)
        {
            ObjectSafetyOptions m_options = ObjectSafetyOptions.INTERFACESAFE_FOR_UNTRUSTED_CALLER | ObjectSafetyOptions.INTERFACESAFE_FOR_UNTRUSTED_DATA;
            pdwSupportedOptions = (int) m_options;
            pdwEnabledOptions = (int) m_options;
            return 0;
        }

        public int SetInterfaceSafetyOptions(ref Guid riid, int dwOptionSetMask, int dwEnabledOptions)
        {
            return 0;
        }
    }
}
