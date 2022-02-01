
public static class MeniSistem
{
    static List<Osoba> hotel = new();
    public static void Main()
    {
        do
        {
            Console.WriteLine("===============================");
            Console.WriteLine("1. Imenik                     │");
            Console.WriteLine("2. Prikazite Informacije      │");
            Console.WriteLine("3. Cenovnik                   │");
            Console.WriteLine("4. Izlaz                      │");
            Console.WriteLine("===============================");
            Console.Write("Izbor: ");
            string unos = Console.ReadLine();
            switch (unos)
            {
                case "1":
                    Unosinformacija();
                    break;

                case "2":
                    Console.Clear();
                    PrikazInformacija();
                    break;

                case "3":
                    Console.Clear();
                    Cenovnik();
                    break;

                case "4":
                    return;
            }
            Console.Clear();
        } while (true);
    }
    static void Cenovnik()
    {
        int _soba = 2000;
        int _obroci = 1000;
        int _roomservice = 1500;

        Console.Clear();
        Console.WriteLine("Ovo su nase ponude");
        Console.WriteLine("1. Hotelska soba bez dodatnih troskova");
        Console.WriteLine("2. Hotelska soba sa obrocima");
        Console.WriteLine("3. Hotelska soba sa room servisom");
        Console.WriteLine("4. Hotelska soba sa obrocima i room servisom");
        Console.WriteLine("5. Nazad");
        string unos = Console.ReadLine();
        Console.Clear();
        switch (unos)
        {
            case "1":
                Console.WriteLine($"Cena hotelske sobe bez dodatnih troskova je \n{_soba} Dinara");
                Console.ReadKey();
                break;

            case "2":
                Console.WriteLine($"Cena hotelske sobe sa obrocima je \n{_soba + _obroci} Dinara");
                Console.ReadKey();
                break;

            case "3":
                Console.WriteLine($"Cena hotelske sobe sa room servisom je \n{_soba + _roomservice} Dinara");
                Console.ReadKey();
                break;

            case "4":
                Console.WriteLine($"Cena hotelske sobe sa obrocima i room servisom je \n{_soba + _obroci + _roomservice} Dinara");
                Console.ReadKey();
                break;

            case "5":
                return;

            default:
                Console.WriteLine("ERROR");
                Console.ReadKey();
                Cenovnik();
                break;
        }
    }
    static void Unosinformacija()
    {
        Console.Clear();
        Console.WriteLine("==========================");
        Console.WriteLine("1. Unesite Informacije   │");
        Console.WriteLine("2. Nazad                 │");
        Console.WriteLine("==========================");
        string unos = Console.ReadLine();
        Console.Clear();

        switch (unos)
        {
            case "1":
                Console.Clear();
                ImeIPrezime();
                break;

            case "2":
                return;
        }
    }
    static void ImeIPrezime()
    {
        Osoba o = new();
        Console.Write("Unesite ime: ");
        o._ime = Console.ReadLine();
        Console.Write("Unesite prezime: ");
        o._prezime = Console.ReadLine();
        Console.Write("Unesite email: ");
        o._email = Console.ReadLine();
        Console.Write("Unesite broj sobe: ");
        o._brojsobe = Console.ReadLine();

        hotel.Add(o);

        foreach (Osoba neko in hotel)
        {
            Console.WriteLine($"{neko._ime} {neko._prezime} {neko._email} {neko._brojsobe}");
        }
    }
    static void PrikazInformacija()
    {
        foreach (Osoba neko in hotel)
        {
            Console.WriteLine($"Ime: {neko._ime}");
            Console.WriteLine($"Prezime: {neko._prezime}");
            Console.WriteLine($"Email: {neko._email}");
            Console.WriteLine($"Broj Sobe: {neko._brojsobe}");
        }
        Console.ReadKey();
    }
   
}

