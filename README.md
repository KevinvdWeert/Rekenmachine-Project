# Rekenmachine in C#

Deze eenvoudige rekenmachine is een consoletoepassing geschreven in C#. Het programma biedt ondersteuning voor basisbewerkingen zoals optellen, aftrekken, vermenigvuldigen en delen. Kommagetallen worden ondersteund, en de gebruiker kan meerdere berekeningen uitvoeren in dezelfde sessie.

## Functies
- Ondersteunt de volgende bewerkingen:
  - **+** (optellen)
  - **-** (aftrekken)
  - **x** (vermenigvuldigen)
  - **:** (delen)
- Mogelijkheid om kommagetallen in te voeren (gebruik een `,` als decimaalteken).
- Meerdere berekeningen uitvoeren in een enkele sessie.
- Eenvoudige en intuïtieve gebruikersinterface in de console.

## Hoe te gebruiken
1. Start de toepassing.
2. Voer het eerste getal in (bijvoorbeeld: `10` of `3,5`).
3. Kies de gewenste bewerking (`+`, `-`, `x`, `:`).
4. Voer het tweede getal in.
5. Het resultaat wordt weergegeven.
6. Kies of u een nieuwe berekening wilt uitvoeren.

## Vereisten
- .NET Framework of .NET Core (met ondersteuning voor C#).
- Een C# compiler (bijvoorbeeld Visual Studio of een andere IDE).

## Installatie
1. Clone deze repository:
   ```bash
   git clone https://github.com/<gebruikersnaam>/rekenmachine.git
   ```
2. Open het project in een C# IDE zoals Visual Studio.
3. Compileer en voer het project uit.

## Code-uitleg
Het programma gebruikt een **while-loop** om meerdere berekeningen mogelijk te maken binnen een enkele sessie. Invoer wordt gelezen met `Console.ReadLine()` en verwerkt met `double.Parse()`. De operator wordt gecontroleerd via een `if-else` structuur.

### Belangrijkste codefragmenten
**Rekenkundige bewerkingen:**
```csharp
if (Input2 == "+")
{
    Console.WriteLine($"Resultaat: {getal1 + getal2}");
}
else if (Input2 == ":")
{
    Console.WriteLine($"Resultaat: {getal1 / getal2}");
}
else if (Input2 == "-")
{
    Console.WriteLine($"Resultaat: {getal1 - getal2}");
}
else if (Input2 == "x")
{
    Console.WriteLine($"Resultaat: {getal1 * getal2}");
}
```
**Ondersteuning voor kommagetallen:**
```csharp
double getal1 = double.Parse(Console.ReadLine().Replace('.', ','));
double getal2 = double.Parse(Console.ReadLine().Replace('.', ','));
```

## Toekomstige verbeteringen
- Ondersteuning voor complexere berekeningen (bijvoorbeeld machten of wortels).
- Foutafhandeling voor ongeldige invoer.
- Ondersteuning voor meerdere berekeningen in één invoer (bijvoorbeeld: `10 + 5 * 2`).
- Grafische gebruikersinterface (GUI).

## Licentie
Dit project valt onder de MIT-licentie. Zie het bestand `LICENSE` voor meer informatie.

