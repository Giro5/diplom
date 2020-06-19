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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-08 13:58:10
