CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Código] INT NOT NULL, 
    [Loja] INT NOT NULL, 
    [Nome] NVARCHAR(100) NOT NULL, 
    [FsicaUnid] INT NOT NULL, 
    [Endereço] NVARCHAR(100) NOT NULL, 
    [N° Fantasia] INT NOT NULL, 
    [Bairro] NVARCHAR(100) NOT NULL, 
    [Tipo] INT NOT NULL, 
    [Estado] NVARCHAR(100) NOT NULL, 
    [Cd. Município] NVARCHAR(100) NOT NULL, 
    [CEP] NVARCHAR(9) NOT NULL, 
    [Município] NVARCHAR(100) NOT NULL, 
    [DDD] NCHAR(10) NOT NULL, 
    [Telefone] NVARCHAR(14) NOT NULL, 
    [CNPJ/CPF] NVARCHAR(100) NOT NULL, 
    [País] NVARCHAR(100) NOT NULL, 
    [Dt.Abert/Nasc] DATETIME NOT NULL, 
    [E-mail] NVARCHAR(100) NOT NULL, 
    [Home-Page] NVARCHAR(100) NOT NULL
)
