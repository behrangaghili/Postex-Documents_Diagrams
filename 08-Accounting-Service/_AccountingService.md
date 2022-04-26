# Accounting service
تمامی اتفاقات مالی شامل تعریف قراردادهای مختلف مبتنی بر آنچه اکنون کار می شود، پرداختی های آنلاین و غیر آنلاین، تسهیم وجود در کیف پول، گیفت کارتها، پروموشن های تشویقی، تخفیفات در این سرویس انجام خواهد شد. لیزینگ نیز در این بخش تعریف خواهد شد



## Affiliate service

   همکری در فروش سیستمی است که به شما این اجزه را می دهد که بتوانید از ثبت سفارش دوستان و آشنایانتان درصدی دریافت کنید
   این سیستم به صورتی کار می کند که شما لینکی که در قسمت امتیاز همکاری وجود دارد را در اختیار سایر افزاد قرار دهید و درصدی را به عنوان معرفی این عزیزان به سیستم پستکس دریافت کنید

   ![Affiliate Service](imgs/AfiliatLink.png)
[دیاگرام های همکاری در فروش](Diagrams/BA1-Affiliatelink.drawio)
![دیاگرام همکاری در فروش](imgs/BA1-Affiliatelink.png)

### متد هاو دیتابیس بخش همکاری در فروش

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

## Discount Service

   تخفیفات بخشی مهمی از سیستم پستکس هستند که شما با استفاده از آن می توانید به صوت تجمیعی و تکی برو روی سفارشات خود تخفیف در یافت کنید
   ![تخفیفات](imgs/Discount.PNG)
   [دیاگرام بخش تخفیفات](Diagrams/BD1-Discount.drawio)
   ![دیاگرام تخفیفات](imgs/BD1-Discount.png)

### متد ها و دیتابیس بخش تخفیفات

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

## Cashout
## Wallet
## Refound
## Financial promotion
## Gifts
