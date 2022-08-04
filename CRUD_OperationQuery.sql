--create database 
CREATE DATABASE CRUDOperation

--create table
CREATE TABLE Student 
(
	StudentId INT PRIMARY KEY, 
	FirstName VARCHAR(255),
	LastName VARCHAR(255),
	PhoneNo VARCHAR(255),
	Email VARCHAR(255)
)

--display all
SELECT * FROM Student