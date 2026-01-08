-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           9.5.0 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.14.0.7165
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para db_barber
DROP DATABASE IF EXISTS `db_barber`;
CREATE DATABASE IF NOT EXISTS `db_barber` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_barber`;

-- Copiando estrutura para tabela db_barber.tb_agendamento
DROP TABLE IF EXISTS `tb_agendamento`;
CREATE TABLE IF NOT EXISTS `tb_agendamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `clienteId` int NOT NULL,
  `servicoId` int NOT NULL,
  `data` date NOT NULL DEFAULT (curdate()),
  `horaInicio` time NOT NULL DEFAULT (curtime()),
  `horaFim` time NOT NULL DEFAULT (curtime()),
  PRIMARY KEY (`id`),
  KEY `FK_tb_agendamento_tb_clientes` (`clienteId`),
  KEY `FK_tb_agendamento_tb_servicos` (`servicoId`),
  CONSTRAINT `FK_tb_agendamento_tb_clientes` FOREIGN KEY (`clienteId`) REFERENCES `tb_clientes` (`id`),
  CONSTRAINT `FK_tb_agendamento_tb_servicos` FOREIGN KEY (`servicoId`) REFERENCES `tb_servicos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_barber.tb_agendamento: ~0 rows (aproximadamente)
DELETE FROM `tb_agendamento`;

-- Copiando estrutura para tabela db_barber.tb_clientes
DROP TABLE IF EXISTS `tb_clientes`;
CREATE TABLE IF NOT EXISTS `tb_clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL DEFAULT '0',
  `telefone` varchar(20) NOT NULL DEFAULT '0',
  `email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `telefone` (`telefone`),
  KEY `nome` (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_barber.tb_clientes: ~0 rows (aproximadamente)
DELETE FROM `tb_clientes`;

-- Copiando estrutura para tabela db_barber.tb_servicos
DROP TABLE IF EXISTS `tb_servicos`;
CREATE TABLE IF NOT EXISTS `tb_servicos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `preco` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_barber.tb_servicos: ~0 rows (aproximadamente)
DELETE FROM `tb_servicos`;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
