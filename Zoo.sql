-- Ovo je SQL skripta
--prebacujem se na master bazu
use master;
go  
--brišem bazu ako postoji
drop database if exists zoo;
go

create database zoo;
go

use zoo;
go

create table datum(
sifra int not null primary key identity(1,1),
datumrodjenja datetime not null,
datumdolaska datetime not null,
datumsmrti datetime not null);


create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar (50) not null,
IBAN char(11)
);

create table prostorija(
sifra int not null primary key identity(1,1),
dimenzije varchar(30) not null,
maksbroj int not null,
mjesto varchar(30) not null
);

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int not null references djelatnik(sifra),
prostorija int not null references prostorija(sifra),
datum int not null references datum(sifra)
);