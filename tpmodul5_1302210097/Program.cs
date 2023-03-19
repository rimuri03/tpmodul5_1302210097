public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo User " + user.ToString());
    }

}
public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data.ToString());
    }
}
class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string namaPanggilan = "Rizki";
        halo.SapaUser(namaPanggilan);

        DataGeneric<string> data = new DataGeneric<string>("1302210097");
        data.PrintData();
    }
}

