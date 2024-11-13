-- Ovo je SQL skripta
--prebacujem se na master bazu
use master;
go  
--brišem bazu ako postoji
drop database if exists sport;
go

create database sport;
go

use sport;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan datetime not null,
stadion varchar(50) not null,
predsjednik varchar(50) not null,
drzava varchar(50) not null,
liga int not null
); 

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datumrodjenja datetime not null,
pozicija varchar(20) not null,
brojdresa int(30) not null,
klub varchar(50) not null references klub(sifra)
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme datetime not null,
lokacija varchar(50) not null,
stadion varchar(50) not null,
domaciklub varchar(50) not null references klub(sifra),
gostujuciklub varchar(50) not null references klub(sifra),
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
klub varchar(50) not null references klub(sifra),
nacionalnost varchar(50) not null,
iskustvo varchar(50)
);
