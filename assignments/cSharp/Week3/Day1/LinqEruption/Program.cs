﻿List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
//PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");


// Use LINQ to find the first eruption that is in Chile and print the result.
Eruption? firstInChile = eruptions.FirstOrDefault(e => e.Location == "Chile");
//Console.WriteLine(firstInChile);

// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? firstInHawaii = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
if(firstInHawaii is not null ){
   //Console.WriteLine(firstInHawaii);
}

// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption? firstAfter1900 = eruptions.FirstOrDefault(e => e.Year > 1900);
//Console.WriteLine(firstAfter1900);

// Find all eruptions where the volcano's elevation is over 2000m and print them.
List<Eruption> elevationOver2000 = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
//PrintEach(elevationOver2000);

// Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
List<Eruption> startsWithL = eruptions.Where(e => e.Volcano.StartsWith('L')).ToList();
// PrintEach(startsWithL);
// System.Console.WriteLine(startsWithL.Count + " eruptions found");

// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int maxElevation = eruptions.Max(e => e.ElevationInMeters);
// System.Console.WriteLine($"the highest elevation is {maxElevation}");

// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
string nameMaxElevation = eruptions.FirstOrDefault(e => e.ElevationInMeters == maxElevation).Volcano;
// Console.WriteLine(nameMaxElevation);

// Print all Volcano names alphabetically.
List<string> namesAlphabetically = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
// PrintEach(namesAlphabetically);

// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
List<Eruption> before1000Alpha = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).ToList();
// PrintEach(before1000Alpha);

// BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> before1000AlphaNames = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
PrintEach(before1000AlphaNames);

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

