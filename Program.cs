using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{

    class Program
    {
        static void Main(string[] args)
        {
            bool pProgram = true;
            Amazon amazon = new Amazon(1, "AmazoneAntJohn");
            Administrator admin1 = new Administrator("John", "John@Gmail.com", "1234");
            amazon.aAdministrator.Add(admin1);
            Console.WriteLine("Hej!");

            while (pProgram == true)
            {
                Console.WriteLine("Vill du vara: \n 1. Administrator \n 2. Customer");
                int hejsan = int.Parse(Console.ReadLine());
                switch (hejsan)
                {
                    case 1:
                        Console.WriteLine(" 1. Vill du skapa en admin? \n 2. Köpa in produkter som en Administrator? ");
                        hejsan = int.Parse(Console.ReadLine());
                        switch (hejsan)
                        {
                            case 1:
                                Console.WriteLine("Skriv dina uppgifter: 1. Namn 2. Email 3. Lösenord ");
                                string namn = Console.ReadLine();
                                string Email = Console.ReadLine();
                                string password = Console.ReadLine();
                                Administrator admin = new Administrator(namn, Email, password);
                                amazon.aAdministrator.Add(admin);
                                foreach (var Administrator in amazon.aAdministrator)
                                {
                                    Console.WriteLine(Administrator.Name);
                                    Console.WriteLine(Administrator.AdminEmail);
                                    Console.WriteLine("----------------------");
                                }
                                break;
                            case 2:

                                Console.WriteLine("Ange Namn och Lösenord för Administratorn");
                                string vem1 = Console.ReadLine();
                                string Lösenord1 = Console.ReadLine();
                                foreach (var vem in amazon.aAdministrator)
                                {
                                    vem.verifyLogin(vem1, Lösenord1);
                                    if (vem.LoginStatus == true)
                                    {
                                        Console.WriteLine($"Hej {vem1}");
                                        Console.WriteLine("Vill du handla in: \n 1. Äpple \n 2. Iphone \n 3. Dator");
                                        hejsan = int.Parse(Console.ReadLine());
                                        switch (hejsan)
                                        {
                                            case 1:
                                                Console.WriteLine("Ange: 1. Namn på produkten 2. Värde per styck 3. Antal produkter");
                                                string Underlag = Console.ReadLine();
                                                int värde = int.Parse(Console.ReadLine());
                                                int antal = int.Parse(Console.ReadLine());
                                                Äpple äpple = new Äpple(Underlag, värde, antal);
                                                admin1.aÄpple.Add(äpple);
                                                foreach (var aäpple in admin1.aÄpple)
                                                {
                                                    Console.WriteLine(aäpple.Discription);
                                                    Console.WriteLine(aäpple.Value);
                                                    Console.WriteLine(aäpple.AmountOf);
                                                    Console.WriteLine("------------------");
                                                }
                                                vem.LoginStatus = false;
                                                break;
                                            case 2:
                                                Console.WriteLine("Ange: 1. Namn på produkten 2. Värde per styck 3. Antal produkter");
                                                string Underlag1 = Console.ReadLine();
                                                int värde1 = int.Parse(Console.ReadLine());
                                                int antal1 = int.Parse(Console.ReadLine());
                                                Iphone iphone = new Iphone(Underlag1, värde1, antal1);
                                                admin1.aIphone.Add(iphone);
                                                foreach (var aiphone in admin1.aIphone)
                                                {
                                                    Console.WriteLine(aiphone.Discription);
                                                    Console.WriteLine(aiphone.Value);
                                                    Console.WriteLine(aiphone.AmountOf);
                                                    Console.WriteLine("------------------");
                                                }
                                                vem.LoginStatus = false;
                                                break;
                                            case 3:
                                                Console.WriteLine("Ange: 1. Namn på produkten 2. Värde per styck 3. Antal produkter");
                                                string Underlag2 = Console.ReadLine();
                                                int värde2 = int.Parse(Console.ReadLine());
                                                int antal2 = int.Parse(Console.ReadLine());
                                                Dator dator = new Dator(Underlag2, värde2, antal2);
 
                                                admin1.aDator.Add(dator);
                                                foreach (var adator in admin1.aDator)
                                                {
                                                    Console.WriteLine(adator.Discription);
                                                    Console.WriteLine(adator.Value);
                                                    Console.WriteLine(adator.AmountOf);
                                                    Console.WriteLine("------------------");
                                                }
                                                vem.LoginStatus = false;
                                                break;
                                            default:
                                                Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Denna admin finns ej eller så var lösenordet fel");
                                    }

                                }
                                break;
                            default:
                                Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ska du:\n1. Registrera ny costumer \n2. Logga in som customer och börja handla");
                        hejsan = int.Parse(Console.ReadLine());
                        switch (hejsan)
                        {
                            case 1:
                                Console.WriteLine("Ange dina uppgifter: 1. Namn 2. Adress 3. Email 4. Kredikortnummer 5. Användarnamn 6. Lösenord");
                                string namn = Console.ReadLine();
                                string adress = Console.ReadLine();
                                string email = Console.ReadLine();
                                string kreditkort = Console.ReadLine();
                                string användarnamn = Console.ReadLine();
                                string lösen = Console.ReadLine();
                                Customer customer = new Customer(namn, adress, email, kreditkort, användarnamn, lösen);
                                amazon.aCustomers.Add(customer);
                                Console.WriteLine("Du har nu gjort din costumer! Dessa är vilka som finns");
                                foreach (var acustom in amazon.aCustomers)
                                {
                                    Console.WriteLine(acustom.Name);
                                    Console.WriteLine(acustom.Address);
                                    Console.WriteLine(acustom.Email);
                                    Console.WriteLine(acustom.CreditCardInfo);
                                    Console.WriteLine(acustom.användarNamn);
                                    Console.WriteLine(acustom.Password);
                                    Console.WriteLine("-------------------------");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Du måste identifiera dig innan du kan handla! Ange ditt användarnamn och lösenord");
                                användarnamn = Console.ReadLine();
                                lösen = Console.ReadLine();
                                foreach (var acustom in amazon.aCustomers)
                                {
                                    if (användarnamn == acustom.användarNamn && lösen == acustom.Password)
                                    {
                                        Console.WriteLine($"Välkommen {användarnamn} eller {acustom.Name}");
                                        Console.WriteLine("Vad vill du handla \n1. Dator \n2. Iphone \n3. Äpple");
                                        hejsan = int.Parse(Console.ReadLine());
                                        switch (hejsan)
                                        {
                                            case 1:
                                                if (admin1.aDator.Count > 0)
                                                {
                                                    Console.WriteLine("Ok! vilken typ av dator vill du ha? det finns: ");
                                                    foreach (var Datorer in admin1.aDator)
                                                    {
                                                        Console.WriteLine(Datorer.Discription);
                                                        string Vilkentyp1 = Console.ReadLine();
                                                        Console.WriteLine("Hur många datorer vill du ha?");
                                                        int antal1 = int.Parse(Console.ReadLine());
                                                        foreach (var aDatorer in admin1.aDator)
                                                        {
                                                            if (aDatorer.Discription == Vilkentyp1)
                                                            {
                                                                if (aDatorer.AmountOf >= antal1)
                                                                {
                                                                    aDatorer.AmountOf = aDatorer.AmountOf - antal1;
                                                                    Console.WriteLine($"Du köpte {antal1}st {aDatorer.Discription} därmed finns det bara kvar {aDatorer.AmountOf} Detta kostade {aDatorer.Value} per styck.");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Tyvärr så har vi inte så många {aDatorer.Discription} vänligen be Administrationen att köpa in mer eller köp någon annan vara");
                                                                }
                                                            }

                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Det finns inga datorer kontakta admin");
                                                }
                                                break;
                                            case 2:
                                                if (admin1.aIphone.Count > 0)
                                                {
                                                    Console.WriteLine("Ok! vilken typ av Iphone vill du ha? det finns: ");
                                                    foreach (var Iphones in admin1.aIphone)
                                                    {
                                                        Console.WriteLine(Iphones.Discription);
                                                    }
                                                    string Vilkentyp2 = Console.ReadLine();
                                                    Console.WriteLine("Hur många Iphones vill du ha?");
                                                    int antal2 = int.Parse(Console.ReadLine());
                                                    foreach (var aIphones in admin1.aÄpple)
                                                    {
                                                        if (aIphones.Discription == Vilkentyp2)
                                                        {
                                                            if (aIphones.AmountOf >= antal2)
                                                            {
                                                                aIphones.AmountOf = aIphones.AmountOf - antal2;
                                                                Console.WriteLine($"Du köpte {antal2}st {aIphones.Discription} därmed finns det bara kvar {aIphones.AmountOf} Detta kostade per telefon {aIphones.Value}kr");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Tyvärr så har vi inte så många {aIphones.Discription} vänligen be Administrationen att köpa in mer eller köp någon annan vara");
                                                            }
                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Det finns inga iphones! Kontakta admin");
                                                }
                                                break;
                                            case 3:
                                                if (admin1.aÄpple.Count > 0)
                                                {
                                                    Console.WriteLine("Ok! vilken typ av äpple vill du ha? det finns: ");
                                                    foreach (var äpplee in admin1.aÄpple)
                                                    {
                                                        Console.WriteLine(äpplee.Discription);
                                                    }
                                                    string Vilkentyp = Console.ReadLine();
                                                    Console.WriteLine("Hur många Äpplen vill du ha?");
                                                    int antal = int.Parse(Console.ReadLine());
                                                    foreach (var aÄpple in admin1.aÄpple)
                                                    {
                                                        if (aÄpple.Discription == Vilkentyp)
                                                        {
                                                            if (aÄpple.AmountOf >= antal)
                                                            {
                                                                aÄpple.AmountOf = aÄpple.AmountOf - antal;
                                                                Console.WriteLine($"Du köpte {antal}st {aÄpple.Discription} därmed finns det bara kvar {aÄpple.AmountOf} Detta kostade {aÄpple.Value} per styck.");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Tyvärr så har vi inte så många {aÄpple.Discription} vänligen be Administrationen att köpa in mer eller köp någon annan vara");
                                                            }
                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Det finns inga äpplen");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fel användarnamn eller lösenord, det kanske inte finns en customer så skapa en");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Du måste skriva responsiva nummret till det du vill göra");
                        break;

                }
            }
        }
    }
}