# en-natt-pa-museet 
Objektorienterad programmering med C# - december 2020
## Inlämningsuppgift i Praktiskt projektarbete och sammanfattning 
100/100 (VG)
### Scenario
Du jobbar i det här scenariot som frilansande programmerare år 1979 och har fått ett uppdrag att göra en virtualisering/digitalisering av ett konstmuseum som ska vara användbart från en splirrans ny datorterminal som kommer stå i museets entré. Man ska därför i ett konsolprogram kunna vandra runt i museumets olika rum och få beskrivningar av konstverken i det rummet. Konstmuseumets personal är väldigt positivt inställda och nyfikna på din idé och framtida lösning, och räknar med att detta kommer vara en stor publikdragare!

Strukturen på ditt program är i denna uppgift mer än tidigare upp till dig, så tänk på att tillämpa vad du lärt dig om objektorienterad programmering. Utmaningen i denna uppgift är strukturen mellan de olika rummen och hur användaren kan navigera mellan dessa i programmet. Målet är att skapa ett program där man kan navigera i museet likt ett gammalt datorspel - alltså där man kan "gå" mellan rummen.

Karta över museet och konstverk i varje rum
Studera den nedanstående bilden, detta är hur museumet ser ut. Vilken typ av konstverk som finns i museeum får du bestämma själv i denna uppgift, välj gärna något som du själv har intresse av!
![Map](/images/MAP.jpg)
Detta antal av konstverk ska finnas i varje rum:
* Vita rummet: ett (1) konstverk
* Svarta rummet: inga (0) konstverk
* Lila rummet: fyra (4) konstverk
* Blåa rummet: ett (1) konstverk
* Röda rummet: tre (3) konstverk
* Gröna rummet: två (2) konstverk
* Korridoren: inga (0) konstverk
* Entreen: inga (0) konstverk

### Kravlista
* Lösningen ska bestå av en konsolapplikation skriven i C# som är körbar med .NET Core
* När programmet startar ges en förklaring över hur programmenet ska användas
* Konsolapplikationen beskriver för användaren ett rum ur museumet i taget, inklusive konstverken i det rummet
* Användaren startar i museets entré
* I applikationen kan användaren navigera mellan olika rum
* De rum och konstverken som finns i applikationen är enligt kartan i ovanstående scenario
* I applikationen kan användaren bara navigera mellan rum om de är anslutna till varandra
* Koden i din lösningen är strukturerad så att det är enkelt att i framtiden flytta konstverk mellan rummen
* Koden i din lösningen är strukturerad så att det är enkelt att i framtiden visa andra museum med annan rumuppsättning
* Varje konstverk representeras i kod via en titel, beskrivning och en upphovsmakare
* Konsolapplikationen ska lämnas in med ett tillhörande testprogram, där minst 3 enhetstester är implementerade.
* Ett av de bifogade enhetstesterna visar att förflyttning i museet fungererar enligt uppsatta regler
* Koden är strukturad på ett sådant sätt att Console klassen är väl separerad från programmets övriga logik (vilket rum är användaren i, vilka konstverk finns där osv)
* När programmet startar - efter att användarinstruktionerna visas men innan första rummet beskrivs kan användaren välja mellan det ursprungliga museumet och ytterligare ett eget exempel på ett annat museum
* Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf
* reflections-filen ska under rubriken "Navigering" innehålla en kort beskrivning av hur navigering mellan museets rum fungerar i din lösning
* reflections-filen ska under rubriken "Seperation" beskriva hur du har seperarat konsol-klassen från programmets logik
* reflections-filen ska under rubriken "Testning" beskriva de tester du skapat och deras syfte i lösningen samt en motivering varför de är väl valda tester

