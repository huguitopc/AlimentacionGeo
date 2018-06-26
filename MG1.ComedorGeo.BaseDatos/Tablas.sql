create database dbAlimentacionGeo
go
use dbAlimentacionGeo
go
exec sp_addtype codigo,'bigint','not null'
go
create table Persona(
	id codigo primary key,
	NombrePersona varchar(90)not null,
	ApellidoPaterno varchar(90)not null,
	ApellidoMaterno varchar(90)not null,
	Sexo char default ('M') check(Sexo = 'm' or Sexo = 'f') not null,
	FechaNacimiento datetime not null,
	DocumentoIdentidad bigint unique not null,
	NombreCompleto varchar(200)
)
go

select * from Persona where id=126

insert into Persona values (1,'Pedro','Peralta','Nunez','M','01/04/1954',5847477,null)
insert into Persona values (2,'Maria','Gutierrez','Parada','F','20/08/1955',5847333,'')
insert into Persona values (3,'Ana','Parada','Pereira','F','04/11/1960',5847334,null)
insert into Persona values (4,'Pablo','Peña','Balcazar','M','02/02/1940',5844427,null)
insert into Persona values (5,'Luisa','Justiniano','Rosales','F','25/11/1970',5841234,null)
insert into Persona values (6,'Alex','Rocha','Mercado','M','24/09/1975',7685322,null)
insert into Persona values (7,'Alex Federico','Pereira','Peña','M','02/02/1982',5855360,null)
insert into Persona values(8,'Alexander','Aguilera','Roca','M','16/6/2008',5623668,null)
insert into Persona values(9,'Yanine','Aguilera','Orosco','F','23/2/2016',6387670,null)
insert into Persona values(10,'Dalcy','Banegas','Montaño','F','1/11/2013',3871501,null)
insert into Persona values(11,'Carla Yuvinka','Bazan','Pedraza','F','27/1/2016',9010999,null)
insert into Persona values(12,'Fabiola','Colque','Rivera','F','1/1/2016',5454215,null)
insert into Persona values(13,'Nancy','Delgadillo','Sanchez','F','1/10/2004',3827188,null)
insert into Persona values(14,'Jorge Ricardo','Gallegos','Ponce','M','1/10/2015',35414,null)
insert into Persona values(15,'Ena Sandra','Jimenez','Aponte','F','1/2/2006',1500566,null)
insert into Persona values(16,'Maribel','Martinez','Rivera','F','16/5/2006',5869432,null)
insert into Persona values(17,'Silvana Ines','Montero','Gil','F','1/3/1995',3851002,null)
insert into Persona values(18,'Ana Luisa','Ovando','Melgar','F','3/11/2009',6391077,null)
insert into Persona values(19,'Ana Yelissa','Parada','Saavedra','F','23/2/2016',7755146,null)
insert into Persona values(20,'Robin','Paz','Urquieta','M','1/10/2015',4574728,null)
insert into Persona values(21,'Alicia','Peña','Galvez','F','13/8/2009',5341996,null)
insert into Persona values(22,'Viviana','Perez','Cuellar','F','1/8/2005',1751021,null)
insert into Persona values(23,'Alejandra','Roca','Camacho','F','26/10/2012',6363604,null)
insert into Persona values(24,'Raul','Rodriguez','Castro','M','20/7/2000',2808043,null)
insert into Persona values(25,'Jose Luis','Rodriguez','Fujimoto','M','30/11/2015',6428518,null)
insert into Persona values(26,'Raul','Rodriguez','Zabala','M','1/7/2004',5398184,null)
insert into Persona values(27,'Marizol','Solis','','F','11/9/2008',7942409,null)
insert into Persona values(28,'Varinia','Torres','Collazos','F','8/12/2015',6591641,null)
insert into Persona values(29,'Quitita','Torrez','Mendoza','F','1/11/2003',2843788,null)
insert into Persona values(30,'R.Junior','Aguilera','Soquere','M','15/11/2011',9009118,null)
insert into Persona values(31,'Jhon Juddy','Cabrera','Lopez','M','1/7/2001',5366888,null)
insert into Persona values(32,'Frank Alejandro','Eguez','Mendez','M','16/11/2015',9780436,null)
insert into Persona values(33,'Alvaro Gustavo','Flores','Martinez','M','3/7/2006',6244295,null)
insert into Persona values(34,'Nelson Hernan','Gonzales','Torrico','M','15/2/2012',4892752,null)
insert into Persona values(35,'Jesus','Lelarge','Vaca','M','1/10/2004',5584348,null)
insert into Persona values(36,'Jose Adan','Mboigue','Arembe','M','14/1/2008',6227699,null)
insert into Persona values(37,'Sergio Dennis','Medina','Castillo','M','5/4/2011',5382510,null)
insert into Persona values(38,'Harick Jonathan','Montero','Montero','M','3/2/2016',7782070,null)
insert into Persona values(39,'Julio Cesar','Morales','Alipaz','M','17/2/2009',4629047,null)
insert into Persona values(40,'Carlos Hugo','Parada','Romero','M','11/2/2016',9710219,null)
insert into Persona values(41,'Percy Numberg','Paz','Montaño','M','17/4/2012',7713897,null)
insert into Persona values(42,'Rider','Salas','Rodas','M','13/1/2009',7684825,null)
insert into Persona values(43,'Freddy Orlando','Salazar','Rico','M','25/10/2010',6314211,null)
insert into Persona values(44,'Cesar','Suarez','Mendoza','M','25/3/2013',6310310,null)
insert into Persona values(45,'Carlos Alberto','Velasco','Chavez','M','23/11/2015',3832606,null)
insert into Persona values(46,'Lucio','Victoria','Santos','M','19/1/2016',11331330,null)
insert into Persona values(47,'Alejandro','Zurita','Viruez','M','6/3/2014',9013407,null)
insert into Persona values(48,'Viviana Patricia','Paniagua','Landivar','F','1/9/2011',2941045,null)
insert into Persona values(49,'Paola Lucrecia','Querejazu','Pacheco','F','15/8/2002',3260163,null)
insert into Persona values(50,'Carlos Rene','Ibañez','Noriega','M','3/11/2015',4172763,null)
insert into Persona values(51,'Veronica','Pereira','Rojas','F','1/2/2003',3894667,null)
insert into Persona values(52,'Anibal','Rueda','Peralta','M','7/12/2015',8217667,null)
insert into Persona values(53,'Andres Eduardo','Tejada','Diez de Medina','M','23/11/2015',5230126,null)
insert into Persona values(54,'Elizabeth Karen','Chali','Zarzar','F','14/10/2013',1886321,null)
insert into Persona values(55,'Moira Alejandra','Coronado','Arnez','F','1/10/2015',5867579,null)
insert into Persona values(56,'Maria Cristina','Molina','Querema','F','9/10/2013',6285089,null)
insert into Persona values(57,'Jose Enrique','Vilches','Salas','M','1/10/2015',4576408,null)
insert into Persona values(58,'Oscar Freddy','Salazar','Panoso','M','15/6/2001',2859528,null)
insert into Persona values(59,'Roy Brayham','Choque','Carrillo','M','1/8/2011',9678717,null)
insert into Persona values(60,'Roberto Loir','Cuellar','Cruz','M','16/8/2011',8253645,null)
insert into Persona values(61,'Wilfredo','Franco','Rapu','M','14/1/2008',7749872,null)
insert into Persona values(62,'Saul','Gilarde','Gutierrez','M','15/6/2001',6217850,null)
insert into Persona values(63,'Isaias Jonas','Hurtado','Suarez','M','4/8/2008',8256076,null)
insert into Persona values(64,'Adrian','Lopez','Gomez','M','2/7/2012',8992200,null)
insert into Persona values(65,'Luis','Medina','Noza','M','16/6/2010',9703958,null)
insert into Persona values(66,'Carlos Alberto','Parada','Romero','M','23/1/2014',9800540,null)
insert into Persona values(67,'Daniel','Robles','Cuellar','M','27/1/2014',6278898,null)
insert into Persona values(68,'Carlos','Roca','Herrera','M','1/12/2011',5389932,null)
insert into Persona values(69,'Marco Antonio','Sossa','Aroca','M','3/9/2012',10809127,null)
insert into Persona values(70,'Henry','Suarez','Cajareico','M','17/5/2007',7707863,null)
insert into Persona values(71,'Ruddy','Yovio','Méndez','M','1/9/2002',4694146,null)
insert into Persona values(72,'Erick Leiton','Zabala','Roman','M','6/3/2012',6242859,null)
insert into Persona values(73,'Leonardo','Gonzales','Saavedra','M','12/6/2007',6285165,null)
insert into Persona values(74,'Jorge','Gutierrez','Salinas','M','14/1/2008',4736680,null)
insert into Persona values(75,'Ruben Dario','Nuñez','Zaconeta','M','1/9/2001',4173777,null)
insert into Persona values(76,'Oscar Felipe','Ortiz','Machicado','M','15/8/2002',6268434,null)
insert into Persona values(77,'Jose Luis','Ortiz','Smith','M','8/9/2008',7847867,null)
insert into Persona values(78,'Jesus','Pedraza','Ayala','M','1/2/1995',1935736,null)
insert into Persona values(79,'Nicanor','Pedraza','Ayala','M','1/8/2003',4669707,null)
insert into Persona values(80,'Carmelo','Portales','Justiniano','M','1/8/2005',3205860,null)
insert into Persona values(81,'Jose Luis','Presente','Solares','M','23/6/2008',4719798,null)
insert into Persona values(82,'Justo','Salvatierra','Robert','M','1/4/2010',3907980,null)
insert into Persona values(83,'Ulices','Yepes','Revollo','M','26/7/1993',3823211,null)
insert into Persona values(84,'Diego Mauricio','Aguilera','Soquere','M','15/3/2010',7782668,null)
insert into Persona values(85,'Charles','Albrecht','Ayala','M','1/7/2004',6253387,null)
insert into Persona values(86,'Osman','Alvarez','Ureña','M','14/11/2008',5412290,null)
insert into Persona values(87,'Agustin','Antelo','Vaca','M','24/2/2010',6283048,null)
insert into Persona values(88,'Victor Alfredo','Apala','Morales','M','2/7/2008',6220792,null)
insert into Persona values(89,'David','Aponte','Campo','M','1/7/2004',5419547,null)
insert into Persona values(90,'Jaime','Arancibia','Possiabo','M','25/9/2008',5857117,null)
insert into Persona values(91,'Yerson','Ardaya','Delgado','M','11/3/2013',7810439,null)
insert into Persona values(92,'Oscar','Avalos','Calizaya','M','1/9/2001',4591679,null)
insert into Persona values(93,'Dielvin','Avaroma','Salvatierra','M','4/8/2008',6240858,null)
insert into Persona values(94,'Eduin','Cabrera','López','M','9/4/2007',6336987,null)
insert into Persona values(95,'Carmelo','Calzadilla','Farell','M','1/7/2004',4732545,null)
insert into Persona values(96,'Rene Alexander','Castellon','Leon','M','6/3/2012',8234377,null)
insert into Persona values(97,'Daniel','Choque','Mendoza','M','6/6/2011',2139181,null)
insert into Persona values(98,'Juan','Chuve','Zambrana','M','1/7/1997',3211095,null)
insert into Persona values(99,'Rodrigo','Coca','Orellana','M','6/3/2012',9629101,null)
insert into Persona values(100,'Roy Eduardo','Dominguez','Justiniano','M','20/6/2011',9031942,null)
insert into Persona values(101,'Juan Benigno','Flores','Castillo','M','23/7/2012',8239104,null)
insert into Persona values(102,'Jose Ariel','Galindo','Mojica','M','14/1/2008',7679749,null)
insert into Persona values(103,'Edward Yhony','Garcia','Rosas','M','1/2/2003',3282540,null)
insert into Persona values(104,'Marcelo','Gemio','Verastegui','M','14/1/2008',7722994,null)
insert into Persona values(105,'Genaro','Gutierrez','Barrios','M','2/4/2012',4732946,null)
insert into Persona values(106,'Rogelio','Gutierrez','Chambi','M','27/5/2010',7859726,null)
insert into Persona values(107,'Fernando','Gutierrez','Salinas','M','22/7/2010',9622900,null)
insert into Persona values(108,'Jorge','Gutiérrez','Vargas','M','1/8/1999',4710497,null)
insert into Persona values(109,'Miguel Antonio','Justiniano','Bailaba','M','15/8/2002',6281702,null)
insert into Persona values(110,'Rafael Gumber','Languidey','Flores','M','15/8/2002',4663014,null)
insert into Persona values(111,'Bernardo','Leaños','Viera','M','14/1/2008',5375674,null)
insert into Persona values(112,'Ferddy','Lopez','Gomez','M','23/2/2010',7719518,null)
insert into Persona values(113,'Moises','Mamani','Garcia','M','7/2/2014',6298939,null)
insert into Persona values(114,'Máximo','Marca','Mansilla','M','1/2/1990',3208508,null)
insert into Persona values(115,'Eusebio','Masabi','Sita','M','16/9/1992',3912352,null)
insert into Persona values(116,'Juan Carlos','Menacho','Azaba','M','1/4/2002',4174439,null)
insert into Persona values(117,'Juan Carlos','Moreno','Chuve','M','1/8/2012',8926470,null)
insert into Persona values(118,'Erland','Murillo','Menacho','M','1/7/2004',5832863,null)
insert into Persona values(119,'Richard','Paiba','Suarez','M','16/7/2009',6244218,null)
insert into Persona values(120,'Lider','Pantoja','Durán','M','1/9/2002',3914522,null)
insert into Persona values(121,'Joselo','Pantoja','Vidal','M','24/11/2008',6248904,null)
insert into Persona values(122,'Nicanor','Paz','Montaño','M','26/7/2010',5895942,null)
insert into Persona values(123,'Alejandro','Karelli','Ardaya','M','18/02/1987',5895999,null)

create table Rubro(
	id codigo primary key,
	NombreRubro varchar(30) not null,
	DescripcionRubro varchar(90) not null
)
go

select * from Rubro

insert into Rubro values(1,'Fabrica de Baterias','Fabrica de Baterias')
insert into Rubro values(2,'Fabrica de Retenes','Fabrica de Retenes')
insert into Rubro values(3,'Venta de Baterias','Venta de Baterias')
insert into Rubro values(4,'Planta de Reciclaje','Planta de Reciclaje')
insert into Rubro values(5,'Catering','Catering')

create table TipoEmpresa(
	id codigo primary key,
	NombreTipo varchar(20) not null
)
go

insert into TipoEmpresa values(1,'Grupo Geoautomotriz')
insert into TipoEmpresa values(2,'Proveedor')

create table Empresa(
	id codigo primary key,
	RazonSocial varchar(90) not null,
	Nit varchar(20) unique not null,
	Direccion varchar(90) not null,
	Telefono varchar(20) not null,
	idRubro codigo references Rubro,
	idTipo codigo references TipoEmpresa
)
go

select * from Empresa

insert into Empresa values(1,'Batebol SA','1234567890','Parque Industrial PI-4','334455',1,1)
insert into Empresa values(2,'Eco Volta SA','1234568890','Parque Industrial PI-3','345345',2,1)
insert into Empresa values(3,'Total Service SRL','1254567890','Parque Industrial PI-3','369369',3,1)
insert into Empresa values(4,'Commetal SA','1234567690','Warnes, Carretera a la Belgica','865787',4,1)
insert into Empresa values(5,'El Trigal','1234567390','2do Anillo entre Paragua y Canal Cotoca','363455',5,2)

create table RepresentanteLegal(
	id codigo references Persona primary key,
	Poder varchar(20) not null,
	idEmpresa codigo references Empresa
)
go

select * from RepresentanteLegal

insert into RepresentanteLegal values(1,'Total',1)

create table Cargo(
	id codigo primary key,
	NombreCargo varchar(90) unique not null
)
go

select * from Cargo

insert into Cargo values(1,'Auxiliar Contable')
insert into Cargo values(2,'Analista Contable')
insert into Cargo values(3,'Coordinador Contable')
insert into Cargo values(4,'Jefe Contable')
insert into Cargo values(5,'Operador de Maquinaria')
insert into Cargo values(6,'Ejecutivo Comercial')
insert into Cargo values(7,'Analista de Compras')
insert into Cargo values(8,'Auxiliar de Desarrollo Humano')
insert into Cargo values(9,'Analista de Activos Fijos')

create table Turno(
	id codigo primary key,
	NombreTurno varchar(20) not null,
	HorarioIngreso time not null,
	HorarioSalida time not null
)
go

select * from Turno

insert into Turno values(1,'Mañana','08:00','17:00')
insert into Turno values(2,'Tarde','11:00','20:00')
insert into Turno values(3,'Noche','18:00','02:00')

create table Area(
	id codigo primary key,
	NombreArea varchar(90) unique not null
)
go

select * from Area

insert into Area values(1,'Administracion')
insert into Area values(2,'Operaciones')
insert into Area values(3,'Comercial')
insert into Area values(4,'Produccion')
insert into Area values(5,'Desarrollo Humano')

create table CentroCosto(
	id codigo,
	NombreCentroCosto varchar(90) unique not null,
	idArea codigo references Area,
	primary key (idArea, id)
)
go

select * from CentroCosto

insert into CentroCosto values(1,'Admministracion',1)
insert into CentroCosto values(2,'Sistemas',1)
insert into CentroCosto values(3,'Logistica',2)
insert into CentroCosto values(4,'Almacen',2)
insert into CentroCosto values(5,'Caja',3)
insert into CentroCosto values(6,'Marketing',3)
insert into CentroCosto values(7,'Ventas',3)
insert into CentroCosto values(8,'Operaciones',2)
insert into CentroCosto values(9,'Produccion',4)
insert into CentroCosto values(10,'Desarrollo Humano',5)

create table Grupo(
	id codigo primary key,
	NombreGrupo varchar(90) unique not null
)
go

select * from Grupo
select * from Perfil
select * from GrupoPerfil

insert into Grupo values(1,'Administrador')
insert into Grupo values(2,'Analista')
insert into Grupo values(3,'Empleado')
insert into Grupo values(4,'Jefe')
insert into Grupo values(5,'Prueba')

create table Perfil(
	id codigo primary key,
	NombrePerfil varchar(90) unique not null
)
go

select * from Perfil

insert into Perfil values(1,'Empleado')
insert into Perfil values(2,'Menu')
insert into Perfil values(3,'Programacion')
insert into Perfil values(4,'Usuario')
insert into Perfil values(5,'Reporte')

create table GrupoPerfil(
	id codigo primary key,
	idGrupo codigo,
	idPerfil codigo,
	Flag int default (0) check(Flag = 1 or Flag = 0) not null,
	foreign key (idGrupo) references Grupo,
	foreign key (idPerfil) references Perfil
)
go

select gp.idGrupo, g.NombreGrupo, gp.idPerfil, p.NombrePerfil from GrupoPerfil gp
inner join Grupo g on gp.idGrupo = g.id
inner join Perfil p on gp.idPerfil = p.id

select * from GrupoPerfil gp where gp.idGrupo = 1

insert into GrupoPerfil values(1,1,1,1)
insert into GrupoPerfil values(2,1,2,1)
insert into GrupoPerfil values(3,1,3,1)
insert into GrupoPerfil values(4,1,4,1)
insert into GrupoPerfil values(5,1,5,1)

insert into GrupoPerfil values(6,2,1,0)
insert into GrupoPerfil values(7,2,2,0)
insert into GrupoPerfil values(8,2,3,0)
insert into GrupoPerfil values(9,2,4,0)
insert into GrupoPerfil values(10,2,5,0)

insert into GrupoPerfil values(11,3,1,0)
insert into GrupoPerfil values(12,3,2,0)
insert into GrupoPerfil values(13,3,3,0)
insert into GrupoPerfil values(14,3,4,0)
insert into GrupoPerfil values(15,3,5,0)

insert into GrupoPerfil values(16,4,1,0)
insert into GrupoPerfil values(17,4,2,0)
insert into GrupoPerfil values(18,4,3,0)
insert into GrupoPerfil values(19,4,4,0)
insert into GrupoPerfil values(20,4,5,0)

create table Usuario(
	id codigo identity primary key,
	NombreUsuario varchar(20) unique not null,
	Contraseña varchar(10) not null,
	idGrupo codigo references Grupo
)
go

select * from Usuario

select * from Usuario u inner join Grupo g on u.idGrupo = g.id
select * from Grupo
select * from Perfil

insert into Usuario values('apereira','123',1)
insert into Usuario values('ejordan','321',3)

create table Empleado(
	id codigo references Persona primary key,
	idEmpresa codigo references Empresa,
	idCargo codigo references Cargo,
	idArea codigo,
	idCentroCosto codigo,
	foreign key (idArea, idCentroCosto) references CentroCosto,
	FechaIngreso datetime not null,
	idTurno codigo references Turno,
	idUsuario codigo references Usuario
)
go

select * from Persona
select * from Empresa
select * from Cargo
select * from Area
select * from CentroCosto order by id
select * from Turno
select * from Usuario

select * from Empleado

insert into Empleado values(1,1,1,4,9,'01/01/1990',1,2)
insert into Empleado values(2,2,2,1,1,'01/12/1995',1,2)
insert into Empleado values(3,3,1,3,6,'10/09/1993',2,2)
insert into Empleado values(4,4,3,2,3,'01/03/1999',2,2)
insert into Empleado values(5,1,2,2,8,'15/06/1998',1,2)
insert into Empleado values(6,2,2,3,6,'30/07/2000',2,2)
insert into Empleado values(7,1,9,1,1,'30/07/2000',2,1)

create table EstadoEmpleado(
	id codigo primary key,
	NombreEstado varchar(90) not null,
	DescripcionEstado varchar(90) not null
)
go

select * from EstadoEmpleado

insert into EstadoEmpleado values(1,'Activo','Activo')
insert into EstadoEmpleado values(2,'Permiso','Permiso')
insert into EstadoEmpleado values(3,'Vacacion','Vacacion')
insert into EstadoEmpleado values(4,'Baja','Baja')

create table DetalleEstado(
	id codigo identity primary key,
	idEmpleado codigo references Empleado not null,
	idEstado codigo references EstadoEmpleado not null,
	FechaInicio datetime not null,
	FechaFin datetime
)
go

select * from DetalleEstado
select * from Empleado
select * from EstadoEmpleado

insert into DetalleEstado values(1,1,'01/01/1990',null)
insert into DetalleEstado values(2,2,'01/04/2017','04/04/2017')
insert into DetalleEstado values(3,1,'10/09/1993',null)
insert into DetalleEstado values(4,3,'01/03/2017','30/04/2017')
insert into DetalleEstado values(5,4,'15/06/1998','15/06/2008')
insert into DetalleEstado values(6,1,'30/07/2000',null)

create table Programacion(
	id codigo primary key,
	FechaInicio datetime not null,
	FechaFin datetime not null
)
go

select * from Programacion

insert into Programacion values (1,'04/01/2017','04/05/2017')
insert into Programacion values (2,'04/01/2017','04/05/2017')
insert into Programacion values (3,'04/01/2017','04/05/2017')
insert into Programacion values (4,'04/01/2017','04/05/2017')
insert into Programacion values (5,'04/01/2017','04/05/2017')
insert into Programacion values (6,'04/01/2017','04/05/2017')

create table Estado(
	id codigo primary key,
	NombreEstado varchar(90)
)
go

select * from Estado

insert into Estado values(1,'Solicitado')
insert into Estado values(2,'Ejecutado')

create table DetalleProgramacion(
	idEmpleado codigo references Empleado,
	idProgramacion codigo references Programacion,
	idEstado codigo references Estado,
	primary key (idEmpleado, idProgramacion)
)
go

select * from DetalleProgramacion

create table TipoAlimento(
	id codigo primary key,
	NombreTipo varchar(90) not null
)
go

select * from TipoAlimento

insert into TipoAlimento values(1,'Sopa')
insert into TipoAlimento values(2,'Segundo')
insert into TipoAlimento values(3,'Postre')
insert into TipoAlimento values(4,'Jugo')

create table Tipo(
	id codigo primary key,
	NombreTipo varchar(90) not null
)
go

select * from Tipo

insert into Tipo values(1,'Normal')
insert into Tipo values(2,'Dieta')
insert into Tipo values(3,'Especial')

create table Alimento(
	id codigo primary key,
	NombreAlimento varchar(90) not null,
	Precio float,
	Cantidad float,
	itTipo codigo foreign key references Tipo,
	itTipoAlimento codigo foreign key references TipoAlimento
)
go

select distinct a.id, a.NombreAlimento from Alimento a inner join Menu m on a.id = m.idAlimento

insert into Alimento values(1, 'Asado en Olla', 15, 50, 1, 2)
insert into Alimento values(2, 'Limonada', 2, 50, 1, 4)
insert into Alimento values(3, 'Maracuya', 2, 50, 1, 4)
insert into Alimento values(4, 'Pollo al Horno', 15, 50, 1, 2)
insert into Alimento values(5, 'Sopa de Mani', 4, 50, 1, 1)

create table Ingrediente(
	id codigo primary key,
	NombreIngrediente varchar(50) not null,
	Calorias float not null
)
go

select * from Ingrediente

insert into Ingrediente values(1,'Arroz',0)
insert into Ingrediente values(2,'Carne',0)
insert into Ingrediente values(3,'Yuca',0)
insert into Ingrediente values(4,'Tomate',0)
insert into Ingrediente values(5,'Azucar',0)
insert into Ingrediente values(6,'Limon',0)
insert into Ingrediente values(7,'Maracuya',0)
insert into Ingrediente values(8,'Pollo',0)
insert into Ingrediente values(9,'Cebolla',0)

create table DetalleAlimento(
	idAlimento codigo,
	idIngrediente codigo,
	Porcion float not null,
	TotalCalorias float,
	foreign key (idAlimento) references Alimento,
	foreign key (idIngrediente) references Ingrediente,
	primary key (idAlimento,idIngrediente)
)
go

create table Menu(
	id codigo primary key,
	FechaMenu datetime not null,
	idAlimento codigo foreign key references Alimento
)
go

select * from Menu

insert into Menu values(1,'',5)

create table OrdenServicio(
	id codigo primary key,
	Observacion varchar(250),
	idMenu codigo references Menu
)
go

select * from OrdenServicio

insert into OrdenServicio values(1,'',1)

create table DetalleEstadoServicio(
	idEmpleado codigo,
	idProgramacion codigo,
	foreign key (idEmpleado,idProgramacion) references DetalleProgramacion,
	idOrdenServicio codigo,
	foreign key (idOrdenServicio) references OrdenServicio,
	idEstado codigo foreign key references Estado,
	primary key(idEmpleado,idProgramacion,idOrdenServicio)
)
go

select * from VDetalleEstadoServicio
select * from DetalleEstadoServicio

select * from Persona
select * from Rubro
select * from TipoEmpresa
select * from Empresa
select * from RepresentanteLegal
select * from Cargo
select * from Turno
select * from Area
select * from CentroCosto WHERE idArea=3
select * from Grupo
select * from Perfil
select * from GrupoPerfil
select * from Usuario
select * from Empleado
select * from EstadoEmpleado
select * from DetalleEstado
select * from Programacion
select * from Estado
select * from DetalleProgramacion
select * from Ingrediente
select * from TipoAlimento
select * from Tipo
select * from Alimento
select * from Menu
select * from OrdenServicio
select * from DetalleEstadoServicio
select * from Bitacora

/*
drop table Bitacora
drop table DetalleEstadoServicio
drop table OrdenServicio
drop table Menu
drop table Alimento
drop table Tipo
drop table TipoAlimento
drop table Ingrediente
drop table DetalleProgramacion
drop table Estado
drop table Programacion
drop table DetalleEstado
drop table EstadoEmpleado
drop table Empleado
drop table Usuario
drop table GrupoPerfil
drop table Perfil
drop table Grupo
drop table CentroCosto
drop table Area
drop table Turno
drop table Cargo
drop table RepresentanteLegal
drop table Empresa
drop table TipoEmpresa
drop table Rubro
drop table Persona
go
*/

drop table TBResumenAlimentacion
go
create table TBResumenAlimentacion(
	id codigo primary key,
	FechaAlimentacion datetime not null,
	CodigoEmpleado codigo not null,
	NombreEmpleado varchar(90) not null,
	Cargo varchar(90) not null,
	CentroCosto varchar(90) not null,
	Area varchar(90) not null,
	TipoMenu varchar(50) not null,
	Plato varchar(90) not null,
	CaloriasPlato bigint not null,
	Bebida varchar(90) not null,
	CaloriasBebida bigint not null,
	Postre varchar(90) not null,
	CaloriasPostre bigint not null,
	TotalPrecio float not null
)
go

select * from TBResumenAlimentacion

create table Bitacora(
	id codigo identity(1,1) primary key,
	Transaccion varchar(50),
	Tabla varchar(50),
	idTabla bigint,
	idUsuario codigo,
	nombreUsuario varchar(50),
	--nombreMaquina varchar(50),
	Host varchar(50),
	Aplicacion varchar(100),
	Modificado datetime,
	foreign key (idUsuario) references Usuario
)
go

select * from Bitacora

/*---------------TRIGGER O DISPARADOR PARA CADA COMPLETAR DATOS DE LA BITACORA---------------*/

drop trigger tg_BitacoraEmpleado
go

create trigger tg_BitacoraEmpleado on Empleado for insert, update, delete
as
	declare @idTabla bigint
begin
	if COLUMNS_UPDATED() <> 0
	begin
		if exists (select * from deleted)
		begin
			select @idTabla = d.id from deleted d
			insert into Bitacora values ('Update','Tabla_Empleado',@idTabla,'alexp',SYSTEM_USER,HOST_NAME(),APP_NAME(),GETDATE())
		end
		else
		begin
			select @idTabla = i.id from inserted i
			insert into Bitacora values ('Insert','Tabla_Empleado',@idTabla,'alexp',SYSTEM_USER,HOST_NAME(),APP_NAME(),GETDATE())
		end
	end
	else
	begin
		select @idTabla = d.id from deleted d
		insert into Bitacora values ('Delete','Tabla_Empleado',@idTabla,'alexp',SYSTEM_USER,HOST_NAME(),APP_NAME(),GETDATE())
	end
end
go

/*---------------CONSULTAS---------------*/

--1.- Consulta de los platos, cantidad, ingredientes y calorias

select * from VDetalleProgramacion

select * from DetalleEstadoServicio
select * from Empleado
select * from Programacion
select * from OrdenServicio
--MENU
select * from Menu
select * from Alimento
------
select * from Estado


select dp.idEmpleado, p.NombreCompleto, dp.idProgramacion, pr.FechaInicio, pr.FechaFin, dp.idEstado, et.NombreEstado
from DetalleProgramacion dp
	inner join Empleado em on dp.idEmpleado = em.id
	inner join Persona p on em.id = p.id
	inner join Programacion pr on dp.idProgramacion = pr.id
	inner join Estado et on dp.idEstado = et.id

select * 
from Menu m
where FechaMenu between '08/08/2017' and '08/08/2017'

/*---------------RESUMEN DE LOS PLATOS, CANTIDAD, PRECIO Y CALORIAS---------------*/

select dp.id, pl.NombrePlato, pl.Cantidad, pl.Precio, sum(i.Calorias) as Calorias
from DetallePlato dp
inner join Plato pl on dp.idPlato = pl.id
inner join Ingrediente i on dp.idIngrediente = i.id
group by dp.id, pl.NombrePlato, pl.Cantidad,pl.Precio

go

/*---------------VISTA COMPLETA DEL EMPLEADO---------------*/

select * from Empleado

select * from VEmpleado
go
drop view VEmpleado
go

alter view VEmpleado
as
select e.id, pr.NombreCompleto, e.idEmpresa, emp.RazonSocial, e.FechaIngreso, e.idCargo, C.NombreCargo,
e.idArea, a.NombreArea, e.idCentroCosto, cc.NombreCentroCosto, e.idTurno, t.NombreTurno, e.idUsuario, u.NombreUsuario
from Empleado e
		inner join Persona pr on e.id = pr.id
		inner join Empresa emp on e.idEmpresa = emp.id
		inner join Cargo c on e.idCargo = c.id
		inner join Area a on e.idArea = a.id
		inner join CentroCosto cc on e.idCentroCosto = cc.id
		inner join Turno t on e.idTurno = t.id
		inner join Usuario u on e.idUsuario = u.id
--top 8(select count (e.id) from Empleado e)
go

select * from VEmpleado

/*---------------VISTA COMPLETA DEL EMPLEADO PARA DETALLE PROGRAMACION---------------*/

select * from Empleado

select * from VEmpleadoProgramacion
go
drop view VEmpleadoProgramacion
go

create view VEmpleadoProgramacion
as
select e.id, pr.NombreCompleto
from Empleado e
		inner join Persona pr on e.id = pr.id		
go

select * from VEmpleado

/*---------------VISTA DEL CENTRO DE COSTO---------------*/

select * from CentroCosto cc inner join Area a on cc.idArea = a.id

select * from VCentroCosto where idArea=1
go
drop view VCentroCosto
go

create view VCentroCosto
as
select cc.id, cc.NombreCentroCosto, a.id as idArea, a.NombreArea
from CentroCosto cc
		inner join Area a on cc.idArea = a.id
go

/*---------------VISTA DEL GRUPO_PERFIL---------------*/

select gp.idGrupo, g.NombreGrupo, gp.idPerfil, p.NombrePerfil from GrupoPerfil gp inner join Grupo g on gp.idGrupo = g.id inner join Perfil p on gp.idPerfil = p.id

select * from VGrupoPerfil
go
drop view VGrupoPerfil
go

create view VGrupoPerfil
as
select gp.idGrupo, g.NombreGrupo, gp.idPerfil, p.NombrePerfil
from GrupoPerfil gp
	inner join Grupo g on gp.idGrupo = g.id
	inner join Perfil p on gp.idPerfil = p.id
go


/*---------------VISTA DEL PERFIL---------------*/

select * from VPerfil
go
drop view VPerfil
go

create view VPerfil
as
select p.id, p.NombrePerfil
from Perfil p
go

/*---------------VISTA DEL DETALLE PROGRAMACION---------------*/

select * from VDetalleProgramacion
go
drop view VDetalleProgramacion
go

create view VDetalleProgramacion
as
select dp.idEmpleado, p.NombreCompleto, a.NombreArea, dp.idProgramacion, pr.FechaInicio, pr.FechaFin, dp.idEstado, e.NombreEstado 
from DetalleProgramacion dp
	inner join Empleado em on dp.idEmpleado = em.id
	inner join Persona p on em.id = p.id
	inner join Area a on em.idArea = a.id
	inner join Programacion pr on dp.idProgramacion = pr.id
	inner join Estado e on dp.idEstado = e.id
go

/*---------------VISTA DEL ALIMENTO PROGRAMACION---------------*/

select * from Menu
select * from Alimento

--select distinct a.id, a.NombreAlimento, m.FechaMenu, a.Cantidad, a.Precio

create view VAlimentoProgramacion
as
select distinct a.id, a.NombreAlimento, m.FechaMenu, a.Cantidad, a.Precio
from Alimento a
	inner join Menu m on m.idAlimento = a.id
go

/*---------------VISTA COMPLETA DEL EMPLEADO, SUS DATOS, FECHA, ALIMENTACION, CALORIAS---------------*/
select * from DetalleEstadoServicio

drop view VDetalleEstadoServicio
go
create view VDetalleEstadoServicio
as
select dts.idEmpleado, p.NombreCompleto, dts.idProgramacion, pr.FechaInicio, pr.FechaFin,
dts.idOrdenServicio, os.idMenu, m.FechaMenu, m.idAlimento, a.NombreAlimento, os.Observacion, idEstado, es.NombreEstado
from DetalleEstadoServicio dts
	inner join Persona p on dts.idEmpleado = p.id
	inner join Programacion pr on dts.idProgramacion = pr.id
	inner join OrdenServicio os on dts.idOrdenServicio = os.id
	inner join Menu m on os.idMenu = m.id
	inner join Alimento a on m.idAlimento = a.id
	inner join Estado es on dts.idEstado = es.id

go

select * from VDetalleEstadoServicio

/*---------------TRIGGER O DISPARADOR PARA ACTUALIZAR CALORIAS EN PLATO Y BEBIDA---------------
	LOS DATOS DE LAS CALORIAS ESTAN EN INGREDIENTES*/

select * from Plato pl inner join DetallePlato dp on pl.id = dp.idPlato inner join Ingrediente i on dp.idIngrediente = i.id
select * from DetallePlato
select * from Plato

drop trigger tg_caloriasPlato
go
create trigger tg_caloriasPlato on DetallePlato for insert
as
	declare @idPlato codigo, @idIngrediente codigo, @TCaloriasPlato float

	select @idPlato = ins.idPlato, @idIngrediente = ins.idIngrediente from DetallePlato dp
	inner join inserted ins on dp.idPlato = ins.idPlato

	select @TCaloriasPlato = sum(i.Calorias) from DetallePlato dp
	inner join Ingrediente i on dp.idIngrediente = i.id where dp.idPlato = @idPlato
	
	update Plato set TCaloriasPlato = @TCaloriasPlato where id = @idPlato
go

drop trigger tg_caloriasBebida
go
create trigger tg_caloriasBebida on DetalleBebida for insert
as
	declare @idBebida codigo, @idIngrediente codigo, @TCaloriasBebida float

	select @idBebida = ins.idBebida, @idIngrediente = ins.idIngrediente from DetalleBebida db
	inner join inserted ins on db.idBebida = ins.idBebida

	select @TCaloriasBebida = sum(i.Calorias) from DetalleBebida db
	inner join Ingrediente i on db.idIngrediente = i.id where db.idBebida = @idBebida
	
	update Bebida set TCaloriasBebida = @TCaloriasBebida where id = @idBebida
go

/*---------------TRIGGER O DISPARADOR PARA CADA INSERCION DEL NOMBRE COMPLETO DE PERSONA---------------*/

drop trigger tg_nombreCompletoPersona
go
create trigger tg_nombreCompletoPersona on Persona for insert
as
	declare @id codigo, @NombrePersona varchar(90), @ApellidoPaterno varchar(90), @ApellidoMaterno varchar(90), @NombreCompleto varchar(200)

	select @id = ins.id, @NombrePersona = ins.NombrePersona, @ApellidoPaterno = ins.ApellidoPaterno, @ApellidoMaterno = ins.ApellidoMaterno
	from Persona pr inner join inserted ins on pr.id = ins.id
	
	select @NombreCompleto = @NombrePersona + ' ' + @ApellidoPaterno + ' ' + @ApellidoMaterno

	update Persona set NombreCompleto = @NombreCompleto where id = @id
	
go

/*---------------TRIGGER O DISPARADOR PARA LA INSERCION DOBLE---------------*/

select * from Empleado

create trigger tg_insertarEmpleado on Empleado for insert
as
	declare @idEsposo codigo, @idEsposa codigo, @SexoEsposo char, @SexoEsposa char

begin tran
	select @idEsposo = i.idEsposo, @idEsposa = i.idEsposa from Matrimonio m
	inner join inserted i on m.idEsposo = i.idEsposo and m.idEsposa = i.idEsposa

	select @SexoEsposo = p.Sexo from Matrimonio m inner join Persona p on m.idEsposo = p.id
	select @SexoEsposa = p.Sexo from Matrimonio m inner join Persona p on m.idEsposa = p.id
	
	if(@SexoEsposo != @SexoEsposa)
	begin
		commit tran
	end
	else
	begin
		rollback tran
	end

/*---------------CURSOR PARA INSERCION DE PERFILES EN GRUPO---------------*/
insert into Grupo values(5,'Prueba')
--drop procedure sp_InsertarPerfilCursor(@id, @idGrupo, @Flag)
go
create procedure sp_InsertarPerfilCursor(@id codigo, @idGrupo codigo, @Flag int)
as
	declare @idPerfil codigo
	
	declare currPerfil cursor for
		select p.id from Perfil p
	open currPerfil
	fetch next from currPerfil into @idPerfil
	while (@@FETCH_STATUS = 0)
	begin
		insert into GrupoPerfil values (@id + @idPerfil, @idGrupo, @idPerfil, @Flag)
		fetch next from currPerfil into @idPerfil
	end
	close currPerfil
	deallocate currPerfil

/*---------------TRIGGER O DISPARADOR PARA LA INSERCION DE GRUPO---------------*/

go
create trigger tg_insertarGrupoPerfil on Grupo for insert
as
	declare @id codigo, @idGrupo codigo, @Flag int

	select @id = max(gp.id) from GrupoPerfil gp

	select @idGrupo = i.id from Grupo g inner join inserted i on g.id = i.id

	select @Flag = 0

	exec sp_InsertarPerfilCursor @id, @idGrupo, @Flag

go

/*---------------CURSOR PARA ACTUALIZAR EL NOMBRE COMPLETO DE PERSONA---------------*/

drop procedure sp_ActualizarNombreCompletoCursor
go
create procedure sp_ActualizarNombreCompletoCursor
as
	declare @id codigo, @NombrePersona varchar(90), @ApellidoPaterno varchar(90), @ApellidoMaterno varchar(90), @NombreCompleto varchar(200)
	
	declare currnombre cursor for
		select pr.id, pr.NombrePersona, pr.ApellidoPaterno, pr.ApellidoMaterno from Persona pr
	open currnombre
	fetch next from currnombre into @id, @NombrePersona, @ApellidoPaterno, @ApellidoMaterno
	while (@@FETCH_STATUS = 0)
	begin
		update Persona set NombreCompleto = @NombrePersona + ' ' + @ApellidoPaterno + ' ' + @ApellidoMaterno
		where id = @id
		fetch next from currnombre into @id, @NombrePersona, @ApellidoPaterno, @ApellidoMaterno
	end
	close currnombre
	deallocate currnombre

exec sp_ActualizarNombreCompletoCursor

/*---------------PROCEDMIENTOS ALMACENADOS---------------
	PROCEDIMIENTO PARA ACTUALIZAR EL EMPLEADO, SUS DATOS, FECHA, ALIMENTACION, CALORIAS */

select * from TBResumenAlimentacion
go
drop procedure sp_ActualizarTBResumenAlimentacion
go

create procedure sp_ActualizarTBResumenAlimentacion
as
	delete from TBResumenAlimentacion
	insert into TBResumenAlimentacion
select al.id, al.FechaAlimentacion,pr.id as CodigoEmpleado,
	(pr.NombrePersona + ' ' + pr.ApellidoPaterno + ' ' + pr.ApellidoMaterno) as NombreEmpleado,	c.DescripcionCargo,cc.NombreCentroCosto,a.NombreArea,
	tm.NombreTipoMenu, pl.NombrePlato, pl.TCaloriasPlato, bd.NombreBebida, bd.TCaloriasBebida, ps.NombrePostre, ps.TCaloriasPostre, sum(pl.precio + bd.precio + ps.precio) as TotalPrecio
	from Alimentacion al
		inner join Menu m on al.idMenu = m.id
		inner join Programacion p on al.idProgramacion = p.id
		inner join TipoMenu tm on m.idTipoMenu = tm.id
		inner join Plato pl on m.idPlato = pl.id
		inner join Bebida bd on m.idBebida = bd.id
		inner join Postre ps on m.idPostre = ps.id
		inner join Empleado e on p.idEmpleado = e.id
		inner join Persona pr on e.id = pr.id
		inner join Cargo c on e.idCargo = c.id
		inner join CentroCosto cc on c.idCentroCosto = cc.id
		inner join Area a on cc.idArea = a.id
	group by al.id, al.FechaAlimentacion, pr.id, (pr.NombrePersona + ' ' + pr.ApellidoPaterno + ' ' + pr.ApellidoMaterno), c.DescripcionCargo,cc.NombreCentroCosto,a.NombreArea,
	tm.NombreTipoMenu, pl.NombrePlato, pl.TCaloriasPlato, bd.NombreBebida, bd.TCaloriasBebida, ps.NombrePostre, ps.TCaloriasPostre
go

select * from TBResumenAlimentacion
exec sp_ActualizarTBResumenAlimentacion
go

BACKUP DATABASE [dbAlimentacionGeo] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\Backup\dbAlimentacionGeo.bak' WITH NOFORMAT, NOINIT,  NAME = N'dbAlimentacionGeo-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO

/*
Cursor para eliminar los registros por la edad menor

create procedure sp_EliminarMenorEdad
@EdadParametro float
as
	declare @id integer,@Edad float
	declare currAlumno cursor for
		select a.id, datediff(year,a.FechaNacimiento,getdate())) as Edad from Alumno A
		where (datediff(year, a.FechaNacimiento, getdate()))<@EdadParametro
	open CurrAlumno
	fetch next from currAlumno into @id,@Edad
	while (@@fetch_Status=0)
	begin
		delete from Alumno where id=@id
		fetch next from currAlumno into @id,@Edad
	end
	close currAlumno
	deallocate currAlumno
	end

create trigger tg_validar on Matrimonio for insert
as
	declare @edadEsposo codigo, @edadEsposa codigo, @idEsposo codigo, @idEsposa codigo

begin tran
	select @idEsposo = i.idEsposo, @idEsposa = i.idEsposa from Matrimonio m
	inner join inserted i on m.idEsposo = i.idEsposo and m.idEsposa = i.idEsposa

	select @edadEsposo = datediff(year,p.FechaNacimiento,m.FechaMatrimonio) from Matrimonio m
	inner join Persona p on m.idEsposo = p.id
	
	select @edadEsposa = datediff(year,p.FechaNacimiento,m.FechaMatrimonio) from Matrimonio m
	inner join Persona p on m.idEsposa = p.id
	
	if((@edadEsposo>=18)and(@edadEsposa>=18))
	begin
		commit tran
	end
	else
	begin
		rollback tran
	end

go
create trigger tg_validarSexo on Matrimonio for insert
as
	declare @idEsposo codigo, @idEsposa codigo, @SexoEsposo char, @SexoEsposa char

begin tran
	select @idEsposo = i.idEsposo, @idEsposa = i.idEsposa from Matrimonio m
	inner join inserted i on m.idEsposo = i.idEsposo and m.idEsposa = i.idEsposa

	select @SexoEsposo = p.Sexo from Matrimonio m inner join Persona p on m.idEsposo = p.id
	select @SexoEsposa = p.Sexo from Matrimonio m inner join Persona p on m.idEsposa = p.id
	
	if(@SexoEsposo != @SexoEsposa)
	begin
		commit tran
	end
	else
	begin
		rollback tran
	end

drop trigger tg_validarMatrimonio
go
create trigger tg_validarMatrimonio on Matrimonio for insert
as
	declare @idEsposo codigo, @idEsposa codigo, @edadEsposo codigo, @edadEsposa codigo, @SexoEsposo char, @SexoEsposa char, @CantEsposo bigint, @CantEsposa bigint

begin tran
	select @idEsposo = i.idEsposo, @idEsposa = i.idEsposa from Matrimonio m
	inner join inserted i on m.idEsposo = i.idEsposo and m.idEsposa = i.idEsposa

	select @edadEsposo = datediff(year,p.FechaNacimiento,m.FechaMatrimonio), @SexoEsposo = p.Sexo
	from Matrimonio m
	inner join Persona p on m.idEsposo = p.id

	select @CantEsposo = COUNT(m.idEsposo) from Matrimonio m

	select @edadEsposa = datediff(year,p.FechaNacimiento,m.FechaMatrimonio),@SexoEsposa = p.Sexo
	from Matrimonio m
	inner join Persona p on m.idEsposa = p.id

	select @CantEsposa = COUNT(m.idEsposa) from Matrimonio m

	if((@edadEsposo>=18)and(@edadEsposa>=18))
	begin
		if(@SexoEsposo='M' and @SexoEsposa = 'F')
		begin
			if(@CantEsposo <= 1 and @CantEsposa <= 1)
			begin
				commit tran
			end
		end
		else
		begin
			rollback tran
		end
	end
	else
	begin
		rollback tran
	end

select * from Matrimonio
select 
	m.idEsposo,(select p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno from persona p where p.id = m.idEsposo)as NombreEsposo,
	m.idEsposa,(select p.NombrePersona+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno from persona p where p.id = m.idEsposa)as NombreEsposa,
	m.FechaMatrimonio from Matrimonio m