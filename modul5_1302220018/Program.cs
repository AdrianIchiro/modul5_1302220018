
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;


    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + 1 + " berisi: " + this.storedData[i] + " yang disimpan pada waktu UTC " + this.inputDates[i]);
        }
    }

   static void Main(string[] args)
    {
        SimpleDataBase<string> simpleDataBase = new SimpleDataBase<string>();
        simpleDataBase.AddNewData("13");
        simpleDataBase.AddNewData("02");
        simpleDataBase.AddNewData("22");
        simpleDataBase.PrintAllData();
    }
}

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




