Console.WriteLine("\t \t \t \t \t \t \t Welcome to Bank");
tryagain:
string username = Console.ReadLine();
string password = Console.ReadLine();
string secim_et = "";
int inputay = 0;
string inputAy = "";
string kreditMiqdar = "";
int odenmeliMebleg = 0;
int inputAyliq = 0;
int yeniay = 0;
int kreditMiqdariInt = 0;
int inputayInt = 0;
int qiymetYeni = 0;
int ayYeni = 0;


if (username == "Admin" && password == "admin")
{
    Console.WriteLine("WELCOME Admin");
Menu:
    Console.WriteLine("Zehmet olmasa secin :" +
        "\n 1.Kredit goturmek \n 2. kredit odemek \n 3. hesabat");
    string secim1 = "1";
    string secim2 = "2";
    string secim3 = "3";
    Console.WriteLine("Emeliyyat: ");
    secim_et = Console.ReadLine();
    string click = "";



    if (secim_et == secim1)
    {
        Console.WriteLine("Ay daxil edin: 12 ve ya 24  ");
        inputayInt = int.Parse(Console.ReadLine());
        Console.WriteLine("Mebleg daxil edin : ");
    meblegdaxil:
        kreditMiqdariInt = int.Parse(Console.ReadLine());
        odenmeliMebleg = kreditMiqdariInt + kreditMiqdariInt / 100 * inputayInt;
        inputAyliq = kreditMiqdariInt / inputayInt;
        if (kreditMiqdariInt < 0)
        {
            Console.WriteLine("Xahis olunur 0 dan boyuk eded giresiz");
            goto meblegdaxil;

        }


        if (inputayInt == 12)
        {
            Console.WriteLine("odenelocek mebleg");
            Console.WriteLine(odenmeliMebleg);

        }
        else if (inputayInt == 24)
        {

            Console.WriteLine("Odenilecek mebleg");
            Console.WriteLine(odenmeliMebleg);

        }
        Console.WriteLine("Ayliq odenis");
        Console.WriteLine(inputAyliq);

        Console.WriteLine("Rasiniz ? ");
        Console.WriteLine("1.Beli \n 2.xeyr");
        string beli = Console.ReadLine();
        string beli1 = "1";
        string beli2 = "2";
        if (beli == beli1)
        {
            Console.WriteLine("Emeliyyat ugurla tamamlandi !");
            qiymetYeni = odenmeliMebleg;
            ayYeni = inputayInt;


            goto Menu;
        }
        else if (beli == beli2)
        {
            Console.WriteLine("Emeliyyat legv olundu");
            goto Menu;
        }
    }
    if (secim_et == secim3)
    {
        Console.WriteLine("Borcunuz");
        Console.WriteLine(qiymetYeni);
        Console.WriteLine("Qalan ay");
        Console.WriteLine(ayYeni);
        Console.WriteLine("Menyuya qayitmaq ucun 0 click edin");
        click = Console.ReadLine();
        if (click == "0")
        {
            goto Menu;
        }


    }

    if (secim_et == secim2)
    {


        Console.WriteLine("Ayliq odenis :");
        Console.WriteLine(inputAyliq);

        Console.WriteLine("Odemek ucun 1 i basin");
        string clickode = Console.ReadLine();
        if (clickode == "1")
        {
            Console.WriteLine("Odenis ugurlu oldu");
            qiymetYeni = qiymetYeni - inputAyliq;
            ayYeni = ayYeni - 1;
            Console.WriteLine("Qalan borc");
            Console.WriteLine(qiymetYeni);
            Console.WriteLine("Qalan ay");
            Console.WriteLine(ayYeni);
            goto Menu;
        }


    }

}


else
{
    Console.WriteLine("Zehmet olmasa kodunuzu duzgun girin ");
    goto tryagain;
}
