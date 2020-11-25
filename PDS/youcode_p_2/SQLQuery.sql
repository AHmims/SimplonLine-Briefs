CREATE DATABASE youcode_p_2;
USE youcode_p_2;
/**/
CREATE TABLE apprenant(
	identifiant int IDENTITY(1,1) PRIMARY KEY,
	nom varchar(255),
	prenom varchar(255),
	dateNaissance date,
	numTel int,
	adresseMail varchar(255),
	adresse varchar(255),
	pays varchar(255),
	ville varchar(255),
	specialites varchar(255)
);
