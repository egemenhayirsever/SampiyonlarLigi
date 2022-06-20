using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiSimulasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //1. TORBA -----------------------------------------------------------------------------------------------

            Takimlar tk1 = new Takimlar();
            tk1.TakimAdi = "BayernMunich";
            tk1.Ulke = "Almanya";
            tk1.Torba = "1.Torba";

            Takimlar tk2 = new Takimlar();
            tk2.TakimAdi = "Sevilla";
            tk2.Ulke = "İspanya";
            tk2.Torba = "1.Torba";

            Takimlar tk3 = new Takimlar();
            tk3.TakimAdi = "Real Madrid";
            tk3.Ulke = "İspanya";
            tk3.Torba = "1.Torba";

            Takimlar tk4 = new Takimlar();
            tk4.TakimAdi = "Liverpool";
            tk4.Ulke = "İngiltere";
            tk4.Torba = "1.Torba";

            Takimlar tk5 = new Takimlar();
            tk5.TakimAdi = "Juventus";
            tk5.Ulke = "İtalya";
            tk5.Torba = "1.Torba";

            Takimlar tk6 = new Takimlar();
            tk6.TakimAdi = "Paris Saint-Germain";
            tk6.Ulke = "Fransa";
            tk6.Torba = "1.Torba";

            Takimlar tk7 = new Takimlar();
            tk7.TakimAdi = "Zenit";
            tk7.Ulke = "Rusya";
            tk7.Torba = "1.Torba";

            Takimlar tk8 = new Takimlar();
            tk8.TakimAdi = "Porto";
            tk8.Ulke = "Portekiz";
            tk8.Torba = "1.Torba";


            //2. TORBA -----------------------------------------------------------------------------------------------
            Takimlar tk9 = new Takimlar();
            tk9.TakimAdi = "Barcelona";
            tk9.Ulke = "İspanya";
            tk9.Torba = "2.Torba";

            Takimlar tk10 = new Takimlar();
            tk10.TakimAdi = "Atlético Madrid";
            tk10.Ulke = "İspanya";
            tk10.Torba = "2.Torba";

            Takimlar tk11 = new Takimlar();
            tk11.TakimAdi = "Manchester City";
            tk11.Ulke = "İngiltere";
            tk11.Torba = "2.Torba";

            Takimlar tk12 = new Takimlar();
            tk12.TakimAdi = "Manchester United";
            tk12.Ulke = "İngiltere";
            tk12.Torba = "2.Torba";

            Takimlar tk13 = new Takimlar();
            tk13.TakimAdi = "Borussia Dortmund";
            tk13.Ulke = "Almanya";
            tk13.Torba = "2.Torba";

            Takimlar tk14 = new Takimlar();
            tk14.TakimAdi = "Shakhtar Donetsk";
            tk14.Ulke = "Ukrayna";
            tk14.Torba = "2.Torba";

            Takimlar tk15 = new Takimlar();
            tk15.TakimAdi = "Chelsea";
            tk15.Ulke = "İngiltere";
            tk15.Torba = "2.Torba";

            Takimlar tk16 = new Takimlar();
            tk16.TakimAdi = "Ajax";
            tk16.Ulke = "Hollanda";
            tk16.Torba = "2.Torba";


            //3. TORBA -----------------------------------------------------------------------------------------------

            Takimlar tk17 = new Takimlar();
            tk17.TakimAdi = "Dynamo Kiev";
            tk17.Ulke = "Ukrayna";
            tk17.Torba = "3.Torba";

            Takimlar tk18 = new Takimlar();
            tk18.TakimAdi = "Red Bull Salzburg";
            tk18.Ulke = "Almanya";
            tk18.Torba = "3.Torba";

            Takimlar tk19 = new Takimlar();
            tk19.TakimAdi = "RB Leipzig";
            tk19.Ulke = "Almanya";
            tk19.Torba = "3.Torba";

            Takimlar tk20 = new Takimlar();
            tk20.TakimAdi = "Internazionale";
            tk20.Ulke = "İtalya";
            tk20.Torba = "3.Torba";

            Takimlar tk21 = new Takimlar();
            tk21.TakimAdi = "Olympiacos";
            tk21.Ulke = "Yunanistan";
            tk21.Torba = "3.Torba";

            Takimlar tk22 = new Takimlar();
            tk22.TakimAdi = "Lazio";
            tk22.Ulke = "İtalya";
            tk22.Torba = "3.Torba";

            Takimlar tk23 = new Takimlar();
            tk23.TakimAdi = "Krasnodar";
            tk23.Ulke = "Rusya";
            tk23.Torba = "3.Torba";

            Takimlar tk24 = new Takimlar();
            tk24.TakimAdi = "Atalanta";
            tk24.Ulke = "İtalya";
            tk24.Torba = "3.Torba";
            //4. TORBA -----------------------------------------------------------------------------------------------

            Takimlar tk25 = new Takimlar();
            tk25.TakimAdi = "Lokomotiv Moskova";
            tk25.Ulke = "Rusya";
            tk25.Torba = "4.Torba";

            Takimlar tk26 = new Takimlar();
            tk26.TakimAdi = "Marseille";
            tk26.Ulke = "Fransa";
            tk26.Torba = "4.Torba";

            Takimlar tk27 = new Takimlar();
            tk27.TakimAdi = "Club Brugge";
            tk27.Ulke = "Belçika";
            tk27.Torba = "4.Torba";


            Takimlar tk28 = new Takimlar();
            tk28.TakimAdi = "Bor. Mönchengladbach";
            tk28.Ulke = "Almanya";
            tk28.Torba = "4.Torba";


            Takimlar tk29 = new Takimlar();
            tk29.TakimAdi = "Galatasaray";
            tk29.Ulke = "Türkiye";
            tk29.Torba = "4.Torba";


            Takimlar tk30 = new Takimlar();
            tk30.TakimAdi = "Midtjylland";
            tk30.Ulke = "Danimarka";
            tk30.Torba = "4.Torba";


            Takimlar tk31 = new Takimlar();
            tk31.TakimAdi = "Rennes";
            tk31.Ulke = "Fransa";
            tk31.Torba = "4.Torba";


            Takimlar tk32 = new Takimlar();
            tk32.TakimAdi = "Ferencváros";
            tk32.Ulke = "Macaristan";
            tk32.Torba = "4.Torba";

            List<Takimlar> listTakim = new List<Takimlar> { tk1, tk2, tk3, tk4, tk5, tk6, tk7, tk8, tk9, tk10, tk11, tk12, tk13, tk14,tk15,tk16,tk17,tk18,tk19,tk20,tk21,tk22,tk23,tk24,tk25,tk26,tk27,tk28,tk29,tk30,tk31,tk32 };
           
            // KOŞULLAR
            /*
            1)Aynı torba
            2)Aynı ülkeden olmayacak
            */
            char[] grup = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            int j = 0;
            int birinciTorbadanGelenTakimIndexi = 0;
            int ikinciTorbadanGelenTakimIndexi = 0;
            int ucuncuTorbadanGelenTakimIndexi = 0;
            int dorduncuTorbadanGelenTakimIndexi = 0;
            int turSay = 0;
            Random rastgele = new Random();
        a:
            for (int i = 0; i < 8; i++)//grup
            {
                Console.WriteLine(grup[i] + " Grubu");
                //1. torbadan takımlar
                j = 0;
                while (j < 1)
                {
                    birinciTorbadanGelenTakimIndexi = rastgele.Next(8);
                    if (listTakim[birinciTorbadanGelenTakimIndexi].Grup == null)
                    {
                        listTakim[birinciTorbadanGelenTakimIndexi].Grup = "Grubu " + grup[i];
                        Console.WriteLine(listTakim[birinciTorbadanGelenTakimIndexi].TakimAdi + " - " + listTakim[birinciTorbadanGelenTakimIndexi].Ulke);
                        j++;
                    }
                    else
                    {
                        turSay++;
                        if (turSay > 100)
                        {
                            Console.Clear();
                            foreach (var item in listTakim)
                            {
                                item.Grup = null;
                            }
                            turSay = 0;
                            goto a;
                        }
                    }
                }
                //2. torbadan takımlar
                j = 0;
                while (j < 1)
                {
                    ikinciTorbadanGelenTakimIndexi = rastgele.Next(8, 16);
                    if (listTakim[ikinciTorbadanGelenTakimIndexi].Grup == null && listTakim[birinciTorbadanGelenTakimIndexi].Ulke != listTakim[ikinciTorbadanGelenTakimIndexi].Ulke)
                    {
                        listTakim[ikinciTorbadanGelenTakimIndexi].Grup = "Grubu " + grup[i];
                        Console.WriteLine(listTakim[ikinciTorbadanGelenTakimIndexi].TakimAdi + " - " + listTakim[ikinciTorbadanGelenTakimIndexi].Ulke);
                        j++;
                    }
                    else
                    {
                        turSay++;
                        if (turSay > 100)
                        {
                            Console.Clear();
                            foreach (var item in listTakim)
                            {
                                item.Grup = null;
                            }
                            turSay = 0;
                            goto a;
                        }
                    }
                }
                //3. torbadan takımlar
                j = 0;
                while (j < 1)
                {
                    ucuncuTorbadanGelenTakimIndexi = rastgele.Next(16, 24);
                    if (listTakim[ucuncuTorbadanGelenTakimIndexi].Grup == null && listTakim[ucuncuTorbadanGelenTakimIndexi].Ulke != listTakim[birinciTorbadanGelenTakimIndexi].Ulke && listTakim[ucuncuTorbadanGelenTakimIndexi].Ulke != listTakim[ikinciTorbadanGelenTakimIndexi].Ulke)
                    {
                        listTakim[ucuncuTorbadanGelenTakimIndexi].Grup = "Grubu " + grup[i];
                        Console.WriteLine(listTakim[ucuncuTorbadanGelenTakimIndexi].TakimAdi + " - " + listTakim[ucuncuTorbadanGelenTakimIndexi].Ulke);
                        j++;
                    }
                    else
                    {
                        turSay++;
                        if (turSay > 100)
                        {
                            Console.Clear();
                            foreach (var item in listTakim)
                            {
                                item.Grup = null;
                            }
                            turSay = 0;
                            goto a;
                        }
                    }
                }
                //4. torbadan takımlar
                j = 0;
                turSay = 0;
                while (j < 1)
                {
                    dorduncuTorbadanGelenTakimIndexi = rastgele.Next(24, 32);
                    if (listTakim[dorduncuTorbadanGelenTakimIndexi].Grup == null && listTakim[dorduncuTorbadanGelenTakimIndexi].Ulke != listTakim[ucuncuTorbadanGelenTakimIndexi].Ulke && listTakim[dorduncuTorbadanGelenTakimIndexi].Ulke != listTakim[birinciTorbadanGelenTakimIndexi].Ulke && listTakim[dorduncuTorbadanGelenTakimIndexi].Ulke != listTakim[ikinciTorbadanGelenTakimIndexi].Ulke)
                    {
                        listTakim[dorduncuTorbadanGelenTakimIndexi].Grup = "Grubu " + grup[i];
                        Console.WriteLine(listTakim[dorduncuTorbadanGelenTakimIndexi].TakimAdi + " - " + listTakim[dorduncuTorbadanGelenTakimIndexi].Ulke);
                        j++;
                    }
                    else
                    {
                        turSay++;
                        if(turSay > 100)
                        {
                            Console.Clear();
                            foreach(var item in listTakim)
                            {
                                item.Grup = null;
                            }
                            turSay = 0;
                            goto a;
                        }
                    }
                }
                Console.WriteLine();
            }
            #endregion
            
            //fixture belirle Mac yaptir
            Console.WriteLine("A Grubu");
            
            //List<Takimlar> grupA = new List<Takimlar>();
            //foreach (var item in listTakim)
            //{
            //    if (item.Grup == "Grubu A")
            //    {
            //        grupA.Add(item);

            //    }

            //}
           
            
            List<Takimlar> grupA = listTakim.Where(t => t.Grup == "Grubu A").ToList();
            grupA = FiksturBelirle(grupA);//db.SaveChanges gibi
            PuanDurumunuGoster(grupA);

            Console.WriteLine("B Grubu");
            List<Takimlar> grupB = listTakim.Where(t => t.Grup == "Grubu B").ToList();
            grupB = FiksturBelirle(grupB);//db.SaveChanges gibi
            PuanDurumunuGoster(grupB);

            Console.WriteLine("C Grubu");
            List<Takimlar> grupC = listTakim.Where(t => t.Grup == "Grubu C").ToList();
            grupC = FiksturBelirle(grupC);//db.SaveChanges gibi
            PuanDurumunuGoster(grupC);

            Console.WriteLine("D Grubu");
            List<Takimlar> grupD = listTakim.Where(t => t.Grup == "Grubu D").ToList();
            grupD = FiksturBelirle(grupD);//db.SaveChanges gibi
            PuanDurumunuGoster(grupD);

            Console.WriteLine("E Grubu");
            List<Takimlar> grupE = listTakim.Where(t => t.Grup == "Grubu E").ToList();
            grupE = FiksturBelirle(grupE);//db.SaveChanges gibi
            PuanDurumunuGoster(grupE);

            Console.WriteLine("F Grubu");
            List<Takimlar> grupF = listTakim.Where(t => t.Grup == "Grubu F").ToList();
            grupF = FiksturBelirle(grupF);//db.SaveChanges gibi
            PuanDurumunuGoster(grupF);

            Console.WriteLine("G Grubu");
            List<Takimlar> grupG = listTakim.Where(t => t.Grup == "Grubu G").ToList();
            grupG = FiksturBelirle(grupG);//db.SaveChanges gibi
            PuanDurumunuGoster(grupG);

            Console.WriteLine("H Grubu");
            List<Takimlar> grupH = listTakim.Where(t => t.Grup == "Grubu H").ToList();
            grupH = FiksturBelirle(grupH);//db.SaveChanges gibi
            PuanDurumunuGoster(grupH);

            Console.ReadLine();
            
        }
        
        static List<Takimlar> FiksturBelirle(List<Takimlar> grup)
        {
            Random rastgele = new Random();
            int takim1Index = -1;
            int takim2Index = -1;
            int takim3Index = -1;
            int takim4Index = -1;
            int j = 0;
            while (j < 3) // 3 tane fikstur çıkarması lazım 6 maç
            {
                takim1Index = rastgele.Next(4); 
                takim2Index = rastgele.Next(4);
                if (takim1Index != takim2Index)
                {      
                    //ör:liverpoolun rakibi                ör:barcelona
                    if (grup[takim1Index].Rakip1 == null && grup[takim2Index].Rakip1 == null)
                    {
                        //gruptaki takım 3 ve takım 4 bu for ile bulundu
                        for (int k = 0; k < 4; k++)
                        {
                            if (k != takim1Index && k != takim2Index)
                            {
                                if (takim3Index < 0)
                                {
                                    takim3Index = k;
                                }
                                else
                                {
                                    takim4Index = k;
                                }
                            }
                        }
                        // Liverpool rakibi Barcelona
                        //Barcelonanın rakibi Liverpool
                        grup[takim1Index].Rakip1 = grup[takim2Index].TakimAdi;
                        grup[takim2Index].Rakip1 = grup[takim1Index].TakimAdi;
                        grup[takim3Index].Rakip1 = grup[takim4Index].TakimAdi;
                        grup[takim4Index].Rakip1 = grup[takim3Index].TakimAdi;
                        Console.WriteLine("----Maclar----");
                        /*evSahibiGol = rastgele.Next(8);
                        konukSahibiGol = rastgele.Next(8);*/
                        grup = MacYap(grup, takim1Index, takim2Index, takim3Index, takim4Index);
                        j++;//1 maçlar tamamlandığı için j yi 1 arttırdım. j = 3 olduğunda döngüden çıkar
                    }
                    takim1Index = -1;
                    takim2Index = -1;
                    takim3Index = -1;
                    takim4Index = -1;
                    takim1Index = rastgele.Next(4);
                    takim2Index = rastgele.Next(4);
                    if(takim1Index != takim2Index)
                    {
                        if (grup[takim1Index].Rakip2 == null && grup[takim2Index].Rakip2 == null)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                if (k != takim1Index && k != takim2Index)
                                {
                                    if (takim3Index < 0)
                                    {
                                        takim3Index = k;
                                    }
                                    else
                                    {
                                        takim4Index = k;
                                    }
                                }
                            }
                            grup[takim1Index].Rakip2 = grup[takim2Index].TakimAdi;
                            grup[takim2Index].Rakip2 = grup[takim1Index].TakimAdi;
                            grup[takim3Index].Rakip2 = grup[takim4Index].TakimAdi;
                            grup[takim4Index].Rakip2 = grup[takim3Index].TakimAdi;
                            if (grup[takim1Index].Rakip2 != grup[takim1Index].Rakip1 && grup[takim2Index].Rakip2 != grup[takim2Index].Rakip1
                                && grup[takim3Index].Rakip2 != grup[takim3Index].Rakip1 && grup[takim4Index].Rakip2 != grup[takim4Index].Rakip1)
                            {
                                Console.WriteLine("----Maclar----");
                                grup = MacYap(grup, takim1Index, takim2Index, takim3Index, takim4Index);
                                /*Console.WriteLine(grup[takim1Index].TakimAdi + " vs " + grup[takim2Index].TakimAdi);
                                Console.WriteLine(grup[takim3Index].TakimAdi + " vs " + grup[takim4Index].TakimAdi);*/
                                j++;
                            }
                            else
                            {
                                foreach (var item in grup)
                                {
                                    item.Rakip2 = null;
                                }
                            }
                        }
                    }
                    takim1Index = -1;
                    takim2Index = -1;
                    takim3Index = -1;
                    takim4Index = -1;
                    takim1Index = rastgele.Next(4);
                    takim2Index = rastgele.Next(4);
                    if(takim1Index != takim2Index)
                    {
                        if (grup[takim1Index].Rakip3 == null && grup[takim2Index].Rakip3 == null)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                if (k != takim1Index && k != takim2Index)
                                {
                                    if (takim3Index < 0)
                                    {
                                        takim3Index = k;
                                    }
                                    else
                                    {
                                        takim4Index = k;
                                    }
                                }
                            }
                            grup[takim1Index].Rakip3 = grup[takim2Index].TakimAdi;
                            grup[takim2Index].Rakip3 = grup[takim1Index].TakimAdi;
                            grup[takim3Index].Rakip3 = grup[takim4Index].TakimAdi;
                            grup[takim4Index].Rakip3 = grup[takim3Index].TakimAdi;
                            if (grup[takim1Index].Rakip3 != grup[takim1Index].Rakip1 && grup[takim2Index].Rakip3 != grup[takim2Index].Rakip1
                                && grup[takim3Index].Rakip3 != grup[takim3Index].Rakip1 && grup[takim4Index].Rakip3 != grup[takim4Index].Rakip1 &&
                                grup[takim1Index].Rakip3 != grup[takim1Index].Rakip2 && grup[takim2Index].Rakip3 != grup[takim2Index].Rakip2
                                && grup[takim3Index].Rakip3 != grup[takim3Index].Rakip2 && grup[takim4Index].Rakip3 != grup[takim4Index].Rakip2)
                            {
                                Console.WriteLine("----Maclar----");
                                grup = MacYap(grup, takim1Index, takim2Index, takim3Index, takim4Index);
                                /*Console.WriteLine(grup[takim1Index].TakimAdi + " vs " + grup[takim2Index].TakimAdi);
                                Console.WriteLine(grup[takim3Index].TakimAdi + " vs " + grup[takim4Index].TakimAdi);*/
                                j++;
                            }
                            else
                            {
                                foreach (var item in grup)
                                {
                                    item.Rakip3 = null;
                                }
                            }
                        }
                    }
                    
                }
            }
            Console.WriteLine();
            return grup;
        }

        static List<Takimlar> MacYap(List<Takimlar> grup, int takim1Index, int takim2Index, int takim3Index, int takim4Index)
        {
            Random rastgele = new Random();
            int evSahibiTakimGol = rastgele.Next(8);
            int konukTakimGol = rastgele.Next(8);
            //bunlar genel toplam gol oldukları için sürekli ekleniyorlar
            grup[takim1Index].AtilanGol += evSahibiTakimGol;
            grup[takim2Index].AtilanGol += konukTakimGol;
            grup[takim1Index].YenilenGol += konukTakimGol;
            grup[takim2Index].YenilenGol += evSahibiTakimGol;
            if (evSahibiTakimGol > konukTakimGol)
            {
                grup[takim1Index].Puan += 3;
            }
            else if (evSahibiTakimGol < konukTakimGol)
            {
                grup[takim2Index].Puan += 3;
            }
            else
            {
                grup[takim1Index].Puan += 1;
                grup[takim2Index].Puan += 1;
            }
            Console.WriteLine(grup[takim1Index].TakimAdi + " " + evSahibiTakimGol + " - " + konukTakimGol + " " + grup[takim2Index].TakimAdi);
            evSahibiTakimGol = rastgele.Next(8);
            konukTakimGol = rastgele.Next(8);
            grup[takim2Index].AtilanGol += evSahibiTakimGol;
            grup[takim1Index].AtilanGol += konukTakimGol;
            grup[takim2Index].YenilenGol += konukTakimGol;
            grup[takim1Index].YenilenGol += evSahibiTakimGol;
            if (evSahibiTakimGol > konukTakimGol)
            {
                grup[takim2Index].Puan += 3;
            }
            else if (evSahibiTakimGol < konukTakimGol)
            {
                grup[takim1Index].Puan += 3;
            }
            else
            {
                grup[takim1Index].Puan += 1;
                grup[takim2Index].Puan += 1;
            }
            Console.WriteLine(grup[takim2Index].TakimAdi + " " + evSahibiTakimGol + " - " + konukTakimGol + " " + grup[takim1Index].TakimAdi);
            evSahibiTakimGol = rastgele.Next(8);
            konukTakimGol = rastgele.Next(8);
            grup[takim3Index].AtilanGol += evSahibiTakimGol;
            grup[takim4Index].AtilanGol += konukTakimGol;
            grup[takim3Index].YenilenGol += konukTakimGol;
            grup[takim4Index].YenilenGol += evSahibiTakimGol;
            if (evSahibiTakimGol > konukTakimGol)
            {
                grup[takim3Index].Puan += 3;
            }
            else if (evSahibiTakimGol < konukTakimGol)
            {
                grup[takim4Index].Puan += 3;
            }
            else
            {
                grup[takim3Index].Puan += 1;
                grup[takim4Index].Puan += 1;
            }
            Console.WriteLine(grup[takim3Index].TakimAdi + " " + evSahibiTakimGol + " - " + konukTakimGol + " " + grup[takim4Index].TakimAdi);
            evSahibiTakimGol = rastgele.Next(8);
            konukTakimGol = rastgele.Next(8);
            grup[takim4Index].AtilanGol += evSahibiTakimGol;
            grup[takim3Index].AtilanGol += konukTakimGol;
            grup[takim4Index].YenilenGol += konukTakimGol;
            grup[takim3Index].YenilenGol += evSahibiTakimGol;
            if (evSahibiTakimGol > konukTakimGol)
            {
                grup[takim4Index].Puan += 3;
            }
            else if (evSahibiTakimGol < konukTakimGol)
            {
                grup[takim3Index].Puan += 3;
            }
            else
            {
                grup[takim3Index].Puan += 1;
                grup[takim4Index].Puan += 1;
            }
            Console.WriteLine(grup[takim4Index].TakimAdi + " " + evSahibiTakimGol + " - " + konukTakimGol + " " + grup[takim3Index].TakimAdi);
            return grup;
        }

        static void PuanDurumunuGoster(List<Takimlar> grup)
        {
            //Önce puana göre sonra averaja göre sonra Atılan gole göre sırala
            List<Takimlar> siralama = grup.OrderByDescending(t => t.Puan).ThenByDescending(t => t.Avaraj).ThenByDescending(t => t.AtilanGol).ToList();
            Console.WriteLine("\nPuan Durumu:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((i + 1) + ". " + siralama[i].TakimAdi + " P:" + siralama[i].Puan + " A:" + siralama[i].Avaraj + " AG:" + siralama[i].AtilanGol + " YG:" + siralama[i].YenilenGol);
            }
            Console.WriteLine("\nGruptan Cikanlar:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(siralama[i].TakimAdi);
            }
            Console.WriteLine();

        }

    }


}
