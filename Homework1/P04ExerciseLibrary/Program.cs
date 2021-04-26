using System;
using System.Collections.Generic;

namespace P04ExerciseLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta()
            {
                Numer = "1308/00",
                Tytul = "O kurdlach dla opornych",
                Wydanie = 1,
                DataZakpu = new DateTime(2000, 1, 27),
                Cena = new Cena()
                {
                    CenaKsiazki = 17.5m,
                    Uwagi = "zakup z 18.08 – 20,00"
                },
                Autorzy = new Autor[]
                {
                    new Autor()
                    {
                        Imie = "L",
                        SrodkoweImie = "A",
                        Nazwisko = "Tarantoga"
                    },
                    new Autor()
                    {
                        Imie = "I",
                        Nazwisko = "Tichy"
                    }
                },
                Sygnatury = new Sygnatura[]
                {
                    new Sygnatura() { Numer = 012370 },
                    new Sygnatura()
                    {
                        Numer = 012371,
                        Aktywna = false,
                        Uwagi = "zgłoszona utrata 01.05.2000",
                        Wypozyczenia = new List<Wypozyczenie>()
                        {
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty = "A1427"
                                },
                                DataWypozyczenia = new DateTime(2000, 1, 31),
                                PrzewidywanaDataZwrotu = new DateTime(2000, 2, 15),
                                RzeczywistaDataZwrotu = new DateTime(2000, 2, 20),
                                Uwagi = "Pobrano karę 2,00"
                            },
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty = "B2354"
                                },
                                DataWypozyczenia = new DateTime(2000, 2, 2),
                                PrzewidywanaDataZwrotu = new DateTime(2000, 3, 7),
                                Uwagi = "06.03.2000 Zgoda na przedłużenie",
                                Przedluzenie = new Wypozyczenie()
                                {
                                    PrzewidywanaDataZwrotu = new DateTime(2000, 3, 15),
                                    RzeczywistaDataZwrotu = new DateTime(2000, 3, 15)
                                }
                            },
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty = "C2467",
                                },
                                DataWypozyczenia = new DateTime(2000, 3, 20),
                                PrzewidywanaDataZwrotu = new DateTime(2000, 4, 10),
                                RzeczywistaDataZwrotu = new DateTime(2000, 4, 10),
                                Uwagi = "W dniu 25.03.2000 na książkę zapisał się D6792; prosi o powiadomienie"
                            },
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty = "D6792"
                                },
                                DataWypozyczenia = new DateTime(2000, 4, 12),
                                PrzewidywanaDataZwrotu = new DateTime(2000, 3, 30),
                                Uwagi = "01.05.2000 Zgłoszone zagubienie. Pobrano karę 3*17,50 = 52,50"
                            }
                        },
                    },
                    new Sygnatura() { Numer = 012372 },
                    new Sygnatura() { Numer = 014568, Uwagi = "dodatkowy zakup 18.08.2000" }
                }
            };

            string uwagi =
                karta.Sygnatury[1].Wypozyczenia[2].Uwagi;

            Console.WriteLine(uwagi);


            karta.Nastepna = new Karta()
            {
                Wydanie = 2,
                Tytul = "O kurdlach dla początkujących",
                Numer = "0200/01"
            };

            Console.ReadKey();
        }
    }
}
