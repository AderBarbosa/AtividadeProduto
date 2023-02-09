using System;

class Program {
  public static void Main (string[] args) {
  string produto, convert, convert1;
  Double valor, quantidade, desconto1, desconto2, desconto3;
    
    Console.WriteLine ("Informe o nome do produto adquirido: " );
    produto = Console.ReadLine();
    Console.WriteLine (" Qual o valor do produto: " );
    convert = Console.ReadLine ();
  valor = Double.Parse(convert);
    Console.WriteLine (" Quantidade adquirida do produto: " );
    convert1 = Console.ReadLine ();
  quantidade = Double.Parse (convert1);
  desconto1 = 0.02;
  desconto2 = 0.03;
  desconto3 = 0.05;
    if (quantidade <= 5)
    {
      Double i, d, t;
      i = (quantidade * valor);
      d = (i * desconto1);
      t = (i - d);
      Console. WriteLine(" O produto " + produto + " quantidade adquirida é de " + quantidade + " e o desconto foi de 2%" + " O valor total é de R$" + t);
    }
        if (quantidade > 5 && quantidade <= 10)
        {
           Double i, d, t;
      i = (quantidade * valor);
      d = (i * desconto2);
      t = (i - d);
      Console. WriteLine(" O produto " + produto + " quantidade adquirida é de " + quantidade + " e o desconto foi de 3%" + " O valor total é de R$" + t);
        }
    
        if (quantidade > 10)
        {
        Double i, d, t;
      i = (quantidade * valor);
      d = (i * desconto3);
      t = (i - d);
      Console. WriteLine(" O produto " + produto + " a quantidade adquirida foi de " + quantidade + " e o desconto foi de 5%" + " O valor total é de R$" + t);
        }
    
  }
}