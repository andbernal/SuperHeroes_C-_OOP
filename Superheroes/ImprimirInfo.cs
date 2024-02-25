using System.Text;
using Superheroes.app.Models;
using Superheroes.interfaces;

namespace Superheroes
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Name}");
            Console.WriteLine($"Identificación Secreta: {superHeroe.IdentidadSecreta}");

        }
    }
}