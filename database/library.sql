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
  PRIMARY KEY (`idPAIS`)
) ENGINE=InnoDB;

-- Tabla EDITORIAL
DROP TABLE IF EXISTS `EDITORIAL`;
CREATE TABLE `EDITORIAL` (
  `idEDITORIAL` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `PAIS_idPAIS` INT NOT NULL,
  PRIMARY KEY (`idEDITORIAL`),
  KEY `fk_EDITORIAL_PAIS1_idx` (`PAIS_idPAIS`),
  CONSTRAINT `fk_EDITORIAL_PAIS1` FOREIGN KEY (`PAIS_idPAIS`) REFERENCES `PAIS` (`idPAIS`)
    ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB;

-- Tabla GENERO
DROP TABLE IF EXISTS `GENERO`;
CREATE TABLE `GENERO` (
  `idGENERO` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idGENERO`)
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

INSERT INTO EDITORIAL (nombre, PAIS_idPAIS) VALUES
('Editorial Losada', (SELECT idPAIS FROM PAIS WHERE nombre = 'Argentina')),
('Editorial Sudamericana', (SELECT idPAIS FROM PAIS WHERE nombre = 'Argentina')),
('Zig-Zag', (SELECT idPAIS FROM PAIS WHERE nombre = 'Chile')),
('Planeta Chile', (SELECT idPAIS FROM PAIS WHERE nombre = 'Chile'));

INSERT INTO AUTOR (nombre, fecha_nacimiento, PAIS_idPAIS) VALUES
('Fiódor Dostoievski', '1821-11-11', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Lev Tolstói', '1828-09-09', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Antón Chéjov', '1860-01-29', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Iván Turguénev', '1818-10-28', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Nikolái Gógol', '1809-03-31', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Aleksandr Pushkin', '1799-06-06', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Mijaíl Bulgákov', '1891-05-15', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Máximo Gorki', '1868-03-28', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Anna Ajmátova', '1889-06-23', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia')),
('Vladímir Nabókov', '1899-04-22', (SELECT idPAIS FROM PAIS WHERE nombre = 'Rusia'));

INSERT INTO LIBRO (titulo, isbn, anio_publicacion, sinopsis, EDITORIAL_idEDITORIAL, GENERO_idGENERO)
VALUES
('Crimen y castigo', '9780140449136', 1866, 'Raskólnikov asesina y reflexiona sobre la culpa.', 1, 1),
('Los hermanos Karamázov', '9780140449242', 1880, 'Drama familiar y filosófico.', 1, 4),
('El jugador', '9780140449211', 1867, 'Adicción al juego y obsesiones amorosas.', 2, 1),
('Anna Karénina', '9780140449174', 1877, 'Historia de amor y tragedia.', 1, 7),
('Guerra y paz', '9780140447934', 1869, 'Épica novela histórica rusa.', 3, 12),
('El jardín de los cerezos', '9780140449082', 1904, 'Declive de una familia aristocrática.', 2, 6),
('Tío Vania', '9780140449532', 1897, 'Crítica a la vida rural rusa.', 2, 6),
('Padres e hijos', '9780140449471', 1862, 'Conflicto generacional y nihilismo.', 1, 3),
('Almas muertas', '9780140448078', 1842, 'Sátira de la burocracia rusa.', 3, 1),
('El capote', '9780140449853', 1842, 'Tragedia de un funcionario.', 4, 1),
('Eugene Onegin', '9780140448030', 1833, 'Versión novelada de amor y destino.', 4, 15),
('El Maestro y Margarita', '9780140455465', 1967, 'Sátira al sistema soviético con elementos fantásticos.', 1, 9),
('La madre', '9780140446692', 1906, 'Activismo político y revolución.', 2, 1),
('Réquiem', '9780141185453', 1935, 'Poesía sobre el dolor del estalinismo.', 3, 15),
('Lolita', '9780141182537', 1955, 'Controvertida historia de obsesión.', 4, 1),
('Memorias del subsuelo', '9780140447637', 1864, 'Monólogo interior y existencialismo.', 1, 5),
('La dama del perrito', '9780141182919', 1899, 'Encuentro amoroso inesperado.', 2, 8),
('La muerte de Iván Ilich', '9780140449617', 1886, 'Reflexión sobre la muerte.', 1, 4),
('La nariz', '9780140449242', 1836, 'Cuento surrealista.', 4, 10),
('Relatos de Kolymá', '9780141195438', 1978, 'Historias del gulag soviético.', 3, 1);

-- Dostoievski
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Fiódor Dostoievski' AND l.titulo IN ('Crimen y castigo', 'Los hermanos Karamázov', 'El jugador', 'Memorias del subsuelo');

-- Tolstói
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Lev Tolstói' AND l.titulo IN ('Anna Karénina', 'Guerra y paz', 'La muerte de Iván Ilich');

-- Chéjov
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Antón Chéjov' AND l.titulo IN ('El jardín de los cerezos', 'Tío Vania', 'La dama del perrito');

-- Turguénev
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Iván Turguénev' AND l.titulo IN ('Padres e hijos');

-- Gógol
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Nikolái Gógol' AND l.titulo IN ('Almas muertas', 'El capote', 'La nariz');

-- Pushkin
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Aleksandr Pushkin' AND l.titulo IN ('Eugene Onegin');

-- Bulgákov
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Mijaíl Bulgákov' AND l.titulo IN ('El Maestro y Margarita');

-- Gorki
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Máximo Gorki' AND l.titulo IN ('La madre');

-- Ajmátova
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Anna Ajmátova' AND l.titulo IN ('Réquiem');

-- Nabókov
INSERT INTO LIBROAUTOR (AUTOR_idAUTOR, LIBRO_idLIBRO)
SELECT a.idAUTOR, l.idLIBRO FROM AUTOR a, LIBRO l
WHERE a.nombre = 'Vladímir Nabókov' AND l.titulo IN ('Lolita');

