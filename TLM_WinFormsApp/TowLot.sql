-- MySqlBackup.NET 2.3.6.2
-- Dump Time: 2022-09-09 10:47:42
-- --------------------------------------
-- Server version 8.0.28 MySQL Community Server - GPL



CREATE DATABASE IF NOT EXISTS `towlot2` /*!40100 DEFAULT CHARACTER SET latin1 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `towlot2`;



/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of tlm_images
-- 

DROP TABLE IF EXISTS `tlm_images`;
CREATE TABLE IF NOT EXISTS `tlm_images` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `VIN` varchar(17) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `ImageFile` varchar(250) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `img_vin` (`VIN`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tlm_images
-- 

/*!40000 ALTER TABLE `tlm_images` DISABLE KEYS */;

/*!40000 ALTER TABLE `tlm_images` ENABLE KEYS */;

-- 
-- Definition of tlm_lot
-- 

DROP TABLE IF EXISTS `tlm_lot`;
CREATE TABLE IF NOT EXISTS `tlm_lot` (
  `lot_id` int NOT NULL AUTO_INCREMENT,
  `lot` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`lot_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table tlm_lot
-- 

/*!40000 ALTER TABLE `tlm_lot` DISABLE KEYS */;
INSERT INTO `tlm_lot`(`lot_id`,`lot`) VALUES
(1,'Lot 1'),
(2,'Garage'),
(3,'Farm');
/*!40000 ALTER TABLE `tlm_lot` ENABLE KEYS */;

-- 
-- Definition of tlm_owner
-- 

DROP TABLE IF EXISTS `tlm_owner`;
CREATE TABLE IF NOT EXISTS `tlm_owner` (
  `O_id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Last_name` varchar(25) DEFAULT NULL,
  `First_name` varchar(25) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `City` varchar(25) DEFAULT NULL,
  `State` varchar(2) DEFAULT NULL,
  `Zip` varchar(5) DEFAULT NULL,
  `Zip_plus` varchar(4) DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`O_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table tlm_owner
-- 

/*!40000 ALTER TABLE `tlm_owner` DISABLE KEYS */;
INSERT INTO `tlm_owner`(`O_id`,`Last_name`,`First_name`,`Address`,`City`,`State`,`Zip`,`Zip_plus`,`Phone`) VALUES
(3,'GARAGE','BERTS','802 E Central','Carthage','MO','64836','0000','4173589655'),
(4,'NICHOLS','BERT','930 RIDGECREST AVE','CARTHAGE','MO','64836','0000','4173599246'),
(5,'Gilmore','Amber','930 Ridgecrest','Carthage','MO','64836','3217','(417) 359-9246');
/*!40000 ALTER TABLE `tlm_owner` ENABLE KEYS */;

-- 
-- Definition of tlm_rate
-- 

DROP TABLE IF EXISTS `tlm_rate`;
CREATE TABLE IF NOT EXISTS `tlm_rate` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `rate` decimal(5,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tlm_rate
-- 

/*!40000 ALTER TABLE `tlm_rate` DISABLE KEYS */;
INSERT INTO `tlm_rate`(`ID`,`rate`) VALUES
(1,40.00);
/*!40000 ALTER TABLE `tlm_rate` ENABLE KEYS */;

-- 
-- Definition of tlm_reason
-- 

DROP TABLE IF EXISTS `tlm_reason`;
CREATE TABLE IF NOT EXISTS `tlm_reason` (
  `reason_id` int NOT NULL AUTO_INCREMENT,
  `reason` varchar(25) NOT NULL,
  PRIMARY KEY (`reason_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table tlm_reason
-- 

/*!40000 ALTER TABLE `tlm_reason` DISABLE KEYS */;
INSERT INTO `tlm_reason`(`reason_id`,`reason`) VALUES
(1,'Abandoned'),
(2,'Accident'),
(3,'Customer Request'),
(4,'Impound'),
(5,'Police Tow');
/*!40000 ALTER TABLE `tlm_reason` ENABLE KEYS */;

-- 
-- Definition of tlm_transact
-- 

DROP TABLE IF EXISTS `tlm_transact`;
CREATE TABLE IF NOT EXISTS `tlm_transact` (
  `ta_id` bigint NOT NULL AUTO_INCREMENT,
  `VIN` varchar(17) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL,
  `Make` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `Model` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `Year` year DEFAULT NULL,
  `Color` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `OnLot` date DEFAULT NULL,
  `Reason` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `Title` tinyint(1) DEFAULT NULL,
  `Released` date DEFAULT NULL,
  `How_released` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `Last_name` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `First_name` varchar(25) CHARACTER SET latin1 COLLATE latin1_general_cs DEFAULT NULL,
  `AmountDue` decimal(10,2) DEFAULT NULL,
  `AmountPaid` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ta_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Transaction table';

-- 
-- Dumping data for table tlm_transact
-- 

/*!40000 ALTER TABLE `tlm_transact` DISABLE KEYS */;

/*!40000 ALTER TABLE `tlm_transact` ENABLE KEYS */;

-- 
-- Definition of tlm_vehicle
-- 

DROP TABLE IF EXISTS `tlm_vehicle`;
CREATE TABLE IF NOT EXISTS `tlm_vehicle` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `VIN` varchar(17) NOT NULL,
  `Make` varchar(25) DEFAULT NULL,
  `Model` varchar(25) DEFAULT NULL,
  `Year` year DEFAULT NULL,
  `Color` varchar(25) DEFAULT NULL,
  `OnLot` date DEFAULT NULL,
  `lot_id` int DEFAULT NULL,
  `Reason` varchar(25) DEFAULT NULL,
  `Title` tinyint(1) DEFAULT NULL,
  `Released` date DEFAULT NULL,
  `How_released` varchar(25) DEFAULT NULL,
  `Owner_id` bigint DEFAULT NULL,
  `AmountDue` decimal(8,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `vin` (`VIN`) USING BTREE,
  KEY `ownerid` (`Owner_id`),
  KEY `lotid` (`lot_id`)
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8mb3;

DROP PROCEDURE IF EXISTS `spLoadMainForm_Get`;
DELIMITER |
CREATE PROCEDURE `spLoadMainForm_Get`()
BEGIN
SELECT id,VIN, Make, Model, Year, Color, OnLot,
c.lot_id, lot, Reason, Title, Released, How_released,
First_name, Last_name, o.O_id, AmountDue
FROM towlot.tlm_vehicle AS c
LEFT JOIN towlot.tlm_owner AS o ON c.Owner_id = o.O_id
LEFT JOIN towlot.tlm_lot AS l ON c.lot_id = l.lot_id
ORDER BY c.id ASC ;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `spReasonGet_reason`;
DELIMITER |
CREATE PROCEDURE `spReasonGet_reason`( in r varchar(25) )
BEGIN
select * from tlm_reason where reason = r;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `spReason_Get_All`;
DELIMITER |
CREATE PROCEDURE `spReason_Get_All`()
BEGIN
select * from tlm_reason;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `spReason_Insert`;
DELIMITER |
CREATE PROCEDURE `spReason_Insert`(
in pramar1 varchar(25)
)
BEGIN
insert into tlm_reason ( reason )
values ( pramar1 );
END |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2022-09-09 10:47:42
-- Total time: 0:0:0:0:143 (d:h:m:s:ms)
