CREATE DATABASE IF NOT EXISTS UnitCostApp;

USE UnitCostApp;

CREATE TABLE IF NOT EXISTS User(
	Id INT AUTO_INCREMENT NOT NULL,
	Firstname VARCHAR(100),
	Lastname VARCHAR(200),
	Email VARCHAR(1000),
	Psswrd VARCHAR(1000),
	Birthdate DATE,
	CONSTRAINT PRIMARY KEY (Id)
);

/* DROP TABLE User;
 * INSERT INTO User (Firstname, Lastname, Email, Psswrd, Birthdate) VALUES ( 'Edgar', 'Cardiel', 'edcar325@gmail.com', '1234', '1992-08-03' );
 * SELECT * FROM User;
 */

CREATE TABLE IF NOT EXISTS Role(
	Id INT AUTO_INCREMENT NOT NULL,
	Name VARCHAR(200),
	CONSTRAINT PRIMARY KEY (Id)
);

/* DROP TABLE Roles;
 * INSERT INTO Role (Name) VALUES ( 'Admin');
 * SELECT * FROM Role;
 */


