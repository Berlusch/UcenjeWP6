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
placa dec(18,2),
invalid bit not null
);

create table slike(
sifra int not null primary key identity(1,1),
zaposlenik int not null references zaposlenici(sifra),
rednibroj int not null,
putanja varchar(100) not null
);

insert into zaposlenici(ime, prezime, datumrodjenja, placa, invalid) VALUES
('Ivana', 'Ivić', '1977-12-8', 7500.00, 0),
('Marko', 'Marić', '1979-02-22', 8500.00, 0),
('Ana', 'Horvat', '1992-11-03', 9200.00, 1);

insert into slike(zaposlenik, rednibroj, putanja) values
(1, 1, 'C:\Users\Ivana\Pictures\slika1.jpg'),
(1, 2, 'C:\Users\Ivana\Pictures\slika2.jpg'),
(2, 1, 'C:\Users\Marko\Pictures\slika1.jpg'),
(2, 2, 'C:\Users\Marko\Pictures\slika2.jpg'),
(3, 1, 'C:\Users\Ana\Pictures\slika1.jpg'),
(3, 2, 'C:\Users\Ana\Pictures\slika2.jpg');

