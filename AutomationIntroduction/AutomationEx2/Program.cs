using System;

namespace AutomationEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //NumberMethod();
                //StringMethod();
                //CharMethod();
                HourMethod();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Console.WriteLine("Hello World!");
                Console.ReadLine();
            }

        }

        private static void HourMethod()
        {
            //16.	Cititi de la tastatura o ora a zilei. In cazul in care ora respectiva este mai mica de 12 afisati:
            //“Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”.
            //in  caz contrar afisati mesajul :”Buna seara!”
            Console.WriteLine("Input an hour");
            int hour = int.Parse(Console.ReadLine());
           
            if (hour < 0 || hour > 24) throw new ArgumentException("Your input is not an hour");
            else if (hour < 12) Console.WriteLine("Buna dimineata");
            else if (hour<17) Console.WriteLine("Buna ziua");
            else Console.WriteLine(" Buna seara!");

        }

        private static void CharMethod()
        {
            //Cititi de la tastatura un character si verificati daca acel character este 
            //cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”
            Console.WriteLine("Inpun a char:");
            char character = char.Parse(Console.ReadLine());
            if (Char.IsDigit(character)) Console.WriteLine($"Caracterul  * {character}* pe care l-ai introdus este cifra!");

            //Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este 
            //adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”, 
            //in caz contrat afisati “Caracterul *character* pe care l-ai introdus nu este cifra.
            if (Char.IsDigit(character)) Console.WriteLine($"Caracterul  * {character}* pe care l-ai introdus este cifra!");
            else Console.WriteLine($"Caracterul  * {character}* pe care l-ai introdus nu este cifra!");

            //	Cititi de la tastatura un caracter. Daca acel caracter este litera afisati mesajul :”Caracterul *caracter* este litera!”. 
            //In cazul in care este o cifra afisati mesajul :”Caracterul *caracter* este o cifra!”. 
            //In cazul contrar afisati mesajul: “Caracterul *caracter* nu este nici cifra nici litera
            if (Char.IsDigit(character)) Console.WriteLine($"Caracterul  * {character}* pe care l-ai introdus este cifra!");
            else if (Char.IsLetter(character))
                Console.WriteLine($"Caracterul  * {character}* pe care l-ai introdus este litera!");
            else Console.WriteLine($"Caracterul  * {character}* pe care l-ai introdus nu este nici cifra nici litera!");



        }

        private static void NumberMethod()
        {
            // 1.	Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. 
            //In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!
            Console.WriteLine("Input a number:");
            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Verify if number is equal with 20");

            // 8.Cititi de la tastatura un numar.Verificati daca numarul este egal cu 20.
            //In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.

            if (nr == 20) Console.WriteLine($"Numarul {nr} este egal cu 20 ");
            else Console.WriteLine($"Numarul {nr} nu este egal cu 20 ");

            //Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, 
            //adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.
            if (nr < 20) Console.WriteLine($"Numarul e mai mic ca 20, iar adunat cu 5 are rezultatul {nr + 5}");
            else Console.WriteLine($"Numarul {nr} este mai mare sau egal cu 20 si nu este adunat cu 5 ");

            //Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”.
            if (nr >= 0) Console.WriteLine($"Numarul * {nr}* este pozitiv");


            //12.Cititi de la tastatura un numar.Verificati daca numarul este pozitiv si afisati:
            //“Numarul* numar*este pozitiv”. In caz contrar afisati “Numarul* numar*este negativ!.
            if (nr >= 0) Console.WriteLine($"Numarul * {nr}* este pozitiv");
            else Console.WriteLine($"Numarul * {nr}* este negativ");


            //Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati:
            //“Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.

            if (nr < 20 || nr > 40) Console.WriteLine($"Numarul {nr} este mai mic de 20 sau mai mare de 40!)");

            //13.Cititi de la tastatura un numar.Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: 
            //“Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”

            if (nr < 20 || nr > 40) Console.WriteLine($"Numarul {nr} este mai mic de 20 sau mai mare de 40!)");
            else Console.WriteLine($"Numarul {nr} este intre 20 si 40");


            //Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :
            //”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar nu afisati nimic

            if (nr % 2 == 0) Console.WriteLine($"Numarul * {nr} * pe care l’ati introdus este par");

            //Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :
            //In caz contrar afisati “Numarul *numar* pe care l’ati introdus este impar!”
            if (nr % 2 == 0) Console.WriteLine($"Numarul * {nr} * pe care l’ati introdus este par");
            else Console.WriteLine($"Numarul * {nr} * pe care l’ati introdus este impar");

        }

        private static void StringMethod()
        {
            //Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, 
            //afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.
            Console.WriteLine("Input a word:");
            string word = Console.ReadLine();
            if (word.ToLower() == "automation") Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation");

            //	Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.
            //In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.
            if (word.ToLower() == "automation") Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation");
            else Console.WriteLine("Cuvantul pe care l-ai citit nu este “automation”");
            
        }

    }
}
/*



 * 


.	Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este <150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si <195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.

18.	Cititi 3 numere de la tastatura si afisati cel mai mare numar.
19.	Cititi de la tastatura 2 numere. Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul: 
*/
