-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jan 11, 2021 at 11:57 AM
-- Server version: 5.7.17-log
-- PHP Version: 7.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `questionnaire`
--

-- --------------------------------------------------------

--
-- Table structure for table `answers`
--

CREATE TABLE `answers` (
  `id` int(11) NOT NULL,
  `age` tinyint(4) DEFAULT NULL,
  `gender` bit(1) DEFAULT NULL,
  `province` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `marital` bit(1) DEFAULT NULL,
  `job` tinyint(4) DEFAULT NULL,
  `income` tinyint(4) DEFAULT NULL,
  `education` tinyint(4) DEFAULT NULL,
  `infection` bit(1) DEFAULT NULL,
  `disease` tinyint(4) DEFAULT NULL,
  `diagnosis` tinyint(4) DEFAULT NULL,
  `duration` tinyint(4) DEFAULT NULL,
  `headach1` tinyint(4) DEFAULT NULL,
  `headach2` tinyint(4) DEFAULT NULL,
  `cough1` tinyint(4) DEFAULT NULL,
  `cough2` tinyint(4) DEFAULT NULL,
  `weakness1` tinyint(4) DEFAULT NULL,
  `weakness2` tinyint(4) DEFAULT NULL,
  `anosmia1` tinyint(4) DEFAULT NULL,
  `anosmia2` tinyint(4) DEFAULT NULL,
  `prosmia1` tinyint(4) DEFAULT NULL,
  `prosmia2` tinyint(4) DEFAULT NULL,
  `taste1` tinyint(4) DEFAULT NULL,
  `taste2` tinyint(4) DEFAULT NULL,
  `insomnia1` tinyint(4) DEFAULT NULL,
  `insomnia2` tinyint(4) DEFAULT NULL,
  `urination1` tinyint(4) DEFAULT NULL,
  `urination2` tinyint(4) DEFAULT NULL,
  `hypertension` bit(1) DEFAULT NULL,
  `diabetes` bit(1) DEFAULT NULL,
  `overweight` bit(1) DEFAULT NULL,
  `cardiovascular` bit(1) DEFAULT NULL,
  `respiratorylung` bit(1) DEFAULT NULL,
  `kidney` bit(1) DEFAULT NULL,
  `cancer` bit(1) DEFAULT NULL,
  `ms` bit(1) DEFAULT NULL,
  `irib` bit(1) DEFAULT NULL,
  `satellite` bit(1) DEFAULT NULL,
  `instagram` bit(1) DEFAULT NULL,
  `telegram` bit(1) DEFAULT NULL,
  `twitter` bit(1) DEFAULT NULL,
  `whatsapp` bit(1) DEFAULT NULL,
  `friends` bit(1) DEFAULT NULL,
  `website` bit(1) DEFAULT NULL,
  `newspaper` bit(1) DEFAULT NULL,
  `ambi1` tinyint(4) DEFAULT NULL,
  `ambi2` tinyint(4) DEFAULT NULL,
  `ambi3` tinyint(4) DEFAULT NULL,
  `ambi4` tinyint(4) DEFAULT NULL,
  `ambi5` tinyint(4) DEFAULT NULL,
  `ambi6` tinyint(4) DEFAULT NULL,
  `ambi7` tinyint(4) DEFAULT NULL,
  `ambi8` tinyint(4) DEFAULT NULL,
  `ambi9` tinyint(4) DEFAULT NULL,
  `ambi10` tinyint(4) DEFAULT NULL,
  `ambi11` tinyint(4) DEFAULT NULL,
  `ambi12` tinyint(4) DEFAULT NULL,
  `ambi13` tinyint(4) DEFAULT NULL,
  `ambi14` tinyint(4) DEFAULT NULL,
  `ambi15` tinyint(4) DEFAULT NULL,
  `ambi16` tinyint(4) DEFAULT NULL,
  `ambi17` tinyint(4) DEFAULT NULL,
  `ambi18` tinyint(4) DEFAULT NULL,
  `ambi19` tinyint(4) DEFAULT NULL,
  `ambi20` tinyint(4) DEFAULT NULL,
  `ambi21` tinyint(4) DEFAULT NULL,
  `ambi22` tinyint(4) DEFAULT NULL,
  `ambi23` tinyint(4) DEFAULT NULL,
  `ambi24` tinyint(4) DEFAULT NULL,
  `ambi25` tinyint(4) DEFAULT NULL,
  `ambi26` tinyint(4) DEFAULT NULL,
  `ambi27` tinyint(4) DEFAULT NULL,
  `dark1` tinyint(4) DEFAULT NULL,
  `dark2` tinyint(4) DEFAULT NULL,
  `dark3` tinyint(4) DEFAULT NULL,
  `dark4` tinyint(4) DEFAULT NULL,
  `dark5` tinyint(4) DEFAULT NULL,
  `dark6` tinyint(4) DEFAULT NULL,
  `dark7` tinyint(4) DEFAULT NULL,
  `dark8` tinyint(4) DEFAULT NULL,
  `dark9` tinyint(4) DEFAULT NULL,
  `dark10` tinyint(4) DEFAULT NULL,
  `dark11` tinyint(4) DEFAULT NULL,
  `dark12` tinyint(4) DEFAULT NULL,
  `covid1` tinyint(4) DEFAULT NULL,
  `covid2` tinyint(4) DEFAULT NULL,
  `covid3` tinyint(4) DEFAULT NULL,
  `covid4` tinyint(4) DEFAULT NULL,
  `covid5` tinyint(4) DEFAULT NULL,
  `covid6` tinyint(4) DEFAULT NULL,
  `covid7` tinyint(4) DEFAULT NULL,
  `covid8` tinyint(4) DEFAULT NULL,
  `covid9` tinyint(4) DEFAULT NULL,
  `covid10` tinyint(4) DEFAULT NULL,
  `covid11` tinyint(4) DEFAULT NULL,
  `covid12` tinyint(4) DEFAULT NULL,
  `covid13` tinyint(4) DEFAULT NULL,
  `covid14` tinyint(4) DEFAULT NULL,
  `covid15` tinyint(4) DEFAULT NULL,
  `covid16` tinyint(4) DEFAULT NULL,
  `covid17` tinyint(4) DEFAULT NULL,
  `covid18` tinyint(4) DEFAULT NULL,
  `emotion1` tinyint(4) DEFAULT NULL,
  `emotion2` tinyint(4) DEFAULT NULL,
  `emotion3` tinyint(4) DEFAULT NULL,
  `emotion4` tinyint(4) DEFAULT NULL,
  `emotion5` tinyint(4) DEFAULT NULL,
  `emotion6` tinyint(4) DEFAULT NULL,
  `emotion7` tinyint(4) DEFAULT NULL,
  `emotion8` tinyint(4) DEFAULT NULL,
  `emotion9` tinyint(4) DEFAULT NULL,
  `emotion10` tinyint(4) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `answers`
--
ALTER TABLE `answers`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
