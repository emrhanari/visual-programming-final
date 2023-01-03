-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 03 Oca 2023, 14:47:38
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `kutuphaneotomasyonu`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kayitlar`
--

DROP TABLE IF EXISTS `kayitlar`;
CREATE TABLE IF NOT EXISTS `kayitlar` (
  `kayit_id` int(200) NOT NULL AUTO_INCREMENT,
  `kullanici_id` int(100) NOT NULL,
  `kitap_id` int(100) NOT NULL,
  `alis_tarih` datetime(6) NOT NULL,
  `son_tarih` datetime(6) NOT NULL,
  `durum` bit(1) NOT NULL,
  `ceza` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`kayit_id`),
  KEY `kullanici_id` (`kullanici_id`),
  KEY `kullanici_id_2` (`kullanici_id`),
  KEY `kayit_id` (`kayit_id`,`kitap_id`),
  KEY `kitap_id` (`kitap_id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `kayitlar`
--

INSERT INTO `kayitlar` (`kayit_id`, `kullanici_id`, `kitap_id`, `alis_tarih`, `son_tarih`, `durum`, `ceza`) VALUES
(3, 7, 7, '2023-01-02 19:04:48.533039', '2023-01-17 19:04:48.533039', b'1', ''),
(4, 7, 9, '2023-01-02 19:05:22.816460', '2023-01-17 19:05:22.816460', b'1', ''),
(5, 7, 1, '2023-01-02 19:05:54.657619', '2023-01-17 19:05:54.657619', b'1', ''),
(6, 7, 1, '2023-01-02 19:05:56.306838', '2023-01-17 19:05:56.306838', b'1', ''),
(7, 7, 1, '2023-01-02 19:05:57.088249', '2023-01-17 19:05:57.088249', b'1', ''),
(8, 7, 1, '2023-01-02 19:05:57.777434', '2023-01-17 19:05:57.777434', b'1', ''),
(9, 7, 1, '2023-01-02 19:05:58.433791', '2023-01-17 19:05:58.433791', b'1', ''),
(10, 7, 1, '2023-01-02 19:05:58.570052', '2023-01-17 19:05:58.570052', b'1', ''),
(11, 7, 1, '2023-01-02 19:05:58.745802', '2023-01-17 19:05:58.745802', b'1', ''),
(12, 7, 1, '2023-01-02 19:05:58.895449', '2023-01-17 19:05:58.895449', b'1', ''),
(13, 7, 1, '2023-01-02 19:05:59.050638', '2023-01-17 19:05:59.050638', b'1', ''),
(14, 7, 1, '2023-01-02 19:05:59.195362', '2023-01-17 19:05:59.195362', b'1', ''),
(15, 7, 1, '2023-01-02 19:05:59.325567', '2023-01-17 19:05:59.325567', b'1', ''),
(16, 7, 1, '2023-01-02 19:05:59.468736', '2023-01-17 19:05:59.468736', b'1', ''),
(17, 7, 7, '2023-01-02 20:29:45.561956', '2023-01-17 20:29:45.561956', b'1', ''),
(18, 7, 1, '2023-01-03 02:36:31.940177', '2023-01-18 02:36:31.940177', b'1', ''),
(19, 7, 7, '2023-01-03 17:05:28.581701', '2023-01-18 17:05:28.581701', b'0', ''),
(20, 7, 9, '2023-01-03 17:05:40.508714', '2023-01-18 17:05:40.508714', b'0', '20'),
(21, 7, 13, '2023-01-03 17:05:42.368644', '2023-01-18 17:05:42.368644', b'0', ''),
(22, 7, 13, '2023-01-07 17:10:10.000000', '2023-01-23 17:10:10.000000', b'0', '200'),
(23, 7, 13, '2023-01-03 17:30:50.033077', '2023-01-18 17:30:50.033077', b'1', '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kaynaklar`
--

DROP TABLE IF EXISTS `kaynaklar`;
CREATE TABLE IF NOT EXISTS `kaynaklar` (
  `kaynak_id` int(100) NOT NULL AUTO_INCREMENT,
  `kaynak_ad` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `kaynak_yazar` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `kaynak_yayinci` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `kaynak_sayfasayisi` int(255) NOT NULL,
  `kaynak_basimtarihi` datetime(6) NOT NULL,
  PRIMARY KEY (`kaynak_id`),
  KEY `kaynak_id` (`kaynak_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `kaynaklar`
--

INSERT INTO `kaynaklar` (`kaynak_id`, `kaynak_ad`, `kaynak_yazar`, `kaynak_yayinci`, `kaynak_sayfasayisi`, `kaynak_basimtarihi`) VALUES
(1, 'sadsad', 'emirhan ari', 'bfdgd', 22, '2022-12-22 20:10:37.000000'),
(7, 'ha', 'sadsadsadas', 'u', 54, '2022-12-16 20:44:15.000000'),
(9, 'fgfgg', 'hhf', 'edsw', 100, '2023-01-02 18:27:11.819690'),
(13, 'asdsad', 'sadsadasd', 'sadsada', 400, '2023-01-03 15:28:51.836101');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

DROP TABLE IF EXISTS `kullanicilar`;
CREATE TABLE IF NOT EXISTS `kullanicilar` (
  `kullanici_id` int(11) NOT NULL AUTO_INCREMENT,
  `kullanici_ad` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `kullanici_soyad` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `kullanici_tc` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `kullanici_mail` varchar(35) COLLATE utf8_turkish_ci NOT NULL,
  `kullanici_tel` char(100) COLLATE utf8_turkish_ci NOT NULL,
  `kullanici_ceza` float NOT NULL,
  `kullanici_cinsiyet` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`kullanici_id`),
  KEY `kullanici_id` (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`kullanici_id`, `kullanici_ad`, `kullanici_soyad`, `kullanici_tc`, `kullanici_mail`, `kullanici_tel`, `kullanici_ceza`, `kullanici_cinsiyet`) VALUES
(7, 'emirhan', 'ari', '222', 'emirhan@gmail.com', '05342450866', 0, 'E'),
(14, 'alihan', 'dalgiç', '3256987425', 'alihan@gmail.com', '3264780655', 0, 'E');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

DROP TABLE IF EXISTS `personel`;
CREATE TABLE IF NOT EXISTS `personel` (
  `personel_id` int(11) NOT NULL AUTO_INCREMENT,
  `personel_ad` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `personel_soyad` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `personel_tc` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `personel_tel` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `personel_mail` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `personel_kullaniciAd` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `personel_sifre` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`personel_id`),
  KEY `personel_id` (`personel_id`),
  KEY `personel_id_2` (`personel_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`personel_id`, `personel_ad`, `personel_soyad`, `personel_tc`, `personel_tel`, `personel_mail`, `personel_kullaniciAd`, `personel_sifre`) VALUES
(1, 'muharrem', 'tekin', '12345678901', '05554443322', 'test@test.com', 'muharrem.tekin', '1234');

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `kayitlar`
--
ALTER TABLE `kayitlar`
  ADD CONSTRAINT `kayitlar_ibfk_1` FOREIGN KEY (`kullanici_id`) REFERENCES `kullanicilar` (`kullanici_id`),
  ADD CONSTRAINT `kayitlar_ibfk_2` FOREIGN KEY (`kitap_id`) REFERENCES `kaynaklar` (`kaynak_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
