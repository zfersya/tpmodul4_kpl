// See https://aka.ms/new-console-template for more information

using tpmodul4_1302223090;

KodePos kodePos = new KodePos();


KodePos.NamaDaerah namaDaerah = KodePos.NamaDaerah.Kujangsari;
Console.WriteLine("Kelurahan " + namaDaerah + " KodePos " + kodePos.GetKodePos(namaDaerah));
namaDaerah = KodePos.NamaDaerah.Batununggal;
Console.WriteLine("Kelurahan " + namaDaerah + " KodePos " + kodePos.GetKodePos(namaDaerah));