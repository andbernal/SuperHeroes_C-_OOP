namespace Superheroes.app.Models
{
    internal class SuperPoder
    {public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}
}