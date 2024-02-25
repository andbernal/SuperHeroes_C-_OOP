using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Superheroes.interfaces;


namespace Superheroes.app.Models
{
    internal class SuperHeroe : Heroe, ISuperHeroe
    {
    public int id {get; set;}= 1;

    private string _Name;
    public override string Name
    {
        get
        {
            return _Name;

        }
        set
        {
            _Name = value.Trim();
        }
    }

    public string NombreEIdentidadSecreta
    {
        get
        {
            return $"{Name} ({IdentidadSecreta})";
        }
    }
    public string IdentidadSecreta {get; set;}
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Ciudad;
    public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
    public bool PuedeVolar;

    public SuperHeroe()
    {
        id=1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
        UsarSuperPoderes();
    }
    internal string UsarSuperPoderes()
    {
        StringBuilder sb =new StringBuilder();
        foreach(var item in SuperPoderes)
        {
            sb.AppendLine($"{NombreEIdentidadSecreta} esta utilizando el super poder {item.Nombre}");
        }
        return sb.ToString();
    }
        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }
}