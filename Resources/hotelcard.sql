-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 03, 2024 at 04:50 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelcard`
--

-- --------------------------------------------------------

--
-- Table structure for table `info`
--

CREATE TABLE `info` (
  `status` varchar(50) NOT NULL,
  `fullName` varchar(50) NOT NULL,
  `inDate` date NOT NULL,
  `outDate` date NOT NULL,
  `burnDate` date NOT NULL,
  `payment` varchar(50) NOT NULL,
  `days` int(50) NOT NULL,
  `animals` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `info`
--

INSERT INTO `info` (`status`, `fullName`, `inDate`, `outDate`, `burnDate`, `payment`, `days`, `animals`) VALUES
('Выписываются', 'Zero two', '2024-04-01', '2024-04-01', '2002-02-02', 'Не оплачено', 1, 'Да'),
('Свободные', 'Наначи', '2024-04-01', '2024-04-04', '2001-02-02', 'Оплачено', 4, 'Да'),
('Заняты', 'Неко тян', '2024-04-02', '2024-04-03', '2003-03-03', 'Оплачено', 2, 'Нет'),
('Зарезервировано', 'Сагири Изуми', '2024-04-01', '2024-04-10', '2000-01-01', 'Не оплачено', 10, 'Нет');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `info`
--
ALTER TABLE `info`
  ADD PRIMARY KEY (`fullName`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
