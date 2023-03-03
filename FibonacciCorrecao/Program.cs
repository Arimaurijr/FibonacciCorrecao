internal class Program
{
    private static void Main(string[] args)
    {
        double ant = 1, prox = 0;
        //double atual = 1;
        int posicao;

        Console.WriteLine("Informe a posicao desejada: ");
        posicao = int.Parse(Console.ReadLine());

        /*
        for(int i =0; i<=posicao;i++)
        {
            atual = ant + prox;
            ant = prox;
            prox = atual;
            Console.Write(atual + " ");
        }
        */

        for(int i = 0; i < posicao; i++)
        {
            Console.Write(ant + prox + " ");
            prox = ant + prox;
            ant = prox - ant;
        }
       

    }
}