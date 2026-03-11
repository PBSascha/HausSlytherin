// Berechne den Durchschnitt der Gefahrenstufe aller Kreaturen
double averageDanger = creatures.Average(c => c.DangerLevel);

// Finde die gefährlichste Kreatur
Creature mostDangerous = creatures.OrderByDescending(c => c.DangerLevel).First();
//oder
Creature mostDangerous = creatures.MaxBy(c => c.DangerLevel);

//Filtere alle Kreaturen mit einer Gefahrenstufe über 7
var dangerousCreatures = creatures.Where(c => c.DangerLevel > 7).ToList();

//Kreaturen nach Name sortieren
var sortedCreatures = creatures.OrderBy(c => c.Name).ToList();
