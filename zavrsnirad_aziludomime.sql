use master;
go -- dajemo mu vremena da se prebaci prije nego što ide dalje
-- brišem postojeću bazu ako postoji
drop database if exists azil_udomi_me;
go

create database azil_udomi_me collate Croatian_CI_AS;
go

use azil_udomi_me;
go

--TABLICA STATUS

create table status(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null
);

--TABLICA VELIČINA

create table velicina(
sifra int not null primary key identity(1,1),
naziv varchar(30)
);

--TABLICA BOJA

create table boja(
sifra int not null primary key identity(1,1),
naziv varchar(10)
);

--TABLICA PSI

create table psi(
sifra int not null primary key identity(1,1),
brojcipa char(17) not null,
ime varchar(20) not null,
datum_rodjenja date not null,
spol varchar(10) not null,
CONSTRAINT chk_spol CHECK (spol IN ('muški', 'ženski')),
velicina int not null references velicina(sifra),
boja int not null references boja(sifra),
mojaprica varchar(300) not null,
status int not null references status(sifra),
kastracija bit not null,
);

--TABLICA UDOMITELJI

create table udomitelji(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(30) not null,
adresa varchar(30) not null,
telefon char(20) not null,
email varchar(30) not null
);

--TABLICA UPITI

create table upiti(
sifra int not null primary key identity(1,1),
pas int not null references psi(sifra),
udomitelj int not null references udomitelji(sifra),
datum_upita date not null,
status_upita varchar(30) not null,
napomene varchar(200)
);

insert into status(naziv) values
('udomljen'),
('rezerviran'),
('slobodan'),
('privremeni smještaj');

insert into velicina(naziv) values
('mali: do 5 kg'),
('srednji: 5-25 kg'),
('veliki: >25 kg');

insert into boja(naziv) values
('bijeli'),
('crni'),
('smeđi'),
('šareni');

insert into psi(brojcipa, ime, datum_rodjenja, spol, velicina, boja, mojaprica, kastracija, status) VALUES
('HR123456789012345', 'Max', '2010-08-15', 'muški', 2, 1, 'Max je energičan pas koji voli igru i šetnje.', 'da', 'slobodan'),
('HR234567890123456', 'Luna', '2015-01-20', 'ženski', 1, 2, 'Luna je mirna i nježna, voli biti u društvu ljudi.', 'da', 'slobodan'),
('HR345678901234567', 'Leo', '2010-06-30', 'muški', 3, 3, 'Leo je veliki pas koji traži puno prostora i igre.', 'da', 'slobodan'),
('HR456789012345678', 'Bella', '2013-03-12', 'ženski', 2, 4, 'Bella je vesela i hrabra, uvijek spremna za avanture.', 'da', 'udomljen'),
('HR567890123456789', 'Rex', '2011-11-09', 'muški', 3, 3, 'Rex je zaštitnički nastrojen pas, idealan za obitelj.', 'da', 'slobodan'),
('HR678901234567890', 'Maja', '2017-02-05', 'ženski', 1, 1, 'Maja je umiljata i voli biti u centru pažnje.', 'da', 'rezerviran'),
('HR789012345678901', 'Bruno', '2012-07-22', 'muški', 2, 2, 'Bruno je prijateljski nastrojen pas koji voli sve ljude.', 'ne', 'slobodan'),
('HR890123456789012', 'Zara', '2016-04-11', 'ženski', 1, 2, 'Zara je vesela i razigrana, često trči po dvorištu.', 'da', 'slobodan'),
('HR901234567890123', 'Oscar', '2009-10-02', 'muški', 3, 3, 'Oscar je smiren pas koji voli dugi odmor.', 'da', 'privremeni_smještaj'),
('HR012345678901234', 'Nina', '2018-06-17', 'ženski', 1, 1, 'Nina je ljubazna i voli društvo drugih pasa.', 'ne', 'udomljen'),
('HR112345678901235', 'Dino', '2014-12-08', 'muški', 2, 2, 'Dino je odan pas koji se često igra s djecom.', 'da', 'slobodan'),
('HR223456789012346', 'Kira', '2013-09-03', 'ženski', 2, 4, 'Kira je sramežljiva, ali odana prijateljica.', 'da', 'slobodan'),
('HR334567890123457', 'Toby', '2016-11-10', 'muški', 1, 3, 'Toby je aktivan pas koji uživa u trčanju i lovu na lopticu.', 'ne', 'slobodan'),
('HR445678901234568', 'Rita', '2012-03-25', 'ženski', 2, 1, 'Rita je vesela, uvijek spremna za igru.', 'da', 'udomljen'),
('HR556789012345679', 'Maks', '2011-07-15', 'muški', 3, 2, 'Maks je veliki, ljubazan pas koji se voli opuštati.', 'da', 'slobodan'),
('HR667890123456780', 'Fiona', '2016-05-09', 'ženski', 2, 3, 'Fiona je smirena i vrlo pažljiva prema djeci.', 'ne', 'rezerviran'),
('HR778901234567891', 'Gustav', '2013-04-17', 'muški', 2, 2, 'Gustav je veselo naravnog temperamenta, pravi pas za obitelj.', 'da', 'slobodan'),
('HR889012345678902', 'Vera', '2014-01-30', 'ženski', 1, 1, 'Vera je nježna i voli biti u društvu svojih vlasnika.', 'da', 'slobodan'),
('HR990123456789013', 'Vuk', '2010-09-05', 'muški', 3, 3, 'Vuk je vrlo energičan, voli biti vani i trčati po prirodi.', 'ne', 'slobodan');


insert into udomitelji(ime, prezime, adresa, telefon, email)
VALUES
('Ivan', 'Horvat', 'Osijek, Ulica Mije Đaka 12', '385 98 1234567', 'ivan.horvat@gmail.com'),
('Ana', 'Kovač', 'Vinkovci, Trg Kneza Mihajla 3', '385 91 2345678', 'ana.kovac@gmail.com'),
('Marko', 'Novak', 'Valpovo, Kralja Zvonimira 45', '385 98 3456789', 'marko.novak@gmail.com'),
('Lina', 'Petrović', 'Osijek, Stjepana Radića 14', '385 91 4567890', 'lina.petrovic@gmail.com'),
('Josip', 'Matić', 'Vinkovci, Kolodvorska 9', '385 98 5678901', 'josip.matic@gmail.com'),
('Maja', 'Šimić', 'Valpovo, Dravska 19', '385 91 6789012', 'maja.simic@gmail.com'),
('Tomislav', 'Jurić', 'Osijek, Antuna Mihanovića 7', '385 98 7890123', 'tomislav.juric@gmail.com'),
('Ivana', 'Babić', 'Vinkovci, Ivana Gorana Kovačića 25', '385 91 8901234', 'ivana.babic@gmail.com'),
('Petar', 'Soldo', 'Valpovo, Zagrebačka 34', '385 98 9012345', 'petar.soldo@gmail.com'),
('Jelena', 'Vuković', 'Osijek, Trg Sv. Trojstva 8', '385 91 0123456', 'jelena.vukovic@gmail.com');

INSERT INTO upiti (pas, udomitelj, datum_upita, status_upita, napomene)
VALUES
(3, 7, '2024-06-15', 'zaprimljen', 'nema napomene'),
(9, 2, '2024-08-10', 'u obradi', 'nema napomene'),
(1, 5, '2024-07-05', 'obrađen', 'udomljenje'),
(7, 4, '2024-04-20', 'zaprimljen', 'nema napomene'),
(5, 6, '2024-01-25', 'u obradi', 'nema napomene'),
(8, 3, '2024-02-10', 'zaprimljen', 'nema napomene'),
(2, 10, '2024-05-18', 'obrađen', 'na čekanju'),
(10, 1, '2024-03-12', 'zaprimljen', 'nema napomene'),
(4, 9, '2024-06-22', 'u obradi', 'nema napomene'),
(6, 8, '2024-04-15', 'obrađen', 'odbijeno');

