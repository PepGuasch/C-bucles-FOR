internal class Program
{
    private static void Main(string[] args)
    {
        int nota1,nota2,nota3,notamedia;
        Console.WriteLine("Nota de matematicas: ");
        nota1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nota de Biologia: ");
        nota2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nota de Quimica: ");
        nota3=Convert.ToInt32(Console.ReadLine());
        notamedia=((nota1 + nota2 + nota3)/3);
        if (notamedia>=5){
            Console.WriteLine("Tu nota media es de {0}, has aprovado !!",notamedia);
            
        }
        else{
            Console.WriteLine("Tu nota media es de {0}, has suspendido !",notamedia);
        }
    }
}