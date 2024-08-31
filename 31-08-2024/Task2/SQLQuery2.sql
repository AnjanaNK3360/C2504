CREATE DATABASE PatientDb;

USE PatientDb;

CREATE TABLE PatientMedication (
    PatientID INT PRIMARY KEY,
    Medication NVARCHAR(100),
    Dosage FLOAT,
    Duration INT
);