using System;

namespace AutomationIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              //  Console.WriteLine("First 10 numbers:");
                //NumbersBetween(1, 10);
                Console.WriteLine("Input a number:");
               //int nr = int.Parse(Console.ReadLine());
                // DisplayResults(nr);
               // ArrayExercices();
                InputArray();
                Console.ReadKey();

            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }

        private static void InputArray()
        {
            Console.WriteLine("Input the number of elements in array");
            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the string elements");
            string[] arrString = new string[nr];
            for (int i = 0; i < nr; i++)
            {
                arrString[i] = Console.ReadLine();
            }
            foreach (var item in arrString)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine("Input the int elements");
            int[] arrInt = new int[nr];
            for (int i = 0; i < nr; i++)
            {
                arrInt[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in arrInt)
            {
                Console.Write($"{item}  ");
            }


        }

        public static void DisplayResults(int n)
        {
            Console.WriteLine($"All numbers less than {n}:");
            //NumbersBetween(1, n);
           //NumbersBetween(3, n);
          NumbersSum(0, n);
            EvenNumbers(n);
            Power(n);

        }
        public static void NumbersBetween(int first, int last)
        {
            for (int i = first; i < last; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine(last);
            Console.WriteLine("=======================================");
        }

        public static void NumbersSum(int first, int last)
        {
            int sum = 0;
            for (int i =first; i < last; i++)
            {
                sum += i;
            }
            int s = 0;
            do
            {
                s += first;
                first++;
            } while (first <= last);

            Console.WriteLine($"Sum of first numbers less than {last}: {s}");
            Console.WriteLine("=======================================");
        }
        public static void EvenNumbers(int last)
        {
            Console.WriteLine($"First {last} even numbers: ");
            for (int i = 0; i < last; i+=2)
            {
                Console.Write($"{i}  ");
            }
            if (last%2==0) Console.Write($"{last}  ");
            Console.WriteLine();
            Console.WriteLine("=======================================");
            //do-while
            int j = 0;
            do
            {
               Console.Write($"{j}  ");
                j+=2;
            } while (j <= last);
            Console.WriteLine();
            Console.WriteLine("=======================================");
        }
        public static void Power(int nr)
        {
            Console.WriteLine($"Cubes of first {nr} numbers: ");
            for (int i = 1; i <= nr; i++)
            {
                Console.WriteLine(Math.Pow(i,3));
            }
            Console.WriteLine("=======================================");
            //do-while
            int j = 1;
            do
            {
                Console.WriteLine(Math.Pow(j, 3));
                j++;
            } while (j<=nr);    
        }

        public static void ArrayExercices()
        {
            Console.WriteLine("Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.");
            string[] arr1={"sun","moon", "clouds"};
            Console.WriteLine(arr1[1]);
            Console.WriteLine("=================================================");
            Console.WriteLine("Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”");
            string[] arr2 = { "lemons", "watermelon", "cherry"};
            var word=Array.Find(arr2, n => (n == "cherry"));
            Console.WriteLine($"word {word}");
            Console.WriteLine("Afisati array-ul in ordine inversa: “mom”, “dad”, “child”");
            string[] arr3 = {"mom", "dad", "child"};
            Array.Reverse(arr3);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write($"{arr3[i]}  ");
            }
            Array.Sort(arr3);
            Console.WriteLine();
            Console.WriteLine("array sorted:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write($"{arr3[i]}  ");
            }

        }
    }
}
/*

22.	Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.
23.	Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”
24.	Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.
25.	Afisati array-ul sortat: “mom”, “dad”,( “child”.
26.	Cititi de la tastatura elementele unui array de marime 5. (string)
27.	Cititi de la tastatura elementele unui array de marime 5.(int)


 * 1.	Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!
2.	Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.
3.	Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”
4.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.
5.	Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”.
6.	Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.
7.	Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar nu afisati nimic
8.	Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.
9.	Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””. In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.
10.	Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”, in caz contrat afisati “Caracterul *character* pe care l-ai introdus nu este cifra.
11.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. In caz contrar scadeti numarul cu 5 si afisati rezultatul final.
12.	Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”. In caz contrar afisati “Numarul *numar* este negativ!.
13.	Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”
14.	Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar afisati “Numarul *numar* pe care l’ati introdus este impar!”.
15.	Cititi de la tastatura un caracter. Daca acel caracter este litera afisati mesajul :”Caracterul *caracter* este litera!”. In cazul in care este o cifra afisati mesajul :”Caracterul *caracter* este o cifra!”. In cazul contrar afisati mesajul: “Caracterul *caracter* nu este nici cifra nici litera
16.	Cititi de la tastatura o ora a zilei. In cazul in care ora respectiva este mai mica de 12 afisati: “Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”. In caz contrar afisati mesajul :”Buna seara!”
17.	Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este <150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si <195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.




18.	Cititi 3 numere de la tastatura si afisati cel mai mare numar.
19.	Cititi de la tastatura 2 numere. Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul: 
*/
