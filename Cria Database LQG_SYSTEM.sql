create table tbCliente
(
idCliente int primary key not null,
cliente varchar(80) not null,
contato varchar(20),
ddd char(3),
telefone varchar(9),
celular varchar(10),
endereco varchar(max),
bairro varchar(100),
cep varchar(9),
cidade varchar(100),
estado varchar(2),
email varchar(100),
datadia varchar(50),
cadastradopor varchar(50),
) 

create table tbServico
(
idServico int primary key not null,
nome varchar(80) not null,
descricao varchar(max),
observacao varchar(max),
valor decimal (10,2),
datadia varchar(50),
cadastradopor varchar(50),
)

create table tbOrdemServico
(
idordem int primary key not null,
idcliente int not null,
idservico int not null,
datadia varchar(50),
cadastradopor varchar(50),


CONSTRAINT FK_tbOrdemServico_tbCliente_idCliente FOREIGN KEY(idCliente) REFERENCES tbCliente(idCliente),
CONSTRAINT FK_tbOrdemServico_tbServico_idServico FOREIGN KEY(idServico) REFERENCES tbServico(idServico),
)

create table tbUsuario
(
idUsuario int primary key not null,
usuario varchar(50) not null,
senha varchar(50) not null,
repitasenha varchar(50) not null,
nivelacesso varchar(50) not null,
datadia varchar(50),
cadastradopor varchar(50),
)