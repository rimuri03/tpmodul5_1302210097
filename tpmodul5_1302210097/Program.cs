public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
<<<<<<< HEAD
        Console.WriteLine("Halo user " + user.ToString());
    }

}
=======
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
>>>>>>> generic-class
class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
<<<<<<< HEAD
        string namaPanggilan = "Rimuri";
        halo.SapaUser(namaPanggilan);
=======
        string namaPanggilan = "Rizki";
        halo.SapaUser(namaPanggilan);

        DataGeneric<string> data = new DataGeneric<string>("1302210097");
        data.PrintData();
>>>>>>> generic-class
    }
}

