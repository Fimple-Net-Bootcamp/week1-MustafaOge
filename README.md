### Ödevin Adı: Kütüphane Yönetim Sistemi

#### Amaç
Bu ödevde, bir kütüphane yönetim sistemini temsil eden bir C# konsol uygulaması geliştireceksiniz. Bu sistem, kitaplar, üyeler ve kitap ödünç verme işlemlerini yönetebilecek.

#### Gereksinimler

1. **Sınıfların Tanımlanması**:
   - `Kitap`: Kitabın adı, yazarı, yayın yılı ve bir benzersiz kitap ID'si içermelidir.
   - `Üye`: Üyenin adı, soyadı, üyelik numarası ve ödünç aldığı kitapların listesi.
   - `Kütüphane`: Kitapları ve üyeleri yönetir. Kitap ekleme, silme, ödünç verme ve iade etme işlevleri içermelidir.

2. **Encapsulation (Kapsülleme)**:
   - Tüm sınıf alanları uygun şekilde gizlenmelidir. Public özellikler (properties) ve metodlar aracılığıyla erişim sağlanmalıdır.

3. **Inheritance (Miras Alma)**:
   -  Ortak özellikleri paylaşan `Yazılı Eser` gibi bir üst sınıf oluşturun ve `Kitap` sınıfının bu sınıftan türetilmesini sağlayın.

4. **Polymorphism (Çok Biçimlilik)**:
   - `Kütüphane` sınıfında, ödünç verme ve iade işlemleri için polimorfik davranışlar tanımlayın. Örneğin, farklı türde ödünç verme politikaları uygulayabilirsiniz (kısa süreli, uzun süreli, vb.).

5. **Arayüzler**:
   - `IYazdırılabilir` gibi bir arayüz oluşturun ve kitapların veya üyelerin bilgilerini konsola yazdırmak için bu arayüzü kullanın.
