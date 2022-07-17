-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18-Jun-2022 às 18:50
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `showdomilhao`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cadastro`
--

CREATE TABLE `tb_cadastro` (
  `idnomes` int(11) NOT NULL,
  `nome` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_cadastro`
--

INSERT INTO `tb_cadastro` (`idnomes`, `nome`) VALUES
(4, 'Nicolas Pereira '),
(5, 'Hana sousa kim'),
(6, 'Ronnie Rillo'),
(7, 'Ana lucia carloto'),
(8, 'luiz fernando '),
(9, 'Nicholsons ferrador'),
(10, 'carlos carlos '),
(11, 'nicolas'),
(12, 'amogus'),
(13, 'barnabé santana '),
(14, 'Renan das costas '),
(15, 'Jeferson tavares de '),
(16, 'ana lucia carloto'),
(17, 'ana'),
(18, 'n'),
(19, 'Nicolas pereira '),
(20, 'Nicolas pereira'),
(21, 'Nico'),
(22, 'CHINELO'),
(23, 'nicolas'),
(24, 'jeferson'),
(25, 'n'),
(26, 'z'),
(27, 'x'),
(28, 'nikão'),
(29, 'jonatan'),
(30, 'junior'),
(31, 'aaaaaaaaaaaaa'),
(32, 'sergio madagascar'),
(33, 'nikão'),
(34, 'b'),
(35, 'Sideney sheldon'),
(36, 'Alirceu dos santos d'),
(37, 'ana'),
(38, 'ana'),
(39, 'gui'),
(40, 'tiago barnabé'),
(41, 'SUS'),
(42, 'mari'),
(43, 'Nicolas'),
(44, 'joão'),
(45, 'carmem winstead'),
(46, 'SARAH'),
(47, 'pelvis'),
(48, 'ssdsd'),
(49, 'Isaiah'),
(50, ''),
(51, 'thiago'),
(52, 'Renan de braga lima '),
(53, 'aaaaaaaaaaaaaaaa'),
(54, 'ji'),
(55, 'sheldon'),
(56, 'shledon luiz'),
(57, 'nicolas '),
(58, 'Nicolas'),
(59, 'severino'),
(60, 'aaaaa'),
(61, 'Nicolas junior carlo'),
(62, 'Nicolas '),
(63, 'Nicolas'),
(64, 'Nicolas jr'),
(65, 'luan da silva'),
(66, 'Lauryen KC'),
(67, 'TIÃO'),
(68, 'm'),
(69, 'Nicolas'),
(70, 'nicols 2'),
(71, 'gabriel de almeida b');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_cadastro`
--
ALTER TABLE `tb_cadastro`
  ADD PRIMARY KEY (`idnomes`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_cadastro`
--
ALTER TABLE `tb_cadastro`
  MODIFY `idnomes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
