CREATE DATABASE tarefas;
USE tarefas;

CREATE TABLE tb_diaDaSemana(
    pk_id_diaDaSemana INT PRIMARY KEY AUTO_INCREMENT,
    nomeDoDia VARCHAR(30)
);

INSERT INTO tb_diaDaSemana VALUES (1,'Domingo');
INSERT INTO tb_diaDaSemana VALUES (2,'Segunda-feira');
INSERT INTO tb_diaDaSemana VALUES (3,'Terça-feira');
INSERT INTO tb_diaDaSemana VALUES (4,'Quarta-feira');
INSERT INTO tb_diaDaSemana VALUES (5,'Quinta-feira');
INSERT INTO tb_diaDaSemana VALUES (6,'Sexta-feira');
INSERT INTO tb_diaDaSemana VALUES (7,'Sábado');

SELECT * FROM tb_diaDaSemana;

CREATE TABLE tb_TAREFA(
    id_tarefa INT PRIMARY KEY AUTO_INCREMENT,
    nomeTarefa VARCHAR(30),
    obsTarefa VARCHAR (200),
    horarioTarefa TIME,
	fk_diaDaSemana INT,
    repeteSemanal INT,
    ativaPomodoro INT,
    tarefaConcluida INT,
    notificou INT,
    CONSTRAINT linkDiaSemana FOREIGN KEY (fk_diaDaSemana) REFERENCES tb_diaDaSemana(pk_id_diaDaSemana)
);

INSERT INTO tb_TAREFA (nomeTarefa, obsTarefa, horarioTarefa, fk_diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou)
VALUES ('Estudar inglês', 'Praticar verbos no passado', '11:30', 4, 0, 1, 0, 0);

INSERT INTO tb_TAREFA (nomeTarefa, obsTarefa, horarioTarefa, fk_diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou)
VALUES ('Praticar desenho', '', '09:00', 3, 1, 0, 0, 0);

INSERT INTO tb_TAREFA (nomeTarefa, obsTarefa, horarioTarefa, fk_diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou)
VALUES ('Estudar Modelagem 3D', 'Modelagem orgânica', '15:00', 4, 1, 1, 0, 0);

INSERT INTO tb_TAREFA (nomeTarefa, obsTarefa, horarioTarefa, fk_diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou)
VALUES ('Estudar Modelagem 3D', 'Criação de cenário', '15:00', 2, 1, 1, 0, 0);

INSERT INTO tb_TAREFA (nomeTarefa, obsTarefa, horarioTarefa, fk_diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou)
VALUES ('Game Dev', 'Continuar desenvolvimento do jogo', '14:00', 5, 1, 0, 0, 0);

INSERT INTO tb_TAREFA (nomeTarefa, obsTarefa, horarioTarefa, fk_diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou)
VALUES ('Terminar trabalho', 'Finalizar atividade da faculdade', '12:00', 7, 0, 0, 0, 0);

SELECT * FROM tb_TAREFA;

CREATE TABLE tb_USUARIO(
	id_usuario INT,
	nomeUsuario VARCHAR(30),
    generoUsuario INT,
    ativaNotificacao INT,
    dataUltimaSemana DATE
);

INSERT INTO tb_USUARIO VALUES (1,'', 0, 1, '0001-01-01');

SELECT * FROM tb_USUARIO;