# تعریف سرویس ها (Product servise)  

- ProductService
- PricingService
- AffiliateService
- DiscountService

---

## Product Service

 این سرویس وظیفه ساخت سرویس های پستی را بر عهده دارد ، هر سرویسی که ثبت می شود یک سری آیتم می توان برای سرویس مورد نظر انتخاب کرد که این آیتم ها به شرح زیر می باشند

- شرکت ملی پست هست یا سرویس خصوصی
- درون شهری فعالیت می کند یا برون شهری
- پست خارجی انجام می دهد یا خیر
- هزینه جمع آوری دارد
- هزینه توزیع دارد
- فعال یا غیر فعال بودن
- پست پیشتاز هست یا نه
- ای پی آی دارد یا خیر

### متد های , انتیتی های موجود در بخش تعریف سرویس ها

[متد های قابل تعریف](Diagrams/ProductServiceMethod.drawio)

- CeateProductionService:
  این متد به منظور ساخت سرویس ها مورد استفاده می گیرد . ورودی را از دیتابیس می گیرد و سرویس ها را ایجاد می کند
- EditProductService :
  متدی جهت ویرایش سرویس های عریف شده

[دیتابیس تعریف سرویس](Diagrams/ProductServiceDatabase.drawio)
![دیتابیس تعریف سرویس](imgs/ProductServiceDatabase.png)

## Pricing Service

سیستم قیمت دهی سرویس ها که با استفاده از ارتباط با وندور ها و شرکت های پستی با استفاده از منطقه جغرافیایی و طول مسافت . همچنین وزن مرسوله قیمت با نمایش می دهد .

[متد های بخش قیمت سرویس ها](Diagrams/PricingServiceMethod.drawio)

- GetEigibleService :
   دریافت لیست سرویس ها با توجه به ورودی های کاربر
- GetPriceFrom"ServiceName"
  استعلام قیمت سرویس دهنده های پستی  
- PriceMainPulation
  این متد وظیفه اصلاح قیمت های خام که از سمت سرویس دهنده های پستی می شود را برعهده دارد و قیمت نهایی را به کاربر نشان می دهد

[دیتابیس بخش قیمت سرویس ها](Diagrams/PriceServiseDatabase.drawio)
![دیتابیس قیمت سرویس ها](imgs/PriceServiseDatabase.png)

# Affiliate service

   همکری در فروش سیستمی است که به شما این اجزه را می دهد که بتوانید از ثبت سفارش دوستان و آشنایانتان درصدی دریافت کنید
   این سیستم به صورتی کار می کند که شما لینکی که در قسمت امتیاز همکاری وجود دارد را در اختیار سایر افزاد قرار دهید و درصدی را به عنوان معرفی این عزیزان به سیستم پستکس دریافت کنید

   ![Affiliate Service](imgs/AfiliatLink.png)
[دیاگرام های همکاری در فروش](Diagrams/BA1-Affiliatelink.drawio)
![دیاگرام همکاری در فروش](imgs/BA1-Affiliatelink.png)

## متد هاو دیتابیس بخش همکاری در فروش

[متدهای بخش همکاری در فروش](Diagrams/AffileatServiseMethod.drawio)

- CreatAffilate :
  ساخت لینک همکاری در فروش
- GetAffilateList
  نمایش لیست افیلیت ها
- EditAffilate
  ویرایش کد همکاری در فروش
- AssaignAffilateToCustomer
  اختصاص کد همکاری در فروش به کاربر
- GetAffilateById
  دریافت کد همکاری در فروش به وسیله شناسه
- GetAffilateByUserName
  دریافت کد همکاری در فروش
- DeleteAffilate
  حذف کد همکاری در فروش
- GetOrderUnderAffilate
  دریافت سفارش با کد همکاری در فروش  

[دیتابیس بخش همکاری در فروش](Diagrams/AffiatServiceDatabase.drawio)
![همکاری در فروش](imgs/AffiatServiceDatabase.png)

# Discount Service

   تخفیفات بخشی مهمی از سیستم پستکس هستند که شما با استفاده از آن می توانید به صوت تجمیعی و تکی برو روی سفارشات خود تخفیف در یافت کنید
   ![تخفیفات](imgs/Discount.PNG)
   [دیاگرام بخش تخفیفات](Diagrams/BD1-Discount.drawio)
   ![دیاگرام تخفیفات](imgs/BD1-Discount.png)

## متد ها و دیتابیس بخش تخفیفات

[متدهای بخش تخفیفات](Diagrams/DiscountServiceMethod.drawio)

- CreateDiscount
  ساخت کد تخفیف
- CanApplyDiscountToOrder
  اضافه کردن کد تخفیف به سفارشات
- EditDiscount
  ویرایش کد تخفیف
- GetDiscountById
 دریافت کد با شناسه
- GetAllDiscounts
 نمایش تمامی کد های تخفیف
- UpdateDiscount
 بروزرسانی کد تخفیف
- GetDiscountUsageHistoryById
 نمایش تاریخچه تخفیفات با شناسه
- GetAllDiscountUsageHistory
 نمایش تاریخچه تخفیفات استفاده شده
- InsertDiscountUsageHistory
 قرار دادن تاریخچه نخفیفات برای کاربران
- DeleteDiscountUsageHistory
 حذف کد تخفیف
- SetdiscountLimitation
ایجاد محدودیت در تخفیفات
[دیتابیس بخش تخفیفات](Diagrams/DiscountServiceDatabase.drawio)
![دیتابیس بخش تخفیفات](imgs/DiscountServiceDatabase.png)
