# Katmanlı Mimari Nedir

Katmanlı mimari (Layered Architecture), yazılım sistemlerinin modüler bir şekilde yapılandırılmasını sağlayan bir tasarım desenidir. Yazılımın farklı işlevsel bileşenlerini birbirinden ayırarak, kodun daha anlaşılır, yeniden kullanılabilir, test edilebilir ve bakımının kolay olmasını amaçlar.


Katmanlı mimari (Layered Architecture), yazılım sistemlerinin modüler bir şekilde yapılandırılmasını sağlayan bir tasarım desenidir. Yazılımın farklı işlevsel bileşenlerini birbirinden ayırarak, kodun daha anlaşılır, yeniden kullanılabilir, test edilebilir ve bakımının kolay olmasını amaçlar. İşte katmanlı mimarinin detaylı bir açıklaması:

Temel Kavramlar
Katmanlı mimaride, yazılım genellikle birden fazla katmana (layer) ayrılır. Her bir katman belirli bir sorumluluğa sahiptir ve diğer katmanlarla belirli kurallar çerçevesinde iletişim kurar. Bu katmanlar, işlevsel olarak bağımsızdır ve birbirlerine doğrudan bağımlılıklarını en aza indirir.

Genel Katmanlar
Presentation (Sunum) Katmanı:

Kullanıcı arayüzü ve kullanıcıyla etkileşimin gerçekleştiği katmandır.
Örnek: Windows Forms, Web Arayüzü (HTML, CSS, JavaScript).
Görevi: Kullanıcıdan veri almak ve bu veriyi İş Katmanına iletmek, sonuçları kullanıcıya göstermek.
Örnek: Butonlara tıklama, formları doldurma gibi işlemler burada gerçekleşir.
Business Logic (İş) Katmanı:

İş kurallarının, mantıklarının ve iş süreçlerinin işlendiği katmandır.
Sunum katmanından gelen verileri işler ve sonuçları ilgili katmana iletir.
Örnek: Bir kullanıcı giriş yaptıysa, şifre doğrulama işlemi bu katmanda yapılır.
Görevi: Veri Katmanıyla iletişim kurarak işlemleri yönlendirmek.
Data Access (Veri Erişim) Katmanı:

Veritabanıyla doğrudan iletişim kurar.
CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirir.
Örnek: Kullanıcı bilgilerini SQL sorguları ile çekmek veya güncellemek.
Görevi: Veri manipülasyonu işlemlerini gerçekleştirmek.
Database (Veritabanı) Katmanı:

Verilerin fiziksel olarak depolandığı yerdir.
Örnek: MSSQL, MySQL, PostgreSQL.
Görevi: Verilerin güvenli, optimize ve tutarlı bir şekilde saklanmasını sağlamak.
