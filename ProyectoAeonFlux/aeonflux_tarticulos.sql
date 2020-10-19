-- MySQL dump 10.13  Distrib 5.7.30, for Linux (i686)
--
-- Host: localhost    Database: aeonflux
-- ------------------------------------------------------
-- Server version	5.7.30-0ubuntu0.16.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tarticulos`
--

DROP TABLE IF EXISTS `tarticulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tarticulos` (
  `artcod` varchar(4) NOT NULL,
  `artcodpto` varchar(2) NOT NULL,
  `artdesc` varchar(40) DEFAULT NULL,
  `artcosto` double(12,2) DEFAULT NULL,
  `artpreciodetal` double(12,2) DEFAULT NULL,
  `artpreciomayor` double(12,2) DEFAULT NULL,
  `artexistdetal` int(4) DEFAULT NULL,
  `artexistmayor` int(4) DEFAULT NULL,
  `artestatus` char(1) DEFAULT NULL,
  PRIMARY KEY (`artcod`),
  KEY `artcodpto` (`artcodpto`),
  CONSTRAINT `tarticulos_ibfk_1` FOREIGN KEY (`artcodpto`) REFERENCES `tdepartamentos` (`dptocod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarticulos`
--

LOCK TABLES `tarticulos` WRITE;
/*!40000 ALTER TABLE `tarticulos` DISABLE KEYS */;
INSERT INTO `tarticulos` VALUES ('1010','10','Lapicero Kilometrico',8900.00,14000.00,12000.00,50,200,'A'),('1015','10','Lapiz Mongol',7000.00,12000.00,10000.00,48,150,'A'),('1021','10','Cuaderno 100 hojas',19000.00,25000.00,21000.00,24,100,'A'),('2011','20','Calculo diferencial de Jorge Saenz',48000.00,60000.00,58000.00,10,6,'A'),('2022','20','Estadistica matematica de Mendehall',48000.00,60000.00,54999.99,10,12,'A'),('3022','30','Rayuela de Julio Cortazar',71000.00,85000.00,0.00,6,0,'A'),('3051','30','Casas muertas de Miguel Otero Silva',50000.00,60000.00,0.00,5,0,'A');
/*!40000 ALTER TABLE `tarticulos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-07  5:46:26
