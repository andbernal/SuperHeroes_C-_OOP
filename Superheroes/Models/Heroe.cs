using System.Dynamic;
using System.Text;


namespace Superheroes.app.Models
{
    internal abstract class Heroe
    {
        public abstract string Name {get; set;}
        public abstract string SalvarElMundo ();

        public virtual string SalvarLaTierra()
        {
            return $"{Name} ha salvado la tierra";

        }
    }

}