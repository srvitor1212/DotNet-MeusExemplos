

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