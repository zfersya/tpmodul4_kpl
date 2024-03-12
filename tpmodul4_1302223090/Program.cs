// See https://aka.ms/new-console-template for more information

using tpmodul4_1302223090;

// soal 1
KodePos kodePos = new KodePos();
KodePos.NamaDaerah namaDaerah = KodePos.NamaDaerah.Kujangsari;
Console.WriteLine("Kelurahan " + namaDaerah + " KodePos " + kodePos.GetKodePos(namaDaerah));
namaDaerah = KodePos.NamaDaerah.Batununggal;
Console.WriteLine("Kelurahan " + namaDaerah + " KodePos " + kodePos.GetKodePos(namaDaerah));

// soal 2

DoorMachine.State state = DoorMachine.State.terkunci;
string[] doorState = { "terkunci", "terbuka" };
while (true)
{
    Console.WriteLine("Pintu " + doorState[(int)state]);
    Console.WriteLine("Masukkan Perintah : ");
    string command = Console.ReadLine();
    switch (state)
    {
        case DoorMachine.State.terkunci:
            
            if (command == "BukaPintu")
                state = DoorMachine.State.terbuka;
            else if (command == "KunciPintu")
                state = DoorMachine.State.terkunci;
            else
                state = DoorMachine.State.terkunci;
            break;
        case DoorMachine.State.terbuka:
            if (command == "KunciPintu")
                state = DoorMachine.State.terkunci;
            else if (command == "BukaPintu")
                state = DoorMachine.State.terbuka;
            else
                state = DoorMachine.State.terbuka;
            break;
    }

    Console.WriteLine("|");
    Console.WriteLine("|");
    Console.WriteLine("V");
}
 