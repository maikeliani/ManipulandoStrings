internal class Program
{
    private static void Main(string[] args)
    {   
        string nome;
        Console.WriteLine("Informe seu nome: ");
        nome = Console.ReadLine();
        /*
        Console.WriteLine("Olá {0}", nome);
        Console.WriteLine(nome.Length);
        Console.WriteLine(nome.ToUpper());
        Console.WriteLine(nome.Trim('l')); // remove caracteres de INICIO e FIM
        Console.ReadLine();
        */

        RemoveVogais(nome);
       

        void RemoveVogais(string x)
        {
            
            x = x.Replace('a', '\0');
            x = x.Replace('e', '\0');
            x = x.Replace('i', '\0');
            x = x.Replace('o', '\0');
            x = x.Replace('u', '\0');

            Console.WriteLine(x);
           
        }

       



    }
}