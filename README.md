🛎️ NotificationSystem - Console App  

**NotificationSystem** هو تطبيق Console مبني بـ **C# (.NET 8.0)** يستخدم **Events و Delegates** لإرسال إشعارات عبر البريد الإلكتروني باستخدام **SMTP**.  

 الميزات  
✅ استخدام **Events و Delegates**  
✅ إرسال إشعارات البريد الإلكتروني باستخدام **MailKit**  
✅ تسجيل الأخطاء والتشغيل باستخدام **Serilog**  
✅ تحميل الإعدادات من **Appsettings.json**  

---  

  كيف يعمل؟  
#1️⃣عند تسجيل مستخدم جديد**  
هيتبعتله ميل ترحيبى ع الميل اللى سجل بيه باستخدام الايفنت والديلجيت  

 2️⃣ **إرسال البريد الإلكتروني عبر SMTP**  
- التطبيق يقرأ إعدادات البريد من `Appsettings.json`  
- يستخدم **MailKit** لإرسال الإيميلات  

 3️⃣ تسجيل الأحداث والأخطاء باستخدام Serilog  
- يتم حفظ الـ logs في **logs/log.txt**  
 

  

** التثبيت والتشغيل  
1. استنساخ المشروع 

                                                                                                                                      git clone https://github.com/YourGitHubUsername/NotificationSystem.git  

