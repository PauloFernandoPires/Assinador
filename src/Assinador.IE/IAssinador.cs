using System.Runtime.InteropServices;

namespace Assinador.IE
{
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("197246E3-D11D-419B-BA9F-4F419D1B339F")]
    public interface IAssinador
    {
        string SayHello();
    }
}
