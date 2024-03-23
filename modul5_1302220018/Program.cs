// See https://aka.ms/new-console-template for more informatio
public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T? num1, T? num2, T? num3)
    {
        dynamic num1Parse = num1;
        dynamic num2Parse = num2;
        dynamic num3Parse = num3;
        Console.WriteLine(num1Parse + num2Parse + num3Parse);
    }
    

    static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.JumlahTigaAngka<int>(13, 22, 20);
    }
    
}




