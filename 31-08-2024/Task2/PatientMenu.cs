using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMedication
{
    internal class PatientMenu
    {
        public static void Menu()
        {
            PatientUI ui = new PatientUI();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nPatient Medication Management System");
                Console.WriteLine("1. Create Patient");
                Console.WriteLine("2. Read Patient");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. List All Patients");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ui.CreatePatient();
                        break;
                    case "2":
                        ui.ReadPatient();
                        break;
                    case "3":
                        ui.UpdatePatient();
                        break;
                    case "4":
                        ui.DeletePatient();
                        break;
                    case "5":
                        ui.ListAllPatients();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
