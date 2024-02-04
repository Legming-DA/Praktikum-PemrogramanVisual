create database db_gudangPakaian

use db_gudangPakaian

create table StokPakaian
(id_pakaian varchar(7) primary key not null,
jenis_pakaian varchar(20),
ukuran varchar(3) ,
warna varchar(10),
jumlah_stok int )

insert into StokPakaian values
('G000001','Gaun','L','Putih', 3),
('G000002','Gaun','M','Pink', 2),
('PA00001','Pakaian Adat','M','Hijau', 3),
('PA00002','Pakaian Adat','M','Merah', 10),
('PA00003','Pakaian Adat','M','Hitam', 15)

select * from StokPakaian