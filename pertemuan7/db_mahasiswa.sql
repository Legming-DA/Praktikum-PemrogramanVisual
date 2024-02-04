create database db_mahasiswa
use db_mahasiswa

create table tb_mahasiswa
(NIM varchar(50) primary key not null,
Nama varchar(50),
Jurusan varchar(50),
Angkatan varchar(50))

insert into tb_mahasiswa values
('2118118','Legming Dwi Anggraini','Teknik Informtika','2021')