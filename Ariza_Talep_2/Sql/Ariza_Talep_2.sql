USE [master]
GO
/****** Object:  Database [Ariza_Talep_2]    Script Date: 10.11.2021 16:21:28 ******/
CREATE DATABASE [Ariza_Talep_2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ariza_Talep_2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ariza_Talep_2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ariza_Talep_2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ariza_Talep_2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ariza_Talep_2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ariza_Talep_2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ariza_Talep_2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ariza_Talep_2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ariza_Talep_2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ariza_Talep_2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ariza_Talep_2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET RECOVERY FULL 
GO
ALTER DATABASE [Ariza_Talep_2] SET  MULTI_USER 
GO
ALTER DATABASE [Ariza_Talep_2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ariza_Talep_2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ariza_Talep_2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ariza_Talep_2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ariza_Talep_2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ariza_Talep_2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ariza_Talep_2', N'ON'
GO
ALTER DATABASE [Ariza_Talep_2] SET QUERY_STORE = OFF
GO
USE [Ariza_Talep_2]
GO
/****** Object:  Table [dbo].[Bildiri_Turleri]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bildiri_Turleri](
	[tur_id] [int] IDENTITY(1,1) NOT NULL,
	[tur_ad] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[bolum_id] [int] IDENTITY(1,1) NOT NULL,
	[bolum_adi] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[kullanici_id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_adi_soyadi] [nvarchar](50) NULL,
	[kullanici_sistem_adi] [nvarchar](50) NULL,
	[kullanici_sistem_sifre] [nvarchar](50) NULL,
	[kullanici_bolum_id] [int] NULL,
	[Yonetici] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajlar]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajlar](
	[mesaj_id] [int] IDENTITY(1,1) NOT NULL,
	[mesaj_icerik] [nvarchar](1000) NULL,
	[mesaj_gonderim_zamani] [datetime] NULL,
	[mesaj_Okundu_Kullanici] [bit] NULL,
	[mesaj_Okundu_Yonetici] [bit] NULL,
	[mesaj_kisi_id] [int] NULL,
	[mesaj_ts_id] [int] NULL,
	[mesaj_cevap_id] [int] NULL,
	[mesaj_Sahibi_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oncelik_Duzeyi]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oncelik_Duzeyi](
	[oncelik_duzey_id] [int] IDENTITY(1,1) NOT NULL,
	[oncelik_duzey_adi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sorunlar]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sorunlar](
	[sorun_id] [int] IDENTITY(1,1) NOT NULL,
	[sorun_konu] [nvarchar](250) NULL,
	[sorun_aciklama] [nvarchar](1000) NULL,
	[sorun_oncelik_duzeyi] [int] NULL,
	[sorun_olusturulma_tarihi] [datetime] NULL,
	[sorun_tamamlanma_durumu] [bit] NULL,
	[kullanici_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaleplerSorunlar]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaleplerSorunlar](
	[ts_id] [int] IDENTITY(1,1) NOT NULL,
	[ts_tur_id] [int] NULL,
	[ts_acıklama] [nvarchar](1000) NULL,
	[ts_oncelik_duzeyi] [int] NULL,
	[ts_olusturulma_Tarihi] [datetime] NULL,
	[ts_Tamamlanma_Durumu] [bit] NULL,
	[kullanici_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Bildiri_Tur_Listele]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bildiri_Tur_Listele]
AS
BEGIN
	SELECT * FROM Bildiri_Turleri
END
GO
/****** Object:  StoredProcedure [dbo].[Bildirim_Tur_Ekle]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bildirim_Tur_Ekle]
(
	@tur_ad nvarchar(50)
)
AS
BEGIN
	INSERT INTO Bildiri_Turleri(tur_ad)
	VALUES(@tur_ad)
END
GO
/****** Object:  StoredProcedure [dbo].[Bildirim_Tur_Sil]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bildirim_Tur_Sil]
(
	@tur_id int
)
AS
BEGIN
	DELETE FROM Bildiri_Turleri WHERE tur_id = @tur_id
END
GO
/****** Object:  StoredProcedure [dbo].[Bolum_Ekle]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bolum_Ekle]
(
	@bolum_adi nvarchar(50)
)
AS
BEGIN
	INSERT INTO Bolumler(bolum_adi)
	VALUES(@bolum_adi)
END
GO
/****** Object:  StoredProcedure [dbo].[Bolum_Sil]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bolum_Sil]
(
	@bolum_id int
)
AS
BEGIN
	DELETE FROM Bolumler WHERE bolum_id = @bolum_id
END
GO
/****** Object:  StoredProcedure [dbo].[Bolumleri_Listele]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Bolumleri_Listele]
AS
BEGIN
	Select * from Bolumler order by bolum_adi ASC
END
GO
/****** Object:  StoredProcedure [dbo].[Kullanici_Giris]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kullanici_Giris]
(
	@kullanici_s_adi nvarchar(50),
	@kullanici_s_sifre nvarchar(50)
)
AS
BEGIN
	Select * from Kullanicilar where kullanici_sistem_adi = @kullanici_s_adi AND kullanici_sistem_sifre = @kullanici_s_sifre
END
GO
/****** Object:  StoredProcedure [dbo].[Kullanici_Guncelle]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kullanici_Guncelle]
(
	@kullanici_id int,
	@kullanici_adi_soyadi nvarchar(50),
	@kullanici_sistem_adi nvarchar(50),
	@kullanici_bolum_id int
)
AS
BEGIN

	UPDATE Kullanicilar
	SET kullanici_adi_soyadi = @kullanici_adi_soyadi, 
		kullanici_sistem_adi = @kullanici_sistem_adi, 
		kullanici_bolum_id = @kullanici_bolum_id
	WHERE kullanici_id = @kullanici_id
END
GO
/****** Object:  StoredProcedure [dbo].[Kullanici_KAYDET]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kullanici_KAYDET]
(
	@kullanici_id int output,
	@kullanici_adi_soyadi nvarchar(50),
	@kullanici_sistem_adi nvarchar(50),
	@kullanici_sistem_sifre nvarchar(50),
	@kullanici_bolum_id nvarchar(100)
)
AS
BEGIN

	INSERT INTO Kullanicilar(kullanici_adi_soyadi, kullanici_sistem_adi, kullanici_sistem_sifre, kullanici_bolum_id)
	VALUES (@kullanici_adi_soyadi, @kullanici_sistem_adi, @kullanici_sistem_sifre, @kullanici_bolum_id)

END
GO
/****** Object:  StoredProcedure [dbo].[Kullanici_Sil]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kullanici_Sil]
(
	@kullanici_id int
)
AS
BEGIN
	DELETE FROM Kullanicilar WHERE kullanici_id = @kullanici_id
END
GO
/****** Object:  StoredProcedure [dbo].[Kullanici_Varmi_Kontrol]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kullanici_Varmi_Kontrol]
(
	@kullanici_ad nvarchar(50)
)
AS
BEGIN
	IF EXISTS(SELECT * FROM Kullanicilar WHERE kullanici_sistem_adi = @kullanici_ad)

	Print 'Aynı kullanıcı adına sahip bir kullanıcı mevcut.'
	
	Declare @table TABLE (var_mi int)

	DECLARE @varmı int 
	SET @varmı = (SELECT COUNT (*) FROM Kullanicilar WHERE kullanici_sistem_adi = @kullanici_ad)

	insert into @table VALUES(@varmı)
	SELECT * FROM @table

	return
END
GO
/****** Object:  StoredProcedure [dbo].[Kullanicilari_Listele]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Kullanicilari_Listele]
AS
BEGIN
	SELECT kullanici_id, kullanici_adi_soyadi, kullanici_sistem_adi, Bolumler.bolum_adi, Yonetici 
	FROM Kullanicilar INNER JOIN Bolumler ON Kullanicilar.kullanici_bolum_id = Bolumler.bolum_id
END
GO
/****** Object:  StoredProcedure [dbo].[Mesaj_Gonder]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mesaj_Gonder]
(
	@mesaj_icerik nvarchar(1000),
	@mesaj_gonderim_zamani datetime,
	@mesaj_kisi_id int,
	@mesaj_ts_id int,
	@mesaj_cevap_id int,
	@mesaj_Sahibi_id int
)
AS
BEGIN
	INSERT INTO Mesajlar(mesaj_icerik, mesaj_gonderim_zamani, mesaj_kisi_id, mesaj_ts_id, mesaj_cevap_id, mesaj_Sahibi_id)
	VALUES(@mesaj_icerik, @mesaj_gonderim_zamani, @mesaj_kisi_id, @mesaj_ts_id, @mesaj_cevap_id, @mesaj_Sahibi_id)
END
GO
/****** Object:  StoredProcedure [dbo].[Mesaj_Kullanici_Oku]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mesaj_Kullanici_Oku]
(
	@mesaj_id int,
	@mesaj_Okundu_Kullanici bit
)
AS
BEGIN
	UPDATE Mesajlar
	SET mesaj_Okundu_Kullanici = @mesaj_Okundu_Kullanici
	WHERE mesaj_id <= @mesaj_id
END
GO
/****** Object:  StoredProcedure [dbo].[Mesaj_Yonetici_Oku]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mesaj_Yonetici_Oku]
(
	@mesaj_id int,
	@mesaj_Okundu_Yonetici bit
)
AS
BEGIN
	UPDATE Mesajlar
	SET mesaj_Okundu_Yonetici = @mesaj_Okundu_Yonetici
	WHERE mesaj_id <= @mesaj_id
END
GO
/****** Object:  StoredProcedure [dbo].[Mesajlar_Kisi_Listesi]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Mesajlar_Kisi_Listesi]
(
	@mesaj_kisi_id int
)
AS
BEGIN
	SELECT mesaj_id, mesaj_icerik, mesaj_gonderim_zamani, mesaj_Okundu_Kullanici, mesaj_Okundu_Yonetici, mesaj_ts_id, mesaj_cevap_id, mesaj_Sahibi_id, Kullanicilar.kullanici_adi_soyadi
	FROM Mesajlar INNER JOIN Kullanicilar ON Kullanicilar.kullanici_id = mesaj_Sahibi_id
	WHERE mesaj_kisi_id = @mesaj_kisi_id
	ORDER BY mesaj_id
END
GO
/****** Object:  StoredProcedure [dbo].[Mesajlar_Yonetici_Kisi_Listesi]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[Mesajlar_Yonetici_Kisi_Listesi]
	(
		@mesaj_kisi_id int
	)
	AS
	BEGIN
		SELECT mesaj_id, mesaj_icerik, mesaj_gonderim_zamani, mesaj_Okundu_Kullanici, mesaj_Okundu_Yonetici, mesaj_ts_id, mesaj_cevap_id, mesaj_Sahibi_id,
		Kullanicilar.kullanici_id, kullanici_adi_soyadi
		FROM Mesajlar
		INNER JOIN Kullanicilar ON mesaj_Sahibi_id= Kullanicilar.kullanici_id
		WHERE mesaj_kisi_id = @mesaj_kisi_id
		ORDER BY mesaj_id
	END
GO
/****** Object:  StoredProcedure [dbo].[Okunmamıs_Olanlar]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Okunmamıs_Olanlar]
AS
BEGIN
	SELECT kullanici_id, kullanici_adi_soyadi, COUNT(*) AS 'sayi' 
	FROM Mesajlar INNER JOIN Kullanicilar ON mesaj_kisi_id = Kullanicilar.kullanici_id 
	WHERE mesaj_Okundu_Yonetici = 0 OR mesaj_Okundu_Yonetici IS NULL
	GROUP BY kullanici_id, kullanici_adi_soyadi
END
GO
/****** Object:  StoredProcedure [dbo].[Okunmamis_Mesaj_Sayisi]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Okunmamis_Mesaj_Sayisi]
(
	@mesaj_kisi_id int
)
AS
BEGIN
	Declare @table TABLE (sayi int)

	DECLARE @say_i int 
	SET @say_i = (SELECT COUNT (*) FROM Mesajlar WHERE mesaj_kisi_id = @mesaj_kisi_id AND (mesaj_Okundu_Kullanici = 0 OR mesaj_Okundu_Kullanici IS NULL))

	insert into @table VALUES(@say_i)
	SELECT * FROM @table

	return
END
GO
/****** Object:  StoredProcedure [dbo].[Okunmamis_Mesaj_Sayisi_Yonetici]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Okunmamis_Mesaj_Sayisi_Yonetici]
AS
BEGIN
	Declare @table TABLE (sayi int)

	DECLARE @say_i int
	SET @say_i = (SELECT COUNT (*) FROM Mesajlar WHERE mesaj_Okundu_Yonetici IS NULL OR mesaj_Okundu_Yonetici = 0)

	insert into @table VALUES(@say_i)
	SELECT * FROM @table

	return
END
GO
/****** Object:  StoredProcedure [dbo].[Oncelik_Duzeyi_Sil]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Oncelik_Duzeyi_Sil]
(
	@oncelik_duzey_id int
)
AS
BEGIN
	DELETE FROM Oncelik_Duzeyi WHERE oncelik_duzey_id = @oncelik_duzey_id
END
GO
/****** Object:  StoredProcedure [dbo].[Oncelik_Ekle]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Oncelik_Ekle]
(
	@oncelik_duzey_adi nvarchar(50)
)
AS
BEGIN
	INSERT INTO Oncelik_Duzeyi(oncelik_duzey_adi)
	VALUES(@oncelik_duzey_adi)
END
GO
/****** Object:  StoredProcedure [dbo].[Oncelikleri_Listele]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Oncelikleri_Listele]
AS
BEGIN
	SELECT * FROM Oncelik_Duzeyi
END
GO
/****** Object:  StoredProcedure [dbo].[TaleplerSorunlar_Kaydet]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TaleplerSorunlar_Kaydet]
(
	@ts_tur_id int,
	@ts_acıklama nvarchar(1000),
	@ts_oncelik_duzeyi int,
	@ts_olusturulma_Tarihi datetime,
	@kullanici_id int
)
AS
BEGIN
	INSERT INTO TaleplerSorunlar(ts_tur_id, ts_acıklama, ts_oncelik_duzeyi, ts_olusturulma_Tarihi, kullanici_id)
	VALUES (@ts_tur_id, @ts_acıklama, @ts_oncelik_duzeyi, @ts_olusturulma_Tarihi, @kullanici_id)
END
GO
/****** Object:  StoredProcedure [dbo].[TaleplerveSorunlar]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TaleplerveSorunlar]
(
	@kullanici_id int
)
AS
BEGIN
	SELECT ts_id, Bildiri_Turleri.tur_ad, ts_acıklama, Oncelik_Duzeyi.oncelik_duzey_adi, ts_olusturulma_Tarihi, ts_Tamamlanma_Durumu
	FROM TaleplerSorunlar 
	INNER JOIN Bildiri_Turleri ON ts_tur_id = Bildiri_Turleri.tur_id
	INNER JOIN Oncelik_Duzeyi ON ts_oncelik_duzeyi = Oncelik_Duzeyi.oncelik_duzey_id
	WHERE kullanici_id = @kullanici_id 
END
GO
/****** Object:  StoredProcedure [dbo].[TaleplerveSorunlar_Sorun]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TaleplerveSorunlar_Sorun]
(
	@kullanici_id int
)
AS
BEGIN
	SELECT ts_id, Bildiri_Turleri.tur_ad, ts_acıklama, Oncelik_Duzeyi.oncelik_duzey_adi, ts_olusturulma_Tarihi, ts_Tamamlanma_Durumu
	FROM TaleplerSorunlar 
	INNER JOIN Bildiri_Turleri ON ts_tur_id = Bildiri_Turleri.tur_id
	INNER JOIN Oncelik_Duzeyi ON ts_oncelik_duzeyi = Oncelik_Duzeyi.oncelik_duzey_id
	WHERE kullanici_id = @kullanici_id AND ts_tur_id = 1
END
GO
/****** Object:  StoredProcedure [dbo].[TaleplerveSorunlar_Talep]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TaleplerveSorunlar_Talep]
(
	@kullanici_id int
)
AS
BEGIN
	SELECT ts_id, Bildiri_Turleri.tur_ad, ts_acıklama, Oncelik_Duzeyi.oncelik_duzey_adi, ts_olusturulma_Tarihi, ts_Tamamlanma_Durumu
	FROM TaleplerSorunlar 
	INNER JOIN Bildiri_Turleri ON ts_tur_id = Bildiri_Turleri.tur_id
	INNER JOIN Oncelik_Duzeyi ON ts_oncelik_duzeyi = Oncelik_Duzeyi.oncelik_duzey_id
	WHERE kullanici_id = @kullanici_id AND ts_tur_id = 2
END
GO
/****** Object:  StoredProcedure [dbo].[TalepSorun_Yonetici_Listele]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TalepSorun_Yonetici_Listele]
AS
BEGIN
	SELECT TaleplerSorunlar.ts_id, Bildiri_Turleri.tur_ad, TaleplerSorunlar.ts_acıklama, Oncelik_Duzeyi.oncelik_duzey_adi, TaleplerSorunlar.ts_olusturulma_Tarihi, TaleplerSorunlar.ts_Tamamlanma_Durumu,
	Kullanicilar.kullanici_id, Kullanicilar.kullanici_adi_soyadi, Bolumler.bolum_adi
	FROM Kullanicilar
	INNER JOIN TaleplerSorunlar ON Kullanicilar.kullanici_id = TaleplerSorunlar.kullanici_id
	INNER JOIN Bolumler ON kullanici_bolum_id = Bolumler.bolum_id
	INNER JOIN Oncelik_Duzeyi ON ts_oncelik_duzeyi = Oncelik_Duzeyi.oncelik_duzey_id
	INNER JOIN Bildiri_Turleri ON ts_tur_id = Bildiri_Turleri.tur_id
END
GO
/****** Object:  StoredProcedure [dbo].[TS_Tamamla]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TS_Tamamla]
(
	@ts_id int,
	@ts_Tamamlanma_Durumu bit
)
AS
BEGIN
	UPDATE TaleplerSorunlar
	SET ts_Tamamlanma_Durumu = @ts_Tamamlanma_Durumu
	WHERE ts_id = @ts_id
END
GO
/****** Object:  StoredProcedure [dbo].[Tum_Mesaj_Atanlar]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Tum_Mesaj_Atanlar]
AS
BEGIN
	SELECT kullanici_id, kullanici_adi_soyadi, COUNT(*) AS 'sayi' 
	FROM Mesajlar INNER JOIN Kullanicilar ON mesaj_kisi_id = Kullanicilar.kullanici_id 
	GROUP BY kullanici_id, kullanici_adi_soyadi
END
GO
/****** Object:  StoredProcedure [dbo].[Yeni_Kullanici_Kaydet]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Yeni_Kullanici_Kaydet]
(
	@kullanici_adi_soyadi nvarchar(50),
	@kullanici_bolum_id int
)
AS
BEGIN
	DECLARE @insertedTable TABLE (ID int)

	INSERT INTO Kullanicilar(kullanici_adi_soyadi, kullanici_bolum_id)
	OUTPUT INSERTED.kullanici_id INTO @insertedTable
	VALUES(@kullanici_adi_soyadi, @kullanici_bolum_id)

	SELECT ID FROM @insertedTable
END
GO
/****** Object:  StoredProcedure [dbo].[Yeni_Kullanici_Kontrol]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Yeni_Kullanici_Kontrol]
(
	@kullanici_ad_soyad nvarchar(50),
	@bolum_id int
)
AS
BEGIN
	IF EXISTS(SELECT * FROM Kullanicilar WHERE TRIM(LOWER(kullanici_adi_soyadi)) = @kullanici_ad_soyad AND kullanici_bolum_id = @bolum_id)

	Print 'Bu kullanici var'
	
	Declare @table TABLE (var_mi int)

	DECLARE @varmı int 
	SET @varmı = (SELECT kullanici_id FROM Kullanicilar WHERE TRIM(LOWER(kullanici_adi_soyadi)) = @kullanici_ad_soyad AND kullanici_bolum_id = @bolum_id)

	insert into @table VALUES(@varmı)
	SELECT * FROM @table

	return
END
GO
/****** Object:  StoredProcedure [dbo].[Yetkilendir]    Script Date: 10.11.2021 16:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Yetkilendir]
(
	@yonetici bit,
	@kullanici_id int
)
AS
BEGIN
	UPDATE Kullanicilar
	SET Yonetici = @yonetici
	WHERE kullanici_id = @kullanici_id
END
GO
USE [master]
GO
ALTER DATABASE [Ariza_Talep_2] SET  READ_WRITE 
GO
