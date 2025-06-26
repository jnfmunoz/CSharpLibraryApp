-- Script compatible con MariaDB / HeidiSQL

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- Crear base de datos si no existe
CREATE DATABASE IF NOT EXISTS `library` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `library`;

-- Tabla PAIS
DROP TABLE IF EXISTS `PAIS`;
CREATE TABLE `PAIS` (
  `idPAIS` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `codigo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idPAIS`),
  UNIQUE KEY `idtable1_UNIQUE` (`idPAIS`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`)
) ENGINE=InnoDB;

-- Tabla EDITORIAL
DROP TABLE IF EXISTS `EDITORIAL`;
CREATE TABLE `EDITORIAL` (
  `idEDITORIAL` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `PAIS_idPAIS` INT NOT NULL,
  PRIMARY KEY (`idEDITORIAL`),
  UNIQUE KEY `idEDITORIAL_UNIQUE` (`idEDITORIAL`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`),
  KEY `fk_EDITORIAL_PAIS1_idx` (`PAIS_idPAIS`),
  CONSTRAINT `fk_EDITORIAL_PAIS1` FOREIGN KEY (`PAIS_idPAIS`) REFERENCES `PAIS` (`idPAIS`)
    ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB;

-- Tabla GENERO
DROP TABLE IF EXISTS `GENERO`;
CREATE TABLE `GENERO` (
  `idGENERO` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idGENERO`),
  UNIQUE KEY `idGENERO_UNIQUE` (`idGENERO`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`)
) ENGINE=InnoDB;

-- Tabla LIBRO
DROP TABLE IF EXISTS `LIBRO`;
CREATE TABLE `LIBRO` (
  `idLIBRO` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(45) NOT NULL,
  `isbn` VARCHAR(45) NOT NULL,
  `anio_publicacion` INT DEFAULT 0,
  `sinopsis` VARCHAR(45),
  `EDITORIAL_idEDITORIAL` INT NOT NULL,
  `GENERO_idGENERO` INT NOT NULL,
  PRIMARY KEY (`idLIBRO`),
  UNIQUE KEY `idLIBRO_UNIQUE` (`idLIBRO`),
  KEY `fk_LIBRO_EDITORIAL_idx` (`EDITORIAL_idEDITORIAL`),
  KEY `fk_LIBRO_GENERO1_idx` (`GENERO_idGENERO`),
  CONSTRAINT `fk_LIBRO_EDITORIAL` FOREIGN KEY (`EDITORIAL_idEDITORIAL`) REFERENCES `EDITORIAL` (`idEDITORIAL`)
    ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_LIBRO_GENERO1` FOREIGN KEY (`GENERO_idGENERO`) REFERENCES `GENERO` (`idGENERO`)
    ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB;

-- Tabla AUTOR
DROP TABLE IF EXISTS `AUTOR`;
CREATE TABLE `AUTOR` (
  `idAUTOR` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NOT NULL,
  `fecha_nacimiento` DATE,
  `PAIS_idPAIS` INT NOT NULL,
  PRIMARY KEY (`idAUTOR`),
  UNIQUE KEY `idAUTOR_UNIQUE` (`idAUTOR`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`),
  KEY `fk_AUTOR_PAIS1_idx` (`PAIS_idPAIS`),
  CONSTRAINT `fk_AUTOR_PAIS1` FOREIGN KEY (`PAIS_idPAIS`) REFERENCES `PAIS` (`idPAIS`)
    ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB;

-- Tabla LIBROAUTOR (relación N:M)
DROP TABLE IF EXISTS `LIBROAUTOR`;
CREATE TABLE `LIBROAUTOR` (
  `AUTOR_idAUTOR` INT NOT NULL,
  `LIBRO_idLIBRO` INT NOT NULL,
  KEY `fk_LIBROAUTOR_AUTOR1_idx` (`AUTOR_idAUTOR`),
  KEY `fk_LIBROAUTOR_LIBRO1_idx` (`LIBRO_idLIBRO`),
  CONSTRAINT `fk_LIBROAUTOR_AUTOR1` FOREIGN KEY (`AUTOR_idAUTOR`) REFERENCES `AUTOR` (`idAUTOR`)
    ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_LIBROAUTOR_LIBRO1` FOREIGN KEY (`LIBRO_idLIBRO`) REFERENCES `LIBRO` (`idLIBRO`)
    ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB;

-- Restaurar configuración anterior
SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
library

INSERT INTO `PAIS` (`nombre`, `codigo`) VALUES 
('Afganistán', 'AF'),
('Albania', 'AL'),
('Alemania', 'DE'),
('Andorra', 'AD'),
('Angola', 'AO'),
('Antigua y Barbuda', 'AG'),
('Arabia Saudita', 'SA'),
('Argelia', 'DZ'),
('Argentina', 'AR'),
('Armenia', 'AM'),
('Australia', 'AU'),
('Austria', 'AT'),
('Azerbaiyán', 'AZ'),
('Bahamas', 'BS'),
('Bangladés', 'BD'),
('Barbados', 'BB'),
('Baréin', 'BH'),
('Bélgica', 'BE'),
('Belice', 'BZ'),
('Benín', 'BJ'),
('Bielorrusia', 'BY'),
('Birmania', 'MM'),
('Bolivia', 'BO'),
('Bosnia y Herzegovina', 'BA'),
('Botsuana', 'BW'),
('Brasil', 'BR'),
('Brunéi', 'BN'),
('Bulgaria', 'BG'),
('Burkina Faso', 'BF'),
('Burundi', 'BI'),
('Bután', 'BT'),
('Cabo Verde', 'CV'),
('Camboya', 'KH'),
('Camerún', 'CM'),
('Canadá', 'CA'),
('Catar', 'QA'),
('Chad', 'TD'),
('Chile', 'CL'),
('China', 'CN'),
('Chipre', 'CY'),
('Colombia', 'CO'),
('Comoras', 'KM'),
('Corea del Norte', 'KP'),
('Corea del Sur', 'KR'),
('Costa de Marfil', 'CI'),
('Costa Rica', 'CR'),
('Croacia', 'HR'),
('Cuba', 'CU'),
('Dinamarca', 'DK'),
('Dominica', 'DM'),
('Ecuador', 'EC'),
('Egipto', 'EG'),
('El Salvador', 'SV'),
('Emiratos Árabes Unidos', 'AE'),
('Eritrea', 'ER'),
('Eslovaquia', 'SK'),
('Eslovenia', 'SI'),
('España', 'ES'),
('Estados Unidos', 'US'),
('Estonia', 'EE'),
('Etiopía', 'ET'),
('Filipinas', 'PH'),
('Finlandia', 'FI'),
('Francia', 'FR'),
('Gabón', 'GA'),
('Gambia', 'GM'),
('Georgia', 'GE'),
('Ghana', 'GH'),
('Granada', 'GD'),
('Grecia', 'GR'),
('Guatemala', 'GT'),
('Guinea', 'GN'),
('Guinea-Bisáu', 'GW'),
('Guinea Ecuatorial', 'GQ'),
('Guyana', 'GY'),
('Haití', 'HT'),
('Honduras', 'HN'),
('Hungría', 'HU'),
('India', 'IN'),
('Indonesia', 'ID'),
('Irak', 'IQ'),
('Irán', 'IR'),
('Irlanda', 'IE'),
('Islandia', 'IS'),
('Israel', 'IL'),
('Italia', 'IT'),
('Jamaica', 'JM'),
('Japón', 'JP'),
('Jordania', 'JO'),
('Kazajistán', 'KZ'),
('Kenia', 'KE'),
('Kirguistán', 'KG'),
('Kiribati', 'KI'),
('Kuwait', 'KW'),
('Laos', 'LA'),
('Lesoto', 'LS'),
('Letonia', 'LV'),
('Líbano', 'LB'),
('Liberia', 'LR'),
('Libia', 'LY'),
('Liechtenstein', 'LI'),
('Lituania', 'LT'),
('Luxemburgo', 'LU'),
('Madagascar', 'MG'),
('Malasia', 'MY'),
('Malaui', 'MW'),
('Maldivas', 'MV'),
('Malí', 'ML'),
('Malta', 'MT'),
('Marruecos', 'MA'),
('Mauricio', 'MU'),
('Mauritania', 'MR'),
('México', 'MX'),
('Micronesia', 'FM'),
('Moldavia', 'MD'),
('Mónaco', 'MC'),
('Mongolia', 'MN'),
('Montenegro', 'ME'),
('Mozambique', 'MZ'),
('Namibia', 'NA'),
('Nauru', 'NR'),
('Nepal', 'NP'),
('Nicaragua', 'NI'),
('Níger', 'NE'),
('Nigeria', 'NG'),
('Noruega', 'NO'),
('Nueva Zelanda', 'NZ'),
('Omán', 'OM'),
('Países Bajos', 'NL'),
('Pakistán', 'PK'),
('Palaos', 'PW'),
('Panamá', 'PA'),
('Papúa Nueva Guinea', 'PG'),
('Paraguay', 'PY'),
('Perú', 'PE'),
('Polonia', 'PL'),
('Portugal', 'PT'),
('Reino Unido', 'GB'),
('República Centroafricana', 'CF'),
('República Checa', 'CZ'),
('República del Congo', 'CG'),
('República Democrática del Congo', 'CD'),
('República Dominicana', 'DO'),
('Ruanda', 'RW'),
('Rumanía', 'RO'),
('Rusia', 'RU'),
('Samoa', 'WS'),
('San Cristóbal y Nieves', 'KN'),
('San Marino', 'SM'),
('San Vicente y las Granadinas', 'VC'),
('Santa Lucía', 'LC'),
('Santo Tomé y Príncipe', 'ST'),
('Senegal', 'SN'),
('Serbia', 'RS'),
('Seychelles', 'SC'),
('Sierra Leona', 'SL'),
('Singapur', 'SG'),
('Siria', 'SY'),
('Somalia', 'SO'),
('Sri Lanka', 'LK'),
('Suazilandia', 'SZ'),
('Sudáfrica', 'ZA'),
('Sudán', 'SD'),
('Sudán del Sur', 'SS'),
('Suecia', 'SE'),
('Suiza', 'CH'),
('Surinam', 'SR'),
('Tailandia', 'TH'),
('Tanzania', 'TZ'),
('Tayikistán', 'TJ'),
('Timor Oriental', 'TL'),
('Togo', 'TG'),
('Tonga', 'TO'),
('Trinidad y Tobago', 'TT'),
('Túnez', 'TN'),
('Turkmenistán', 'TM'),
('Turquía', 'TR'),
('Tuvalu', 'TV'),
('Ucrania', 'UA'),
('Uganda', 'UG'),
('Uruguay', 'UY'),
('Uzbekistán', 'UZ'),
('Vanuatu', 'VU'),
('Vaticano', 'VA'),
('Venezuela', 'VE'),
('Vietnam', 'VN'),
('Yemen', 'YE'),
('Yibuti', 'DJ'),
('Zambia', 'ZM'),
('Zimbabue', 'ZW');

INSERT INTO GENERO (nombre) VALUES
('Ficción'),
('Clásicos'),
('Novela Psicológica'),
('Filosófico'),
('Existencialismo'),
('Novela'),
('Drama'),
('Romance'),
('Ciencia Ficción'),
('Misterio'),
('Terror'),
('Historia'),
('Aventura'),
('Biografía'),
('Poesía'),
('Ensayo');
