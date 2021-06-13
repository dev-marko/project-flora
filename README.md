![fcse_logo](https://2018.skopje.wordcamp.org/files/2018/09/Logo_FINKI_UKIM_EN.jpg)
# Flora Warehouse Management System

**Предмет:** Визуелно програмирање

**Име на проект:** Флора - систем за менаџирање на магацинско работење

**Автори:**
- Марко Спасеновски (191128)
- Андреј Ацевски (182081)



**Ментори:** 
- проф. д-р Дејан Ѓорѓевиќ
- проф. д-р Ѓорѓи Маџаров



**Користени технологии:**
```
Microsoft .NET Framework (Windows Forms - C#)
База на податоци: SQLite
SAP Crystal Reports
```

#### **Напомена:** 
За да ви бидат овозможени функционалностите на Crystal Reports, ќе треба да симнете и инсталирате Crystal Reports Runtime. Тоа може да го направите на следниот [линк](https://www.tektutorialshub.com/crystal-reports/download-crystal-reports-for-visual-studio-2019/). 
Crystal Reports за Visual Studio може да симнете преку NuGet менаџерот за пакети: ```Install-Package Crystal.Reports -Version 13.0.15.1840```


## **Краток опис:** 
Системот за менаџирање на магацинско работење е наменет за водење евиденција на акртикли, коминтенти и вработени на претпријатието. Главни функционалности на системот претставуваат: самото водење евиденција на трите пертходно набројани категории и евидентирање на набавки (фактури) и нивно печатење. Овој систем може лесно да се прилагоди за било кое претпријатие. Како пример во овој проект фирмата која што го „користи“ системот е Флора-Компани, земјоделска аптека. 

## Демо: 
Кликнете [тука](https://www.youtube.com/watch?v=5CHzNgrxRU0) за да разгледате кратка видео презентација на главната функционалност на системот.

## Преглед на системот
На почетокот, од корисникот се бара да се најави на системот (слика 1) со неговото корисничко име или да регистрира нов кориснички профил (слика 2).
<p align="center">
<img width="800" src="https://imgur.com/xhczbPm.png" alt="login_screen"><br>
слика 1
</p>
<p align="center">
<img width="250" src="https://imgur.com/L7BJ00I.png" alt="register_screen"><br>
слика 2
</p>

<hr>

#### Навигациско мени
После најавата, на корисникот е претставено главното навигациско мени (слика 3). Преку него може да се пристапи до следните делови на системот:
- Информации за фирмата
- Продажба
- Артикли
- Коминтенти
- Вработени
- Дневник на најави
<p align="center">
<img width="800" src="https://imgur.com/H6JSL7Z.png" alt="main_menu_screen"><br>
слика 3
</p>

<hr>

#### Информации за фирмата
Во овој дел се запишани сите релевантни информации за фирмата, кои што се потребни при печатењето на документи и други процедури. Овие информации може во било кој момент да се ажурираат. Едноставно корисникот треба да ја промени посакуваната информација и да го притисне копчето "Зачувај" за истата да се зачува. Овие информации се чуваат (серијализираат) во самиот директориум на апликацијата. Ова е единствена корист на серијализација во целиот систем, сите останати податоци се чуваат во SQLite базата.
<p align="center">
<img width="800" src="https://imgur.com/ay9StdY.png" alt="information_screen"><br>
слика 4
</p>

<hr>

#### Продажба
При клик на копчето "Продажба" од главното мени, на корисникот се прикажува дополнително подмени (слика 5) каде што може да избере различни функционалности. Моментално е имплементирано само издавањето на излезни фактури, во следни верзии на системот ќе се додаде и можност за пополнување и печатење на платен промет (ПП10, ПП30, ПП40 и ПП50).
<p align="center">
<img width="250" src="https://imgur.com/X2rICue.png" alt="submenu_screen"><br>
слика 5
</p>

<hr>

#### Артикли
Во делот артикли (слика 6) имаме приказ на моменталните артикли во базата, како и можност за внес на нов артикл, промена на постоечки или пак бришење на артикл од базата. Овозможени се сите CRUD операции. Исто така постои можност за пребарување на артикл според неговата шифра или називот. Полињата за шифра, артикл (назив), единица мерка на артиклот и даночна група се задолжителни.
<p align="center">
<img width="800" src="https://imgur.com/SHM8xhn.png" alt="products_screen"><br>
слика 6
</p>

<hr>

#### Коминтенти
Во делот за коминтенти (слика 7) имаме приказ на моменталните коминтенти во базата, како и можност за внес на нов коминтент, промена на постоечки или пак бришење на коминтент од базата. Овозможени се сите CRUD операции. Исто така постои можност за пребарување на коминтент според неговиот назив или даночен број и по град. Полињата за назив, адреса, град, поштенски број и даночен број се задолжителни.
<p align="center">
<img width="800" src="https://imgur.com/hXoPy4j.png" alt="customers_screen"><br>
слика 7
</p>

<hr>

#### Вработени
Во делот за вработени (слика 8) имаме приказ на моменталните вработени во базата, како и можност за внес на нов вработен, промена на постоечки или бришење на вработен од базата. Овозможени се сите CRUD операции. Исто така постои можност за пребарување на вработен според неговото име и презиме.
<p align="center">
<img width="800" src="https://imgur.com/I1SKn0X.png" alt="employees_screen"><br>
слика 8
</p>

<hr>

#### Дневник на најави
При клик на копчето „Дневник на најави“ се прикажува табела каде што се евидентирани сите најави на системот (слика 9), соодветно со датумот и времето на најава и корисничкото име на најавениот корисник.
<p align="center">
<img width="500" src="https://imgur.com/o1okoRD.png" alt="employees_screen"><br>
слика 9
</p>
