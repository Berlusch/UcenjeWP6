-- Ovo je SQL skripta
--create database edunovawp6;

--drop database edunovawp6;

--use edunovawp6;

--create table smjerovi(
--sifra int,
--naziv varchar(50),
--cijena decimal(18,2),
--izvodiseod datetime,
--vaucer bit
--);

--create table grupe(
--sifra int,
--naziv varchar(20),
--velicinagrupe int,
--predavac varchar(50),
--smjer int
--);

--create table polaznici(
--sifra int,
--ime varchar(50),
--prezime varchar(50),
--email varchar(100),
--oib char(11)
--);

create table clanovi(
grupa int,
polaznik int
);