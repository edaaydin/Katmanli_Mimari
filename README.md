# Katmanlı Mimari Nedir

Katmanlı mimari (Layered Architecture), yazılım sistemlerinin modüler bir şekilde yapılandırılmasını sağlayan bir tasarım desenidir. Yazılımın farklı işlevsel bileşenlerini birbirinden ayırarak, kodun daha anlaşılır, yeniden kullanılabilir, test edilebilir ve bakımının kolay olmasını amaçlar.

Temel Kavramlar
<br>
Katmanlı mimaride, yazılım genellikle birden fazla katmana (layer) ayrılır. Her bir katman belirli bir sorumluluğa sahiptir ve diğer katmanlarla belirli kurallar çerçevesinde iletişim kurar. Bu katmanlar, işlevsel olarak bağımsızdır ve birbirlerine doğrudan bağımlılıklarını en aza indirir.

Genel Katmanlar
Presentation (Sunum) Katmanı:

Kullanıcı arayüzü ve kullanıcıyla etkileşimin gerçekleştiği katmandır.
<br>
Örnek: Windows Forms, Web Arayüzü (HTML, CSS, JavaScript).
<br>
Görevi: Kullanıcıdan veri almak ve bu veriyi İş Katmanına iletmek, sonuçları kullanıcıya göstermek.
<br>
Örnek: Butonlara tıklama, formları doldurma gibi işlemler burada gerçekleşir.
<br>
Business Logic (İş) Katmanı:

İş kurallarının, mantıklarının ve iş süreçlerinin işlendiği katmandır.
<br>
Sunum katmanından gelen verileri işler ve sonuçları ilgili katmana iletir.
<br>

Örnek: Bir kullanıcı giriş yaptıysa, şifre doğrulama işlemi bu katmanda yapılır.
<br>
Görevi: Veri Katmanıyla iletişim kurarak işlemleri yönlendirmek.
<br>
Data Access (Veri Erişim) Katmanı:

Veritabanıyla doğrudan iletişim kurar.
<br>
CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirir.
<br>
Örnek: Kullanıcı bilgilerini SQL sorguları ile çekmek veya güncellemek.
<br>
Görevi: Veri manipülasyonu işlemlerini gerçekleştirmek.

Database (Veritabanı) Katmanı:

Verilerin fiziksel olarak depolandığı yerdir.
Örnek: MSSQL, MySQL, PostgreSQL.
Görevi: Verilerin güvenli, optimize ve tutarlı bir şekilde saklanmasını sağlamak.
