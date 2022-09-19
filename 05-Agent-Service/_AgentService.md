# Agent service

## مقدمه

فرایند اصلی بد از ثبت سفارش با این سریس شروع می شود و عملیاتی از جمله ارجاع بار به نماینده و روتینگ و مدیریت سفارشات برای توزیع و جمع آوری مورد استفاده نماینده و جمع آور در این سرویس انجام می شود.

---

## Feature

- AssignToAgent
- AssignToBycer
- ManageShipment
- Add,Edit,CancelShipment
- Labeling
- Packaging

## موجودیت ها

### user

کلیه اطلاعات کاربران در این جدول نگهداری می شوند

- FullName
  نام و نام خانوادگی
- RequiredSerPassword
  کاربر می بایستی حتما پسوردی برای خود انتخاب کند

### Agent

اطلاعات همه نمایندگان در این جدول نگهداری می شود

- CollectoyCustomerId
 کد جمع آور
- RepresentativeCustomerId
  کد نمایندگی
- CollectorUserName
  نام کاربری
- CollectorFullName
  نام
- RepresentativeUserName
  نام کاربری نمایندگی
- RepresentativeFullName
  نام نماینده
- IsEnable
  فعال یا غیر فعال بودن نماینده
- CityId
  کد شهر
- UserId
  کلید خارجی در جدول user
- DispatchingWarwhouseId
  کلیدخارجی در جدول انبار DispatchingWarehouse

### AgentRequiredOptimization

همه ی نماینده هایی که سفارشات آنها نیاز به بهینه سازی دارد در این جدول نگهداری می شود

- AgentId
  کلید خارجی از جدول Agent
- Complate
  تکمیل شده است

### AgentVehicle

وسایل نقلیه نمایندگان . به طور مثال نمینده اصفهان آقای فلان یک موتور سیکلت داره یک سواری

- Title
  عنوان
- CollectorName
  نام جمع آور
- CollectorPhoneNumber
  تلفن جمع آور
- VehicleMapId
  کلید خارجی از AgentVihivleMap
  ابتدا  وسایل نقلیه در آن جدول ذخیره میشوند سپس کد آن در این جدمل نگهداری می شود
- AgentId
  کلید خارجی از جدول Agent

### State

استان ها 

- Title
  عنوان
- IsEnable
  فعال می باشد یا خیر
- PostexId
  کد استان در پستکس

### StaticToken

توکن های ثابت در این جدول نگهداری میشود . به طور مثال برای ارتباط با پارسی مپ نیاز به توکن هست که این توکن ر این جدول نگهداری می شود

- ProviderName
  نام سرویس
- ExpirationDate
  زمان انقضا
- Token
  توکن

### DispatchingWarehouse

سیستم شامل 2 انبار است . یک انبار توزیع و دو انبار کوریر . انبار توزیع مربوط به انبار های پستکس می باشد 

- UserFullName
  انباردار
- PhoneNumber
  تلفن انباردار
- Title
  عنوان انبار
- Lat
  عذض جغرافیایی
- Lng
  طول جغرافیایی
- Address
  آدرس
- IsEnable
  فعال است
- CityId
  کد شهرستان
  
### Warehouse

انبار های کوریر ها در این جدول نگهداری می شود

- UserFullName
  انباردار
- PhoneNumber
  تلفن
- Address
  آدرس
- Title
  عنوان
- Lat
  عرض جغرافیایی
- Lng
  طول جغرافیایی
- IsEnable
  فعال است
- District
  کد منطقه، منطقه پستی تهران
- CityId
  کد شهر

### AgentVehicleMap

وسایل نقلیه با اطلاعات کامل شامل حجم و .. در این جدول نگهداری می شود

- PostexName
 نام وسیله نقلیه
- VehicleType
 نوع مثلا کامیون
- Volume
  حجم
- Weight
  وزن

### City

- PostexId
  کد شهرستان
- Title
  عنوان
- IsEnable
  فعال می باشد
- StateId
  کد استان
- IsTehran
  تهران هست

### ExternalToken

این سیستم با چندین سیستم دیگر مثل پستکس و پارسی مپ در ارتباط است . همه ی توکن های این سیستم ها در این جدول ذخیره می شود . و سیستم برای دسترسی به سایر سرویس ها از این توکن ها استفاده می کند

- Token
  توکن
- ServiceName
  نام سرویس
- AgentId
  کلید خارحی از Agent

### Manifest

این جدول میاد چندین سفارش که آدرس یکسانی دارن رو یکی می کنه . به طور مثال نیازه نماینده سفارش شماره 1 و شماره 2 رو جمع آوری کنه و هر دوی این سفارشات آدرس فرستنده یکسانی دارند ، در این صورت سیستم یه رکورد در این جدول می سازد و هر دوی سفارشات رو یکی می کنه 

- Barcode
  بارکد داخلی تولید شده برای سفارشات یکسان
- Count
  تعداد سفارشاتی که یکسان سازی شده است
- ServiceType
  نوع سرویس
- Title
  عنوان
- Description
  توضیحات
- ActivityStatus
  وضعیت اجرا (تکمیل شده ، در انتظار اجرا و ...)
- Status
  وضعیت سفارش
- ScheduleTaskType
  نوع زمانبندی (به طور مثال در چه مرحله ای است ، جمع آوری از مبدا مشتری و ....)
- ExecutionDateTime
  زمان انجام
- Lat
- Lng
- Address
- PhoneNumber
- FullName
- IsEnable
- CustomerTimeWindow
  پنجره زمانی جهت بهینه سازی
- Periority
  اولویت
- AgentId
  کد نماینده یا جمع آور

### ManifestAttachment

هر manifest می تواند شامل فایل های پیوست باشد . فایل پیوست شامل یک امضا و چندین تصویر از مرسوله یا محل تحویل می باشد

- ManifestId
  کد manifedt
- Status
  وضعیت
- SignatureId
  کد امضا
- ManifestAttachmentImages
  لیست تصاویر

### ManifestAttachmentImage

لیست تصاویر manifest در این جدول نگهداری می شود 

- mediaId کد تصویر

---

## متدها

---

## فرایند ها

---

## دیاگرام ها