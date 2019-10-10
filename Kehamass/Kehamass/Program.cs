using System;

namespace Kehamass
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            Console.WriteLine("Mis on sinu eesnimi? ");
            firstName = Console.ReadLine();
            Console.WriteLine("Mis on sinu perekonnanimi? ");
            lastName = Console.ReadLine();
            Console.WriteLine("Tere {0} {1} ", firstName, lastName);
            Console.WriteLine("Millal sina oled sündinud? Kirjuta aasta: ");
            int aasta;
            aasta = int.Parse(Console.ReadLine());
            int vanus = 2019 - aasta;
            Console.WriteLine("Sina oled " + vanus + " aastat vana");
            if (vanus < 20 || vanus > 60)
            {
                Console.WriteLine("Vabandust kuid programm töötab vanuse vahemikus 20 aastat kuni 60 aastat. ");
            }
            else
            {
                double kehakaal;
                Console.WriteLine("Kui palju sa kaalud? ");
                kehakaal = Double.Parse(Console.ReadLine());

                double pikkus;
                Console.WriteLine("Kui pikk sa oled meetrites? ");
                pikkus = Double.Parse(Console.ReadLine());

                double kehamassiindeks;
                kehamassiindeks = kehakaal / (pikkus * pikkus);

                if (kehamassiindeks < 16)
                {
                    Console.WriteLine("See on tervisele ohtlik, Kehamassi indeksi järgi olete tugevas alakaalus. Väike kaal võib olla osaliselt pärilik, kuid kindlasti tasuks pidada esimese asjana nõu oma perearstiga. Tema saaks vajadusel teha uuringuid, mis aitaks selgitada kaaluprobleemi olemust. Selle kõrval tuleks kindlasti analüüsida põhjalikult oma toitumist. Kas ikka saate toiduga piisavalt energiat? Ise saate pidada toitumispäevikut internetis näiteks nutridata.ee programmi all. Samas võite soovi korral minna arsti vastuvõtule, et koos teie toitumine ja võimalikud terviseprobleemid läbi arutada. ");
                }
                else if (kehamassiindeks > 16 && kehamassiindeks < 18.5)
                {
                    Console.WriteLine("Kehamassi indeksi järgi olete alakaaluline. Väike kaal võib olla osaliselt pärilik, kuid kindlasti tasuks pidada esimese asjana nõu oma perearstiga. Tema saaks vajadusel teha uuringuid, mis aitaks selgitada kaaluprobleemi olemust. Selle kõrval tuleks kindlasti analüüsida põhjalikult oma toitumist. Kas ikka saate toiduga piisavalt energiat? Ise saate pidada toitumispäevikut internetis näiteks nutridata.ee programmi all. Samas võite soovi korral minna arsti vastuvõtule, et koos teie toitumine ja võimalikud terviseprobleemid läbi arutada.");

                }
                else if (kehamassiindeks > 18.6 && kehamassiindeks < 25)
                {
                    Console.WriteLine("Olete normaalkaalus, teil ei ole põhjust nuretsemiseks. ");
                }
                else if (kehamassiindeks > 25.1 && kehamassiindeks < 30)
                {
                    Console.WriteLine("Olete ülekaalus. Selleks et saada aimu kaalutõusu põhjustest, tuleks üle vaadata nii toitumise kui füüsilise aktiivsuse pool. Samuti võivad kaalutõusu mõjutada üleväsimus, magamatus, vale unerežiim. Vajalik oleks toidu- ja liikumispäeviku analüüs.");
                }
                else if (kehamassiindeks > 30.1 && kehamassiindeks < 35)
                {
                    Console.WriteLine("Olete rasvunud. Kui olete inimene, kellele mõjub hästi grupi toetus, siis on kaalujälgijad ehk tänase nimetusega figuurisõbrad ilmselt teie jaoks õige koht. Kui soovite enam üksinda tegutseda, siis selles osas abistavad teid erinevad interneti keskkonnad (toitumine.ee; kaaluabi.ee, jt). Oluline on, et oleksite oma tegevuses järjepidev, sest vaid nii saab loota püsivatele tulemustele.");
                }
                else if (kehamassiindeks > 35.1 && kehamassiindeks < 40)
                {
                    Console.WriteLine("Olete tugevalt rasvunud. Kirja teel ühtegi diagnoosi panna ei saa, kuid rasvumine suurendab kordades kirjas mainitud haiguste väljakujunemis riski. Kindlasti soovitan teil pöörduda arstlikule nõustamisele. Teie kehamassi indeks on > 38, mis tähendab, et teie puhul on tegu raskekujulise rasvumisega, mitte kerge ülekaaluga.Nagu juba mainitud on rasvumine riskifaktoriks paljude raskete haiguste väljakujunemisel. ");

                }
                else
                {
                    Console.WriteLine("Olete tugevas ülekaalus. Teie seisund on tervisele ohtlik, palun pöörduge esimesel võimalusel oma arsti poole! ");
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
