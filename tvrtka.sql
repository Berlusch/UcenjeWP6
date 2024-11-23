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
rednibroj int not null
putanja varchar(30) not null
);

INSERT INTO zaposlenici(ime, prezime, placa) VALUES
('Ivana', 'Ivić', 7500.00),
('Marko', 'Marić', 8500.00),
('Ana', 'Horvat', 9200.00);
insert into slike(zaposlenik) values
(1, 2)
