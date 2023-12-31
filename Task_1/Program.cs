using Laba_4;

Товар товар1 = new Товар
{
    Назва = "Товар 1",
    Ціна = 100.0,
    Опис = "Це опис товару 1",
    Категорія = "Категорія 1"
};


Користувач користувач1 = new Користувач
{
    Логін = "користувач1",
    Пароль = "пароль1",
    ІсторіяПокупок = new List<Замовлення>()
};


Замовлення замовлення1 = new Замовлення
{
    Товари = new List<Товар> { товар1 },
    Кількість = 1,
    ЗагальнаВартість = товар1.Ціна,
    СтатусЗамовлення = "Нове замовлення"
};


користувач1.ІсторіяПокупок.Add(замовлення1);


Магазин магазин = new Магазин
{
    Користувачі = new List<Користувач> { користувач1 },
    Товари = new List<Товар> { товар1 },
    Замовлення = new List<Замовлення> { замовлення1 }
};

List<Товар> знайденіТовари = магазин.ПошукТоварів("Категорія 1");
