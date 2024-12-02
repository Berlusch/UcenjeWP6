-- Ovo je SQL skripta
--prebacujem se na master bazu
use master;
go  
--brišem bazu ako postoji
drop database if exists knjiznica;
go

create database knjiznica;
go

use knjiznica;
go

create table knjige(
sifra INT(11) not null primary key identity(1,1),
naslov varchar(50) not null,
pisac varchar(50) not null,
vlasnik int(11),
clan int(11),
datumpos datetime,
datumvrac datetime
);

create table clan(
sifra int(11) not null primary key identity(1,1),
clbroj int(11) not null
);

create table vlasnik(
sifra int(11) not null primary key identity(1,1),
knjiga int(11)
);

create table osobe(
sifra int(11) not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
adresa varchar(50) not null,
email varchar(50) not null
);