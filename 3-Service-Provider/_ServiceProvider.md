# Service Provider

---
این سرویس وظیفه تعریف سرویس دهنده ها را بر عهده دارد و با دریافت متد ها از سرویس دهنده ها سرویس ها را تعریف میکند

[متد های موجود درسرویس](Diagrams/ServiceProvider.drawio)

- Authentication(Username , password)
  احراز هویت
- RenewToken(Usename,password)
  دریافت توکن جدید
- GetPrice
  دریافت قیمت
- RegisterPrice
  ثبت مرسوله
- CancelParsel
   کنسل کردن مرسوله
- TrackParsel
- پیگیری مرسوله
- EditParsel
- ویرایش مرسوله
