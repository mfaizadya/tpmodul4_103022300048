// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>()
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijawura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public string getKodePos(string kelurahan)
    {
        if (tabelKodePos.ContainsKey(kelurahan))
        {
            return tabelKodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class DoorMachine
{
    private enum State {Terkunci, Terbuka}
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci; // State awal terkunci
    }

    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci.");
        }
        else
        {
            Console.WriteLine("Pintu sudah dalam keadaan terkunci.");
        }
    }

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci.");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka.");
        }
    }

    public void TampilkanStatus()
    {
        Console.WriteLine($"Status pintu saat ini: {currentState}");
    }

}

    class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();
        string[] kelurahanList = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijawura", "Jatisari", "Margasari", "Sekejati", "Sekejati", "Kebonwaru", "Maleer", "Samoja"};

        Console.WriteLine("Daftar Kode Pos:");
        foreach (var kelurahan in kelurahanList)
        {
            Console.WriteLine($"{kelurahan}: {kodePos.getKodePos(kelurahan)}");
        }

        DoorMachine pintu = new DoorMachine();

        pintu.TampilkanStatus();
        pintu.BukaPintu();
        pintu.TampilkanStatus();
        pintu.KunciPintu();
        pintu.TampilkanStatus();

    }
}




