﻿using DataStructuresProje3;
using System.Collections;


List<UM_ALANI> VeriOkumaListeAtama()
{
    List<UM_ALANI> Alanlar = new List<UM_ALANI>();

    String veriler = "1. Divrigi Ulu Camii ve Darüşşifası (Sivas) 1985 \r\n\r\n2. Istanbul'un Tarihi Alanları (İstanbul) 1985 \r\n\r\n3. Goreme Millî Parkı ve Kapadokya (Nevşehir) 1985 (Karma Miras Alanı) \r\n\r\n4. Hattusa: Hitit Başkenti (Çorum) 1986 \r\n\r\n5. Nemrut Dağı (Adıyaman) 1987 \r\n\r\n6. Hieropolis-Pamukkale (Denizli) 1988 (Karma Miras Alanı) \r\n\r\n7. Xanthos-Letoon (Antalya-Muğla) 1988 \r\n\r\n8. Safranbolu Şehri (Karabük) 1994 \r\n\r\n9. Truva Arkeolojik Alanı (Çanakkale) 1998 \r\n\r\n10. Edirne Selimiye Camii ve Külliyesi (Edirne) 2011 \r\n\r\n11. Catalhoyuk Neolitik Alanı (Konya) 2012 \r\n\r\n12. Bursa ve Cumalıkızık: Osmanlı İmparatorluğunun Doğuşu (Bursa) 2014 \r\n\r\n13. Bergama Çok Katmanlı Kültürel Peyzaj Alanı (İzmir) 2014 \r\n\r\n14. Diyarbakir Kalesi ve Hevsel Bahçeleri Kültürel Peyzajı (Diyarbakır) 2015 \r\n\r\n15. Efes (İzmir) 2015 \r\n\r\n16. Ani Arkeolojik Alanı (Kars) 2016 \r\n\r\n17. Aphrodisias (Aydın) 2017 \r\n\r\n18. Gobekli Tepe (Şanlıurfa) 2018\r\n\r\n19. Arslantepe Höyüğü (Malatya) 2021\r\n\r\n20. Gordion (Ankara) 2023\r\n\r\n21. Anadolu’nun Ortaçağ Dönemi Ahşap Hipostil Camiileri (Konya-Eşrefoğlu Camii, Kastamonu-Mahmut Bey Camii, Eskişehir-Sivrihisar Camii, Afyon-Afyon Ulu Camii, Ankara-Arslanhane Camii) 2023";
    String[] satirVeriler = veriler.Split("\r\n\r", StringSplitOptions.RemoveEmptyEntries);

    String[] paragraflar =
    {
        "This region of Anatolia was conquered by the Turks at the beginning of the 11th century. In 1228–29 Emir Ahmet Shah founded a mosque, with its adjoining hospital, at Divrigi. The mosque has a single prayer room and is crowned by two cupolas. The highly sophisticated technique of vault construction, and a creative, exuberant type of decorative sculpture – particularly on the three doorways, in contrast to the unadorned walls of the interior – are the unique features of this masterpiece of Islamic architecture.",
        "With its strategic location on the Bosphorus peninsula between the Balkans and Anatolia, the Black Sea and the Mediterranean, Istanbul has been associated with major political, religious and artistic events for more than 2,000 years. Its masterpieces include the ancient Hippodrome of Constantine, the 6th-century Hagia Sophia and the 16th-century Süleymaniye Mosque, all now under threat from population pressure, industrial pollution and uncontrolled urbanization.",
        "In a spectacular landscape, entirely sculpted by erosion, the Göreme valley and its surroundings contain rock-hewn sanctuaries that provide unique evidence of Byzantine art in the post-Iconoclastic period. Dwellings, troglodyte villages and underground towns – the remains of a traditional human habitat dating back to the 4th century – can also be seen there.",
        "The archaeological site of Hattusha, former capital of the Hittite Empire, is notable for its urban organization, the types of construction that have been preserved (temples, royal residences, fortifications), the rich ornamentation of the Lions' Gate and the Royal Gate, and the ensemble of rock art at Yazilikaya. The city enjoyed considerable influence in Anatolia and northern Syria in the 2nd millennium B.C.",
        "The mausoleum of Antiochus I (69–34 B.C.), who reigned over Commagene, a kingdom founded north of Syria and the Euphrates after the breakup of Alexander's empire, is one of the most ambitious constructions of the Hellenistic period. The syncretism of its pantheon, and the lineage of its kings, which can be traced back through two sets of legends, Greek and Persian, is evidence of the dual origin of this kingdom's culture.",
        "Deriving from springs in a cliff almost 200 m high overlooking the plain, calcite-laden waters have created at Pamukkale (Cotton Palace) an unreal landscape, made up of mineral forests, petrified waterfalls and a series of terraced basins. At the end of the 2nd century B.C. the dynasty of the Attalids, the kings of Pergamon, established the thermal spa of Hierapolis. The ruins of the baths, temples and other Greek monuments can be seen at the site.",
        "This site, which was the capital of Lycia, illustrates the blending of Lycian traditions and Hellenic influence, especially in its funerary art. The epigraphic inscriptions are crucial for our understanding of the history of the Lycian people and their Indo-European language.",
        "From the 13th century to the advent of the railway in the early 20th century, Safranbolu was an important caravan station on the main East–West trade route. The Old Mosque, Old Bath and Süleyman Pasha Medrese were built in 1322. During its apogee in the 17th century, Safranbolu's architecture influenced urban development throughout much of the Ottoman Empire.",
        "Troy, with its 4,000 years of history, is one of the most famous archaeological sites in the world. The first excavations at the site were undertaken by the famous archaeologist Heinrich Schliemann in 1870. In scientific terms, its extensive remains are the most significant demonstration of the first contact between the civilizations of Anatolia and the Mediterranean world. Moreover, the siege of Troy by Spartan and Achaean warriors from Greece in the 13th or 12th century B.C., immortalized by Homer in the Iliad, has inspired great creative artists throughout the world ever since.",
        "The square Mosque with its single great dome and four slender minarets, dominates the skyline of the former Ottoman capital of Edirne. Sinan, the most famous of Ottoman architects in the 16th century, considered the complex, which includes madrasas (Islamic schools), a covered market, clock house, outer courtyard and library, to be his best work. The interior decoration using Iznik tiles from the peak period of their production testifies to an art form that remains unsurpassed in this material. The complex is considered to be the most harmonious expression ever achieved of the Ottoman külliye, a group of buildings constructed around a mosque and managed as a single institution.",
        "Two hills form the 37 ha site on the Southern Anatolian Plateau. The taller eastern mound contains eighteen levels of Neolithic occupation between 7400 bc and 6200 bc, including wall paintings, reliefs, sculptures and other symbolic and artistic features. Together they testify to the evolution of social organization and cultural practices as humans adapted to a sedentary life. The western mound shows the evolution of cultural practices in the Chalcolithic period, from 6200 bc to 5200 bc. Çatalhöyük provides important evidence of the transition from settled villages to urban agglomeration, which was maintained in the same location for over 2,000 years. It features a unique streetless settlement of houses clustered back to back with roof access into the buildings.",
        "This property is a serial nomination of eight component sites in the City of Bursa and the nearby village of Cumalıkızık, in the southern Marmara region. The site illustrates the creation of an urban and rural system establishing the Ottoman Empire in the early 14th century. The property embodies the key functions of the social and economic organization of the new capital which evolved around a civic centre. These include commercial districts of khans, kulliyes (religious institutions) integrating mosques, religious schools, public baths and a kitchen for the poor, as well as the tomb of Orhan Ghazi, founder of the Ottoman dynasty. One component outside the historic centre of Bursa is the village of Cumalıkızık, the only rural village of this system to show the provision of hinterland support for the capital.",
        "This site rises high above the Bakirçay Plain in Turkey’s Aegean region. The acropolis of Pergamon was the capital of the Hellenistic Attalid dynasty, a major centre of learning in the ancient world. Monumental temples, theatres, stoa or porticoes, gymnasium, altar and library were set into the sloping terrain surrounded by an extensive city wall. The rock-cut Kybele Sanctuary lies to the north-west on another hill visually linked to the acropolis. Later the city became capital of the Roman province of Asia known for its Asclepieion healing centre. The acropolis crowns a landscape containing burial mounds and remains of the Roman, Byzantine and Ottoman empires in and around the modern town of Bergama on the lower slopes.",
        "Located on an escarpment of the Upper Tigris River Basin that is part of the so-called Fertile Crescent, the fortified city of Diyarbakır and the landscape around has been an important centre since the Hellenistic period, through the Roman, Sassanid, Byzantine, Islamic and Ottoman times to the present. The site encompasses the Inner castle, known as İçkale and including the Amida Mound, and the 5.8 km-long city walls of Diyarbakır with their numerous towers, gates, buttresses, and 63 inscriptions. The site also includes the Hevsel Gardens, a green link between the city and the Tigris that supplied the city with food and water, the Anzele water source and the Ten-Eyed Bridge.",
        "Located within what was once the estuary of the River Kaystros, Ephesus comprises successive Hellenistic and Roman settlements founded on new locations, which followed the coastline as it retreated westward. Excavations have revealed grand monuments of the Roman Imperial period including the Library of Celsus and the Great Theatre. Little remains of the famous Temple of Artemis, one of the “Seven Wonders of the World,” which drew pilgrims from all around the Mediterranean. Since the 5th century, the House of the Virgin Mary, a domed cruciform chapel seven kilometres from Ephesus, became a major place of Christian pilgrimage. The Ancient City of Ephesus is an outstanding example of a Roman port city, with sea channel and harbour basin.",
        "This site is located on a secluded plateau of northeast Turkey overlooking a ravine that forms a natural border with Armenia. This medieval city combines residential, religious and military structures, characteristic of a medieval urbanism built up over the centuries by Christian and then Muslim dynasties. The city flourished in the 10th and 11th centuries CE when it became the capital of the medieval Armenian kingdom of the Bagratides and profited from control of one branch of the Silk Road. Later, under Byzantine, Seljuk and Georgian sovereignty, it maintained its status as an important crossroads for merchant caravans. The Mongol invasion and a devastating earthquake in 1319 marked the beginning of the city’s decline. The site presents a comprehensive overview of the evolution of medieval architecture through examples of almost all the different architectural innovations of the region between the 7th and 13th centuries CE.",
        "Located in southwestern Turkey, in the upper valley of the Morsynus River, the site consists of two components: the archaeological site of Aphrodisias and the marble quarries northeast of the city. The temple of Aphrodite dates from the 3rd century BC and the city was built one century later. The wealth of Aphrodisias came from the marble quarries and the art produced by its sculptors. The city streets are arranged around several large civic structures, which include temples, a theatre, an agora and two bath complexes.",
        "Located in the Germuş mountains of south-eastern Anatolia, this property presents monumental round-oval and rectangular megalithic structures erected by hunter-gatherers in the Pre-Pottery Neolithic age between 9,600 and 8,200 BCE. These monuments were probably used in connection with rituals, most likely of a funerary nature. Distinctive T-shaped pillars are carved with images of wild animals, providing insight into the way of life and beliefs of people living in Upper Mesopotamia about 11,500 years ago.",
        "Arslantepe Mound is a 30-metre-tall archaeological tell located in the Malatya plain, 15 km south-west of the Euphrates River. Archaeological evidence from the site testifies to its occupation from at least the 6th millennium BCE up until the Medieval period. The earliest layers belong to the Late Chalcolithic 1-2 periods, contemporary to Early Uruk in Southern Mesopotamia (4300-3900 BCE) and are characterized by adobe houses. The most prominent and flourishing period of the site was in the Late Chalcolithic 5 period, during which the so-called palace complex was constructed. Considerable evidence also testifies to the Early Bronze Age period, most prominently identified by the Royal Tomb complex. The archaeological stratigraphy then extends to the Middle and Late Bronze Ages and Hittite periods, including Neo-Hittite levels. The site illustrates the processes which led to the emergence of a State society in the Near East and a sophisticated bureaucratic system that predates writing. Exceptional metal objects and weapons have been excavated at the site, among them the earliest swords so far known in the world, which suggests the beginning of forms of organized combat as the prerogative of an elite, who -at Arslantepe- exhibited them as instruments of their new political power. ",
        "Located in an open rural landscape, the archaeological site of Gordion is a multi-layered ancient settlement, encompassing the remains of the ancient capital of Phrygia, an Iron Age independent kingdom. The key elements of this archaeological site include the Citadel Mound, the Lower Town, the Outer Town and Fortifications, and several burial mounds and tumuli with their surrounding landscape. Archaeological excavations and research have revealed a wealth of remains that document construction techniques, spatial arrangements, defensive structures, and inhumation practices that shed light on Phrygian culture and economy.",
        "This serial property is comprised of five hypostyle mosques built in Anatolia between the late 13th and mid-14th centuries, each located in a different province of present-day Türkiye. The unusual structural system of the mosques combines an exterior building envelope built of masonry with multiple rows of wooden interior columns (“hypostyle”) that support a flat wooden ceiling and the roof. These mosques are known for the skilful woodcarving and handiwork used in their structures, architectural fittings, and furnishings."
    };

    int donguNo = 1;
    foreach (string veri in satirVeriler)
    {
        string alanAdi;
        List<string> ilAdlari = new List<string>();
        string ilanYili;

        string[] parcalanmisVeri = veri.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        if (donguNo < 10) { alanAdi = parcalanmisVeri[0].Substring(3).Trim(); }
        else
        {
            alanAdi = parcalanmisVeri[0].Substring(4).Trim();//metin teimleme tam dogru calısmıyor.
        }

        ilanYili = parcalanmisVeri[2].Trim();

        string iller = parcalanmisVeri[1].Trim();
        if (donguNo != 21 & donguNo != 7) { ilAdlari.Add(iller); }

        if (donguNo == 7)
        {
            string[] elemanlar = iller.Split('-');
            ilAdlari.Add(elemanlar[0]);
            ilAdlari.Add(elemanlar[1]);
        }
        if (donguNo == 21)
        {
            //burada özel bir algoritma ile il sayısı birden fazla olan mirasın il verilerini ayıklatıyorum.
            string[] elemanlar = iller.Split(", ");

            foreach (string e in elemanlar)
            {
                string[] parca = e.Split('-');
                if (parca.Length > 1)
                {
                    string sehir = parca[0];
                    ilAdlari.Add(sehir);
                }
            }
        }

        //burada paragraftaki kelimeler split ile bosluğa göre ayrıstırılıp arraye atanıyor. daha sonra her kelime trim ile nokta virgül ve paranztezlerden kurtarılıyor.
        string[] paragrafKelimeleri = paragraflar[donguNo-1].Split(" ");
        List<string> kelimeler = new List<string>();
        foreach(string kelime in paragrafKelimeleri)
        {
            string duzenlenmisKelime = kelime.Trim(',', '.', '(', ')', ' ');
            kelimeler.Add(duzenlenmisKelime);
        }
        //Um alan nesneleri oluşturulup listeye atanıyor.
        UM_ALANI alan = new UM_ALANI(alanAdi, ilAdlari, ilanYili,kelimeler);
        Alanlar.Add(alan);
        donguNo++;
    }
    return Alanlar;
}


List<UM_ALANI> alanlar = VeriOkumaListeAtama();
MyBinarySearchTree UMagaci = new MyBinarySearchTree();
foreach (UM_ALANI alan in alanlar)
{
    UMagaci.insert(alan);
}

//UMagaci.preOrder(UMagaci.getRoot());
//UMagaci.inOrder(UMagaci.getRoot());
//UMagaci.postOrder(UMagaci.getRoot());
//UMagaci.metot1a(UMagaci.getRoot());
//UMagaci.metot1c(UMagaci.getRoot());
//Hashtable myHash = UMagaci.metot2a(alanlar);
//myHash = UMagaci.metot2b(myHash);
//MyBinarySearchTree blancedTree = UMagaci.metot1d(UMagaci.getRoot());
//blancedTree.metot1b(blancedTree.getRoot());

//MyHeap newHeap = new MyHeap();

/*foreach(UM_ALANI alan in alanlar)
{
    newHeap.insert(alan);
}
newHeap.metot3c();*/

void bubbleSort(List<int> list)
{
    void swap (int one,int two)
    {
        int temp = list[one];
        list[one] = list[two];
        list[two] = temp;
    }
    for(int outt = list.Count; outt >1; outt++)
    {
        for(int inn = 0; inn < outt; inn++)
        {
            if (list[inn] > list[inn + 1])
            {
                swap(inn, inn + 1);
            }
        }
    }
}