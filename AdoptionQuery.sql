CREATE DATABASE AdoptionDb;
USE AdoptionDB;
CREATE TABLE Animals (
	Id INT PRIMARY KEY IDENTITY (1,1),
	[Img] NVARCHAR(255),
	[Name] NVARCHAR(255),
	[Description] NVARCHAR(255),
	[Breed] NVARCHAR(255),
	[Age] INT
);

INSERT INTO Animals(Img, Name, Description, Breed, Age)
VALUES('https://images.unsplash.com/photo-1533738363-b7f9aef128ce?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1935&q=80','Tank','Black', 'Cat',5),
('https://images.unsplash.com/photo-1543852786-1cf6624b9987?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80','Tom','Stylish cat','Cat',6),
('https://images.unsplash.com/photo-1552053831-71594a27632d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=662&q=80','Bella','Gentle dog','Golden Retreiver',3);