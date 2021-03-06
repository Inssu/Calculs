/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 1; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur
            bool correct = false;
            
            // boucle sur le menu
            choix = "1";
            while (choix != "0")
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();

                //Choix des valeurs
                val1 = rand.Next(1, 10); 
                val2 = rand.Next(1, 10);

                // traitement des choix
                if (choix != "0")
                {
                    if (choix == "1")
                    {
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");

                        while (!correct) 
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie : Veuillez entrer un nomber entier :");
                            }
                        }

                        // comparaison avec la bonne réponse
                        correct = false;
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Bravo !");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (choix == "2")
                    {
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        while (!correct)
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie : Veuillez saisir un nombre entier");
                            }
                        }
                        // comparaison avec la bonne réponse
                        correct = false;
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Bravo !");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Erreur de saisie");
                        Console.WriteLine(" ");
                    }
                }
            }
        }
    }
}
