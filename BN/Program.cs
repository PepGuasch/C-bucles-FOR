internal class Program
{
    private static void Main(string[] args)
    {
        int filas = 8;
        int columnas = 8;
        for (int fila = 0; fila < filas; fila++)
        {
            for (int columna = 0; columna < columnas; columna++)
            {
                char contenidoCelda = (fila + columna) % 2 == 0 ? 'B' : 'N';
                Console.Write(contenidoCelda);
            }
            Console.WriteLine();
        }
    }
}