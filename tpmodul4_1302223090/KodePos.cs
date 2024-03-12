using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223090
{
    internal class KodePos
    {
        /*private String[,] tableKodePos = {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };*/
       // using enum
        public enum NamaDaerah
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        }
        private string[] kodePos = {
        "40266", // Batununggal
        "40287", // Kujangsari
        "40267", // Mengger
        "40256", // Wates
        "40287", // Cijaura
        "40286", // Jatisari
        "40286", // Margasari
        "40286", // Sekejati
        "40272", // Kebonwaru
        "40274", // Maleer
        "40273"  // Samoja
        };
        public string GetKodePos(NamaDaerah namaDaerah)
        {
            int i = (int)namaDaerah;
            if (i >= 0 && i < kodePos.Length)
            {
                return kodePos[i];
            }
            else
            {
                return "Kodepos tidak tersedia";
            }
        }
    }
}
