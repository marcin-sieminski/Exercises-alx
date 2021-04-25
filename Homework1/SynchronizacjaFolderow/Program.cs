using FolderSynchronizationLibrary;
using System;

namespace SynchronizacjaFolderow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Synchronizacja folderów\n");
            var folderSynch = new FolderSynchronization();

            Console.WriteLine("Podaj ścieżkę do pierwszego folderu (enter = domyślna):");
            folderSynch.FirstFolderPath = Console.ReadLine();
            if (folderSynch.FirstFolderPath == String.Empty)
            {
                folderSynch.FirstFolderPath = @"C:\Tools\f1";
            }

            Console.WriteLine("Podaj ścieżkę do drugiego folderu (enter = domyślna):");
            folderSynch.SecondFolderPath = Console.ReadLine();
            if (folderSynch.SecondFolderPath == String.Empty)
            {
                folderSynch.SecondFolderPath = @"C:\Tools\f2";
            }

            Console.WriteLine("Podaj ścieżkę do folderu docelowego (enter = domyślna):");
            folderSynch.DestinationFolderPath = Console.ReadLine();
            if (folderSynch.DestinationFolderPath == String.Empty)
            {
                folderSynch.DestinationFolderPath =@"C:\Tools\synch\";
            }

            Console.WriteLine("Podaj rozszerzenia plików. które mają być synchronizowane (oddzielone spacją, enter = txt)");
            var fileNameExtensions = Console.ReadLine();
            if (fileNameExtensions == String.Empty)
            {
                folderSynch.FileNameExtensions = new[] {"txt"};
            }
            else
            {
                folderSynch.FileNameExtensions = fileNameExtensions.Split();
            }

            try
            {
                folderSynch.SynchronizeFolders();
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd przetwarzania: " + e.Message);
                Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nSynchronizacja zakończona sukcesem.");
            Console.ReadKey();
        }
    }
}
