using System;

class DIO {
        
static void Main(string[] args){

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int l = n % 10;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
             // multiplica para obter o produto
             p *= l;
             // adiciona para obter a soma
             s += l;
             // divide por 10 para obter a proxima casa decimal (digito)
             n /= 10;
           }

           Console.WriteLine(p-s);
        }
    }
