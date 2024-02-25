using Superheroes.app.Models;
using Superheroes.app;
using Superheroes;

var imprimirInfo = new ImprimirInfo();


var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de deplazarse por el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Fuerza Extrema";
superFuerza.Nivel = NivelPoder.NivewlTres;

var visionNocturna = new SuperPoder();
visionNocturna.Nombre = "Visión Nocturna";
visionNocturna.Descripcion = "Poder de ver en la noche";
visionNocturna.Nivel = NivelPoder.NivewlTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneracion";
regeneracion.Descripcion = "Poder de regenerar sus partes";
regeneracion.Nivel = NivelPoder.NivewlTres;

var superman = new SuperHeroe();
superman.id =1;
superman.Name = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);
string resultSalvarLaTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarLaTierra);



var wolverine = new AntiHeroe();
wolverine.id = 5;
wolverine.Name = "Wolvering";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiheroe = wolverine.RealizarAccionDeAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivewlTres
}

public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);





/*
var BatMan = new SuperHeroe();

BatMan.id = 2;

BatMan.Name = "BatMan";

BatMan.IdentidadSecreta = "Bruno Días";

BatMan.Ciudad = "Gotica";

BatMan.PuedeVolar = false;

List<SuperPoder> poderesBatman = new List<SuperPoder>();
poderesBatman.Add(visionNocturna);

BatMan.SuperPoderes = poderesBatman;
*/