

# Digram_uml


Backend diagram
   - BB1(Barcode reproduction) : تولید بارکد
   - BCP1(cod paln ): درخواست cod 
   - BC1(custumerPlan) : پنل قرارداد مشتری 
   - BL1(login) : ورود و ثبت نام 
   - BAO1(process after order) : مراحل بعد از ثبت سفارش 
   - BRR1(referral cargo to the representative) : ارجاع بار به نماینده

Finanical diagram
   - FCO1(current cancel financial procress order) : فرایند مالی کنسلی بعد از ثبت سفارش
   - FO1(current complate finanical procerss after order) : فرایند مالی بعد از ثبت سفارش 
   - FD1(Final deducation order) : غرامت و مفقودی نماینده ها 
   - FC1(COD financial process) : فرایند مالی پرداخت در محل 

Cancel diagram
   - CC1(cancel cod order) : کنسل سفارش پرداخت در محل 
   - CO1(cancel order) : کنسلی سفارش

Order diagram
   - OC1 (cod-order ): ثبت سفارش پرداخت در محل
   - OA1(anboh-order ): ثبت سفارش انبوه
   - OC1(cod - order) : سفارش پرداخت محل 
   - OF1(Foreign-order ): ثبت سفارش خارجی
   - OI1(inner order) :  (پرداخت آنلاین )ثبت سفارش داخلی 
   - OC1(innercod-order) : ثبت سفارش داخلی - پرداخت در محل
   - OS1(sazmani order) : ثبت سفارش سازمانی

Abbreviation is such that the first letter of the part in large size is the first subset of the part with number 1 or 2
for Example : BB1 = first B = Backend
                    secound B = Barcode reproduction 
                    Number 1 indicates the current state of the diagram 
