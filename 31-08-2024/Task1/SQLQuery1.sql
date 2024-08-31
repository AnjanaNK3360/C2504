CREATE DATABASE WeekDb;

USE WeekDb;

CREATE TABLE PatientMedication (
    PatientID INT PRIMARY KEY,
    Medication NVARCHAR(100),
    Dosage FLOAT,
    Duration INT
);

INSERT INTO PatientMedication 
(PatientID, Medication, Dosage,Duration) VALUES 
(1, 'Dolo 650', 40 , 3 ),
(2, 'Vicks', 50 , 4),
(3, 'Halls', 60 , 2);

SELECT * FROM PatientMedication;

CREATE TABLE Patients(
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    Medication NVARCHAR(100),
    Dosage FLOAT,
    Duration INT
);
DROP TABLE Patients;


