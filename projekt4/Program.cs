
using System;

class KontoBankowe
{

    private string wlasciciel;
    private decimal saldo;

    public KontoBankowe(string wlasciciel, decimal saldoPoczatkowe)
    {
        this.wlasciciel = wlasciciel;
        saldo = saldoPoczatkowe >= 0 ? saldoPoczatkowe : 0;
    }

    public void PokazSaldo()
    {
        Console.WriteLine($"{wlasciciel}: {saldo} zł");
    }

    public void PokazInformacje()
    {
        Console.WriteLine($"Właściciel: {wlasciciel} | Aktualne saldo: {saldo} zł");
    }

    public void Wplac(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Nieprawidłowa kwota");
            return;
        }
        saldo += kwota;
        Console.WriteLine($"Wpłacono: {kwota} zł");
    }

    public void Wyplac(decimal kwota)
    {
        if (kwota <= 0 || kwota > saldo)
        {
            Console.WriteLine("Nie można wypłacić tej kwoty");
            return;
        }
        saldo -= kwota;
        Console.WriteLine($"Wypłacono: {kwota} zł");
    }

    public bool CzyStacMnie(decimal kwota)
    {
        if (kwota > 0 && saldo >= kwota)
        {
            return true;
        }
        return false;
    }
}

class Program
{
    static void Main()
    {

        KontoBankowe konto1 = new KontoBankowe("Jan", 1000m);
        KontoBankowe konto2 = new KontoBankowe("Anna", 2500m);
        KontoBankowe konto3 = new KontoBankowe("Piotr", 400m);


        konto1.Wplac(500m);

        konto2.Wyplac(300m);

        konto3.Wyplac(1000m);


        konto1.PokazInformacje();
        konto2.PokazInformacje();
        konto3.PokazInformacje();

        decimal czystac = 2000m;
        Console.WriteLine($"Czy Anię stać na wydatek {czystac} zł? " + konto2.CzyStacMnie(czystac));
    }
}






//KontoBankowe konto1 new KontoBankowe("Jan",1000);
//KontoBankowe konto2;
//KontoBankowe konto3;