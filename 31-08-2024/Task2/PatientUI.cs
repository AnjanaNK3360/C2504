using PatientMedicationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMedication
{
    internal class PatientUI
    {
        private PatientDAO patientDAO = new PatientDAO();

        public void CreatePatient()
        {
            Console.Write("Enter Medication: ");
            string medication = Console.ReadLine();
            Console.Write("Enter Dosage: ");
            double dosage = double.Parse(Console.ReadLine());
            Console.Write("Enter Duration: ");
            int duration = int.Parse(Console.ReadLine());

            Patient patient = new Patient(0, medication, dosage, duration);

            patientDAO.Create(patient);
            Console.WriteLine("Patient created successfully.");
        }

        public void ReadPatient()
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Patient patient = patientDAO.Read(id);
            if (patient != null)
            {
                Console.WriteLine($"ID: {patient.PatientID}");
                Console.WriteLine($"Medication: {patient.Medication}");
                Console.WriteLine($"Dosage: {patient.Dosage}");
                Console.WriteLine($"Duration: {patient.Duration}");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        public void UpdatePatient()
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Patient patient = patientDAO.Read(id);
            if (patient != null)
            {
                Console.Write("Enter new Medication: ");
                patient.Medication = Console.ReadLine();
                Console.Write("Enter new Dosage: ");
                patient.Dosage = double.Parse(Console.ReadLine());
                Console.Write("Enter new Duration: ");
                patient.Duration = int.Parse(Console.ReadLine());

                patientDAO.Update(patient);
                Console.WriteLine("Patient updated successfully.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        public void DeletePatient()
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            patientDAO.Delete(id);
            Console.WriteLine("Patient deleted successfully.");
        }

        public void ListAllPatients()
        {
            List<Patient> patients = patientDAO.ListAll();
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"ID: {patient.PatientID}, Medication: {patient.Medication}, Dosage: {patient.Dosage}, Duration: {patient.Duration}");
            }
        }
    }
}
