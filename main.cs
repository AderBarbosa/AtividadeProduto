using System;

class Program {
  public static void Main (string[] args) {
  string produto, convert, convert1;
  Double valor, quantidade;
    Console. WritteLine("Informe o nome do produto adquirido: " ) 
    produto = Console.ReadLine();
    Console. WritteLine(" Qual o valor do produto: " )
    convert = Console.ReadLine ();
  valor = Double.Parse(conver);
    Console. WritteLine(" Quantidade adquirida do produto: " ) 
    convert1 = Console.ReadLine ();
  quantidade = Double.Parse(conver1);
  desconto1 = 0.02
  desconto2 = 0.03
  desconto3 = 0.05
    if (quantidade <= 5)
    {
      Double i, t;
      i = (quantidade * valor)
      t = (i - desconto1)
      Console. WritteLine(" O produto " + produto + " a quantidade adquirida é de " + quantidade + " e o desconto foi de 2%" );
    }
        if (quantidade > 5 && quantidade <= 10)
        {
           Double i, t;
      i = (quantidade * valor)
      t = (i - desconto2)     
        Console. WritteLine(" O produto " + produto + " a quantidade adquirida é de " + quantidade + " e o desconto foi de 3%" );
        }
        if (quantidade > 10)
        {
        Double i, t;
      i = (quantidade * valor)
      t = (i - desconto3)   
        Console. WritteLine(" O produto " + produto + " a quantidade adquirida é de " + quantidade + " e o desconto foi de 5%" );
        }
  }
}
