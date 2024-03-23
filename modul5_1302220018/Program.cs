// See https://aka.ms/new-console-template for more information
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