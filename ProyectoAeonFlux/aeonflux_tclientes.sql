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
-- Table structure for table `tclientes`
--

DROP TABLE IF EXISTS `tclientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tclientes` (
  `clirif` varchar(15) NOT NULL,
  `clinom` varchar(40) DEFAULT NULL,
  `clidir` varchar(60) DEFAULT NULL,
  `clitlf` varchar(15) DEFAULT NULL,
  `cliestatus` char(1) DEFAULT NULL,
  PRIMARY KEY (`clirif`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tclientes`
--

LOCK TABLES `tclientes` WRITE;
/*!40000 ALTER TABLE `tclientes` DISABLE KEYS */;
INSERT INTO `tclientes` VALUES ('J1234','Zona Franca CA','Av 5 de Pueblo Nuevo','04145203021','A'),('J2345','Libreria Antonio CA','Carrera 15 entre calles 56 y 55','02515304890','A'),('J8912','Libreria Marith CA','Carrera 13 esquina calle 48','02514456498','A'),('V27198','Ernesto Perez','Av Rotaria con carrera 19','04142697550','A');
/*!40000 ALTER TABLE `tclientes` ENABLE KEYS */;
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
