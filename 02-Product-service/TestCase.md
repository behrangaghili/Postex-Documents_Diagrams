# سناریوی تست: عملکرد سیستم پروداکت سرویس

## سناریوی تست

به منظور کمک به شما در درک تفاوت سناریو تست و موارد تست، موارد 
آزمایشی خاص برای این سناریو تست خواهد بود.
پروداکت سرویس سه وظیفه اصلی دارد 
1- استعلام قیمت
2- ثبت سفارش
3- ثبت سفارش

### سیستم استعلام قیمت و ثبت سفارش

- بررسی محدویت های وزنی کوریر ها به عنوان مثال در وزن کمتر از 30 گرم و بشتر 30 کیلوگرم پیشتاز نباید نمایش داده شود
- هنگامی که ابعاد خارج از محدوده پستی رفتار سیستم بررسی کنیم به عنوان مثال در ابعاد بالاتر از یک متر پیشتاز نباید نمایش داده شود
- هنگامی که ابعاد و وزن در رنج پستی وارد شدن ولی شهر خارج از محدوده بود رفتار سیستم بررسی شود به عنوان مثال برای سیستم چاپار شهر هایی وارد شود که نماینده در آن ها حصور ندارد
- رفتار سیستم زمانی که گزینه توزیع و جمع آوری را میزنیم بررسی شود 
- رفتار سیستم در هنگامی که نوع پرداخت مختلف را انتخاب میکنیم بررسی شود 
- سیستم در زمان که کوریر پستی مشکل دارد و قطع است تست شود که از سیستم آفلاین استفاده کند و رفتار سیستم در وضعیت آفلاین مورد بررسی قرار گیرد 
- سیستم در زمانی که ثبت سفارش انجام میشود ولی بارکد تولید نمیشود مورد بررسی قرار گیرد

به عنوان مثال :
اگر سفارشی از شهر تهران به شهر تفرش در استان مرکزی با وزن 20000 گرم . ابعاد (طول 102 و عرض 10 و ارتفاع 100)ثبت میشود با این تفاسیر تنها سرویس قابل نمایش سرویس چاپار می باشد

### سیستم رهگیری

- سیستم در زمانی که رهگیری با شماره تماس، کد رهگیری و شماره سفارش انجام میگیرد مورد بررسی قرار گیرد که در هر سه حالت نتیجه یک سان باشد 
- سیستم در زمانی که کد رهگیری با ارقام کم و یا زیاد وارد میشود مورد بررسی قرار گیرد 
- سیستم رهگیری با مرسولاتی که هنوز تحویل کوریر داده نشده است تست شود
- سیستم در زمانی که کد رهگیری شرکت های مختلف وارد می شود مورد بررسی قرار گیرد 

