using System;

namespace MainPrintFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Iprintable pdf = new PDF();
            Iprintable word = new Word();
            Iprintable excell = new Excell();
            MainPrintFile wordFile = new MainPrintFile(word);
            MainPrintFile pdfFile = new MainPrintFile(pdf);
            MainPrintFile excelFile = new MainPrintFile(excell);

        }
    }
}
