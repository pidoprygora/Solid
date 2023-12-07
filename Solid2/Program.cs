using System;

//Який принцип S.O.L.I.D. порушено? Виправте!

/*Зверніть увагу на клас EmailSender. Крім того, що за допомогою методу Send, він відправляє повідомлення, 
він ще і вирішує як буде вестися лог. В даному прикладі лог ведеться через консоль.
Якщо трапиться так, що нам доведеться міняти спосіб логування, то ми будемо змушені внести правки в клас EmailSender.
Хоча, здавалося б, ці правки не стосуються відправки повідомлень. Очевидно, EmailSender виконує кілька обов'язків і, 
щоб клас ні прив'язаний тільки до одного способу вести лог, потрібно винести вибір балки з цього класу.*/
class IEmail
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}

class Email : IEmail
{
    public string From { get; set; }
    public string To { get; set; }
    public string Theme { get; set; }
}

class EmailSender
{
    public void Send(Email email)
    {
        // ... sending...
        Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
    }

    internal void Send(IEmail e6)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IEmail e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        IEmail e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        IEmail e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        IEmail e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        IEmail e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        IEmail e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };


        EmailSender es = new EmailSender();
        es.Send(e1);
        es.Send(e2);
        es.Send(e3);
        es.Send(e4);
        es.Send(e5);
        es.Send(e6);

        Console.ReadKey();
    }
}