using System;  

class minhaClasse { 

  static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    if (salario <= 400) { 
      percentual = 0.15; 
      reajuste =  salario * percentual; 
      novoSalario =   salario + reajuste; 


    } else if (salario <= 800) { 
      percentual = 0.12; 
      reajuste =  salario * percentual; 
      novoSalario =   salario + reajuste; 

    } else if (salario <= 1200) { 
      percentual = 0.10; 
      reajuste =  salario * percentual; 
      novoSalario =   salario + reajuste; 

    } else if (salario <= 2000) { 
      percentual = 0.07; 
      reajuste =  salario * percentual; 
      novoSalario =   salario + reajuste; 

    } else { 
      percentual = 0.04; 
      reajuste =  salario * percentual; 
      novoSalario =   salario + reajuste; 

    } 

    Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}"); 
    Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}"); 
    Console.WriteLine($"Em percentual: {percentual.ToString("P0")}"); 

  } 
}
