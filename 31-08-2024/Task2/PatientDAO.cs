using PatientMedicationApp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMedication
{
    internal class PatientDAO
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WeekDb;Integrated Security=True;";

        // Create a new Patient
        public void Create(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Patients (Medication, Dosage, Duration) VALUES (@Medication, @Dosage, @Duration)";
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
                cmd.Parameters.AddWithValue("@Medication", patient.Medication);
                cmd.Parameters.AddWithValue("@Dosage", patient.Dosage);
                cmd.Parameters.AddWithValue("@Duration", patient.Duration);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Read a Patient by ID
        public Patient Read(int PatientID)
        {
            Patient patient = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PatientID, Medication, Dosage, Duration FROM Patients WHERE PatientID = @PatientID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", PatientID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    patient = new Patient((int)reader["PatientID"],
                                          reader["Medication"].ToString(),
                                          (double)reader["Dosage"],
                                          (int)reader["Duration"]);
                }
            }
            return patient;
        }

        // Update a Patient
        public void Update(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Patients SET Medication = @Medication, Dosage = @Dosage, Duration = @Duration WHERE PatientID = @PatientID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
                cmd.Parameters.AddWithValue("@Medication", patient.Medication);
                cmd.Parameters.AddWithValue("@Dosage", patient.Dosage);
                cmd.Parameters.AddWithValue("@Duration", patient.Duration);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete a Patient by ID
        public void Delete(int PatientID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Patients WHERE PatientID = @PatientID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", PatientID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // List all Patients
        public List<Patient> ListAll()
        {
            List<Patient> patients = new List<Patient>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PatientID, Medication, Dosage, Duration FROM Patients";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient((int)reader["PatientID"],
                                                  reader["Medication"].ToString(),
                                                  (double)reader["Dosage"],
                                                  (int)reader["Duration"]);
                    patients.Add(patient);
                }
            }
            return patients;
        }
    }
}
