namespace classes;
class Program
{
    static void Main(string[] args)
    {
        Worker worker1 = new Worker();
        worker1.Name="Metehan";
        worker1.Surname="Metinoğlu";
        worker1.No=87713017;
        worker1.Departmant="IT";
        worker1.WorkerInformations();
        
        Console.WriteLine("************");
        Worker worker2 = new Worker();
        worker2.Name="Ömer Talha";
        worker2.Surname="Metinoğlu";
        worker2.No=873213017;
        worker2.Departmant="Education";
        worker2.WorkerInformations();

    }

    
}

class Worker
{
    public string Name;
    public string Surname;
    public int No;
    public string Departmant;

    public void WorkerInformations()
    {
        Console.WriteLine("Çalışan Adı:{0}",Name);
        Console.WriteLine("Çalışan Adı:{0}",Surname);
        Console.WriteLine("Çalışan Adı:{0}",No);
        Console.WriteLine("Çalışan Adı:{0}",Departmant);
    }

}
