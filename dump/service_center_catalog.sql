CREATE DATABASE  IF NOT EXISTS `service_center` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `service_center`;
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: service_center
-- ------------------------------------------------------
-- Server version	8.0.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `catalog`
--

DROP TABLE IF EXISTS `catalog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catalog` (
  `article` int(11) NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `warranty_period` int(11) DEFAULT NULL,
  PRIMARY KEY (`article`),
  UNIQUE KEY `article_UNIQUE` (`article`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalog`
--

LOCK TABLES `catalog` WRITE;
/*!40000 ALTER TABLE `catalog` DISABLE KEYS */;
INSERT INTO `catalog` VALUES (168628,'Кулер DEEPCOOL GAMMAXX S40',12),(197937,'Электрочайник Sinbo SK 7307',12),(330745,'Модуль памяти CORSAIR Vengeance LPX CMK16GX4',999),(1049477,'Фритюрница Steba DF 90',24),(1087004,'Видеокарта PCI-E Gigabyte GeForce GTX 1050 Ti G1 GAMING',36),(1091045,'Память DIMM DDR4 8192MB PC17000 2133MHz Crucial CL 15',96),(1091348,'Твердотельный накопитель SSD M.2 2280 250Gb Samsung 960 EVO',36),(1092625,'Мультиметр CEM DT-912',24),(1101673,'Вентилятор Arctic Cooling F12 Value pack',24),(1108147,'Плата MSI Socket-AM4 B350 PC MATE',36),(1109022,'Процессор AMD Ryzen 5 1600',12),(1147793,'Клавиатура проводная HyperX Alloy Elite',24),(1157041,'Мышь беспроводная Logitech Gaming Mouse G603 Wireless LIGHTSPEED',36),(1211814,'БП Cougar GX-S 750W ',60),(1225509,'Кресло игровое ZET Chaos guard 200K',12),(1227162,'15.6\" Ноутбук ASUS VivoBook (S510UN-BQ275)',12),(1254559,'Наушники беспроводные Logitech G PRO Gaming Retail',36),(1303023,'Маршрутизатор TP-LINK Archer C6',36),(1381298,'Видеокарта PCI-E MSI GeForce RTX 2060 Super VENTUS OC',36);
/*!40000 ALTER TABLE `catalog` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-08 13:58:09
