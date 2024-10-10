

-- todas as tabelas
select * from Carro;
select * from CarroMotorista;
select * from Chassi;
select * from Fabricante;
select * from Motorista;

select * from CarroMotorista 
where CarroId = '048b7d9f-70a1-425b-8d07-3caae9b8275d'
	and MotoristaId = '2e0b0736-e08d-42d5-a5be-85946c82c9b1'
;

--delete CarroMotorista;

--

select * from Fabricante f
inner join Carro c		on c.FabricanteId = f.Id
inner join Chassi ch	on ch.CarroId = c.Id
order by f.Nome;

select f.Nome, c.Modelo, ch.NumeroDeSerie
from Fabricante f
inner join Carro c		on c.FabricanteId = f.Id
inner join Chassi ch	on ch.CarroId = c.Id
order by f.Nome;

select * from Carro;

select * from CarroMotorista;

select * from __EFMigrationsHistory;
--delete __EFMigrationsHistory;