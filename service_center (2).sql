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

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `client_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `surname` varchar(100) DEFAULT NULL,
  `patronymic` varchar(100) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`client_id`),
  UNIQUE KEY `id_UNIQUE` (`client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=372 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Василий','Укупов','Леонидович','89245622365'),(356,'Никита','Батурин','Артемьевич','89234534469'),(360,'Григорий','Лодкин','Ильич','12345678909'),(361,'Леонид','Богомолов','Артурович','34572352562'),(362,'Дмитрий','Медведев','Владимирович','45645645646'),(363,'Иван','Иванов','Иванович','12347658563'),(364,'Жора','Папов','Алексеевич','22352352345'),(365,'Михаил','Варломов','Петрович','89275673456'),(366,'имя','фамилия','отчество','89275674567'),(368,'Иван','Попов','','81233455678'),(369,'Игорь','Лехин','','85673451234'),(370,'Антон','Щавелев','','89455676776'),(371,'Василий','Корюхов','','89456784567');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `date_check` date DEFAULT NULL,
  `article` int(11) DEFAULT NULL,
  `client_id` int(11) DEFAULT NULL,
  `serial_number` varchar(100) NOT NULL,
  `date_in` date DEFAULT NULL,
  `date_out` date DEFAULT NULL,
  `status_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  UNIQUE KEY `id_UNIQUE` (`order_id`),
  UNIQUE KEY `serial_number_UNIQUE` (`serial_number`),
  KEY `articleFK_idx` (`article`),
  KEY `clientFK_idx` (`client_id`),
  KEY `statusFK_idx` (`status_id`),
  CONSTRAINT `articleFK` FOREIGN KEY (`article`) REFERENCES `catalog` (`article`),
  CONSTRAINT `clientFK` FOREIGN KEY (`client_id`) REFERENCES `clients` (`client_id`),
  CONSTRAINT `statusFK` FOREIGN KEY (`status_id`) REFERENCES `statuses` (`status_id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2020-01-11',1381298,1,'345-st-562','2020-03-02','2020-03-02',6),(9,'2020-05-10',168628,356,'1236UTKA1','2020-05-01',NULL,5),(13,'2020-04-15',168628,360,'456ltgh4','2020-05-01',NULL,3),(14,'2020-01-26',197937,361,'GRYHJ4326','2020-05-01','2020-05-06',6),(15,'2020-01-03',168628,362,'QWRE0943','2020-05-03',NULL,2),(16,'2020-04-08',1227162,363,'33TY457','2020-05-05','2020-05-10',6),(17,'2020-01-06',1092625,364,'PLOTONOV1','2020-05-10','2020-05-20',6),(18,'2020-03-04',330745,365,'345abcd789','2020-05-15',NULL,4),(19,'2020-02-06',1101673,366,'324hy','2020-06-06','2020-06-06',6),(21,'2020-05-13',1147793,368,'346234','2020-06-07',NULL,1),(22,'2020-05-14',1303023,369,'6567tatarin324','2020-06-07',NULL,1),(23,'2020-05-27',1227162,370,'12345678','2020-06-07',NULL,1),(24,'2020-04-15',1211814,371,'45srt346','2020-06-08',NULL,1);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statuses`
--

DROP TABLE IF EXISTS `statuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `statuses` (
  `status_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`status_id`),
  UNIQUE KEY `id_UNIQUE` (`status_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statuses`
--

LOCK TABLES `statuses` WRITE;
/*!40000 ALTER TABLE `statuses` DISABLE KEYS */;
INSERT INTO `statuses` VALUES (1,'Проводится диагностика'),(2,'Диагностика проведена, ремонт невозможен'),(3,'Диагностика проведена, ремонт возможен'),(4,'Диагностика проведена, не гарантийный случай'),(5,'Ремонт проведен успешно'),(6,'Изделие выдано клиенту');
/*!40000 ALTER TABLE `statuses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(25) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `surname` varchar(100) DEFAULT NULL,
  `patronymic` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `id_UNIQUE` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'user_r','Антон','Богов','Михайлович','123','r'),(2,'user_m','Борис','Гагарин','Семенович','123','m'),(3,'admin','Никита','Батурин','Сергеевич','123','a');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'service_center'
--

--
-- Dumping routines for database 'service_center'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-08 13:58:38
