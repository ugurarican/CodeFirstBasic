# CodeFirstBasic  
## Code First Yaklaşımı ile Veri Tabanı Oluşturma  
#### İstenilenler  
Entity Framework Core kullanarak Code First yaklaşımıyla bir veri tabanı oluşturmanız gerekiyor. Bu veri tabanında, aşağıdaki iki bağımsız veri tablosu bulunmalıdır:  

Movie Tablosu:  

Id: int, birincil anahtar ve otomatik artan.  

Title: string, filmin başlığı.  

Genre: string, filmin türü (örneğin: "Action", "Comedy", "Drama").  

ReleaseYear: int, filmin çıkış yılı.  

Game Tablosu:  

Id: int, birincil anahtar ve otomatik artan.  

Name: string, oyunun adı.  

Platform: string, oyunun oynandığı platform (örneğin: "PC", "PlayStation", "Xbox").  

Rating: decimal, oyunun puanı (0 ile 10 arasında).  

Context sınıfımızın ismi PatikaFirstDbContext olsun.  
Veritabanı ismi PatikaCodeFirstDb1 olsun.  
Veritabanında tablolar Movies ve Games olsun.  

Kodumuzu yazdıktan sonra Package Manage Console ekranında add-migration ile ilk migrationımızı açıyoruz ve ardından update-database ile gönderiyoruz.  
![Migration](https://github.com/ugurarican/CodeFirstBasic/blob/master/migration.png)  

MsSQL'e giderek kontrol ediyoruz ve BİNGO. Başarıyla oluşturduk. :)  
![Db](https://github.com/ugurarican/CodeFirstBasic/blob/master/db.png)
