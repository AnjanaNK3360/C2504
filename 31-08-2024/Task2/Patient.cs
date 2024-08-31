using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMedicationApp
{
    internal class Patient
    {
        public int PatientID;
        public string Medication;
        public double Dosage;
        public int Duration;

        public Patient(int patientID, string medication, double dosage, int duration)
        {
            PatientID = patientID;
            Medication = medication;
            Dosage = dosage;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"[PatientID: {PatientID}, Medication: {Medication}, Dosage: {Dosage}, Duration: {Duration}]";
        }
    }
}

