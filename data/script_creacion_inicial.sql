--=============================================================
--CREACION DEL ESQUEMA CON EL NOMBRE DEL GRUPO--
--=============================================================
USE [GD1C2014]
GO
	
--CREATE SCHEMA [JJRD] AUTHORIZATION [GD]
--GO

--PRINT 'SE CREO EL ESQUEMA CORRECTAMENTE'

--============================================================
-- ===========================================================
--============================================================
--                EMPEZAMOS A CREAR LAS TABLAS
-- =========================================================== 
-- ===========================================================
-- ===========================================================

CREATE PROCEDURE JJRD.CREAR_ROLES
AS
BEGIN

--============================================================
--TABLA ROLES
--============================================================

	CREATE TABLE JJRD.ROLES (
		ID_ROL INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ROL_NOMBRE VARCHAR(40) NOT NULL,
		ROL_ESTADO BIT NOT NULL
	)
	PRINT 'SE CREO TABLA ROLES CORRECTAMENTE'
	
	/*--Se inserta administrador, empresa y cliente--*/ 
	
	INSERT INTO JJRD.ROLES VALUES ('ADMINISTRADOR',1)	
	INSERT INTO JJRD.ROLES VALUES ('EMPRESA',1)	
	INSERT INTO JJRD.ROLES VALUES ('CLIENTE',1)	
	
	
END
GO

CREATE PROCEDURE JJRD.CREAR_USUARIOS
AS
BEGIN

--============================================================
--TABLA USUARIOS
--============================================================
	CREATE TABLE JJRD.USUARIOS (
		ID_USUARIO INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		USERNAME NVARCHAR(30) NOT NULL UNIQUE,
		CONTRASE�A  NVARCHAR(30) NOT NULL,
		HABILITADO BIT NOT NULL,
		LOGIN_FALLIDOS NUMERIC (1,0) NOT NULL, 
		TIPO_DE_USUARIO CHAR NOT NULL,
		FECHA_NACIMIENTO DATETIME,
		NUMERO_VENTA INT,
		PUBLICACIONES_GRATIS NUMERIC(1,0),
		REPUTACION NUMERIC (1,0)
	)

	PRINT 'SE CREO TABLA USUARIOS CORRECTAMENTE'

	/* MIGRACION TABLA USUARIOS (TIPO CLIENTE) */  --PUBLICACIONES_GRATIS (NO ES APLICABLE PARA DATOS MIGRADOS)
insert into JJRD.USUARIOS (USERNAME, CONTRASE�A, HABILITADO, LOGIN_FALLIDOS, TIPO_DE_USUARIO, FECHA_NACIMIENTO)
	select distinct Cli_Mail, Cli_Nombre, 1 as HABILITADO, 0 as LOGIN_FALLIDOS, 'C' as TIPO_DE_USUARIO, Cli_Fecha_Nac
	from gd_esquema.Maestra
	where Cli_Mail is not null
	
	
	
/* MIGRACION TABLA USUARIOS (TIPO EMPRESA) */  --PUBLICACIONES_GRATIS (NO ES APLICABLE PARA DATOS MIGRADOS)
insert into JJRD.USUARIOS (USERNAME, CONTRASE�A, HABILITADO, LOGIN_FALLIDOS, TIPO_DE_USUARIO, FECHA_NACIMIENTO)
	select distinct Publ_Empresa_Razon_Social, Publ_Empresa_Cuit , 1 as HABILITADO, 0 as LOGIN_FALLIDOS, 'E' as TIPO_DE_USUARIO,  Publ_Empresa_Fecha_Creacion
	from gd_esquema.Maestra
	where Publ_Empresa_Razon_Social is not null
				
	

--============================================================
--TABLA ROL_USUARIO
--============================================================
	CREATE TABLE JJRD.ROL_USUARIO(
		ID_ROL INT FOREIGN KEY REFERENCES JJRD.ROLES (ID_ROL),
		ID_USUARIO INT FOREIGN KEY REFERENCES JJRD.USUARIOS (ID_USUARIO)
	)

	PRINT 'SE CREO TABLA ROL_USUARIO CORRECTAMENTE'
END
GO

CREATE PROCEDURE JJRD.FUNCIONALIDADES
AS 
BEGIN

--============================================================
--TABLA FUNCIONALIDADES
--============================================================

	CREATE TABLE JJRD.FUNCIONALIDAD(
		ID_FUNCIONALIDAD INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		DESCRIPCION VARCHAR(60) UNIQUE NOT NULL	
	)
	PRINT 'SE CREO TABLA FUNCIONALIDAD CORRECTAMENTE'
	
	
	/*--Se insertan funcionalidades disponibles--*/
	
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('LOGIN Y SEGURIDAD')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('ABM ROL')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('REGISTRO USUARIO')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('ABM CLIENTE')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('ABM EMPRESA')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('ABM RUBRO')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('ABM VISIBILIDAD')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('GENERAR PUBLICACION')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('EDITAR PUBLICACION')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('GESTIONAR PREGUNTAS')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('COMPRAR/OFERTAR')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('HISTORIAL CLIENTE')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('CALIFICAR AL VENDEDOR')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('FACTURAR')
	INSERT INTO JJRD.FUNCIONALIDAD VALUES ('LISTADO ESTADISTICO')
	
	
--============================================================
--TABLA ROL_FUNCIONALIDAD
--============================================================

	CREATE TABLE JJRD.ROL_FUNCIONALIDAD(
		ID_ROL INT NOT NULL FOREIGN KEY REFERENCES JJRD.ROLES(ID_ROL),
		ID_FUNCIONALIDAD INT NOT NULL FOREIGN KEY REFERENCES JJRD.FUNCIONALIDAD(ID_FUNCIONALIDAD),
		HABILITADO BIT
	)
	
	PRINT 'SE CREO TABLA ROL_FUNCIONALIDAD CORRECTAMENTE'
END
GO


CREATE PROCEDURE JJRD.EMPRESAS
AS
BEGIN

--============================================================
--TABLA EMPRESA
--============================================================

	CREATE TABLE JJRD.EMPRESA(
		ID_EMPRESA INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ID_USUARIO INT FOREIGN KEY REFERENCES JJRD.USUARIOS(ID_USUARIO),
		CUIT NVARCHAR(50) UNIQUE NOT NULL,
		RAZON_SOCIAL NVARCHAR(255) UNIQUE NOT NULL,
		CIUDAD VARCHAR(60), --NOT NULL, SAQUE EL NOT NULL PORQUE EN LA TABLA MAESTRA NO EXISTE ESTE CAMPO Y NO PODIA MIGRAR
		NOMBRE_CONTACTO VARCHAR(255),
		EMAIL NVARCHAR(50) NOT NULL UNIQUE,
		CALLE NVARCHAR(255) NOT NULL,
		NUM_CALLE NUMERIC(18,0) NOT NULL,
		PISO NUMERIC(18,0),
		DEPARTAMENTO NVARCHAR(50),
		LOCALIDAD NVARCHAR(50),
		COD_POSTAL NVARCHAR(50),
		TELEFONO NUMERIC (18,0)
	)
	
	PRINT 'SE CREO TABLA EMPRESA CORRECTAMENTE'	
	
	/* MIGRACION TABLA EMPRESA */
INSERT INTO JJRD.EMPRESA (ID_USUARIO, CUIT, RAZON_SOCIAL, EMAIL, CALLE, NUM_CALLE, PISO, DEPARTAMENTO, COD_POSTAL)
	SELECT DISTINCT U.ID_USUARIO, Publ_Empresa_Cuit, Publ_Empresa_Razon_Social, Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Nro_Calle, Publ_Empresa_Piso, Publ_Empresa_Depto, Publ_Empresa_Cod_Postal
	FROM gd_esquema.Maestra as M
		join JJRD.USUARIOS as U
		on U.USERNAME = M.Publ_Empresa_Razon_Social
	WHERE Publ_Empresa_Razon_Social is not null
	
	
END
GO

CREATE PROCEDURE JJRD.CLIENTES
AS
BEGIN

--============================================================
--TABLA CLIENTE
--============================================================

	CREATE TABLE JJRD.CLIENTE(
		ID_CLIENTE INT PRIMARY KEY IDENTITY(1,1),
		ID_USUARIO INT FOREIGN KEY REFERENCES JJRD.USUARIOS (ID_USUARIO),
		NOMBRE NVARCHAR(255) NOT NULL,
		APELLIDO NVARCHAR(255) NOT NULL,
		TIPO_DOC CHAR(3) NOT NULL,
		NUMERO_DOC NUMERIC(18,0) NOT NULL UNIQUE,
		EMAIL NVARCHAR(255) NOT NULL UNIQUE,
		CALLE NVARCHAR(255) NOT NULL,
		NUM_CALLE NUMERIC(18,0) NOT NULL,
		PISO NUMERIC(18,0),
		DEPARTAMENTO NVARCHAR(50),
		LOCALIDAD NVARCHAR(50),
		COD_POSTAL NVARCHAR(50),
		TELEFONO NUMERIC (18,0)
	)

	PRINT 'SE CREO TABLA CLIENTE CORRECTAMENTE'
		
	
	/* MIGRACION TABLA CLIENTES */
	INSERT INTO JJRD.CLIENTE (ID_USUARIO, NOMBRE, APELLIDO, TIPO_DOC, NUMERO_DOC, EMAIL, CALLE, NUM_CALLE, PISO, DEPARTAMENTO, COD_POSTAL)
	SELECT DISTINCT U.ID_USUARIO, Cli_Nombre, Cli_Apeliido, 'DNI' as TIPO_DOC, Cli_Dni, Cli_Mail, Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal
	FROM gd_esquema.Maestra as M
	JOIN	JJRD.USUARIOS as U
		on	U.USERNAME = M.Cli_Mail
	WHERE Cli_Dni is not null
	
END
GO

CREATE PROCEDURE JJRD.VISIBILIDADES
AS
BEGIN

--============================================================
--TABLA VISIBILIDAD
--============================================================

	CREATE TABLE JJRD.VISIBILIDAD (
		COD_VISIBILIDAD NUMERIC(18,0) NOT NULL PRIMARY KEY,
		DESCRIPCION NVARCHAR(255) NOT NULL,
		PRECIO NUMERIC(18,2) NOT NULL,
		PORCENTAJE_VENTA NUMERIC(18,2) NOT NULL,
		FECHA_FINALIZACION NUMERIC(18,0)
	);
	
	PRINT 'SE CREO TABLA VISIBILIDAD CORRECTAMENTE'
	
	INSERT INTO JJRD.VISIBILIDAD (COD_VISIBILIDAD, DESCRIPCION, PRECIO, PORCENTAJE_VENTA, FECHA_FINALIZACION)

	SELECT DISTINCT PUBLICACION_VISIBILIDAD_COD, PUBLICACION_VISIBILIDAD_DESC, PUBLICACION_VISIBILIDAD_PRECIO, PUBLICACION_VISIBILIDAD_PORCENTAJE, -1 AS FECHA_FINALIZACION
		
		FROM gd_esquema.Maestra AS M 
	
END	
GO

CREATE PROCEDURE JJRD.PUBLICACIONES
AS
BEGIN

--============================================================
--TABLA PUBLICACIONES
--============================================================ 

	CREATE TABLE JJRD.PUBLICACION(
		COD_PUBLICACION NUMERIC(18,0) PRIMARY KEY, --CORREGIDO : IDENTITY(1,1), MAL, EL COD_PUBLICACION VIENE DADO POR LA TABLA MAESTRA
		ID_USUARIO INT FOREIGN KEY REFERENCES JJRD.USUARIOS (ID_USUARIO),
		COD_VISIBILIDAD NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES JJRD.VISIBILIDAD (COD_VISIBILIDAD), 
		DESCRIPCION NVARCHAR(255) NOT NULL,
		STOCK NUMERIC(18,0) NOT NULL,
		FECHA_VENCIMIENTO DATETIME, -- CORREGIDO: NUMERIC (18,0), MAL, ES DATETIME
		FECHA_INICIO DATETIME,
		PRECIO NUMERIC(18,2) NOT NULL,
		ESTADO NVARCHAR(255) NOT NULL,
		TIPO NVARCHAR(255) NOT NULL,
		PREGUNTAS CHAR (2) NOT NULL --VER: PODRIAMOS HABER USADO BIT COMO EN EL CAMPO HABILITADO DE LA TABLA USUARIOS
		);
	PRINT 'SE CREO TABLA PUBLICACION CORRECTAMENTE'
	
	
	/* MIGRACION TABLA PUBLICACIONES */
--Publicaciones hechas por empresas
insert into JJRD.PUBLICACION (COD_PUBLICACION, U.ID_USUARIO, COD_VISIBILIDAD, DESCRIPCION, STOCK, FECHA_VENCIMIENTO,
								FECHA_INICIO, PRECIO, ESTADO, TIPO, PREGUNTAS)
	select distinct Publicacion_Cod , U.ID_USUARIO, V.COD_VISIBILIDAD, Publicacion_Descripcion, Publicacion_Stock, 
					Publicacion_Fecha_Venc, Publicacion_Fecha, Publicacion_Precio, Publicacion_Estado, Publicacion_Tipo, 'SI' as PREGUNTAS
	from gd_esquema.Maestra as M
		join JJRD.USUARIOS as U on U.USERNAME= M.Publ_Empresa_Razon_Social
		join jjrd.VISIBILIDAD as V on V.COD_VISIBILIDAD = M.Publicacion_Visibilidad_Cod
	where M.Publ_Empresa_Razon_Social is not null
	
	
	--Publicaciones hechas por clientes.
insert into JJRD.PUBLICACION (COD_PUBLICACION, U.ID_USUARIO, COD_VISIBILIDAD, DESCRIPCION, STOCK, FECHA_VENCIMIENTO,
								FECHA_INICIO, PRECIO, ESTADO, TIPO, PREGUNTAS)
	select distinct Publicacion_Cod , U.ID_USUARIO, V.COD_VISIBILIDAD, Publicacion_Descripcion, Publicacion_Stock, 
					Publicacion_Fecha_Venc, Publicacion_Fecha, Publicacion_Precio, Publicacion_Estado, Publicacion_Tipo, 'SI' as PREGUNTAS
	from gd_esquema.Maestra as M
		join JJRD.USUARIOS as U on U.USERNAME= M.Publ_Cli_Mail
		join jjrd.VISIBILIDAD as V on V.COD_VISIBILIDAD = M.Publicacion_Visibilidad_Cod
	where M.Publ_Cli_Dni is not null 
	
	
	
END 
GO

CREATE PROCEDURE JJRD.RUBROS
AS
BEGIN

--============================================================
--TABLA RUBRO
--============================================================

	CREATE TABLE JJRD.RUBRO(
	COD_RUBRO INT IDENTITY(1,1) PRIMARY KEY,
	DESCRIPCION NVARCHAR(255) NOT NULL
	);
	
	PRINT 'SE CREO TABLA RUBRO CORRECTAMENTE'
	
	
	
/*--MIGRACION TABLA RUBRO---------->NO ES NECESARIA SON TODOS NULL*/

--INSERT INTO JJRD.RUBRO (DESCRIPCION)
--SELECT DISTINCT  (Publicacion_Rubro_Descripcion)
--from gd_esquema.Maestra
--where Publicacion_Rubro_Descripcion is not null


---
---
--============================================================
--TABLA PUBLICACION_RUBRO
--============================================================		
	
	CREATE TABLE JJRD.PUBLICACION_RUBRO(
	COD_RUBRO INT FOREIGN KEY REFERENCES JJRD.RUBRO(COD_RUBRO),
	COD_PUBLICACION NUMERIC (18,0) IDENTITY(1,1) FOREIGN KEY REFERENCES JJRD.PUBLICACION(COD_PUBLICACION)
	);
	
	PRINT 'SE CREO TABLA PUBLICACION_RUBRO CORRECTAMENTE'
	
END
GO

CREATE PROCEDURE JJRD.OFERTASPUBLICACIONES
AS
BEGIN

--============================================================
--TABLA OFERTAS
--============================================================		

	CREATE TABLE JJRD.OFERTAS(
	ID_OFERTA INT IDENTITY(1,1) PRIMARY KEY,
	COD_PUBLICACION NUMERIC(18,0) FOREIGN KEY REFERENCES JJRD.PUBLICACION(COD_PUBLICACION),
	ID_CLIENTE INT FOREIGN KEY REFERENCES JJRD.CLIENTE (ID_CLIENTE),
	MONTO NUMERIC(18,2) NOT NULL,
	FECHA DATETIME NOT NULL
	)
	
	PRINT 'SE CREO TABLA OFERTAS CORRECTAMENTE'
	
	
	/*---MIGRACION TABLA OFERTAS-----*/ --REHICE HABIA ALGUNAS COSAS MAL.
insert into JJRD.OFERTAS (P.COD_PUBLICACION, ID_CLIENTE, MONTO, FECHA)

	select distinct Publicacion_Cod, C.ID_CLIENTE , Oferta_Monto, Oferta_Fecha
	from gd_esquema.Maestra as M
		join JJRD.PUBLICACION as P on M.Publicacion_Cod = P.COD_PUBLICACION
		join JJRD.CLIENTE as C on M.Cli_Mail = C.EMAIL
	where Oferta_Fecha is not null

END
GO

CREATE PROCEDURE JJRD.COMPRASYCALIFICACIONES
AS
BEGIN

--============================================================
--TABLA CALIFICACIONES
--============================================================		
	
	CREATE TABLE JJRD.CALIFICACIONES(
	COD_CALIFICACION NUMERIC(18,0) PRIMARY KEY, --SACAMOS IDENTITY, COD_CALIFICACION VIENE DADO X LA TABLA MAESTRA.
	--ID_COMPRA NUMERIC(18,0) FOREIGN KEY REFERENCES JJRD.COMPRAS(ID_COMPRA),
	--COD_PUBLICACION NUMERIC(18,0) FOREIGN KEY REFERENCES JJRD.PUBLICACION (COD_PUBLICACION),
	CANTIDAD_ESTRELLAS NUMERIC (18,0) NOT NULL,
	DESCRIPCION NVARCHAR(255) NOT NULL
	); 
	

	PRINT 'SE CREO TABLA CALIFICACIONES CORRECTAMENTE'
	
	/* MIGRACION TABLA CALIFICACIONES */

	insert into JJRD.CALIFICACIONES (COD_CALIFICACION, CANTIDAD_ESTRELLAS, DESCRIPCION)
	select distinct M.Calificacion_Codigo, M.Calificacion_Cant_Estrellas, M.Calificacion_Descripcion
	from gd_esquema.Maestra as M
	where Calificacion_Codigo is not null

		
	--============================================================
	--TABLA COMPRAS
	--============================================================
	CREATE TABLE JJRD.COMPRAS(
	ID_COMPRA NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	COD_PUBLICACION NUMERIC(18,0) FOREIGN KEY REFERENCES JJRD.PUBLICACION(COD_PUBLICACION),
	ID_CLIENTE INT FOREIGN KEY REFERENCES JJRD.CLIENTE(ID_CLIENTE),
	COD_CALIFICACION NUMERIC (18,0) FOREIGN KEY REFERENCES JJRD.CALIFICACIONES (COD_CALIFICACION), --AGREGO FK A CALIFICACIONES
	FECHA DATETIME NOT NULL,
	CANTIDAD NUMERIC(18,2) NOT NULL,
	ID_FACTURA NUMERIC(18,0) FOREIGN KEY REFERENCES JJRD.FACTURAS(ID_FACTURA)
	--COMPRA_CALIFICADA CHAR (2) NOT NULL       SI EXISTE CAMPO FK A CALIFICACIONES (COD_CALIFICACION ) ENTONCES LA COMPRA ESTA CALIFICADA.
	)
	
	PRINT 'SE CREO TABLA COMPRAS CORRECTAMENTE'

	/*---MIGRACION TABLA COMPRAS -----*/
	insert into JJRD.COMPRAS (COD_PUBLICACION, ID_CLIENTE, FECHA, CANTIDAD, COD_CALIFICACION)
	select distinct Publicacion_Cod, C.ID_CLIENTE, Compra_Fecha, Compra_Cantidad, M.Calificacion_Codigo
	from gd_esquema.Maestra as M
		join JJRD.PUBLICACION as P on M.Publicacion_Cod = P.COD_PUBLICACION
		join JJRD.CLIENTE as C on M.Cli_Mail = C.EMAIL
	where Compra_Fecha is not null
	
END
GO

CREATE PROCEDURE JJRD.PREGUNTASPUBLICACION
AS
BEGIN

--============================================================
--TABLA PREGUNTAS
--============================================================		

	CREATE TABLE JJRD.PREGUNTAS(
	COD_PREGUNTA BIGINT IDENTITY(1,1) PRIMARY KEY,
	COD_PUBLICACION NUMERIC(18,0)  FOREIGN KEY REFERENCES JJRD.PUBLICACION (COD_PUBLICACION),
	ID_CLIENTE INT FOREIGN KEY REFERENCES JJRD.CLIENTE (ID_CLIENTE),
	PREGUNTA_DESCRIPCION VARCHAR(80),
	RESPUESTA_FECHA DATETIME NOT NULL,
	RESPUESTA_DESCRIPCION VARCHAR(80)
	);
	
	PRINT 'SE CREO TABLA PREGUNTAS CORRECTAMENTE'
END
GO

CREATE PROCEDURE JJRD.FACTURACION
AS
BEGIN
--============================================================
--TABLA FACTURAS
--============================================================	

	CREATE TABLE JJRD.FACTURAS(
	ID_FACTURA NUMERIC(18,0) PRIMARY KEY,--SACAMOS IDENTITY, ID_FACTURA VIENE DADO POR NUM_FACTURA DE TABLA MAESTRA
	FECHA DATETIME,
	FORMA_DE_PAGO NVARCHAR(255),
	TOTAL NUMERIC (18,2)
	)

	PRINT 'SE CREO TABLA FACTURAS CORRECTAMENTE'	
	
	---MIGRACION TABLA FACTURAS-------------
	INSERT INTO JJRD.FACTURAS (ID_FACTURA, FECHA, FORMA_DE_PAGO, TOTAL)
	SELECT  distinct Factura_Nro, Factura_Fecha, Forma_Pago_Desc, Factura_Total
	FROM gd_esquema.Maestra 
	WHERE Factura_Nro IS NOT NULL
	
	--ver objetos creados: select name from sysobjects
END
GO


exec JJRD.CREAR_ROLES
exec JJRD.CREAR_USUARIOS
exec JJRD.CLIENTES
exec JJRD.EMPRESAS
exec JJRD.FUNCIONALIDADES
exec JJRD.VISIBILIDADES
exec JJRD.PUBLICACIONES
exec JJRD.RUBROS
exec JJRD.FACTURACION
exec JJRD.COMPRASYCALIFICACIONES
exec JJRD.OFERTASPUBLICACIONES
exec JJRD.PREGUNTASPUBLICACION
GO

CREATE PROCEDURE JJRD.PASSWD_RANDOM
AS
BEGIN

--SELECT SUBSTRING(CONVERT(varchar(255), NEWID()), 0, 9)

declare @alphabet varchar(62) = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz'
select 
substring(@alphabet, convert(int, rand()*62), 1) + 
substring(@alphabet, convert(int, rand()*62), 1) +
substring(@alphabet, convert(int, rand()*62), 1) +
substring(@alphabet, convert(int, rand()*62), 1) +
substring(@alphabet, convert(int, rand()*62), 1) +
substring(@alphabet, convert(int, rand()*62), 1) +
substring(@alphabet, convert(int, rand()*62), 1);

END
GO

CREATE PROCEDURE JJRD.USR_RANDOM
AS
BEGIN

declare @alphabet varchar(52) = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz'
select 
substring(@alphabet, convert(int, rand()*52), 1) + 
substring(@alphabet, convert(int, rand()*52), 1) +
substring(@alphabet, convert(int, rand()*52), 1) +
substring(@alphabet, convert(int, rand()*52), 1) +
substring(@alphabet, convert(int, rand()*52), 1) +
substring(@alphabet, convert(int, rand()*52), 1) +
substring(@alphabet, convert(int, rand()*52), 1);

END
GO



CREATE PROCEDURE JJRD.BORRAR_TODO --BORRA TODO DENTRO DEL ESQUEMA JJRD
as
begin
DECLARE @spSQL AS NVARCHAR(MAX)
DECLARE @fnSQL AS NVARCHAR(MAX)
DECLARE @vwSQL AS NVARCHAR(MAX)
DECLARE @fkSQL AS NVARCHAR(MAX)
DECLARE @tblSQL AS NVARCHAR(MAX)

SET @spSQL = ''
SET @fnSQL = ''
SET @vwSQL = ''
SET @fkSQL = ''
SET @tblSQL = ''

-- Procedimientos almacenados
SELECT @spSQL = @spSQL + 'DROP PROCEDURE JJRD.' + QUOTENAME(name)
FROM sys.procedures
WHERE is_ms_shipped = 0
AND name NOT LIKE 'sp\_%' ESCAPE '\'

-- Funciones
SELECT @fnSQL = @fnSQL + 'DROP FUNCTION JJRD.' + QUOTENAME(name)
FROM sys.objects
WHERE is_ms_shipped = 0
AND name NOT LIKE 'fn\_%' ESCAPE '\'
AND type = 'FN'

-- Vistas
SELECT @vwSQL = @vwSQL + 'DROP VIEW JJRD.' + QUOTENAME(name)
FROM sys.views
WHERE is_ms_shipped = 0

-- Claves for�neas
SELECT @fkSQL = @fkSQL + 'ALTER TABLE JJRD.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + ' DROP CONSTRAINT ' + QUOTENAME(name)
FROM sys.foreign_keys
WHERE is_ms_shipped = 0

-- Tablas
SELECT @tblSQL = @tblSQL + 'DROP TABLE JJRD.' + QUOTENAME(name)
FROM sys.tables
WHERE is_ms_shipped = 0
AND name NOT LIKE 'sys%'

EXEC (@spSQL)
EXEC (@fnSQL)
EXEC (@vwSQL)
EXEC (@fkSQL)
EXEC (@tblSQL)

-- + QUOTENAME(SCHEMA_NAME(schema_id)) + '.' + QUOTENAME(name), PARA BORRAR TODOS LOS ESQUEMAS

end
GO

<<<<<<< HEAD
select * from JJRD.USUARIOS 

select * from JJRD.ROLES

select * from JJRD.ROL_USUARIO
//PARA PROBAR
insert JJRD.ROL_USUARIO values (1,1)
insert JJRD.ROL_USUARIO values (2,2)
insert JJRD.ROL_USUARIO values (3,3)
insert JJRD.ROL_USUARIO values (2,1)
insert JJRD.ROL_USUARIO values (3,1)
insert JJRD.ROL_USUARIO values (3,2)
insert JJRD.ROL_USUARIO values (1,5)
insert JJRD.ROL_USUARIO values (1,7)



SELECT distinct(Nombre) from JJRD.USUARIOS U, JJRD.ROL_USUARIO ur
                                                   INNER JOIN JJRD.ROLES R ON R.ID_ROL = ur.ID_ROL 
                                                   WHERE U.HABILITADO = '1' and U.ID_USUARIO = 1
                                                   AND R.ROL_ESTADO = '1'
                                                   
                                                   
SELECT ID_ROL FROM JJRD.ROL_USUARIO  WHERE ID_USUARIO = 1

select COUNT(*) from JJRD.USUARIOS where NOMBRE = 'fantino_Paz@gmail.com'

select COUNT(*) from JJRD.ROL_USUARIO where ID_USUARIO = 1

update JJRD.USUARIOS set LOGIN_FALLIDOS = 0 where id_Usuario = 3
update JJRD.USUARIOS set LOGIN_FALLIDOS = 0 where id_Usuario = 3
update JJRD.USUARIOS set HABILITADO = 1 where id_Usuario = 3

SELECT r.ROL_NOMBRE rol,  r.ID_ROL rol from JJRD.ROLES r, JJRD.ROL_USUARIO ur where ur.ID_ROL = r.ID_ROL and ur.ID_USUARIO = 1


SELECT ID_ROL FROM JJRD.ROLES   WHERE ROL_NOMBRE = 'EMPRESA'

jalif_Ben�tez@gmail.com
urbano_Tapia@gmail.com
=======


>>>>>>> a9cf03ffc6c1de1ea4ef96ccc2b66fc3f73ff24a
