u proje, C# dilinde Dependency Injection (Bağımlılık Enjeksiyonu) kullanarak bir öğretmen ve sınıf modelini içeren bir uygulamadır. Proje, sınıflar arasındaki bağımlılıkları azaltarak daha esnek ve sürdürülebilir bir yapının nasıl oluşturulabileceğini göstermektedir.

Proje Yapısı
Proje, aşağıdaki sınıfları içerir:

IOgretmen (Interface): Öğretmen sınıfının temel arayüzüdür ve öğretmen bilgilerinin alınması için GetInfo() metodunu tanımlar.

Teacher (Concrete Class): Öğretmenin adını ve soyadını içeren sınıftır. IOgretmen arayüzünden türemiştir. GetInfo() metodu ile öğretmenin adını ve soyadını döner.

ClassRoom (Concrete Class): Sınıfın öğretmenini tutar ve yapıcı metodunda (constructor) bir IOgretmen nesnesi alır. Bu sınıf, öğretmen bilgilerini alıp gösterebilmek için GetTeacherInfo() metodunu kullanır.

Amaç
Bu proje, Dependency Injection tekniğinin kullanıldığı bir yapıyı anlamak ve uygulamak için hazırlanmıştır. Constructor Injection ile bir sınıfın bağımlılıkları dışarıdan sağlanır, böylece sınıflar arası bağımlılık minimum seviyede tutulur. Bu da, kodun test edilebilirliğini ve yeniden kullanılabilirliğini artırır.
