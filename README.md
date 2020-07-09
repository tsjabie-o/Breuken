# Breuken
Opdracht voor studie


Je gaat een algoritme maken om breuken te sorteren. Je besluit vooral
quicksort te gebruiken, omdat het zo. . . quick is, maar voor het sorteren van ‘korte’ segmenten
implementeer je selection sort.
Een ‘kort’ segment is elk segment dat korter is dan of even lang is als een zekere drempelwaarde,
die als onderdeel van de input is gegeven. Je moet selection sort gebruiken voor alle korte
segmenten, dus ook de segmenten die je tegenkomt wanneer je quicksort recursief aanroept.
Doe deze check dus niet alleen aan het begin van het sorteren van de gehele lijst, maar steeds
als je een segment wil gaan sorteren: is het ‘kort’, gebruik dan selection sort, en anders
quicksort.
Daarbij wil je natuurlijk in het domein van de gehele getallen blijven, en er geen vieze kommagetallen van maken 
en problemen door afrondingsfouten en beperkte nauwkeurigheid introduceren.
De invoer heeft op de eerste regel een getal n, maximaal 9 999 999, en een getal k, maximaal
999 999. Dan volgen n regels met elk twee integers, beide maximaal 999 999 999: de teller
en noemer van een breuk. De noemer is positief. De betekenis van de parameter k wordt
hieronder bij “Algoritmische eisen” uitgelegd.
De uitvoer heeft op de eerste regel weer het getal n, en op de regels erna dezelfde breuken
als in de invoer, maar dan oplopend gesorteerd op grootte van de waarde van de breuk.

ALGORITMISCHE EISEN
De opdracht heeft twee verschillende aspecten: het representeren van de objecten die je
wil sorteren, en het sorteeralgoritme zelf. Het is aan te raden om te proberen die twee
onderdelen zoveel mogelijk onafhankelijk van elkaar te houden, om zo de implementatie
begrijpelijk te houden, en je sorteeralgoritme herbruikbaar. Je kunt dat doen door voor de
‘grens’ tussen het sorteeralgoritme enerzijds en de objecten die het sorteert anderzijds, een
zogenaamde ‘interface’ te gebruiken. Die specificeert richting het sorteeralgoritme dat een
object een bepaalde functionaliteit levert, in dit geval de mogelijkheid zichzelf met een ander
object te vergelijken. Voor het vergelijkingsgebaseerd sorteren van objecten hoef je over die
objecten zelf namelijk niets te weten, behalve hoe ze zich in de gewenste sorteervolgorde tot
elkaar verhouden.
Je moet voor het sorteren een hybride van quicksort en selection sort implementeren: Voor ´alle
lijsten van lengte > k (waar k gegeven is als het tweede getal op de eerste regel van de invoer)
moet je programma quicksort gebruiken, en voor lijsten van lengte ≤ k moet het selection sort
gebruiken. Je moet beide algoritmen zelf implementeren. Let op: het woord “´alle” hierboven
betekent dat deze eis in elke (recursieve) aanroep van quicksort opnieuw geldt: een segment
met ≤ k elementen wordt met selection sort gesorteerd, en bij een segmentlengte > k moet je
partitioneren en tweemaal in recursie gaan (waarna je dus voor elk van beide partities opnieuw
moet beslissen of je quicksort of selection sort moet gebruiken).
