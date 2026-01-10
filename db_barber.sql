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
  `id_agendamento` int NOT NULL AUTO_INCREMENT,
  `clienteid` int NOT NULL,
  `servicoid` int NOT NULL,
  `datahora_agendamento` datetime NOT NULL,
  PRIMARY KEY (`id_agendamento`),
  UNIQUE KEY `datahora_agendamento` (`datahora_agendamento`),
  KEY `servicoid` (`servicoid`),
  KEY `clienteid` (`clienteid`),
  CONSTRAINT `clienteid` FOREIGN KEY (`clienteid`) REFERENCES `tb_clientes` (`id`),
  CONSTRAINT `servicoid` FOREIGN KEY (`servicoid`) REFERENCES `tb_servicos` (`servicoid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela db_barber.tb_clientes
DROP TABLE IF EXISTS `tb_clientes`;
CREATE TABLE IF NOT EXISTS `tb_clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `telefone` varchar(30) NOT NULL,
  `email` varchar(60) NOT NULL,
  `ativo` int DEFAULT '1',
  `data_cadastro` datetime DEFAULT (now()),
  PRIMARY KEY (`id`),
  UNIQUE KEY `telefone` (`telefone`),
  UNIQUE KEY `email` (`email`),
  KEY `nome` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela db_barber.tb_servicos
DROP TABLE IF EXISTS `tb_servicos`;
CREATE TABLE IF NOT EXISTS `tb_servicos` (
  `servicoid` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) NOT NULL,
  `preco` decimal(10,5) NOT NULL,
  `status` tinyint NOT NULL,
  PRIMARY KEY (`servicoid`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
