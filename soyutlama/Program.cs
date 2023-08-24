 public abstract class calısan
{//fieldımız tanımladık
    public string gorev;
    public DateTime isebaslamatarih;
    public string adsoyad;
    public int maas;
 // constructor açtık
    public calısan()
    {
        gorev = "Yazılım Mühendisi";
        isebaslamatarih = DateTime.Now;
        adsoyad = "Ahmet Melih Pekmez";
        maas = 20000;
    }
}
//abstract klasımızı ana klasta örnekleyememizden ötürü yeni bir klas tanımladık ve kalıtım kullandık
public class İsveren:calısan
{
    public İsveren()
    {
        Console.WriteLine($"Çalışan özellikleri\nAdı Soyadı:{adsoyad}\nGörevi:{gorev}\nİşe Başlama Tarihi:{isebaslamatarih}\nMaaşı:{maas}");
    }
}

class AMP
{
    static void Main(string[] args)
    {
        İsveren i1=new İsveren();
        Console.WriteLine();
    }
}


