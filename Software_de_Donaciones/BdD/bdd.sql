-- MySQL dump 10.15  Distrib 10.0.38-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: AlaDerivaSoftware
-- ------------------------------------------------------
-- Server version	10.0.38-MariaDB-0ubuntu0.16.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `AlaDerivaSoftware`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `AlaDerivaSoftware` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `AlaDerivaSoftware`;

--
-- Table structure for table `Beneficiario`
--

DROP TABLE IF EXISTS `Beneficiario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Beneficiario` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `CI` int(8) NOT NULL,
  `Tipo` enum('Donante','Destinatario') NOT NULL,
  `Nombre` varchar(12) NOT NULL,
  `Apellido` varchar(12) NOT NULL,
  `Telefono` int(20) NOT NULL,
  `Email` varchar(12) NOT NULL,
  `Direccion` varchar(12) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `CI` (`CI`),
  UNIQUE KEY `Telefono` (`Telefono`),
  UNIQUE KEY `Email` (`Email`),
  UNIQUE KEY `Direccion` (`Direccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Beneficiario`
--

LOCK TABLES `Beneficiario` WRITE;
/*!40000 ALTER TABLE `Beneficiario` DISABLE KEYS */;
/*!40000 ALTER TABLE `Beneficiario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Deposito`
--

DROP TABLE IF EXISTS `Deposito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Deposito` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Ubicacion` varchar(20) NOT NULL,
  `Nombre` varchar(12) NOT NULL,
  `Telefono` varchar(20) NOT NULL,
  `Seccion` varchar(4) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Ubicacion` (`Ubicacion`),
  UNIQUE KEY `Telefono` (`Telefono`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Deposito`
--

LOCK TABLES `Deposito` WRITE;
/*!40000 ALTER TABLE `Deposito` DISABLE KEYS */;
/*!40000 ALTER TABLE `Deposito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Perfil`
--

DROP TABLE IF EXISTS `Perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Perfil` (
  `NombreUsuario` varchar(30) NOT NULL,
  `CI` int(8) NOT NULL,
  `Email` varchar(12) NOT NULL,
  `Nombre` varchar(12) NOT NULL,
  `Apellido` varchar(12) NOT NULL,
  `Telefono` int(20) NOT NULL,
  PRIMARY KEY (`NombreUsuario`),
  UNIQUE KEY `CI` (`CI`),
  UNIQUE KEY `Email` (`Email`),
  UNIQUE KEY `Telefono` (`Telefono`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Perfil`
--

LOCK TABLES `Perfil` WRITE;
/*!40000 ALTER TABLE `Perfil` DISABLE KEYS */;
/*!40000 ALTER TABLE `Perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Sesion`
--

DROP TABLE IF EXISTS `Sesion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Sesion` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Estado` enum('Abierta','Cerrada') NOT NULL DEFAULT 'Abierta',
  `Fecha_Hora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sesion`
--

LOCK TABLES `Sesion` WRITE;
/*!40000 ALTER TABLE `Sesion` DISABLE KEYS */;
/*!40000 ALTER TABLE `Sesion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario` (
  `NombreUsuario` varchar(30) NOT NULL,
  `Cargo` enum('Cliente','Encargado','Administrador') NOT NULL,
  `Hash` varchar(100) NOT NULL,
  `sal` varchar(100) NOT NULL,
  PRIMARY KEY (`NombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario`
--

LOCK TABLES `Usuario` WRITE;
/*!40000 ALTER TABLE `Usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `Usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-15 21:02:42
