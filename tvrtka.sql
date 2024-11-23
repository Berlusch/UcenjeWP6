use master;
go -- dajemo mu vremena da se prebaci prije nego što ide dalje
-- brišem postojeću bazu ako postoji
drop database if exists tvrtka;
go
-- kreiram novu bazu
create database tvrtka collate Croatian_CI_AS;
go
-- pozicioniram se na bazu
use tvrtka;
go

create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datumrodjenja date not null,
placa dec(5,2),
invalid bit not null

create table slike(
sifra int not null primary key identity(1,1),
zaposlenik int not null references zaposlenici(sifra),
redni broj int not null
putanja varchar(30) not null
);


