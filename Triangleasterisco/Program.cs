internal class Program
{
    private static void Main(string[] args)
    {
        int altura = 15;
        int baseTriangulo = 15;
        for (int fila = 1; fila <= altura; fila++)
        {

            for (int columna = 1; columna <= baseTriangulo; columna++)
            {
                if (columna <= fila)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}