-- Ovo je SQL skripta
--prebacujem se na master bazu
use master;
go  
--brišem bazu ako postoji
drop database if exists edunovawp6;
go

create database edunovawp6;
go

use edunovawp6;
go

--create database zoo
--use zoo

create table zivotinja(
sifra int,
vrsta varchar(50),
ime varchar(50),
djelatnik int,
prostorija int,
datum int
);

create table prostorija(
sifra int,
dimenzije varchar(30),
maksbroj int,
mjesto varchar(30)
);

create table djelatnik(
sifra int,
ime varchar(50),
prezime varchar(50),
IBAN char(11)
);

create table datum(
datumrodjenja datetime,
datumdolaska datetime);