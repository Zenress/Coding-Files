/* 
Query that removes the current table, creates a new identical table
And then adds the data that the original table has. It is essentially a reset sql query
*/
drop table Movies

create table Movies (
	Id int Identity(1,1) Primary Key not null,
	MovieName varchar(500) not null,
	ReleaseYear int not null,
	Genre varchar(50) not null,
	Instructor varchar(50) not null,
	Actors varchar(500) not null
)

INSERT INTO dbo.Movies (MovieName, ReleaseYear, Genre, Instructor, Actors)
values 
('A Silent Voice', 2016, 'Drama', 'Naoko Yamada', 'Saori Hayami, Miyu Irino'),
('Sword Art Online: Ordinal Scale', 2017, 'Action', 'Tomohiko Itou', 'Yoshitsugu Matsuoka, Haruka Tomatsu, Yoshio Inoue, Sayaka Kanda'),
('Code Geass: Lelouch of the Re;Surrection', 2019, 'Action, Drama', 'Gorou Tanihuchi', 'Jun Fukuyama, Yukana, Takahiro Sakurai, Kaori Nazuka, Nobunaga Shimazaki, Ayumu Murase'),
('Kabenari of the Iron Fortress: The Battle of Unato', 2019, 'Horror, Drama', 'Tetsurou Araki', 'Sayaka Senbongi, Tasuku Hatanaka'),
('Rascal Does Not Dream of a Dreaming Girl', 2019, 'Supernatural, Romance', 'Souichi Masui', 'Asami Seto, Kaito Ishikawa, Inori Minase'),
('Goblin Slayer: Goblins Crown', 2020, 'Action, Fantasy', 'Takaharu Ozaki', 'Yuuichirou Umehara, Yui Ogura'),
('Kurokos Basketball: Last Game', 2017, 'Sports, School', 'Shunsuke Tada', 'Kensho Ono, Junichi Suwabe, Hiroshi Kamiya, Ryouhei Kimura, Daisuke Ono, Kenichi Suzumura, Yuuki Ono'),
('Towa No Quon: 1', 2011, 'Action, Supernatural', 'Umanosuke Iida', 'Hiroshi Kamiya'),
('Towa No Quon: 2', 2011, 'Action, Supernatural', 'Hiroaki Matsuura', 'Hiroshi Kamiya'),
('Towa No Quon: 3', 2011, 'Action, Supernatural', 'Hiroaki Matsuura', 'Hiroshi Kamiya, Kousuke Toriumi, Tomoyuki Shimura'),
('Towa No Quon: 4', 2011, 'Action, Supernatural', 'Hiroaki Matsuura', 'Hiroshi Kamiya, Kousuke Toriumi'),
('Towa No Quon: 5', 2011, 'Action, Supernatural', 'Hiroaki Matsuura', 'Hiroshi Kamiya, Kousuke Toriumi'),
('Towa No Quon: 6', 2011, 'Action, Supernatural', 'Hiroaki Matsuura', 'Hiroshi Kamiya, Kousuke Toriumi'),
('The Anthem of the Heart', 2015, 'Drama, Romance', 'Shunsuke Saitou', 'Inori Minase, Sora Amamiya, Kouki Uchimaya, Yoshimasa Hosoya'),
('Expelled from Paradise', 2014, 'Action, Sci-Fi', 'Kouichi Noguchi', 'Rie Kugiyama, Hiroshi Kamiya, Shincihiro Miki');