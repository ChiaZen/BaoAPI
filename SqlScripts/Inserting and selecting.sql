--INSERT INTO BaoFilling (Id,[Name]) VALUES (0,'Custard')
--INSERT INTO BaoFilling (Id,[Name]) VALUES (1,'Chicken')
--INSERT INTO BaoFilling (Id,[Name]) VALUES (2,'Charsiu')
--INSERT INTO BaoFilling (Id,[Name]) VALUES (3,'SpicyTofu')
--INSERT INTO BaoFilling (Id,[Name]) VALUES (4,'RedBean')
--INSERT INTO BaoFilling (Id,[Name]) VALUES (5,'EggChives')

--SELECT * FROM BaoFilling WHERE Id = 1 or [Name] = 'SpicyTofu'
--SELECT * FROM BaoFilling WHERE [Name] like '%C%'

--INSERT INTO Bao (Id,BaoFillingId,Name,IsGlutenFree,IsVegan) VALUES (0,0,'LavaBao',0,1)
--INSERT INTO Bao (Id,BaoFillingId,Name,IsGlutenFree,IsVegan) VALUES (1,1,'Chicken Bao',1,0)
INSERT INTO Bao(Id,BaoFillingId,Name,IsGlutenFree,IsVegan) VALUES (2,2,'Charsiu Bao',1,0)


SELECT * FROM Bao 
SELECT * FROM BaoFilling
