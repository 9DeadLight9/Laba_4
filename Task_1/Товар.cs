namespace Laba_4;

public class Товар
{
    public string Назва { get; set; }
    public double Ціна { get; set; }
    public string Опис { get; set; }
    public string Категорія { get; set; }
}

public class Користувач
{
    public string Логін { get; set; }
    public string Пароль { get; set; }
    public List<Замовлення> ІсторіяПокупок { get; set; }
}

public class Замовлення
{
    public List<Товар> Товари { get; set; }
    public int Кількість { get; set; }
    public double ЗагальнаВартість { get; set; }
    public string СтатусЗамовлення { get; set; }
}

public interface ISearchable
{
    List<Товар> ПошукТоварів(string критерій);
}

public class Магазин : ISearchable
{
    public List<Користувач> Користувачі { get; set; }
    public List<Товар> Товари { get; set; }
    public List<Замовлення> Замовлення { get; set; }

    public List<Товар> ПошукТоварів(string критерій)
    {
       
        throw new NotImplementedException();
    }
}
