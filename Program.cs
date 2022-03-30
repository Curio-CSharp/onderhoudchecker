using System;
using System.Collections.Generic;

var attracties = new List<Attractie>();

attracties.Add(new Attractie
{
    Naam = "Debug Hero",
    Soort = "Achtbaan",
    BezoekersPerJaar = 11000,
    LaatsteOnderhoud = 320
});

attracties.Add(new Attractie
{
    Naam = "Bugs of Horror",
    Soort = "Achtbaan",
    BezoekersPerJaar = 9900,
    LaatsteOnderhoud = 430
});

attracties.Add(new Attractie
{
    Naam = "Fun Splash",
    Soort = "Water",
    BezoekersPerJaar = 20000,
    LaatsteOnderhoud = 100
});

attracties.Add(new Attractie
{
    Naam = "Turbo Turn 2000",
    Soort = "Water",
    BezoekersPerJaar = 8500,
    LaatsteOnderhoud = 260
});


attracties.Add(new Attractie
{
    Naam = "Magic Programmer",
    Soort = "Darkride",
    BezoekersPerJaar = 12500,
    LaatsteOnderhoud = 85
});


attracties.Add(new Attractie
{
    Naam = "Kids Park",
    Soort = "Anders",
    BezoekersPerJaar = 2100,
    LaatsteOnderhoud = 600
});

var attractionsWhichNeedConstruction = attracties.FindAll(a =>
    a.LaatsteOnderhoud > 500 ||
    (a.BezoekersPerJaar > 10000 && a.LaatsteOnderhoud > 300) ||
    (a.Soort == "Water" && a.LaatsteOnderhoud > 200)
   );

foreach (var attractie in attractionsWhichNeedConstruction)
{
    Console.WriteLine("{0} (soort: {1}) moet onderhouden worden", attractie.Naam, attractie.Soort);
    Console.WriteLine("{0} bezoekers per jaar", attractie.BezoekersPerJaar);
    Console.WriteLine("Laatste onderhoud: {0} dagen geleden", attractie.LaatsteOnderhoud);
    Console.WriteLine();
    Console.WriteLine("Druk een toets in om door te gaan");
    Console.ReadKey();
}