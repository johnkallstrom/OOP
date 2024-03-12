# C# Övningssamling - Inkapsling, arv och polymorfism

#### F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
Svar: Bird

#### F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
Svar: Animal

#### F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
Svar: Det fungerar inte därför att en häst och en hund är inte samma typ. Häst och hund är två olika subklasser av basklassen Animal

#### F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
Svar: Animal

#### F: Skriv ut samtliga Animals Stats() genom en foreach loop. Förklara vad det är som händer
Svar: Listan av animals innehåller olika klasser som alla ärver av basklassen Animal. Foreach-loopen går igenom hela listan och skriver ut statistik för varje djur. 
Eftersom metoden Stats() finns deklarerad i basklassen Animal så kommer varje subklass åt den (dvs alla djur som ärver av Animal) och vi kan på de sättet skriva ut statistiken för varje djur. 
I och med att metoden är virtual kan vi också skriva över den i de subklasser där vi vill kanske lägga till lite extra information, specifik för just den klassen/djuret.

#### F: Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri sträng. Kommer du åt den metoden från Animals listan?
Svar: Nej, eftersom variabeln "animal" i foreach-loopen är av typen Animal och inte Dog så har vi inte tillgång till den metoden.
Bara de fält, egenskaper och metoder som ligger i Animal klassen kommer vi åt.
