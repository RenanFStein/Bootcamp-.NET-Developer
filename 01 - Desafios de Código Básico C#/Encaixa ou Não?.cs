using System.IO;
using System.Linq;
using static System.Console;

class teste{

    static void Main(string[] args)
    {
        int qt = int.Parse(ReadLine());
        
        for (int i = 0 ;i<qt ;i++)
        {
            string[] v = ReadLine().Split(); 
            string a = v[0];
            string b = v[1];

            if (a.EndsWith(b)){
                WriteLine("encaixa");
            }
            else {WriteLine("nao encaixa");}
        }
    }
}
