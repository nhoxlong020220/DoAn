use LoginDB
create table LoginAccount(
ID int identity(1,1) primary key,
UserName varchar(20),
PassWord varchar(20)

)

create table GameCharacter(
NameCharacter varchar(20) primary key,
MaxPoint int ,
Episode int ,
AchievementOnl varchar(50),
ID int not null,
FOREIGN KEY(ID) REFERENCES dbo.LoginAccount(ID)
)
drop table GameCharacter
drop table LoginAccount
drop table EpisodeData
create table EpisodeData(
NameCharacter varchar(20),
Location varchar (10),
NameMap varchar(50),
PointinGame int,
FOREIGN KEY(NameCharacter) REFERENCES dbo.GameCharacter(NameCharacter)
)
