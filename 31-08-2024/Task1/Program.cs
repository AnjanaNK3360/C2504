using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Week4AssessmentApp
{
   public class PatientMedication
    {
        public int PatientID { get; set; }
        public string Medication { get; set; }
        public double Dosage { get; set; }
        public int Duration { get; set; }

        //public PatientMedication(int patientID, string medication, double dosage, int duration)
        //{
        //    PatientID = patientID;
        //    Medication = medication;
        //    Dosage = dosage;
        //    Duration = duration;
        //}
        public override string ToString()
        {
            return $"[PatientID: {PatientID}, Medication: {Medication}, Dosage: {Dosage}, Duration: {Duration}]";
        }

    }
    public class PatientMedicationServices
    {
        /*
        public static void Read(PatientMedication[] medications)
        {

            for (int i = 0; i < medications.Length; i++)
            {
                Console.Write("Enter PatientID: ");
                int patientID = int.Parse(Console.ReadLine());

                Console.Write("Enter Medication: ");
                string medication = Console.ReadLine();

                Console.Write("Enter Dosage:  ");
                double dosage = double.Parse(Console.ReadLine());

                Console.Write("Enter Duration: ");
                int duration = int.Parse(Console.ReadLine());

                medications[i] = new PatientMedication(patientID, medication, dosage, duration);

            }
        }
        */

        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WeekDb;Integrated Security=True;";

        public static void Read(PatientMedication[] medications)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT PatientID, Medication, Dosage, Duration FROM PatientMedication";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    for (int i = 0; i < medications.Length; i++)
                    {
                        if (!reader.Read())
                        {
                            throw new ServerException("[0101]Server Errror.");//throw error
                        }
                        medications[i] = new PatientMedication
                        {
                            PatientID = (int)reader["PatientID"],
                            Medication = reader["Medication"].ToString(),
                            Dosage = (Double)reader["Dosage"],
                            Duration = (int)reader["Duration"]
                        };
                    }

                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                //Console.WriteLine($"SQL Error: {ex.Message}");
                throw new ServerException($"[0102]Server Errror.{ex.Message}");//throw Error
            }
            catch (ServerException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                //Console.WriteLine($"Error: {ex.Message}");
                throw new ServerException($"[0103]Server Errror.{ex.Message}");//throw Error
            }
        }
        

        public static PatientMedication FindMinimumDuration(PatientMedication[] medications)
        {
            int mindur = 0;
            PatientMedication minDurationMedication = medications[0];

            foreach (var medication in medications)
            {
                if (medication.Duration < minDurationMedication.Duration)
                {
                    minDurationMedication = medication;
                    mindur = minDurationMedication.Duration;
                }
            }
            return minDurationMedication;
        }
        public static PatientMedication FindSecondHighestDosage(PatientMedication[] medications)
        {
            double highestDosage = double.MinValue;
            double secondHighestDosage = double.MinValue;

            PatientMedication highestDosageMedication = null;
            PatientMedication secondHighestDosageMedication = null;

            foreach (var medication in medications)
            {
                if (medication.Dosage > highestDosage)
                {
                    if (highestDosage != double.MinValue)
                    {
                        secondHighestDosageMedication = highestDosageMedication;
                        secondHighestDosage = secondHighestDosageMedication.Dosage;
                    }
                    highestDosageMedication = medication;
                    highestDosage = medication.Dosage;
                }
                else if (medication.Dosage > secondHighestDosage && medication.Dosage != highestDosage)
                {
                    secondHighestDosageMedication = medication;
                    secondHighestDosage = secondHighestDosageMedication.Dosage;
                }
            }
            return secondHighestDosageMedication;
        }

        public static void SelectionSortByPatientID(PatientMedication[] medications)
        {
            int n = medications.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (medications[j].PatientID < medications[minIndex].PatientID)
                    {
                        minIndex = j;
                    }
                }
                // Swap
                if (minIndex != i)
                {
                    PatientMedication temp = medications[i];
                    medications[i] = medications[minIndex];
                    medications[minIndex] = temp;
                }
            }
        }
    }

    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            PatientMedication[] medications = new PatientMedication[3];
            try
            {
                PatientMedicationServices.Read(medications);
            }
            catch (ServerException ex)
            {
                log.Error($"{ex.Message}");//Console.WriteLine($"{ex.Message}"); 
            }
            PatientMedication mindur = PatientMedicationServices.FindMinimumDuration(medications);
            log.Info($"minimum duration={mindur.Duration}");//Console.WriteLine($"minimum duration={mindur.Duration}");
            PatientMedication secondHigh = PatientMedicationServices.FindSecondHighestDosage(medications);
            log.Info($"SecondHighestDosage={secondHigh.Dosage}");//Console.WriteLine($"SecondHighestDosage={secondHigh.Dosage}");
            PatientMedicationServices.SelectionSortByPatientID(medications);
            string output = "";
            foreach (var med in medications)
            {
                output += $"{med} ";
            }
            log.Info(output);//Console.WriteLine(output);

        }
    }
}
