/*Upoli123*/
--https://social.msdn.microsoft.com/Forums/es-ES/45d88b2e-7910-4a1c-b2f7-a01bcbf1d39a/conectar-aplicacion-vbnet-con-sql-remotamente?forum=vbes

CREATE TABLE [dbo].[categoria](
	[idcategoria] [int] IDENTITY(1,1) primary key NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](256) NULL,

	);


	CREATE TABLE [dbo].[presentacion](
	[idpresentacion] [int] IDENTITY(1,1) primary key  NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](256) NULL
	);

	CREATE TABLE [dbo].[articulo](
	[idarticulo] [int] IDENTITY(1,1) primary key NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](1024) NULL,
	[imagen] [image] NULL,
	[idcategoria] [int] NOT NULL,
	[idpresentacion] [int] NOT NULL);


	CREATE TABLE [dbo].[proveedor](
	[idproveedor] [int] IDENTITY(1,1) primary key NOT NULL,
	[razon_social] [varchar](150) NOT NULL,
	[sector_comercial] [varchar](50) NOT NULL,
	[tipo_documento] [varchar](20) NOT NULL,
	[num_documento] [varchar](11) NOT NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[url] [varchar](100) NULL);


	CREATE TABLE [dbo].[trabajador](
	[idtrabajador] [int] IDENTITY(1,1) primary key NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellidos] [varchar](40) NOT NULL,
	[sexo] [varchar](1) NOT NULL,
	[fecha_nac] [date] NOT NULL,
	[num_documento] [varchar](8) NOT NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[acceso] [varchar](20) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL);

	CREATE TABLE [dbo].[ingreso](
	[idingreso] [int] IDENTITY(1,1)  primary key NOT NULL,
	[idtrabajador] [int] NOT NULL,
	[idproveedor] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo_comprobante] [varchar](20) NOT NULL,
	[serie] [varchar](4) NOT NULL,
	[correlativo] [varchar](7) NOT NULL,
	[igv] [decimal](4, 2) NOT NULL
	);


	CREATE TABLE [dbo].[detalle_ingreso](
	[iddetalle_ingreso] [int] IDENTITY(1,1)  primary key NOT NULL,
	[idingreso] [int] NOT NULL,
	[idarticulo] [int] NOT NULL,
	[precio_compra] [money] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[stock_inicial] [int] NOT NULL,
	[stock_actual] [int] NOT NULL,
	[fecha_produccion] [date] NOT NULL,
	[fecha_vencimiento] [date] NOT NULL);

	CREATE TABLE [dbo].[cliente](
	[idcliente] [int] IDENTITY(1,1) primary key NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](40) NULL,
	[sexo] [varchar](1) NULL,
	[fecha_nacimiento] [date] NULL,
	[tipo_documento] [varchar](20) NOT NULL,
	[num_documento] [varchar](11) NOT NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](10) NULL,
	[email] [varchar](50) NULL);

	CREATE TABLE [dbo].[venta](
	[idventa] [int] IDENTITY(1,1) primary key NOT NULL,
	[idcliente] [int] NOT NULL,
	[idtrabajador] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo_comprobante] [varchar](20) NOT NULL,
	[serie] [varchar](4) NOT NULL,
	[correlativo] [varchar](7) NOT NULL,
	[igv] [decimal](4, 2) NOT NULL);

	CREATE TABLE [dbo].[detalle_venta](
	[iddetalle_venta] [int] IDENTITY(1,1) primary key NOT NULL,
	[idventa] [int] NOT NULL,
	[iddetalle_ingreso] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[descuento] [money] NOT NULL);

	-----------------------------------------------------------
	--implemetacion de procedimientos almacenados

	--Procedimiento mostrar

	Create proc spmostrar_categoria
	as
	 select top 200 * from categoria
	 order by idcategoria desc
	 go

	 --procedimiento buscar nombre

	 create proc spbuscar_categoria
	   @textobuscar varchar(50)
	   as
	    select * from categoria
		where nombre like @textobuscar + '%'
		go

--procedimiento insertar

  create proc spinsertar_categoria
   @idcategoria int output,
   @nombre varchar(50),
   @descripcion varchar(256)
   as
   insert into categoria (nombre,descripcion) 
    values(@nombre,@descripcion)
	go


	--procedimiento editar

	create proc speditar_categoria
	@idcategoria int,
	@nombre varchar(50),
	@descripcion varchar(256)
	as
	  update categoria set nombre=@nombre,
	    descripcion=@descripcion
		where idcategoria=@idcategoria

		go
 


 --procedimiento eliminar

 create proc speliminar_categoria
 @idcategoria int
 as
   delete from categoria
   where idcategoria = @idcategoria

   go

   ---------------------------------------------

   --PRESEBTACION
   -- PROCEDIMIENTO MOSTRAR PRESENTACION

   create proc spmostrar_presentacion
   as 
   select top 100 * from presentacion
   order by idpresentacion desc
   go

   --procedimiento buscar presentaciones 

   create proc spbuscar_presentacion_nombre
   @textobuscar varchar(50)
   as
    select * from presentacion
	where nombre like @textobuscar + '%'

	--procedimiento insertar presentaciones

	create proc spinsertar_presentacion
	@idpresentacion int output,
	@nombre varchar(50),
	@descripcion varchar(256)
	as
	  insert into presentacion(idpresentacion,nombre,descripcion)
	  values (@idpresentacion,@nombre,@descripcion)
	  go

	 


	  --procedimeinto editar presentacion


	  create proc speditar_presentacion
	@idpresentacion int ,
	@nombre varchar(50),
	@descripcion varchar(256)
	as
	 update presentacion set nombre=@nombre, descripcion=@descripcion
	 where idpresentacion=@idpresentacion
	 go


	 --procedimiento elimar presentacion

	 create proc speliminar_presentacion
	   @idpresentacion int
	   as

	   delete presentacion where idpresentacion=@idpresentacion
	   go
	   

	-------------------------------------------
	--consultas articulos

	--procedimiento para mostrar articulo
CREATE PROC spmostrar_articulo
 AS
SELECT top 100 dbo.articulo.idarticulo, dbo.articulo.codigo, dbo.articulo.nombre, dbo.articulo.descripcion, dbo.articulo.imagen,
		dbo.articulo.idcategoria, dbo.categoria.nombre AS Categoria, dbo.articulo.idpresentacion, 
        dbo.presentacion.nombre AS Presentacion
FROM    dbo.articulo INNER JOIN
        dbo.categoria ON
	    dbo.articulo.idcategoria = dbo.categoria.idcategoria INNER JOIN
        dbo.presentacion ON
	    dbo.articulo.idpresentacion = dbo.presentacion.idpresentacion
		order by dbo.articulo.idarticulo desc

go

	--proc buscar articulo-nombre
CREATE PROC spbuscar_articulo_nombre
@textobuscar varchar(50)
 AS
SELECT  dbo.articulo.idarticulo, dbo.articulo.codigo, dbo.articulo.nombre, dbo.articulo.descripcion, dbo.articulo.imagen,
		dbo.articulo.idcategoria, dbo.categoria.nombre AS Categoria, dbo.articulo.idpresentacion, 
        dbo.presentacion.nombre AS Presentacion
FROM    dbo.articulo INNER JOIN
        dbo.categoria ON
	    dbo.articulo.idcategoria = dbo.categoria.idcategoria INNER JOIN
        dbo.presentacion ON
	    dbo.articulo.idpresentacion = dbo.presentacion.idpresentacion
		where dbo.articulo.nombre like @textobuscar + '%'
		order by dbo.articulo.idarticulo desc

go

	--proc insertar articulo

	create proc spinsertar_articulo
	@idarticulo int output,
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(256),
	@imagen image,
	@idcategoria int,
	@idpresentacion int
	as
	insert into articulo(codigo,nombre,descripcion,imagen,idcategoria,idpresentacion)
	values(@codigo,@nombre,@descripcion, @imagen, @idcategoria, @idpresentacion)
	go


	--proce editar arti
	create proc speditar_articulo
	@idarticulo int ,
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(256),
	@imagen image,
	@idcategoria int,
	@idpresentacion int
	as
	update articulo set codigo=@codigo,nombre=@nombre,descripcion=@descripcion,
	imagen=@imagen,idcategoria=@idcategoria,idpresentacion=@idpresentacion
	where idarticulo=@idarticulo
	go

	--proc eliminar articulo

	create proc speliminar_articulo
	@idarticulo int 
	as
	delete from articulo
	where idarticulo=@idarticulo
	go
	------------------------------------------------------------------
	--proveedores procedimiento

	--MOSTRAR
	    create proc spmostrar_proveedor
		as
		select top 100 * from proveedor order by razon_social asc
		go

	--BUSCAR RAZON SOCIal
	   create proc spbuscar_proveedor_razon_social
	   @textobuscar varchar(50)
	   as
	   select * from proveedor
	   where razon_social like @textobuscar + '%'

	--BUSCAR NUM DOCUMENTO
	    create proc spbuscar_proveedor_num_documento
	   @textobuscar varchar(11)
	   as
	   select * from proveedor
	   where num_documento like @textobuscar + '%'
	   go

	--INSERTAR
	  create proc spinsertar_proveedor
	  @idproveedor int OUTPUT,
	  @razon_social varchar(150),
	  @sector_comercial varchar(50),
	  @tipo_documento varchar(20),
	  @num_documento varchar(11),
	  @direccion varchar(100),
	  @telefono varchar(10),
	  @email varchar(50),
	  @url varchar(100)
	  as
	  insert into proveedor(razon_social,sector_comercial,tipo_documento,num_documento,direccion,telefono,email,url)
	  values(@razon_social,@sector_comercial,@tipo_documento,@num_documento,@direccion,@telefono,@email,@url)
	  go
	 

	--EDITAR
	create proc speditar_proveedor
	  @idproveedor int ,
	  @razon_social varchar(150),
	  @sector_comercial varchar(50),
	  @tipo_documento varchar(20),
	  @num_documento varchar(11),
	  @direccion varchar(100),
	  @telefono varchar(10),
	  @email varchar(50),
	  @url varchar(100)
	  as
	   update proveedor set razon_social=@razon_social,sector_comercial=@sector_comercial,
	  tipo_documento=@tipo_documento,num_documento=@num_documento,direccion=@num_documento,telefono=@telefono,email=@email,url=@url
	  where idproveedor=@idproveedor
	  go


	--ELIMINAR

	create proc speliminar_proveedor
	 @idproveedor int
	 as
	 delete from proveedor
	 where idproveedor= @idproveedor
	 go

	 ----------------------------------------------
	 --clientes
	 --mostrar
	 create proc spmostrar_cliente
	 as
	 select top 100 * from cliente order by apellidos asc
	 go


	 --buscarapellido
	 
	  create proc spbuscarclientes_apellido
	   @textobuscar varchar(50)
	   as
	   select * from cliente
	   where apellidos like @textobuscar + '%'
	   go

	 --buscar num_documento

	 create proc spbuscarcliente_num_documento
	  @textobuscar varchar(50)
	   as
	   select * from cliente
	   where num_documento like @textobuscar + '%'
	   go

	 --insertar
	 create proc psinsertar_cliente 

	 @idcliente int output,
	 @nombre varchar(50),
	 @apellidos varchar(40),
	 @sexo varchar(1),
	 @fecha_nacimiento date,
	 @tipo_documento varchar(20),
	 @num_documento varchar(11),
	 @direccion varchar(100),
	 @telefono varchar(10),
	 @email varchar(50)
	 as
	 insert into cliente (nombre,apellidos,sexo,fecha_nacimiento,tipo_documento,num_documento,direccion,telefono,email)
	  values(@nombre,@apellidos,@sexo,@fecha_nacimiento,@tipo_documento,@num_documento,@direccion,@telefono,@email)


	 --editar
	 create proc speditar_cliente
	 @idcliente int,
	 @nombre varchar(50),
	 @apellidos varchar(40),
	 @sexo varchar(1),
	 @fecha_nacimiento date,
	 @tipo_documento varchar(20),
	 @num_documento varchar(11),
	 @direccion varchar(100),
	 @telefono varchar(10),
	 @email varchar(50)
	 as
      update cliente set nombre=@nombre,apellidos=@apellidos,sexo=@sexo, fecha_nacimiento=@fecha_nacimiento,tipo_documento=@tipo_documento,num_documento=@num_documento,
	  direccion=@direccion,telefono=@telefono,email=@email
	  where idcliente=@idcliente
	  go


	 --eliminar

	 create proc speliminar_cliente
	 @idcliente int
	 as
	 delete from cliente
	 where idcliente=@idcliente
	 go

	 -----------------------------------------------------------------------------------
	 --procedimientos almacenados de trabajadores

	 --mostrar
	 create proc spmostrar_trabajador
	 as
	 select top 100 * from trabajador
	 order by apellidos asc
	 go

	 --buscar por apellidos

	  create proc spbuscarapellido_trabajador
	  @textobuscar varchar(50)
	  as
	  select * from trabajador
	  where apellidos like @textobuscar + '%'
	  order by apellidos asc
	  go


	 --buscar num_documentos

	  create proc spbuscarnum_docu_trabajador
	  @textobuscar varchar(50)
	  as
	  select * from trabajador
	  where num_documento like @textobuscar + '%'
	  order by apellidos asc
	  go

	 --insertar

	 create proc psinsertar_trabajador

	 @idtrabajador int output,
	 @nombre varchar(50),
	 @apellidos varchar(50),
	 @sexo varchar(1),
	 @fecha_nac date,
	 @num_documento varchar(8),
	 @direccion varchar(100),
	 @telefono varchar(10),
	 @email varchar(50),
	 @acceso varchar(20),
	 @usuario varchar(20),
	 @password varchar(20)
	 as
	 insert into trabajador(nombre,apellidos,sexo,fecha_nac,num_documento,direccion,telefono,email,acceso,usuario,password)
	 values(@nombre,@apellidos,@sexo,@fecha_nac,@num_documento,@direccion,@telefono,@email,@acceso,@usuario,@password)
	 go


	 --editar
	 create proc speditar_trabajador
	 @idtrabajador int ,
	 @nombre varchar(50),
	 @apellidos varchar(50),
	 @sexo varchar(1),
	 @fecha_nac date,
	 @num_documento varchar(8),
	 @direccion varchar(100),
	 @telefono varchar(10),
	 @email varchar(50),
	 @acceso varchar(20),
	 @usuario varchar(20),
	 @password varchar(20)
	 as
	 update trabajador set nombre=@nombre,apellidos=@apellidos,sexo=@sexo,fecha_nac=@fecha_nac,
	 num_documento=@num_documento,direccion=@direccion,telefono=@telefono,email=@email,acceso=@acceso,usuario=@usuario,password=@password
	 where idtrabajador = @idtrabajador
	 go
	       
	 
	 --eliminar
	 create proc speliminar_trabajador
	  @idtrabajador int
	  as
	  delete trabajador where idtrabajador=@idtrabajador
	  go


	  select * from trabajador
	  -----------------------------------------------------------------------

	  create proc sp_login
	  @usuario varchar(20),
	  @password varchar(20)
	  as
	   select idtrabajador,apellidos,nombre,acceso
	   from trabajador
	   where usuario=@usuario and password=@password
	   go


	   select * from ingreso
	   ---------------------------------------------------------------
	   --Gestion de ingresos
	   alter table ingreso 
	   add estado varchar(7) not null
	   go

	   ----------------------------------
	   --procedimientos de ingresos

	   ALTER proc spmostrar_ingreso
	   as
	   select top 100 i.idingreso,
	   (t.apellidos+' '+t.nombre) as Trabajador,
	   p.razon_social as Proveedor ,
	   i.fecha,i.tipo_comprobante,
	   i.serie,i.estado,
	   i.correlativo, 
	   --SUM(d.precio_compra*d.stock_inicial) as Total
	   'C$' + CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(SUM(d.precio_compra*d.stock_inicial) AS MONEY), 1)) as Total
	    from detalle_ingreso  d inner join  ingreso i
		on  d.idingreso=i.idingreso
		inner join proveedor  p
		on i.idproveedor=p.idproveedor
		inner join trabajador t
		on i.idtrabajador=t.idtrabajador
		group by i.idingreso,(t.apellidos+' '+t.nombre),p.razon_social ,
	   i.fecha,i.tipo_comprobante,i.serie,i.estado,i.correlativo
	   order by i.idingreso desc
	   go

	   --motrar ingrso entre fecha

	   create proc spbuscar_ingreso_fecha
	   @textobuscar varchar(20),
	   @textobuscar2 varchar(20)
	   as
	    select  i.idingreso,(t.apellidos+' '+t.nombre) as Trabajador,p.razon_social as Proveedor ,
	    i.fecha,i.tipo_comprobante,i.serie,i.estado, SUM(d.precio_compra*d.stock_inicial) as Total
	    from detalle_ingreso  d inner join  ingreso i
		on  d.idingreso=i.idingreso
		inner join proveedor  p
		on i.idproveedor=p.idproveedor
		inner join trabajador t
		on i.idtrabajador=t.idtrabajador
		group by i.idingreso,(t.apellidos+' '+t.nombre),p.razon_social ,
	   i.fecha,i.tipo_comprobante,i.serie,i.estado
	    having i.fecha >=@textobuscar and i.fecha <= @textobuscar2
		go

		--insertar ingreso

		ALTER proc spinsertar_ingreso
		@idingreso int = null output,
		@idtrabajador int,
		@idproveedor int, 
		@fecha  date,
		@tipo_comprobante varchar(20),
		@serie varchar(4),
		@correlativo varchar(7),
		@igv decimal(4,2),
		@estado varchar(7)
		as
		insert into ingreso(idtrabajador,idproveedor,fecha,tipo_comprobante,serie,correlativo,igv,estado)
		values(@idtrabajador,@idproveedor,@fecha,@tipo_comprobante,@serie,@correlativo,@igv,@estado)
			--obtener el codigo autogenerado
		SET @idingreso=@@IDENTITY
		go

		--procedimiento para anular ingresos

		ALTER proc spanular_ingreso
		@idingreso int
		as
		update ingreso set estado='ANULADO'
		WHERE idingreso=@idingreso
		go
		---------------------------

		--procedimiento para insertar los detalles de ingresos

		create proc spinsertar_detalle_ingrese
		@iddetalle_ingreso int output,
		@idingreso int,
		@idarticulo int,
		@precio_compra money,
		@precio_venta money,
		@stock_inicial int,
		@stock_actual int,
		@fecha_produccion date,
		@fecha_vencimiento date
		as
		insert into detalle_ingreso(idingreso,idarticulo,precio_compra,precio_venta,stock_inicial,stock_actual,fecha_produccion,fecha_vencimiento)
		values(@idingreso,@idarticulo,@precio_compra,@precio_venta,@stock_inicial,@stock_actual,@fecha_produccion,@fecha_vencimiento)
		go
		----------------
		--procedimiento mostrar detalle de ingreso

		create proc spmostrar_detalle_ingreso
		@textobuscar int 
		as
		select d.idarticulo,a.nombre as Articulo, d.precio_compra,
		d.precio_venta,d.stock_inicial,d.fecha_produccion,d.fecha_vencimiento,
		(d.stock_inicial*d.precio_compra) as Subtotal
		from detalle_ingreso d inner join articulo a
		on d.idarticulo=a.idarticulo
		where d.idingreso=@textobuscar
		go
		-------------------------------------------------------------------
		--Gestion de Ventas

	CREATE proc spmostrar_ventas
	as
	select top 100 
	v.idventa,
	(t.nombre+' '+t.apellidos) as Trabajador,
	(c.nombre+' '+c.apellidos) as Cliente,
	v.fecha,v.tipo_comprobante,
	v.serie,
	v.correlativo,
	--sum((d.cantidad * d.precio_venta) - d.descuento) as Total,
	'C$' + CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(sum((d.cantidad * d.precio_venta) - d.descuento)  AS MONEY), 1)) as Total
	from detalle_venta  d inner join venta  v
	on d.idventa = v.idventa 
	inner join cliente  c 
	on  v.idcliente = c.idcliente 
	inner join  trabajador  t
	on v.idtrabajador = t.idtrabajador
	group by v.idventa,
	(t.nombre+' '+t.apellidos) ,
	(c.nombre+' '+c.apellidos) ,
	 v.fecha,
	 v.tipo_comprobante,
	 v.serie,v.correlativo
	 order by  v.idventa desc
	  go

	 -------------------
	 -----mostrar fecha por fechas 

	 create proc spbuscar_venta_fecha
	 @tectobuscar varchar(50),
	 @tectobuscar2 varchar(50)
	 as
	 select 
	v.idventa,
	(t.nombre+' '+t.apellidos) as Trabajador,
	(c.nombre+' '+c.apellidos) as Cliente,
	v.fecha,v.tipo_comprobante,
	v.serie,
	v.correlativo,
	sum((d.cantidad * d.precio_venta) - d.descuento) as Total
	from detalle_venta  d inner join venta  v
	on d.idventa = v.idventa 
	inner join cliente  c 
	on  v.idcliente = c.idcliente 
	inner join  trabajador  t
	on v.idtrabajador = t.idtrabajador
	group by v.idventa,
	(t.nombre+' '+t.apellidos) ,
	(c.nombre+' '+c.apellidos) ,
	 v.fecha,
	 v.tipo_comprobante,
	 v.serie,v.correlativo
	 having v.fecha >= @tectobuscar and 
	 v.fecha <=@tectobuscar2
	 go


	-----------------------
	--insertar ventas

	create proc spinsert_venta
	@idventa int =null output,
	@idcliente int,
	@idtrabajador int,
	@fecha date,
	@tipo_comprobante varchar(20),
	@serie varchar(7),
	@correlativo varchar(7),
	@igv decimal(4,2)
	as
	insert into venta(idcliente,idtrabajador,fecha,tipo_comprobante,serie,correlativo,igv)
	values (@idcliente,@idtrabajador,@fecha,@tipo_comprobante,@serie,@correlativo,@igv)
	set @idventa=@@IDENTITY
	go


	---Eliminar ventas
	create proc speliminar_venta
	@idventa int
	as
	delete from venta
	where idventa=@idventa
	go

	--isnertar detalle de venta

	create proc spinsertar_venta_detalle
	@iddetalle_venta int  output,
	@idventa int,
	@iddetalle_ingreso int,
	@cantidad int,
	@precio_venta money,
	@descuento money
	as
	insert into detalle_venta(idventa,iddetalle_ingreso,cantidad,precio_venta,descuento)
	values (@idventa,@iddetalle_ingreso,@cantidad,@precio_venta,@descuento)
	go

	------
	--trigguer para restablecer el stock despues de eliminar la venta y sus detalles

	create trigger trrestablecer_stock
	on [detalle_venta]--disparar cuando se vea afectada la tabla detalle_venta
	for delete
	as
	update di set di.stock_actual=di.stock_actual-dv.cantidad
	from detalle_ingreso di inner join deleted as dv
	on di.iddetalle_ingreso=dv.iddetalle_ingreso
	go

	---disminuir el stock despues de una venta
	create proc spdisminuir_stock
	@iddetalle_ingreso int,
	@cantidad int
	as
	update detalle_ingreso set stock_actual=stock_actual-@cantidad
	where iddetalle_ingreso=@iddetalle_ingreso
	go

	--mostrar los detalles de una venta
	create proc spmostrar_detalle_venta
	@textobuscar int 
	as
	select d.iddetalle_ingreso,a.nombre as Articulo,
	d.cantidad,d.precio_venta,d.descuento,
	((d.precio_venta* d.cantidad)-d.descuento) as subtotal
	from detalle_venta d inner join detalle_ingreso di
	on d.iddetalle_ingreso=di.iddetalle_ingreso
	inner join articulo a
	on di.idarticulo=a.idarticulo
	where d.idventa = @textobuscar
	go


	---mostrar los articulos para la venta

	create proc spbuscararticulo_venta_nombre
	@textobuscar varchar(50)
	as
	select d.iddetalle_ingreso,a.codigo,a.nombre ,
	c.nombre as Categoria,p.nombre as Presentacion,
	d.stock_actual,d.precio_compra,d.precio_venta,
	d.fecha_vencimiento
	from articulo a inner join categoria c
	on a.idcategoria=c.idcategoria
	inner join presentacion p
	on a.idpresentacion = p.idpresentacion
	inner join  detalle_ingreso d
	on a.idarticulo=d.idarticulo
	inner join ingreso i
	on d.idingreso=i.idingreso
	where  a.nombre like @textobuscar + '%'
	and d.stock_actual > 0
	and i.estado <> 'ANULADO'
	go
	

	------
	create proc spbuscararticulo_venta_codigo
	@textobuscar varchar(50)
	as
	select d.iddetalle_ingreso,a.codigo,a.nombre ,
	c.nombre as Categoria,p.nombre as Presentacion,
	d.stock_actual,d.precio_compra,d.precio_venta,
	d.fecha_vencimiento
	from articulo a inner join categoria c
	on a.idcategoria=c.idcategoria
	inner join presentacion p
	on a.idpresentacion = p.idpresentacion
	inner join  detalle_ingreso d
	on a.idarticulo=d.idarticulo
	inner join ingreso i
	on d.idingreso=i.idingreso
	where  a.nombre = @textobuscar
	and d.stock_actual > 0
	and i.estado <> 'ANULADO'
	go
	

	SELECT * FROM detalle_ingreso

	SELECT * FROM ingreso

	-------------------
	--REPORTES
	
	CREATE PROC reporte_factura
	@idventa int
	as
	select 
	v.idventa,
	(t.apellidos+' '+t.nombre) as Trabajador,
	(c.apellidos+' '+c.nombre) as Cliente,
	c.direccion,
	c.telefono,
	v.fecha,
	v.tipo_comprobante,
	v.serie,
	v.correlativo,
	v.igv,
	a.nombre,
	dv.precio_venta,
	dv.cantidad,
	dv.descuento,
	(dv.cantidad * dv.precio_venta - dv.descuento) as Total_Parcial
    from detalle_venta dv inner join detalle_ingreso di
	on dv.iddetalle_ingreso = di.iddetalle_ingreso
	inner join articulo a 
	on a.idarticulo = di.idarticulo
	inner join venta v
	on v.idventa = dv.idventa
	inner join cliente c
	on c.idcliente=v.idcliente
	inner join trabajador t
	on t.idtrabajador= v.idtrabajador
	where v.idventa in(6,8)
	go

	
	 select * from venta




	 select top 100 
	v.idventa,
	(t.nombre+' '+t.apellidos) as Trabajador,
	(c.nombre+' '+c.apellidos) as Cliente,
	v.fecha,v.tipo_comprobante,
	v.serie,
	v.correlativo,
	--sum((d.cantidad * d.precio_venta) - d.descuento) as Total,
	'C$' + CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(sum((d.cantidad * d.precio_venta) - d.descuento)  AS MONEY), 1)) as Total
	from detalle_venta  d inner join venta  v
	on d.idventa = v.idventa 
	inner join cliente  c 
	on  v.idcliente = c.idcliente 
	inner join  trabajador  t
	on v.idtrabajador = t.idtrabajador
	group by v.idventa,
	(t.nombre+' '+t.apellidos) ,
	(c.nombre+' '+c.apellidos) ,
	 v.fecha,
	 v.tipo_comprobante,
	 v.serie,v.correlativo
	 order by  v.idventa desc


	 ---------------------------------------------------------
	 CREATE PROC spstock_articulo
	 as
	 	 SELECT  dbo.articulo.codigo,
	         dbo.articulo.nombre, 
			 sum( dbo.detalle_ingreso.stock_inicial) as  Cantidad_Ingreso,
			 sum( dbo.detalle_ingreso.stock_actual)  as Cantidad_Stock, 
			 dbo.categoria.nombre AS Categoria,
			 (sum( dbo.detalle_ingreso.stock_inicial) -  sum( dbo.detalle_ingreso.stock_actual)) as Cantidad_VEnta
      FROM    dbo.articulo INNER JOIN
              dbo.categoria ON dbo.articulo.idcategoria = dbo.categoria.idcategoria INNER JOIN
              dbo.detalle_ingreso ON dbo.articulo.idarticulo = dbo.detalle_ingreso.idarticulo INNER JOIN
              dbo.ingreso ON dbo.detalle_ingreso.idingreso = dbo.ingreso.idingreso
			  where ingreso.correlativo <>  'ANULADO'
			  GROUP BY dbo.articulo.codigo,
	                   dbo.articulo.nombre,
					   dbo.categoria.nombre
			  
		------------------------------------------------
		--migrar la bd






















