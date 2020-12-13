A projekt lényegében egy kosárlabda szimulátor alkalmazás. Az alkalmazást megnyitva eldönthetjük, 
hogy megnézzük milyen játékosok vannak, vagypedig lejátszuk maga a meccset.
1 Formon dolgozok végig, onnan érem el a 3 UserControl osztályt, illetve van még 2 másik osztály.

XML beolvasás és LINQ: 
A játékosok adatai egy XML fájból vannak kiolvasva (1-es tételem)(játékosok player osztálynak lesznek példányai), és a Játékospiac opcióra kattintva
megnézhetjük milyen játékosok közül vállogathatunk(Market). Itt beállíthatunk érték határokat, annak fügvényében
milyen játékost szeretnénk (ez LINQ-val van megoldva). Egyébként nem a pontos értékek jelennek meg a Data-
gridviewben, hanem -3 3-as intevallumon eltérhet. Ez azért van, hogy ne abból álljon a játék, hogy kinézem 
pontosan kik a legjobb ár érték arányú játékosok. 

Maga a program fő funkciója(+Graphics használata):
Új meccsre kattintva megjelenik az első csapat felülete(Team_UC usercontrol osztály), itt megadhatjuk az 5 játékosunkat és csapatnevet, majd ha ez
megvan, akkor az ellenfél csapatával is megtehetjük ezt. Ha készen áll mindkét csapat, akkor játszahtjuk le a meccset(MAtch_UC).
A csapatok pontjai negyedenként van számolva, az igazolt játékosok értékéből, illetve egy random tényezőből ( hogy adott
eseten egy gyengébb csapat is nyerni tudjon nagyon ritkán). MEccset játszva megjelenik a Grapics osztály segítségével egy kosárpálya
és egy eredmény jelző tábla(Court class), ami folyamatosan frissül. Maga a meccs úgy épül fel, hogy az 
összes negyedhez van egy külön gomb, és mindegyik a meghívja a mecsmotor és az eredeményjelző frissítése fügvényt.
Meccs után bármennyi visszavágót játszhatunk még, illetve új játékot is 
kezhetünk más csapatokkal. 

CSV-be írás:
CSV-fájbla 3 esetben van lehetőségünk írni. Mecccs után az adott meccs adatait tudjuk kíirni, a játékos álományt is kitud-
juk menteni csv-be (gyakorlatilag az XMLT-alakítjuk CSV-re), illetve a program futása alatt lejátszott meccseket is ki tudjuk iratni, 
legyen szó ugyanazon csapatok visszavágóíról, vagypedig a más csapatok meccseiről.


Hibakeresés: 
Első csapatot kitöltve tudjuk a másodikat, majd utána lejátszani a meccset (addig inaktívak a gombok, de ha teljesül a feltétel a 
gomb fölé víve a kurzozt aktiválódik). Első meccs után egyébként lehetőségünk van csak az egyik csapatot modósítani, (ilyenkor a másik csapat marad),
vizsont ha az egyik csapatot nem readyzzük le, nem enged meccset játszani, így nem áll fel az esélye a "null" csapatoknak. 