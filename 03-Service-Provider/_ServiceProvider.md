# Service Provider

---

این سرویس وظیفه اتصال به سیستم های خارجی پستی را فراهم آورده تا کاربر و سیستم مرکزی به راحتی بتوانند سرویس مورد نظر خود را انتخاب نمایند

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
