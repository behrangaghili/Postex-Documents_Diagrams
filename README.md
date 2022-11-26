# فهرست مطالب

## مقدمه

پستکس یک پلتفرم است که به شما این امکان را می دهد که وزن ، حجم ، مبدا و مقصد بسته خود را انتخاب کنید و ما در قاب پنچره پستکس به شما بگوییم چه شرکت پستی با چه قیمتی و چه محدوده وزنی و چه محدودیت هایی می تواند در شهر شما ، بین شهر های کشور و یا حتی بین المللی برای شما حمل را انجام دهد خدمات پستکس به صورت پس کرایه ، پیش کرایه و سی او دی عرضه می شود و با چند کلیلک ساده همه این امکانات را می توانید در اختیار داشته باشید و بر اساس نیاز های روزانه سرویس  مورد نظر را انتخاب کنید.

## زیرساخت های سیستم 

### تکنولوژی سیستم [(Infrastructure)](00-InfraStructure/InfraStructure.md)

### فرایند های کلی (GeneralProcess)

- [فرایند کلی ثبت نام](00-InfraStructure/00-General-Process/BeforeOrder.drawio)
- [فرایند کلی ثبت سفارش](00-InfraStructure/00-General-Process/Order.drawio)
- [فرایند کلی بعد از ثبت سفارش](00-InfraStructure/00-General-Process/AfterOrder.drawio)

### استقرار [(Staging)](00-InfraStructure/00-Establishment/Establishment.md)

### تست و تولید [(Test - Production)](00-InfraStructure/00-Test/Test.md)

## ورود و ثبت نام [(Authentication and Roles)](01-Authentication-and-Roles/_AuthenticationAndRole.md)

- گروه ها (Group)
- سطوح دسترسی (Role)
- افراد (User)
- سطوح دسترسی (Permission)

## تعریف سرویس ها [Product service](02-Product-service/_ProductService.md)

### قیمت های آفلاین Gatwaye Price

- تعریف محصول (Define Product)
- تعریف صفات محصولات (Define Product Attr)
- تعریف تخفیفات (Define Discont)
  
### قیمت ها ( Price Service)

- ValidateInputbyContract
- دریافت قیمت (Get Price)
- محاسبه قیمت (Calc Price)
- لاگ های قیمت (Log Price)

### سرویس رهگیری (Tracking Service)

- رهگیری انبوه (Bulk Tracking)
- رهگیری تکی (Single Tracking)

### سفارشات انبوه (Bulk Service)

- سفارشات انبوه (Bulk Service)

## قرارداد مشتری [(contract service )](03-Contract-Service/_ContractService.md)

- تعریف کانترکت (Add Contract)
- اصلاح قرارداد (Edit Cotract)
- فعال کردن قرارداد (Active Contract)
- غیر فعال کردن قرارداد (Disable Contract)
- مشتری قرارداد (CustomerContract)
- قرارداد پیش فرض (General Contract)

## ثبت سفارش [(Parcel-order service )](04-Pracel-Order-Service/_ParacelOrderService.md)

- ساخت سفارش (Creat Parcel)
- تغییر وضعیت سفارش (Parcel change status)
- تنظیمات سفارش (parcel seting)
- محاسبه هزینه سفارش (Calculate Parsel Prise)
- دریافت بارکد (Get Postal barcode)
- امکان ثیت سفارش با اکسل (ExcelService)
- امکان تعریف بسته بندی (Shipment Bundeling)
- مشخص کردن شماره سفارش (Set parcel number)

## مدیریت سفارشات [(Agent service)](05-Agent-Service/_AgentService.md)

- ارجاع بار به نماینده (AssignToAgent)
- ارجاع بار به کوریر (AssignToBycer)
- مدیریت حمل و نقل (ManageShipment)
- مدیریت سفارش اضافه کردن اصلاح کردن و کنسل کردن (Add,Edit,CancelShipment)
- برچسب بر روی محصولات (Labeling)
- بسته بندی (Packaging)

## تیکت [(Ticketing)](06-Ticketing/_Ticketing.md)

- Ticket CRUD
- پیگیری تیکت (Ticket Follow up)

## فرایند های مالی [(Accounting service)](07-Accounting-Service/_AccountingService.md)

- تسویه حساب (Cashout)
- کیف پول (Wallet)
- بازگشت پول به حساب یا کیف پول مشتری(Refound)
- Financial promotion
- Gifts

## گزارشات [(Reporting)](08-Reporting/_Reporting.md)

- نمایش گزارشات (Show Reports)
- سفارشی کردن گزارشات (Customize Reports)
- چاپ گزارشات (Print Reports)
- ساخت صف (Make Queue)
- ساخت خروجی اکسل و پی دی اف ( Create Invoice)
- ساخت گزارشات به صورت افلاین (Create Offline Reports)
- یکی کردذن گزارشات (Merg Reports)

## اعلانات [(Notification Service)](09-Notification-Service/_NotificationService.md)

- اتصال به سرویس پیامک(Connect to SMS Services)
- اتصال به سرویس ایمیل (Connect To Email Services)
- پوش نوتیفیکیشن (Application Push Notification)
- وب سرویس های شبکه های اجتماعی (social media web services)

## پرداخت ها [(payment service)](10-Peyment-Service/_PeymentService.md)

- پرداخت هزینه سفارش (PayForOrder)
- Online Banks  gateways

## لاگ [(Logs)](11-Log/_Log.md)

- لاگ های سگانه ThirdPartyLoging Servic
- لاگ های همیشگی (always)
- لاگ های موردی  (percase)
- لاگ های محیط توسعه(Environment)

## طراحی [(UI)](12-UI/Ui.md)

[لیست سرویس ها](https://docs.google.com/spreadsheets/d/1WJbg2b9-I040qbG7qJXNGT5llJ1ACH19/edit?usp=sharing&ouid=117990549631970722186&rtpof=true&sd=true)

---
