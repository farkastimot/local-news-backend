using System;
using Microsoft.EntityFrameworkCore;

namespace LocalNewsApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category()
                    {
                        Id = 1,
                        Name = "Entertainment"
                    },
                    new Category()
                    {
                        Id = 2,
                        Name = "Health"
                    },
                    new Category()
                    {
                        Id = 3,
                        Name = "Politics"
                    },
                    new Category()
                    {
                        Id = 4,
                        Name = "Technology"
                    },
                    new Category()
                    {
                        Id = 5,
                        Name = "Sports"
                    });
            modelBuilder.Entity<Article>().HasData(
                    new Article()
                    {
                        Id = 1,
                        Author = "",
                        Title = "Régóta hiányzó funkcióval bővül az Epic Games Store - Esport1",
                        PublishedAt = DateTime.Parse("2021 - 10 - 05T10: 00:00Z"),
                        Category = 1,
                        Content = @"Lassan 3 éve, 2018 decembere óta bővíti a videojáték-piac webáruházainak listáját az Epic Games Store, amely története során több, a PC-játékosokat olykor megosztó döntésével igyekszik minél több felhasználót megnyerni magának: lehet itt gondolni a rendszeres, ingyenes játékokra is, de mellette több, frissen megjelenő cím esetében is megvásárolják rövidebb-hosszabb ideig az adott játék exkluzivitását, azaz hogy csak az EGS platformján lehet beszerezni.

A közösség több funkciót is hiányolt azonban a kliensből,
                        ezek közül az egyik a közeljövőben viszont valósággá válik: érkeznek ugyanis a teljesítmények,
                        az Epic Achievements,
                        amellyel XP - t tudunk gyűjteni,
                        ennek mennyisége az achievement szintjétől függ: lesz bronz(5 - 45 XP),
                        ezüst(50 - 95 XP),
                        arany(100 - 200 XP) és platinum(250 XP) is.

Első körben viszont csak 6 játék esetében lesz elérhető az achievement - rendszer,
                        de az Epic ígéretei szerint az idei évben azonban további játékokra is ki szeretnék terjeszteni az XP - gyűjtési lehetőséget.A 6 játék,
                        amelyben elsőként lesznek elérhetők a teljesítmények,
                        az alábbiak:

Rocket Legue
Hades
Pillars of Eternity
Humankind
Zombie Army 4
Defense Grid",
                        Description = "Kitűzött célja is volt az Epic Games-nek a funkció bevezetése, amely először 6 játékot érint.",
                        UrlToImage = "https://esport1.hu/images/615c0f460ee3a_615c0f460edf3-regota-hianyzo-funkcioval-bovul-az-epic-games-store.jpg"
                    },
                    new Article()
                    {
                        Id = 2,
                        Author = "Nótin Tamás",
                        Title = "Magyar György: Karácsony és Márki-Zay nem írhatja át a játékszabályokat - Index.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T09:50:00Z"),
                        Category = 3,
                        Content = @"A Civil Választási Bizottság elnöke kizártnak tartja, hogy Karácsony Gergely és Márki-Zay Péter szövetségesként szerepeljen a miniszterelnök-jelölti előválasztás második fordulójának szavazólapján.
A főpolgármester és a hódmezővásárhelyi polgármester az előválasztás első fordulója után egyezett meg, hogy együtt indulnak tovább a második fordulóban. Hétfőn azt is bejelentették, hogy kezdeményezik: egymás mellett szerepelhessen a nevük a szavazólapon. A két politikus formálódó szövetsége egyértelműen az első fordulót megnyerő Dobrev Klára győzelmét akadályozná meg.

Magyar György, a Civil Választási Bizottság elnöke az Indexnek az mondta: ha két jelölt együttműködik, és arról politikai döntés születik, azzal nincs semmi baj sem, de azt nem lehet mások rovására tenni, illetve

nem lehet a játékszabályokat játék közben átírni.

Magyar György teljesen kizártnak, jogi nonszensznek tartja, hogy Karácsony Gergely és Márki-Zay Péter neve egymás mellett szerepeljen a szavazólapon az előválasztás második fordulójában. Elmondta: vagy három név kerül egymás alá a szavazólapon, vagy egyikőjük visszalép, és akkor a választó két név közül választhat.

De olyan a szavazólapon nem fordulhat elő, hogy tandemben induljon két jelölt, mert a választók az első fordulóban is csak egy jelöltre adták le a szavazatukat

– tette hozzá a Civil Választási Bizottság elnöke.

Azt is hangsúlyozta, hogy ez a választóknak és az egész előválasztásnak a megcsúfolása lenne, nevetségessé és komolytalanná tétele.

Magyar György hozzátette, hogy az Országos Választási Előválasztási Bizottságnak kell döntést hoznia. Ugyanakkor azt is elmondta:

HA KARÁCSONY GERGELY ÉS MÁRKI-ZAY PÉTER KEZDEMÉNYEZÉSE MÉGIS ÁTMENNE VALAMILYEN CSODA FOLYTÁN AZ ORSZÁGOS ELŐVÁLASZTÁSI BIZOTTSÁGON, AKKOR A CIVIL VÁLASZTÁSI BIZOTTSÁG FELÁLL, ÉS NEM SEGÍTIK TOVÁBB AZ ELŐVÁLASZTÁST SEM SZAVAZATSZÁMLÁLÁSSAL, SEM PEDIG TECHNIKAI HÁTTÉRREL.

Magyar György szerint a kezdeményezéssel tönkretennék az előválasztást; arra figyelmeztet, hogy a választó tud jutalmazni és büntetni is.

Ha megváltoztatnák az előválasztás feltételrendszerét, azzal kivennék a választás lehetőségét a választók kezéből

– fogalmazott a Civil Választási Bizottság elnöke.

Hétfőn este az ATV Híradójának is elmondta Magyar György, hogy az előválasztás eredeti játékszabályait nincs mód átírni. Dobrev Klára „kicsit zavaros javaslatnak” nevezte az ATV Egyenes beszéd című műsorában Karácsony Gergely és Márki-Zay Péter közös indulását. A DK miniszterelnök-jelöltje szerint nem lehet megtenni a szavazókkal, hogy ne tudják, pontosan kire is szavaznak.

(Borítókép: Magyar György. Fotó: Szigetváry Zsolt / MTI)",
                        Description = "Magyar György: Karácsony és Márki-Zay nem írhatja át a játékszabályokat.",
                        UrlToImage = "https://kep.cdn.index.hu/1/0/4012/40129/401294/40129405_3062341_13c602a7be75f5d53137f6fbd47d2fa8_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 3,
                        Author = "HVG Kiadó Zrt.",
                        Title = "Kult: George Clooney: „Tönkretettem Batmant” | hvg.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T09:33:00Z"),
                        Category = 1,
                        Content = @"„Nem kértek fel. Ha úgy tönkre vágsz egy franchise-t, ahogy én tettem, akkor inkább másfelé fordítják a fejüket” – mondta George Clooney a Variety szerint, amikor nekiszegezték a kérdést, hogy Michael Keatonhoz és Ben Affleckhez hasonlóan, miért nem lesz benne a The Flash-ben.

Clooney 1997 - ben játszotta el Batmant Joel Schumacher Batman & Robin című,
                        még a rajongók között is hírhedten rossz filmjében.A színész többször elismerte,
                        hogy nemcsak a filmet,
                        de saját alakítását is borzasztónak találja.

A színész felesége,
                        Amal Clooney azt is elárulta,
                        hogy férje nem engedi,
                        hogy megnézze a filmet.Clooney ezt azzal indokolta,
                        hogy szeretné,
                        ha felesége tisztelné,
                        ezért nem nézheti meg a hírhedt alkotást.",
                        Description = "Jövőre kerül mozikba a The Flash című szuperhősfilm, amelybe meghívtak több színészt is, akik korábban Batmant alakította. George Clooneyt viszont nem, és ő tudja is, miért.",
                        UrlToImage = "https://images.hvg.hu/image.jpg?id=8d87f0ee-9cf3-4af9-8321-0c0b0bc49b42&view=7fcefbf8-ac48-4ee6-aef5-32203afa118c"
                    },
                    new Article()
                    {
                        Id = 4,
                        Author = "Grósz Petra",
                        Title = "Mindent visz ez a sorozat, pedig sokáig senki sem akarta megcsinálni - Index.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T09:12:00Z"),
                        Category = 1,
                        Content = @"Hwang Dong-hyuknak, az írónak nem volt könnyű dolga.
A Squid Game, magyar címén a Nyerd meg az életed alig két hete debütált a Netflixen, térdre kényszerítve szinte minden más sorozatot, legfőképpen a nem angol nyelven írottakat. A széria már most elképesztő népszerűségnek örvend. A közösségi oldalakon mindenki erről beszél, ennek fényében pedig sok jelenetet mémesítenek is, ami jócskán spoilerveszélyes azok számára, akik még nem nézték végig a sorozatot. Bár a népszerűség kétségtelen, az írónak nem volt könnyű dolga, amikor szerette volna megfilmesíteni az ötletét.

Mint kiderült, Hwang Dong-hyuk tíz éven át lobbizott, hogy képernyőre vihesse a sorozatot. Valószínűleg azért talált egymás után zárt ajtókra, mert kezdetben csak koreai származású producerekkel beszélt, akik elzárkóztak az ötlettől, mondván, túl erőszakos és bonyolult. Ez nem meglepő, hiszen Dél-Koreában inkább családbarát tartalmakra összpontosítanak az alkotók. A kitartása végül meglehetősen kifizetődő lett, azonban a sorozat elkészülését nem csak az nehezítette, hogy az író nem talált partnereket.

Hwang Dong-hyuk elmondása szerint némileg a saját életéből merített ihletet, amikor hozzáfogott a forgatókönyvhöz, ami eredetileg egy filmet formált volna meg. Persze nem halálig tartó játékokra kell gondolni, hanem arra, hogy az író maga is komoly pénzügyi problémákkal küzdött, egyszer meg is kellett szakítania a szkript készítését, mert el kellett adnia a laptopját, hogy kihúzza a hónap végéig. Mint mondja, összesen hat hónapot vett igénybe, amíg megírta, majd átírta az első két részt, ezután pedig a barátaihoz fordult tippekért – írta meg Perez Hilton.

Ez egy szomorú történet. De az ok, amiért visszatértem a projekthez, az az, hogy mára a világ olyan hellyé vált, ahol ezek a hihetetlen túlélési történetek hétköznapivá váltak

– magyarázta Hwang Dong-hyuk, aki a járványhelyzet miatt is kénytelen volt egy ideig pihentetni a munkálatokat.


Az írót egyébként többen megvádolták, hogy az Éhezők viadala, az As the Gods Will vagy a Battle Royale mintájára készítette el a sorozatot, ő azonban egy pillanatig sem tagadja, hogy a japán képregényekből rengeteget inspirálódott az évek során. A nézők egy része persze a sztereotipizálásba is beleállt, sérelmezték a csaló és csábító nő, a haszontalan öregember és a bevándorló klasszikusnak szánt karakterét.

Problémák merültek fel továbbá a sorozathoz készült angol feliratokkal is. Egy koreai anyanyelvű nő több ponton is felhívta a figyelmet, hogy az eredeti nyelven zseniálisan megírt szövegek az angol feliratot nézve jócskán eltérnek, kvázi élvezhetetlenné téve a sztorit. Mindez egyébként felmerül akkor is, ha angol szinkront és magyar feliratot választunk ki: a történet ugyan nem változik meg a diskurzusokat nézve, de jól hallható, hogy az angolul elhangzott szöveg és a magyar felirat között nincs meg a tökéletes összhang.

Mindezek ellenére a sorozat kirobbanó sikernek örvend, mindez pedig valószínűleg tovább fog növekedni a következő hetekben – talán már a napokban is látható lesz mindez, hiszen a tegnapi Facebook-összeomlás közel hét órán át tartott, ez idő alatt pedig akár hét részt is végig lehet nézni a sorozatból.

(Borítókép: Részlet a Nyerd meg az életed című sorozatból. Fotó: Youngkyu Park / Netflix)",
                        Description = "Mindent visz ez a sorozat, pedig sokáig senki sem akarta megcsinálni - Hwang Dong-hyuk azt mondja, a saját életéből is merített, amikor a történet írta.",
                        UrlToImage = "https://kep.cdn.index.hu/1/0/4012/40127/401273/40127357_3062181_93c1101df8756ab92983b15da31f0a4a_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 5,
                        Author = "",
                        Title = "Windows 11-támogatással jön az AMD Adrenalin meghajtócsomagjának legújabb verziója - PC Fórum",
                        PublishedAt = DateTime.Parse("2021-10-05T09:00:00Z"),
                        Category = 4,
                        Content = @"Az AMD hétfőn - éppen időben a Windows 11 megjelenéséhez - új verziót adott ki videókártyáihoz szánt Adrenalin szoftveréből. Az Adrenalin 21.10.1 legfontosabb újítása, hogy már hivatalosan is támogatja a működést a Windows 11 végleges változatán, de a cég szerint jelentősen javít egy rakás játék teljesítményén is.
Ugyan az AMD már korábban kiadott meghajtókat a Windows 11-hez, de azok hivatalosan csak az előzetes változatát támogatását tartalmazták, míg a mostani új verzió már a rendszer végleges változatán is használható. Ugyanakkor természetesen a csomag a Windows 10-zel is kompatibilis maradt, így arra is továbbra is felrakható.A játékok közül egyértelműen a napokban megjelenő Far Cry 6 fog profitálni az új meghajtókból, mert az az AMD szerint egyes kártyákon és felbontásokban akár 10-13%-kal is sebesebben működik majd, mint a korábbi driverekkel. Ugyanakkor a PlayerUnknown’s Battlegrounds is állítólag 11%-ot gyorsul 4K-s ultra felbontás mellett, és a csomag már tartalmazza a jelenleg még bétában lévő Battlefield 2042, valamint a Naraka: Bladepoint támogatását is.A fentieken túl egy rakás apró működési rendellenességét is javító Radeon Software Adrenalin 21.10.1 csomagot innen lehet letölteni.",
                        Description = "Üdvözlünk a PC Fórum-n!",
                        UrlToImage = "https://pcforum.hu/assets/site.pc/images/sitelogo-share-pcforum--dyn--sitelogo-share.png"
                    },
                    new Article()
                    {
                        Id = 6,
                        Author = "Portfolio.hu",
                        Title = "Varga Judit nagy változásokat lengetett be az igazságügyben - Portfolio",
                        PublishedAt = DateTime.Parse("2021-10-05T08:54:00Z"),
                        Category = 3,
                        Content = @"A digitalizáció és a mesterséges intelligencia korunk legnagyobb lehetősége, ugyanakkor legnagyobb kihívása is, amely érinti az igazságszolgáltatási rendszereket is - mondta Varga Judit igazságügyi miniszter kedden Gödöllőn, az Európa Tanács (ET) magyar elnöksége keretében tartott igazságügy-miniszteri konferencián. Egységes jogiszemély-nyilvántartást és az e-government helyett m-governmentet, azaz mobil applikációkra épülő igazságszolgáltatási elérhetőségi rendszereket építene az Igazságügyi Minisztérium. 
A tanácskozást megelőzően újságírók előtt a miniszter arról beszélt, hogy az állampolgárok, vállalkozások jogosan várják el, hogy az igazságszolgáltatás, a hatóság minél gyorsabban, minél hatékonyabban intézze ügyeiket, éppen ezért az elektronikus szolgáltatások és lehetőségek tárházát itt is bővíteni kell.

Magyarország élen jár az igazságszolgáltatás digitalizációjában, az Európai Bizottság igazságügyi eredménytáblája is dobogós helyen említi hazánkat - hívta fel a figyelmet Varga Judit.

Varga Judit kiemelte, hogy minden tagállam a maga módján ad válaszokat a digitalizáció és a mesterséges intelligencia kihívásaira, azonban fontos olyan minimum sztenderdeket találni, amelyek később ezeket a rendszereket összekapcsolhatóvá teszik, hogy az állampolgárok egy határon átnyúló ügylet során se ütközzenek akadályba.

Hangsúlyozta: nagyon fontos az adatvédelem, a tisztességes eljárás és minden magas emberi jogi garancia betartása a digitalizációval, illetve szintén fontos, hogy a mesterséges intelligencia az igazságszolgáltatás területén milyen mértékben tudja átvenni az ember szerepét, és melyek azok a területek, ahol mindenképp meg kell tartani az emberi tényezőt.

Közölte azt is, hogy a konferencián részt vesz az ET mesterséges intelligenciával foglalkozó ad hoc bizottságának vezetője, illetve a bíróságok együttműködésével foglalkozó bizottság vezetője is; ők a tanácskozás szakmai irányítását látják el.

A miniszter kérdésre válaszolva elmondta:

AZ IM CÉLJA, HOGY EGY EGYSÉGES JOGISZEMÉLY-NYILVÁNTARTÁSSAL TOVÁBB LENDÍTSE A JOGI VERSENYKÉPESSÉGET MAGYARORSZÁGON, ILLETVE AZ E-GOVERNMENT HELYETT EGYFAJTA M-GOVERNMENTET, AZAZ MOBIL APPLIKÁCIÓKRA ÉPÜLŐ IGAZSÁGSZOLGÁLTATÁSI ELÉRHETŐSÉGI RENDSZEREKET ÉPÍTSEN.

Az Európa Tanács Miniszteri Bizottsága soros magyar elnöksége keretében szervezett legmagasabb rangú igazságügyi konferencián részt vesz Marija Pejcinovic Buric, az Európa Tanács főtitkára, valamint 38 tagállam delegációja.  Magyarország május 21. és november 17. között tölti be az Európa Tanács Miniszteri Bizottságának elnöki szerepét.

A címlapkép forrása: MTI Fotó/Mohai Balázs.",
                        Description = "A digitalizáció és a mesterséges intelligencia korunk legnagyobb lehetősége, ugyanakkor legnagyobb kihívása is, amely érinti az igazságszolgáltatási rendszereket is - mondta Varga Judit igazságügyi miniszter kedden Gödöllőn, az Európa Tanács (ET) magyar elnök…",
                        UrlToImage = "https://cdn.portfolio.hu/articles/images-xl/v/a/r/varga-judit-igazsagugyi-miniszter-482758.jpg"
                    },
                    new Article()
                    {
                        Id = 7,
                        Author = "Mázsár Tamás",
                        Title = "Sztrájkbizottságot alakít a két nagy pedagógus-szakszervezet - 24.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T08:48:00Z"),
                        Category = 3,
                        Content = @"Azonnali béremelést és az oktatásban dolgozók munkaterheinek csökkentését követelve közös sztrájkbizottságot alakít a Pedagógusok Szakszervezete (PSZ) és a Pedagógusok Demokratikus Szakszervezete (PDSZ) – jelentették be a két szervezet közös sajtótájékoztatóján kedden, a pedagógusok világnapján Budapesten.

A PSZ és a PDSZ közös, négy pontból álló követelést fogalmazott meg – írja az MTI. Ezeket Szabó Zsuzsa, a PSZ elnöke és Nagy Erzsébet, a PDSZ országos választmányának tagja ismertette. Követeléseikről még kedden Orbán Viktor miniszterelnököt is tájékoztatják, ezt a levelet a sajtótájékoztatón írták alá a PSZ és a PDSZ képviselői.

Kérdésre válaszolva elmondták: a kormánynak a jogszabály szerint öt napon belül ki kell jelölnie a sztrájktárgyalási partnereket. Szabó Zsuzsa azt is elmondta, hogy a parlamenti pártoknak is levelet írtak, azt kérve, tegyenek ajánlatot az oktatásban dolgozók számára.",
                        Description = "A jogszabály szerint öt napon belül ki kell jelölnie a sztrájktárgyalási partnereket.",
                        UrlToImage = "https://24.p3k.hu/app/uploads/2021/10/73941771-e1633423620880-1024x577_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 8,
                        Author = "HVG Kiadó Zrt.",
                        Title = "Mark Zuckerberg 7 milliárd dollárt bukott a Facebook leállása miatt - hvg.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T08:43:00Z"),
                        Category = 4,
                        Content = @"Bill Gates már gazdagabb a közösségi oldal alapítójánál.

A hétfői Facebook-leállás miatt 7 milliárd dollárt bukott az oldal alapítója, Mark Zuckerberg, akinek így 120,9 milliárd dollárra csökkent a vagyona – írja a Bloomberg.

A hétfői hibák miatt Zuckerbeg az ötödik helyre, Bill Gates mögé került a leggazdagabbak listáján.

A Bloomberg azt írja, hogy szeptember óta folyamatosan csökken a Facebook részvényeinek értéke, a mostani leállás hírére rövid pedig idő alatt további 5 százalékot estek a a papírok.

Hétfőn közel hat órára leállt a Facebook, az Instagram és a WhatsApp. Facebook és a közösségi oldalhoz tartozó szolgáltatások csak magyar idő szerint éjfél előtt váltak újra elérhetővé.. Azután, hogy a rendszerek lassan ismét működni kezdtek, a Facebooknál közleményt adtak ki, amelyben azt írták, hogy a kimaradáshoz hibás konfigurációs változtatások vezettek, amelyek miatt probléma lépett fel az adatközpontjaik közötti kommunikációban. A hiba a belső eszközeiket és rendszereiket is érintette, ami tovább nehezítette a probléma megoldását.",
                        Description = "Bill Gates már gazdagabb a közösségi oldal alapítójánál.",
                        UrlToImage = "https://images.hvg.hu/image.jpg?id=9e810fdf-87a7-4a40-8dcc-91a488af286e&view=7fcefbf8-ac48-4ee6-aef5-32203afa118c"
                    },
                    new Article()
                    {
                        Id = 9,
                        Author = "nemzetisport.hu",
                        Title = "Batik a karjánál fogva tessékelte a labda mögé a győztes gól szerzőjét! - Nemzeti Sport",
                        PublishedAt = DateTime.Parse("2021-10-05T08:42:17Z"),
                        Category = 5,
                        Content = @"A labdarúgó NB I 8. fordulóját követő visszapillantónkban fókuszban a Honvéd nem minden napi körülmények között született győztes gólja az addigi listavezető Kisvárda ellen, de szó lesz az „életmentő” zalai győzelemről és Gróf Dávid debreceni esélyéről is. Az eseménydús forduló egyéb fontos történéseit pedig a keretekben található címekre kattintva idézheti fel!   
A FORDULÓ MEGMOZDULÁSA – ZINÉDINE MACHACH

A tettek mezejére lépett Batik Bence – a Bp. Honvéd szabadrúgáshoz készülődött a Kisvárda elleni bajnoki (2–1) hosszabbításában, a labda mögött Zinédine Machach és Zsótér Donát állt, utóbbi maradt ott. Csakhogy a kapu előtt helyezkedő kispesti csapatkapitány visszaküldte a francia-marokkói támadót, mondván, ő rúgja középre a labdát. A légiós ment, elrúgta, csak nem középre, hanem Dombó Dávid kapujába – így pedig nyertek a kispestiek.

„Rengeteget jelent ez a gól    – mondta a klub hivatalos honlapjának a középpályás Zinédine Machach, aki a nyáron érkezett kölcsönbe a Napolitól. –   Az első gólomat szereztem a Honvédban, de remélem, még sok követi majd! A Kisvárda elleni meccs nehéz és hajtós volt, megküzdöttünk a három pontért. Nem kezdtünk jól, de sikerült hamar kiegyenlítenünk. Megmutattuk, micsoda mentális erő van a csapatban! Minden játékos az utolsó pillanatig harcolt, ment előre, ezt belülről átélni nagyon jó érzés. Az atmoszféra pedig lenyűgöző volt!“
A Honvéd a gyenge bajnoki rajt után összeszedte magát, és az utóbbi öt bajnokijából négyet megnyert, csak a Ferencváros bizonyult jobbnak (0–1). A kispestiek legközelebb a Mol Fehérvár otthonába látogatnak, és a hírek szerint akkor már a csapat egyik legfontosabb láncszeme, a tízszeres válogatott Nagy Dominik is bevethető állapotba kerül, aki kisebb sérülés miatt kénytelen volt kihagyni a pénteki összecsapást.

„Jön egy kis szünet a válogatott mérkőzései miatt, de ez ugyanolyan fontos időszak lesz, mint amikor tétmeccset játszunk: kemény munka vár ránk, hogy felkészüljünk a folytatásra. Magasra tettük a lécet, ami a céljainkat illeti, ehhez pedig sokat kell még dolgoznunk, hogy további pontokat és győzelmeket gyűjtsünk a bajnokságban.”
A FORDULÓ HELYEZKEDÉSE ÉS DUPLÁJA – KOSZTA MÁRK

Koszta Márk az MTK Budapest elleni bajnokin többször is posztot változtatott, ráadásul két góljának köszönhetően a ZTE FC győzött és felzárkózott a középmezőnyhöz

 
A FORDULÓ KIÁLLÁSA
Végh Gábor: A Fradi ellen Waltner Róbert vezeti a csapatot
A FORDULÓ BUKÁSAI
 Eszembe nem jutott, hogy kirúghatnak – Costantino
Már nem Pintér Attila a Mezőkövesd vezetőedzője
Vastapssal és Waltner Róbert vezetőedző éltetésével fejeződött be a ZTE FC–MTK Budapest bajnoki (2–0) vasárnap késő délután. Napok óta a vezetőedző leváltásáról érkeztek pletykák vagy valós információk, de a klubtól megerősítés nem történt. Mindenesetre a szurkolók reakciója egyértelművé tette, hogy kiállnak Waltner Róbert mellett, aki meg is hatódott a lelátóról érkező rigmusok hallatán. Csapata teljesítményét látva már nem volt oka meghatódni, mindenesetre győzelmükkel a hazaiak elmozdultak a kiesőzónából, ahova a forduló szombati mérkőzései után kerültek.

„Csapatmunka volt, mert a jó beadások nélkül nem lehettem volna eredményes  – jelentette ki Koszta Márk, a ZTE FC 25 esztendős támadója, aki két góljával eldöntötte a fővárosi kék-fehérek elleni bajnokit. –   A teljesítmény minősége most nem is annyira számított, de mindenképpen győznünk kellett. Számomra fontos, hogy élvezem a szakmai stáb bizalmát, korábban Újpesten és Mezőkövesden nem feltétlenül volt így.”

A támadó az első félidőben szokatlan szerepkörben futballozott, bal oldali szélsőként kezdte a mérkőzést, majd az első félidőben rendre cserélgették az oldalakat szélsőtársával, Skribek Alennel.

„Alapvetően támadó középpályásnak tartom magam, ezt Waltner Róbert vezetőedző is tudja, de most a bal szélen kezdtem, és ránk bízta, hogy mérkőzés közben mikor váltunk oldalt Alennel. Úgy vélem jól oldottuk meg a feladatunkat, mert közvetlenül az első gól előtt húzódtam át a jobb oldalra, és a bal oldalról érkező beadásra csak megfelelő ütemben kellett érkeznem.”

A második félidő közepén, a center Preszlav Borukov lecserélésével aztán Koszta Márk előretolt ékként futballozott tovább, és Tajti Mátyás beadását követően éppen abból a pozícióból, középről, előrevetődve fejelte be csapata második gólját.

„A hetvenedik perc környékén kérdezték a kispadról, hogy bírom-e még, jeleztem, hogy még maradok, és kaptam is egy jó beadást. Hazai pályán ez volt az első győzelmünk az idényben, bár könnyen lehetett volna döntetlen is a vége, Demjén Patrik kisegítette a csapatot, amikor egygólos vezetésünknél kivédte az MTK tizenegyesét.”

A mérkőzést megelőző napokban a lehetséges edzőváltás is befolyásolhatta az edzésmunkát.

„Waltner Róbert mindenkit megkért, hogy csakis az MTK elleni mérkőzésre koncentráljunk. Személy szerint örülnék, ha maradna, mert most felzárkóztunk a középmezőnyhöz, ráadásul neki ez több mint egy állás, és ezt a szurkolók is tudják. Hallatták is a hangjukat a mérkőzés végén.”

Duplájával Koszta Márk már négy gólnál tart az idényben, pályafutása egészét tekintve pedig már harmincöt gólt szerzett az élvonalban.        T. N.



A FORDULÓ SÉRÜLÉSE – TOMÁS KOSICKY

A Debreceni VSC szlovák kapusa a Mol Fehérvár FC ellen dőlt ki a sorból – eljött Gróf Dávid ideje?
Azonnal érződött, nagy a baj – még fél óra hátra volt a Mol Fehérvár FC elleni (1–1) bajnokiból, amikor Tomás Kosicky, a Debreceni VSC kapusa vezette a labdát, majd fájdalmas arccal elterült a földön. A Loki szlovák labdarúgóját hordágyon kellett levinni, s a vizsgálatok során kiderült, izomszakadást szenvedett. Előreláthatólag hat-nyolc hetes kihagyás vár a futballistára.

Helyére Gróf Dávid állt be, aki kis híján – lábbal – hárította Kenan Kodro tizenegyesét. Vajon eljött a magyar kapus ideje? Kosicky ugyan kiszorította a kezdőből, de másfél-két hónap elég lehet ahhoz, hogy bebizonyítsa, vele erősebb a DVSC.

A futballista a napokban így nyilatkozott lapunknak:   „Mindent lehet rám mondani, de azt nem, hogy megelégszem a középszerűséggel, elvagyok a kispadon. Azért is váltottam klubot annak idején, azért jöttem el a Ferencvárosból, hogy végre állandó játéklehetőséget kapjak. Nagy reményekkel érkeztem a klubhoz, és nem érzem, hogy sínen lennék. Ez nekem egyértelmű csalódás. De bizakodó vagyok, hogy még lehet ebből sikersztori, olyan, amilyet megálmodtam magamnak Debrecenben.”

A lehetőséget erre bizonyosan megkapja Gróf Dávid.   CS. A.",
                        Description = "„Odamész és berúgod” – szólhatott a kispesti ukáz. Zalai kiállás Waltner mellett. Eljött Gróf Dávid ideje Debrecenben?",
                        UrlToImage = "http://www.nemzetisport.hu/data/cikk/2/85/33/29/cikk_2853329/1200honvvarda_fb.jpg"
                    },
                    new Article()
                    {
                        Id = 10,
                        Author = "K. B.",
                        Title = "Várhidi: A 0–8-as bundameccs és a tévézés tette tönkre az edzői karrieremet - Nemzeti Sport",
                        PublishedAt = DateTime.Parse("2021-10-05T08:28:41Z"),
                        Category = 5,
                        Content = @"2007-ben az év szövetségi kapitányának választották, ma Nagykanizsán gyerekeket edz Várhidi Péter, akivel a most kiesés ellen küzdő Újpest 23 éve nyerte meg eddigi utolsó NB I-es aranyérmét. A tréner köntörfalazás nélkül beszélt számos meghatározó élményéről az Origónak, többek között a magyar futball egyik legundorítóbb bundameccséről, a szerbek elleni 0–8-ról is.
Az Újpest az 1997–1998-as idényben nyerte meg a bajnokságot az ön vezetésével. Több mint két évtizede. Az Újpest most a kiesés ellen küzd – közölték a tényt az origo.hu honlapján Várhidi Péterrel.

„Akkor nagyon jó csapatunk volt, abban a társaságban legalább négy bajnoki cím volt benne – reagált a szakember. – Csak 1998-ban minden szétesett. Mi még egyesületként nyertünk bajnokságot, majd jött az átalakulás, a gazdasági társaságok megszületése. Az 1998-as aranyérem után az Újpest úgy alakult át, hogy az addigi főszponzor kiszállt, mi egy fillér nélkül maradtunk. Nagyon fáj a szívem ezért a csapatért. Én ott nőttem fel, oda köt minden, borzalmas megélni, ami a jelenlegi Újpesttel történik. Unalmas már az is, hogy mindig az 1998-as aranyéremről beszélnek.”

Várhidit 2007-ben a magyar újságírók az év edzőjének választották. Abban az évben vertük meg a világbajnok olasz válogatottat a Puskás Arénában, akkor ő volt a szövetségi kapitány. De azok után, hogy az MLSZ 2008-ban leváltotta, és a helyére a holland Erwin Koemant hozta, már egyetlen nagycsapatnál sem dolgozhatott.

„Az NB I-ben mi már nem kellünk, az NB II-ben meg nekem nincs igazán kedvem dolgozni. Voltam ott eleget, láttam, mi történik, az nem egy olyan edzőnek való, aki a munkában és a szép futballban hisz. 2007 után csak a régi vágású, mozdíthatatlan edzők maradtak meg, mint Garami József az MTK-nál, a Herczeg Bandi Debrecenben, vagy Csank János. A többiek – én is – fokozatosan szorultak a háttérbe. De ha azt mondja nekem 2007-ben, hogy ez történik velem, aligha hiszem el. Az olaszok elleni győzelem – legyen az csak egy barátságos meccs – örök élmény marad. A Sport tévében van egy kommentátor, aki ha meglát, a mai napig ehhez gratulál. Lehet ezen gúnyolódni, de azóta a magyar válogatott nem nyert meccset az aktuális világbajnok ellen. De azt is be kell ismerni, hogy az olaszok augusztusban nem csúcsformában jöttek Budapestre. Úgy gondolták, hogy rúgnak egy gólt, aztán annyi. Csak azzal nem számoltak, hogy a csapat és én is extra motivációval rendelkeztünk. Akkor már sokat kommentáltam a tévében az olasz meccseket, ismertem az ellenfél összes játékosát.”

A mester arról is beszélt, ez idő tájt szinte mindenki az Újpesttel azonosította, s ez nem vált a javára, miként az sem, hogy a Sport 1-ben rendszeresen szakértett.

„A debreceni tulajdonos, Szima Gábor azt mondta, hogy két edző közül választanak, az egyik jelölt a Várhidi, de én biztosan soha nem leszek edzője a DVSC-nek, mert rosszat mondtam róluk a tévében. Nekem a tévézés az edzői karrieremet tönkretette. De ezzel sincs bajom. Abban az időben hetente telefonált a tévébe több klubtulajdonos, hogy mit képzelünk. Ott mindenki hibás volt, a Nyilasi Tibi, a Puhl Sanyi, a Zombori, a Várhidi. Valamennyien kegyvesztettek lettünk a tulajdonosok szemében.”

Azt is megkérdezték tőle, utólag visszanézve volt-e olyan, hogy a játékosai tudatosan kiszúrtak vele.

„Hát persze, a 0–8-as bundameccs a szerb utánpótlás-válogatott ellen ilyen volt. Nekem az a meccs a karrierembe került. A bundáról nem tudtam. Anno bent voltam a rendőrségen, kihallgattak. Elmondtam mindent, amiről információm volt. A kihallgatás végén megkérdeztem a rendőrt, hogy mit tudnak. Elővett egy nagy dossziét, hogy ennyi anyaguk van. A rendőrség mindent tudott, én semmit. Az a vicc az egészben, hogy ezen a meccsen nem is nekem kellett volna a kispadon ülni, mert nem én voltam az edzője annak a csapatnak. Szerintem ez egy előre megtervezett dolog volt, ki akartak csinálni. Akkor már Erwin Koeman volt a szövetségi kapitány, nem tetszett neki, hogy én is ott vagyok az MLSZ-ben, zavarhatta őt, hogy az elődje ott ül a nyakán.”

„Voltak olyanok, akik azóta elnézést kértek – folytatta. – Meg voltak olyanok is, akik megláttak, és elindultak az ellenkező irányba. Nehogy a szemembe kelljen nézniük.”

Ők játszottak a 0–8-as meccsen
Bogdán Ádám – Kiss Zoltán, Guzmics Richárd, Pintér Ádám, Völgyi Dániel – Vass Ádám – Demjén Gábor, Filkor Attila, Zsidai László, Szakály Péter – Feczesin Róbert

Ahogyan arról május 15-én beszámoltunk, Várhidi napjainkban Nagykanizsán dolgozik, a  Zrínyi Miklós–Bolyai János Általános Iskolában indított focisulit.",
                        Description = "A trénert 2007-ben az év szövetségi kapitányának választották, ma Nagykanizsán gyerekeket edz.",
                        UrlToImage = "http://www.nemzetisport.hu/data/cikk/2/85/33/25/cikk_2853325/Varhidi_Peter_fb.jpg"
                    },
                    new Article()
                    {
                        Id = 11,
                        Author = "Papdi-Pécskői Viktor",
                        Title = "Facebook-leállás: törlődtek a hálózatról az adatközpontok - Index.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T08:18:00Z"),
                        Category = 4,
                        Content = @"Nem lehetett távolról javítani a hibát, egy hálózati zavar lavinaszerű folyamatot indított el, ami végül a teljes leálláshoz vezetett.
Egy konfigurációs hiba okozta a világ legnépszerűbb közösségi oldala, a Facebook szolgáltatásának hétfő délutántól éjfélig tartó globális kimaradását. A közösségi platformon kívül sok más szolgáltatást – képmegosztót, csevegőprogramokat, VR-sisakokat és okosszemüveget – kínáló cég történetének ez volt az eddigi leghosszabbra nyúlt szolgáltatáskiesése. A hiba okaival kapcsolatban nem közöltek részleteket, de szakértők szerint a BGP nevű hálózati technológia okozta a hibát.

A mérnöki csapatok arról értesültek, hogy az adatközpontok közötti forgalmat koordináló routerek konfigurációjának változtatása megzavarta a kommunikációt. A hálózati zavar lavinaszerű hatással volt az adatközpontok kommunikációjára, ami végül a szolgáltatásaink leállásához vezetett

– írta közleményében a Facebook infrastruktúráért felelős alelnöke, Santosh Janardhan.

A BGP a border gateway protocol elnevezést takarja, olyan routereket, amelyek nagyobb hálózatok közötti adatcsomagok irányítását végzik. Ha ezek nem működnek, az internet nagyobb szolgáltatók hálózataiból álló szigetekre esik szét. A hálózatok folyamatosan változnak, de mivel az adatcsomagoknak így is el kell jutniuk a rendeltetési helyükre, a routerek megosztják egymással az új címeket, hogy új útvonalakat tervezhessenek. Ha ez utóbbiba hiba kerül, az végigvonul a rendszeren.

Outlookozni kényszerültek
Aki próbált már útvonalat tervezni, az tudja, hogy a különböző helynevek, körülmények, fizetős utak, a legrövidebb-leggyorsabb optimalizáció igen bonyolulttá teheti a folyamatot. A hálózaton is hasonlóan bonyolult a helyzet, az algoritmusnak nagyon sok különböző megfontolás alapján kell döntenie az optimális útvonalról (például hálózati költségek alapján).


A Facebook maga építette BGP-rendszerét, ami az adatközpontjaik közötti információmozgást irányítja, és ugyanakkor gyorsan frissíthető. A szakértők szerint egy ilyen rutinszerű frissítés során ment félre valami. A Cloudflare technikai vezetőjének magyarázata szerint hirtelen nagyon sok frissítést látott, amelyek az útvonalak törléséről szóltak.

A leállás azért húzódott el, mert Facebook mérnökeinek az adatközpontokban személyesen kellett javítaniuk a hibát, miközben a többi alkalmazott céges beléptetőrendszer hiányában Outlookon levelezve próbált kommunikálni, a Google Docs és a Zoom helyett pedig az Apple FaceTime-ot és a Discordot használták.

A közösségi háló viselt ügyeivel kapcsolatos, küszöbön álló kongresszusi meghallgatás miatt felmerül a szándékosság kérdése, de ezt nehéz bizonyítani, mivel az IT-osztály egyik tagjának szerencsétlen hibája ugyanúgy boríthatta a rendszert. ",
                        Description = "Facebook-leállás: törlődtek a hálózatról az adatközpontok - Nem lehetett távolról javítani a hibát, lavinaszerű folyamat indult el.",
                        UrlToImage = "https://kep.cdn.index.hu/1/0/4012/40126/401268/40126853_3062139_ecd5a25ea822f2670529cf3e08015e2f_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 12,
                        Author = "",
                        Title = "Halálra gázoltak egy fiatal magyar kézilabdázónőt - Origo",
                        PublishedAt = DateTime.Parse("2021-10-05T07:55:00Z"),
                        Category = 5,
                        Content = @"Meghalt a Jánossomorja Sportegyesület 20 éves kézilabdázója, Budai Viktória. A fiatal játékost a hírek szerint egy 35 éves kábítószer hatása alatt álló sofőr gázolta el kerékpározás közben, amelyet nem élt túl a fiatal kézilabdázó lány.

A 20 éves Budai Viktória a Jánossomorja Sportegyesület játékosa volt.A klub a Facebookon jelentette be a halálhírt,
                        és közölték,
                        hogy szerdán este hétkor gyertyagyújtásos megemlékezést tartanak.

„A Jánossomorja Sportegyesület Kézilabda Szakosztálya mély fájdalommal tudatja,
                        hogy kiváló csapattársunk,
                        kapusunk,
                        barátunk,
                        Budai Viktória a mai napon tragikus körülmények közt itt hagyott bennünket.Csapatunk gyertyagyújtással 2021.október 5 - én,
                        kedden este 19:00 - kor a jánossomorjai hármashalom - emlékműnél tart megemlékezést.Gyújtsunk gyertyát együtt emlékére!” – írták.",
                        Description = "A kapust egy kábítószer hatása alatt álló sofőr gázolta el kerékpározás közben.",
                        UrlToImage = "https://cdn.nwmgroups.hu/s/img/i/2110/20211005budai-viktoria-kezilabda2.jpg?w=1024"
                    },
                    new Article()
                    {
                        Id = 13,
                        Author = "Csernátony Csaba",
                        Title = "Windows: mostantól lehet frissíteni - Napi.hu - Napi.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T07:53:00Z"),
                        Category = 4,
                        Content = @"Új időszakot indított a Microsoft keddtől: megjelent ugyanis a Windows operációs rendszer legfrissebb, 11-es verziója. Az arra jogosult felhasználók  a Windows 10-es számítógépüket ingyenesen frissíthetik - közölte a szoftvercég. 

A Windows 11-ben a cég fejlesztői különös hangsúlyt fektettek a rendszer teljesítményoptimalizálására, így hatékonyabbá válik a felhasználók számára a munkavégzés és a mindennapi tevékenységek is.

A Microsoft készített egy 'kérdezz - feleleket', amelyből kiderül többek között az is, hogy mi a különbség és 10-es és a 11-es verzió között. ",
                        Description = "Október 5-től a Microsoft elérhetővé tette a Windows 11-et.",
                        UrlToImage = "https://www.napi.hu/fototar/fototar/202001/orig/image1579255163.jpg/800/?v=2021073101"
                    },
                    new Article()
                    {
                        Id = 14,
                        Author = "BABJÁK BENCE",
                        Title = "Újpest: Az én hibám, ha hiányzik a kvalitás a csapatból – Duchatelet - Nemzeti Sport",
                        PublishedAt = DateTime.Parse("2021-10-05T07:33:58Z"),
                        Category = 5,
                        Content = @"– Az Újpest harminchárom éve nem kezdte ilyen rosszul a bajnokságot. Miben látja az okokat?
– Több összetevője van a gyenge kezdésnek, az egyikről a közelmúltban videós összeállítást is készítettünk – válaszolta Roderick Duchatelet, az Újpest tulajdonosa. – Emellett több játékos sérüléssel bajlódott az idény elején, más futballistáinkat meglepően hosszú időre tiltották el a piros lapjuk után. Az Európa-konferencialiga-szereplés idején nem tudtuk úgy pihentetni és frissíteni a játékosokat, ahogy kellett volna, ami még több sérüléshez és rossz eredményekhez vezetett. A csapatot mentálisan is megviselték a vereségek, negatív spirálba került.

– Az előző idényben az Újpest Magyar Kupát nyert, a keret jelentős része pedig együtt maradt. Ennek fényében különösen érthetetlen a gyengélkedés.
– A nyáron távozó Vincent Onovo viszont nagyon hiányzik. Amíg itt futballozott, sokan észre sem vették, mennyire hasznos, olyan típusú középpályás, akinek akkor tűnik fel a hiánya, miután elment. Annak idején Bojan Szankoviccsal már átéltük ezt.

– Valós veszélynek érzi a kiesést?
– Ez nem történhet meg, a csapatban megvan a kellő minőség ahhoz, hogy az eddigieknél jobb eredményt érjen el. A téli átigazolási időszakban pedig erősíthetünk a hiányposztokon.

– A keret minősége alapján mit tartana reális elvárásnak?
– Ha sikerül a terveknek megfelelően megerősíteni a csapatot, az utóbbi évekhez hasonlóan ismét a nemzetközi kupaszereplésért küzdhetünk.

– Merész tervek, ám a Gyirmót elleni hétvégi vereségnél úgy tűnt, a szenvedély, az érzelem és a küzdeni akarás is hiányzott a játékosokból. Hogyan lehet kirángatni a csapatot a gödörből?
– Ha a támadósorunkban rejlő potenciált nézzük, akkor mindenki könnyed győzelmet várt, csakhogy a tizenkét csapatos bajnokságban egyetlen vetélytárs ellen sem mehetünk biztosra. Itt minden meccs egy-egy csata. A Gyirmót ellen új szerkezettel kísérleteztünk, ami nem úgy sült el, ahogyan reméltük. A mérkőzés nagy nyertese a vendégek vezetőedzője, Csertői Aurél volt, aki remekül felkészítette a csapatát arra, hol tudnak megsebezni minket, a játékosai pedig tökéletesen kivitelezték a megálmodott taktikát.

– Nyolc fordulót követően nyeretlenül áll az utolsó helyen az Újpest. Továbbra is bízik Michael Oenning vezetőedzőben?
– Nem az edzőváltás a megoldás. Michael Oenninget remek szakembernek tartom, de meg kell találni az egyensúlyt a csapatban. Minden játékosnak tudnia kell, mi a feladata az adott poszton, és mindenkinél fenn kell tartani a motivációt.

– Mikor döntene az edzőváltás mellett?
– Csak akkor, ha azt látom, nincs más megoldás, és nincs fejlődés. Ugyanakkor a mostani idényben egyszer futballoztunk igazán rosszul, sajnos épp legutóbb, a Gyirmót ellen. A Ferencváros otthonában viszont tíz emberrel is jól játszottunk, és a korábbi fordulókban sem lehetett panasz a teljesítményünkre. Más tényezők miatt nem született még meg az első győzelem.

– A saját felelősségét miben látja?
– A végső döntés mindig az enyém, akár a vezetőedző kiválasztásáról, akár a játékosok szerződtetéséről van szó. Vagyis az én hibám, ha hiányzik a minőség a csapatból.

– A hazai meccseken szinte teljesen hiányzik a futballhangulat. Nem zavarja a kapu mögötti üres szektor látványa?
– Nem különösebben. Az sokkal jobban bánt, hogy a két kapu közötti szektorokban is kevesen vannak. Emellett annak is örülnék, ha több nő, valamint több család választaná hétvégi programnak a hazai mérkőzésünket.

– A Gyirmót elleni meccs után néhány szurkoló megtapsolta azokat a játékosokat, akik a tőlük mezt kérő kisgyerekeknek odaadták a dresszüket, a drukkerek másik csoportja viszont le akarta vetetni a labdarúgókkal. Erről mi a véleménye?
– Azok, akik a lefújás után a stadion elé vonultak, nem szurkolók, hanem tiltakozók. Ha a meccs alatt nem tudják buzdítani a csapatot, a lefújás után se kezdjenek magánakcióba. Akad olyan játékos, aki korábban is gyengébben teljesített, más viszont szombaton futballozott először formán kívül a mostani idényben. A Gyirmót ellen csapatszinten buktunk meg, és nagyon szűk látókörre vall, ha valaki az idény eddigi összes keserűségét azokra a játékosokra vetíti ki, akik a Gyirmót ellen pályára léptek.",
                        Description = "„Ha sikerül a terveknek megfelelően megerősíteni a keretet, ismét a nemzetközi kupaszereplésért küzdhetünk.”",
                        UrlToImage = "http://www.nemzetisport.hu/data/cikk/2/85/33/5/cikk_2853305/duchatelet-SMIC1788_fb.jpg"
                    },
                    new Article()
                    {
                        Id = 15,
                        Author = "Mázsár Tamás",
                        Title = "16 koronavírusos beteg hunyt el az elmúlt 24 órában - 24.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T07:11:00Z"),
                        Category = 2,
                        Content = @"Ahhoz képest, hogy a múlt héten naponta 500–600 új fertőzöttet regisztráltak, a legfrissebb napi adatok szerint az elmúlt 24 órában csak 294 új fertőzöttet találtak. Az elhunytak száma viszont tovább nő. Miközben a múlt héten folyamatosan tíz alatt volt a napi halálesetek száma, addig most egy nap alatt 16 ember hunyt el, így az elhunytak száma 30 246-ra emelkedett. A gyógyultak száma 786 883 , az aktív fertőzötteké 8 041-re emelkedett. 585 koronavírusos beteget ápolnak kórházban, közülük 86-an vannak lélegeztetőgépen.

A beoltottak száma 5 897 432, közülük 5 661 324 már a második oltását is megkapta, 816 ezren pedig már a harmadik oltást is felvették. 294 új fertőzöttet igazoltak, ezzel a járvány kezdete óta összesen 825 170-re nőtt a beazonosított fertőzöttek száma.",
                        Description = "A legfrissebb napi adatok szerint viszont az elmúlt 24 órában csak 294 új fertőzöttet találtak.",
                        UrlToImage = "https://24.p3k.hu/app/uploads/2021/04/koronavirus_ill24-e1619769007666-1024x579_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 16,
                        Author = "oriic",
                        Title = "Alan Wake Remastered - Befutottak az első tesztek - Gamepod",
                        PublishedAt = DateTime.Parse("2021-10-05T07:00:00Z"),
                        Category = 1,
                        Content = @"Sam Lake a nyáron jelentette be, hogy érkezik az Alan Wake Remastered, amely hivatalosan a mai naptól elérhető PC-n, Xbox One-on, Xbox Series X/S-en, PlayStation 4-en és PlayStation 5-ön. Ahogy ilyen esetekben lenni szokott, befutottak az első tesztek is, amelyek szerint jól sikerült az új kiadás, így érdemes lehet beszerezni a remaster verziót is valamelyik platformra.

",
                        Description = "A nagy többség szerint remekül sikeredett az új kiadás.",
                        UrlToImage = "https://cdn.prohardver.hu/dl/cnt/2021-10/171190s.jpg"
                    },
                    new Article()
                    {
                        Id = 17,
                        Author = "Horváth Bence",
                        Title = "Az EU-bővítés Voldemortja: Várhelyi Olivér elfogultságára panaszkodnak Brüsszelben - 444.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T06:39:42Z"),
                        Category = 3,
                        Content = @"Hosszú írást szentelt a Politico a magyar EU-biztos, Várhelyi Olivér munkásságának. Várhelyi 2019 óta az EU bővítési biztosa, miután Orbán eredeti biztosjelöltjéből, Trócsányi Lászlóból nem kért az Európai Parlament.

A Politico újságírói tucatnyi uniós hivatalnokkal beszélgetve, illetve belső dokumentumokat megismerve írnak arról, hogy bár az uniós biztosokat a pártatlanságnak kellene vezérelnie, Várhelyi az esetleges uniós bővítéssel kapcsolatos tárgyalások során szemlátomást kivételez Szerbiával kapcsolatban, és igyekszik kisebbíteni a jogállamisággal és emberi jogok helyzetével kapcsolatos negatív észrevételek súlyát.

A lap szerint azzal, ahogy Várhelyi ignorálni igyekszik a jogállamisággal kapcsolatos szempontokat, a Bizottság elnöke, Ursula von der Leyen által megfogalmazott elvárásokkal is szembemegy, és sokkal inkább a magyar kormány kottája szerint játszik.

A Politico hangsúlyozza, hogy mind Orbán, mind a szerb államfő, Aleksandar Vučić kormányzásával kapcsolatban szokás autokrata elemekről beszélni. Az persze egyáltalán nem magától értetődő, hogy Várhelyi erőfeszítései bármilyen eredményre vezethetnek majd a közeljövőben: az EU tagországok kormányainak többsége egyelőre nem akarja elsietni az unió bővítését. Ugyanakkor Várhelyi eljárásai mégis kockára tehetik a Bizottság megítélését a nyugat-balkáni kormányok körében. Abban a régióban, ahol az EU mellett Oroszország, Kína, Törökország és az Öböl-menti államok is igyekeznek nagyobb befolyásra szert tenni.

Várhelyi nem kívánt interjút adni a lapnak, de írásban válaszolt a Politico pár kérdésére, és itt azt állította, hogy a bővítési tárgyalások során igenis figyelembe vette a jogállamiság kérdését is. Ugyanakkor a Bizottság tisztviselői, uniós diplomaták és EP-képviselők ezzel nem értenek egyet.

A Bizottság egy név nélkül nyilatkozó tisztviselője arról beszélt, hogy Várhelyi aláássa a Bizottság tekintélyét a partnerországok és a tagállamok kormányai előtt. Egy másik diplomata az EU-bővítés Voldemortjaként hivatkozott Várhelyire: szerinte a magyar biztos a „budapesti urainak agendáját követi, autoriter vezetőkkel barátkozik, és nagyrészt figyelmen kívül hagyja a jogállamisággal kapcsolatos kérdéseket”.

A lapnak több nyilatkozó is hangsúlyozta, hogy a jogállamiság helyzetének kulcsfontosságú kérdésnek kell lennie, amikor EU-n kívüli, de az EU-ba vágyó államokról beszélünk. Az osztrák szociáldemokrata Andreas Schieder és a holland zöld Tineke Strik EP-képviselők is elmondták, hogy Várhelyi egyáltalán nem győzte meg őket arról, hogy fontos lenne számára ez a szempont.

Szerbia esetében ráadásul EP-képviselők és jogvédő szervezetek is úgy látják, hogy nemcsak hogy előrelépés nem történt az emberi jogok, illetve a jogállamiság területén, de egyes esetekben visszaesést is tapasztaltak. A bővítési és szomszédsági biztos azonban nem emelte fel emiatt a szavát.

A lap által megismert dokumentumok szerint Várhelyi és szűk csapata igyekszik mindent megtenni azért, hogy Szerbia csatlakozását gördülékennyé tegyék, és ehhez többek között a hivatalos uniós szövegekben is felvizezik a szerb demokrácia problémáiról szóló részeket.

Szerbia 2014-ben kezdte meg a csatlakozási tárgyalások első körét, de több nyugat-balkáni országhoz hasonlóan még nem teljesítette a hivatalos tárgyalások megkezdődéséhez szükséges feltételeket. Időközben azonban több nemzetközi jogvédő szervezet felmérése szerint is romlott a demokrácia állapota az országban. Két EB-tisztviselő elmondása szerint Várhelyi irodája ennek ellenére javította fel Szerbia értékelését a jogállamiság terén az idei bővítési jelentésben. A Politico ráakadt azokra a dokumentumokra is, melyek szerint Várhelyi hivatala nyáron a Bizottság saját értékelésével volt elégedetlen a szerb jogállamisággal kapcsolatban, és Várhelyi külön levélben kifogásolta, hogy milyen szakértőket idéztek a témával kapcsolatban.

A Bizottság név nélkül nyilatkozó tisztviselői beszámoltak arról is, hogy cél volt, hogy felgyorsítsák a szerbiai tárgyalásokat, és nyomás volt a stábon, hogy ehhez megoldásokat találjanak. Várhelyi ezzel kapcsolatban azt írta a lapnak, hogy az egész régió csatlakozási folyamatát szeretné gyorsítani.

A Politico ír arról is, hogy Várhelyi lépései a Bizottságon belül is ellenérzéseket keltettek, és a Bizottság alá tartozó Jogérvényesülés és fogyasztópolitika főigazgatóság három tisztviselője is negatív értékelést adott az idei bővítési jelentésre. Ez elsősorban azért történt, mert a szerb állapotok túl pozitívan voltak ebben bemutatva, árulta el a lapnak két bizottsági forrás.

A lap úgy tudja, hogy a Várhelyi vezette Európai Szomszédságpolitika és a Csatlakozási Tárgyalások Főigazgatóság (DG NEAR) több tisztviselője is arra kérte más főigazgatóságokon dolgozó kollégáit, hogy lépjenek fel a DG NEAR közpolitikai javaslataival szemben. Ugyanakkor a lapnak nyilatkozó források szerint ez önmagában nem elégséges ahhoz, hogy Várhelyi tevékenységét ellensúlyozzák, hiszen nem lehetséges, hogy minden egyes, a magyar biztos hivatala által beterjesztett dokumentummal szemben így járjanak el.

Egy nagyobb emberi jogi szervezet képviselője, aki név nélkül nyilatkozott, mivel nem akarta, hogy a szervezete és a Bizottság közötti munkakapcsolat sérüljön, elmondta a Politicónak, hogy mára feladta a reményt, hogy Várhelyivel egyeztethessen. Miközben Várhelyi elődje, az osztrák Johannes Hahn bármikor állt a rendelkezésükre, ha bővítési kérdésekről volt szó.

Azért is kritizálták Várhelyit, mert nem tett eleget azért, hogy feloldja az Észak-Macedónia körüli konfliktusokat. Észak-Macedónia még nevet is változtatott azért, hogy a csatlakozási tárgyalásokat megkezdhesse, ugyanakkor nyelvi és történelmi konfliktusok miatt a bolgárok mindenféle egyeztetést blokkolnak. A Bizottságból nyilatkozó források szerint Várhelyi egyáltalán nem törekedett megoldani ezt a problémát, és egy EU-diplomata szerint ennek kellene legyen jelenleg a kiemelt ügynek a portfóliójában, de semmiféle előrelépést nem tud eddig felmutatni.

Várhelyi idén felvetette azt is, hogy akkor Albánia kezdhesse meg a tárgyalásokat, míg Észak-Macedónia nem, ez pedig sokakat felháborított, hiszen az országértékelés alapján mindkét ország ugyanúgy áll, így ugyanannyira jogosult lenne a tárgyalásokra. Egy német zöld EP-képviselő, Romeo Franz szerint annyi a különbség, hogy Orbán Viktor az észak-macedón ellenzéket támogatja. Ennek világos jele az is, hogy Nikola Gruevszki jelenleg is Magyarországon tartózkodik.

A Politico cikke szerint Várhelyi kinevezése óta a DG NEAR több magas beosztású tisztviselője is távozott, mások pedig veszítettek lelkesedésükből. A problémát az okozza, hogy a stáb nagy része erőteljesen elköteleződött bizonyos értékek felé, de a kabinet jelenlegi álláspontja sokszor eltér ezektől, mondta el a lap egyik forrása. Szerinte Várhelyi egy „teljesen másik bolygón él”.

Várhelyi maga azt írta a lapnak, hogy rendkívül nagyra értékeli a DG NEAR minden beosztottjának munkáját. Von der Leyen szóvivője, Eric Mamer pedig azt írta a Politicónak, hogy Várhelyi a Bizottság elnökének teljes bizalmát élvezi.

Várhelyi Olivér karrierjéről 2019-ben hosszabban is írtunk.",
                        Description = "A Politicónak panaszkodtak uniós források, hogy a magyar bővítési biztos túlságosan elnéző Szerbiával, és nem veszi komolyan a jogállamisági feltételeket.",
                        UrlToImage = "https://assets.4cdn.hu/kraken/7UNvjX4UPQkK22n1HRs.jpeg"
                    },
                    new Article()
                    {
                        Id = 18,
                        Author = "Kovács Ferenc Dávid",
                        Title = "Válaszok nélkül maradt a magyar jogállamiságot vizsgáló tényfeltáró EU-delegáció - Index.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T06:28:00Z"),
                        Category = 3,
                        Content = @"Egymásnak ellentmondva ítélték meg a magyar jogállamiságot az EP–LIBE-küldöttség tagjai – derült ki a háromnapos magyarországi, a jogállamisággal kapcsolatos tényfeltáró látogatásuk után tartott sajtótájékoztatón. Az egyik vélemény szerint például az igazságszolgáltatás függetlenségével kapcsolatban aggályok merültek fel, egy másik álláspont szerint Magyarországon jogállamiság van – számolt be az MTI. 

A látogatásunk során feltett kérdéseinkre több esetben nem kaptunk választ a magyar hatóságoktól – jelentette ki Gwendoline Delbos-Corfield, az Európai Parlament állampolgári jogi, bel- és igazságügyi bizottsági (LIBE) küldöttség vezetője hétfőn a delegáció strasbourgi sajtótájékoztatóján.

Jorge Buxade Villalba, az Európai Konzervatívok és Reformerek képviselőcsoport politikusa ezzel szemben hangsúlyozta: Magyarországon jogállamiság van, ahol a parlament által elfogadott törvényekkel kormányoznak.

Gwendoline Delbos Corfield, az uniós parlament zöld párti képviselője aláhúzta: az igazságszolgáltatás függetlenségével kapcsolatban aggályok merültek fel, mivel a Kúria és az Alkotmánybíróság elnökét a magyar parlament kétharmados többsége választotta meg, és a legutóbb bevezetett reformok által egyre több hatalommal ruházzák fel őket.

A médiaszabadság és pluralizmus kérdésével kapcsolatban Gwendoline Delbos-Corfield úgy fogalmazott: bár az illetékes magyar hatóságok adatokkal igazolták, hogy Magyarországon legalább annyi a kormánykritikus, mint a kormánypárti sajtóorgánum, de a közpénzből egyenlőtlen módon finanszírozzák őket.

Az oktatás helyzetéről a küldöttség vezetője elmondta: benyomásai alapján aggodalomra ad okot, hogy egyre több felsőoktatási intézmény kerül alapítványi fenntartásba, ezáltal finanszírozásuk átláthatatlanná válik.

Jorge Buxade Villalba, az Európai Konzervatívok és Reformerek képviselőcsoport politikusa ezzel szemben hangsúlyozta: Magyarországon jogállamiság van, ahol a parlament által elfogadott törvényekkel kormányoznak. Véleménye szerint a delegáció vezetője, Gwendoline Delbos-Corfield saját személyes nézeteit hangsúlyozta a levont következtetések során. Az uniós parlamenti képviselő is annak a véleménynek adott hangot, hogy a látogatás során egyetlen tényszerű bizonyítékot sem találtak az emberi jogok megsértésre. Az EP-nek az a feladata, hogy védje a jogokat, és nem az, hogy egy uniós tagállam belpolitikájába beavatkozzon – jelentette ki.

Isabel Wieseler Lima, a küldöttség Európai Néppártot képviselő tagja szerint Magyarországon nem csupán „töredékes problémák vannak, hanem problémasorozatok”, amelyekkel kapcsolatban

A MAGYAR KORMÁNY ÚGY TESZ, MINTHA NEM LÉTEZNÉNEK.

Bettina Vollath, az EP szociáldemokrata képviselője úgy vélekedett, hogy Magyarországon a helyzet tovább romlott a jogállamiság szempontjából a hatalmon lévő autoriter rezsim miatt. Hangsúlyozta: sajnálattal tölti el, hogy a uniós tagországok kormányait tömörítő Tanács nem lép a 7-es cikkely szerinti eljárást illetően, továbbá a jogállamisági mechanizmus azonnali és visszamenőleges hatállyal történő alkalmazását sürgette.

Nicolas Bay, az Identitás és Demokrácia jobboldali EP-csoport képviselője szerint a magyarországi látogatás rendkívül rosszul volt időzítve, mivel az országban éppen az ellenzéki előválasztások folytak, azonban a LIBE ragaszkodott a kezdeményezéshez. Bay aláhúzta: a küldöttség semmilyen kézzelfogható bizonyítékot nem talált az emberi jogok megsértésére, azonban a delegáció tagjai már úgy érkeztek Magyarországra, hogy kritikusan vélekedtek a magyar kormányról.",
                        Description = "Válaszok nélkül maradt a magyar jogállamiságot vizsgáló tényfeltáró EU-delegáció - Kifejtették a tagok, mit tapasztaltak Magyarországon.",
                        UrlToImage = "https://kep.cdn.index.hu/1/0/4012/40124/401241/40124115_3061933_8ec128d98e9a309b44cfa02c2ee0016f_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 19,
                        Author = "24.hu",
                        Title = "Feleségül vette a rizsfőzőjét egy indonéz férfi, majd pár nap múlva el is vált tőle - 24.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T06:12:00Z"),
                        Category = 1,
                        Content = @"Hűséges, engedelmes, szeretetteljes, és remekül főz: mi mást kereshetne egy férfi élete párjában – tette fel magának a kérdést Khoirul Anam, majd mivel más nem jutott eszébe, feleségül vette az elektromos rizsfőzőjét, amire szerinte ráillettek ezek a tulajdonságok.
Khoirul Anam szeptember 20-án osztotta meg az esküvői fotóit a Facebookon. A képek melyeken a fiatal féri tradicionális ünnepi ruhát, a rizsfőző pedig fehér fátylat visel, elterjedtek a közösségi portálokon, majd a nemzetközi sajtóban is felbukkantak – írja a News18 című indonéz portál.

Alig néhány nappal az esküvő után azonban Anam bejelentette a válását. Azt írta, rájött, hogy ifjú felesége csak rizst tud főzni, ez pedig aligha lesz elég ahhoz, hogy egy életet éljen le mellette. A helyi média szerint Anam, aki egyfajta celebnek számít a hazájában, a népszerűségét akarta növelni a viccnek szánt esküvővel és válással.",
                        Description = "Nem volt túl hosszú házasság.",
                        UrlToImage = "https://24.p3k.hu/app/uploads/2021/10/rizsfozo-eskuvo-1024x576_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 20,
                        Author = "24.hu",
                        Title = "Bélyegeket vett a kormány 42 milliárdért - 24.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T05:38:00Z"),
                        Category = 3,
                        Content = @"Elég sajátos módon történt az elvileg gazdaságvédelemre szánt durván 4 ezer milliárd forintnyi pénz elköltése tavaly: a Gazdaságvédelmi Alapból kifolyatott 4030 milliárd forintnak nem egészen az egynegyede, 908 milliárd forint ment csak közvetlen gazdaságvédelmi támogatásra, amelyet a cégek kaptak meg, vette észre a Népszava a tavalyi költségvetés elszámolásában.

Ennél nagyobb összeget, csaknem 1200 milliárd forintot állami vállalatok nyeltek el. Ebből az egyik legérdekesebb tétel 42 milliárd forint, ennyiért vásárolt az állam bélyeggyűjteményt a gazdaságvédelmi kiadások terhére. „A költségvetés általános indoklásból derül ki, hogy ez a pénz valójában a Magyar Posta Zrt. feltőkésítésére ment, és, hogy ne legyen ebből tiltott állami támogatás, a Magyar Posta átadta a birtokában lévő Bélyegmúzeumot a magyar államnak, s ennek értékét 42 milliárdban állapították meg.”

Kapott jócskán pénzt a MÁV, a Volánok, vagy a Paks2-projekt is.

A kormány által közölt adatokból az is kiszámítható, hogy csak készpénzben és csak tavaly 137,7 milliárd forintot kaptak a gazdaságvédelmi alapból a Fideszhez köthető, vagy egyenesen a kormánytagok által irányított közalapítványok – nem ideértve a kormánypárt által szinten elfoglalt felsőoktatási alapítványokat. Ezen felül a fideszes közalapítványok tavaly több száz milliárdnyi állami vagyont kaptak Mol-részvények, vagy ingatlanok formájában – írja a lap.

A legtöbb pénzt a Mathias Corvinus Collegium kapta (amelynek vezetője Orbán Balázs, a kormányfő politikai igazgatója), ezen belül külön árulkodó, hogy 14,5 milliárd forint készpénz került a Kommentár Alapítványhoz – „amely gyakorlatilag a hasonló című folyóiratot kiadó alapítványt takarja, illetve a Fidesz politikai hátországának szellemi műhelye. Vagyis a gazdaságvédelmi pénzekből politikai tevékenység támogatására szavazott meg a kormány több, mint 10 milliárd forintot.”

Sajnos az elszámolásból nem derül ki pontosan, hogy bizonyos tételek valójában mit takarnak, így hiába lenne elvárható az átláthatóság, egyes kiadási tételek tartalma homályban marad. A lap ide sorolja, hogy 207 milliárdot számolt le a kormány „egyes energetikai kérdésekről szóló előterjesztés szerinti feladatok végrehajtásához kapcsolódó forrásigény” címen, „de az nem derül ki, hogy mire is ment pontosan ez a bő 200 milliárd. Más forrásokból tudhatjuk, hogy ez a pénz a kormány karácsonyi pénzszórásaként kerülhetett az állami tulajdonban lévő MVM energiaholdinghoz. A képviselők előtt fekvő törvénytervezetből az is kiderül, hogy kormány a gazdaságvédelmi pénzek terhére 198 milliárd forintot fizetett ki „nemzetközi pénzügyi szolgáltatásokkal kapcsolatos egyes intézkedésekre”. A szövegből kihámozható, a hogy pénzt az utolsó fillérig a Corvinus Befektetési Zrt. kapta hiteltartozásai rendezésére. A Corvinus egy állami befektetési cég, amely a Budapest Bankot illetve az Erste Bank kisebbségi részét birtokolja. A Budapest Bank – miután az beolvadt a Magyar Bankholdingba – , már nincs a cég tulajdonában, ám a zárszámadási törvényből nem derül ki a világosan, hogy pontosan mire is használta a 198 milliárdot az állami Corvinus Zrt.”",
                        Description = "És homályban marad, hogy mire költött valójában százmilliárdokat az állam. A Fideszhez köthető vagy kormánytagok által vezetett közalapítványokhoz ömlött készpénz.",
                        UrlToImage = "https://24.p3k.hu/app/uploads/2021/10/d_mtz20210603012-e1633412293181-1024x575_wm.jpg"
                    },
                    new Article()
                    {
                        Id = 21,
                        Author = "Molnár Szabina",
                        Title = "Házaspár halt meg a győrújbaráti balesetben - Index.hu",
                        PublishedAt = DateTime.Parse("2021-10-05T05:32:00Z"),
                        Category = 2,
                        Content = @"Egy házaspár vesztette életét Győr-Moson-Sopron megyében, miután egy figyelmetlenül előző autós balesetet okozott Győrújbarát közelében. A rendőrség tájékoztatása szerint a 68 éves férfi még a helyszínen, 62 éves felesége a kórházban vesztette életét.

A Győr - Moson - Sopron Megyei Rendőr - főkapitányság tájékoztatása szerint egy 49 éves győri férfi hétfő este a 82 - es számú főút felől Győrújbarát irányába haladt,
                        amikor előzési szándékkal áttért a menetirány szerinti bal oldali sávba,
                        ahol összeütközött egy szemből érkező autóval.Ebben az autóban utazott a házaspár,
                        akik meghaltak a balesetben.Az ütközés feltételezett okozóját súlyos sérülésekkel vitték kórházba.

A rendőrség minden autóst arra kér,
                        hogy mielőtt előzni akar,
                        mindenképpen figyelmesen nézzen körül az úton,
                        hogy elkerülhessék az efféle baleseteket.",
                        Description = "Házaspár halt meg a győrújbaráti balesetben - A szerencsétlenség hétfő este történt.",
                        UrlToImage = "https://kep.cdn.index.hu/1/0/4012/40124/401242/40124215_3061941_9e22581180692ad98346a3ddc98875a5_wm.jpg"
                    });
        }
    }
}
