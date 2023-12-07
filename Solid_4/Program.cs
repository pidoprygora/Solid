using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodeApplicable
{
    void ApplyPromocode(string promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizeable
{
    void SetSize(byte size);
}

interface IPriced
{
    void SetPrice(double price);
}

class Book : IPriced, IDiscountable
{
    public void SetPrice(double price)
    {
        // ціна для книги
    }

    public void ApplyDiscount(string discount)
    {
        // знижка для книги
    }
}

class UpperClothing : IPriced, IDiscountable, IColorable, ISizeable
{
    public void SetPrice(double price)
    {
        // ціни для верхнього одягу
    }

    public void ApplyDiscount(string discount)
    {
        // знижка для верхнього одягу
    }

    public void SetColor(byte color)
    {
        // кольоір для верхнього одягу
    }

    public void SetSize(byte size)
    {
        // розмір для верхнього одягу
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання інтерфейсів для книги
        Book book = new Book();
        book.SetPrice(350);
        book.ApplyDiscount("10%");

        // Приклад використання інтерфейсів для верхнього одягу
        UpperClothing clothing = new UpperClothing();
        clothing.SetPrice(60);
        clothing.ApplyDiscount("30%");
        clothing.SetColor(245);
        clothing.SetSize(38);

        Console.ReadKey();
    }
}
