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
CREATE DATABASE IF NOT EXISTS `db_barber` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_barber`;

-- Copiando estrutura para tabela db_barber.tb_agendamentos
CREATE TABLE IF NOT EXISTS `tb_agendamentos` (
  `id_agendamento` int NOT NULL AUTO_INCREMENT,
  `cliente_id` int NOT NULL,
  `funcionario_id` int NOT NULL,
  `servico_id` int NOT NULL,
  `datahora_inicio` datetime NOT NULL,
  `status` enum('AGENDADO','CONCLUIDO','CANCELADO') NOT NULL DEFAULT 'AGENDADO',
  PRIMARY KEY (`id_agendamento`),
  UNIQUE KEY `uk_funcionario_horario` (`funcionario_id`,`datahora_inicio`),
  KEY `fk_ag_cliente` (`cliente_id`),
  KEY `fk_ag_servico` (`servico_id`),
  KEY `idx_agendamento_data` (`datahora_inicio`),
  CONSTRAINT `fk_ag_cliente` FOREIGN KEY (`cliente_id`) REFERENCES `tb_clientes` (`id_cliente`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_ag_funcionario` FOREIGN KEY (`funcionario_id`) REFERENCES `tb_funcionarios` (`id_funcionario`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_ag_servico` FOREIGN KEY (`servico_id`) REFERENCES `tb_servicos` (`id_servico`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_barber.tb_agendamentos: ~0 rows (aproximadamente)
DELETE FROM `tb_agendamentos`;

-- Copiando estrutura para tabela db_barber.tb_clientes
CREATE TABLE IF NOT EXISTS `tb_clientes` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `telefone` varchar(30) NOT NULL,
  `email` varchar(60) NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT '1',
  `data_cadastro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_cliente`),
  UNIQUE KEY `uk_cliente_telefone` (`telefone`),
  UNIQUE KEY `uk_cliente_email` (`email`),
  KEY `idx_cliente_nome` (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_barber.tb_clientes: ~0 rows (aproximadamente)
DELETE FROM `tb_clientes`;

-- Copiando estrutura para tabela db_barber.tb_funcionarios
CREATE TABLE IF NOT EXISTS `tb_funcionarios` (
  `id_funcionario` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `telefone` varchar(30) NOT NULL,
  `comissao` decimal(5,2) NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_funcionario`),
  UNIQUE KEY `uk_funcionario_telefone` (`telefone`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_barber.tb_funcionarios: ~0 rows (aproximadamente)
DELETE FROM `tb_funcionarios`;

-- Copiando estrutura para tabela db_barber.tb_servicos
CREATE TABLE IF NOT EXISTS `tb_servicos` (
  `id_servico` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `descricao` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  `duracao_minutos` int NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_servico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela db_barber.tb_servicos: ~0 rows (aproximadamente)
DELETE FROM `tb_servicos`;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
