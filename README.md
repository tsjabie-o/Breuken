# Breuken
Opdracht voor studie


Een programma dat breuken sorteert op waarde. Dat doet het programma zonder de breuk te berekenen om afrondingsfouten te voorkomen.
Het programma gebruikt een hybride soorteeralgoritme, bestaande uit quicksort en selection sort. Zie Algoritmische Eisen voor details.


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
