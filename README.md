# Bibliotekos valdymo sistema 📖[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/) 


## Turinys 

- Apie projekto Tech Stack'ą.
- Trumpas projeto architektūros pristatymas 
- Kur panaudoti visi principai

#
# Tech stack'as 🔗
| Tipas | Tech     | Dėtaliau                       |
| :-------- | :------- | :-------------------------------- |
| `Programavimo kalba`      | `C#` | v7.2 |
| `Framework'as`      | `.NET` | WPF - Windows Presentation Foundation |
| `Objektinis programavimas`      | `OOP` | Inkapsuliacija, abstrakcija, paveldimumas bei polimorfizmas|
| `SOLID principai`      | `SOLID` | SRP, OCP, LSP, ISP, DIP  |
| `UI/UX`      | `XAML` |
| `IDE`      | `Visual Studio 2022` | 


```bash
  Projekto paleidimas `LMS_VIKO_Nojus_Rascius_PI22A.sln`.
```
#

# Trumpas projeto architektūros pristatymas 🔠

Interface'ai:

- IPublishable.cs
- IGenerator.cs
- IItemManager.cs
- IUserManager.cs

Klasės:

- GenerateBooks.cs (paveldimumas - IGenerator)
- GenerateJournals.cs (paveldimumas - IGenerator)
- ItemManager.cs (paveldimumas - IItemManager)
- Book.cs (paveldimumas - IPublishable)
- Journal.cs (paveldimumas - IPublishable)
- User.cs
- UserManager.cs (paveldimumas - IUserManager)

UI/UX:

- (main)_LogInWindow.xaml
- App.xaml
- HomeWindow.xaml
- RegisterWindow.xaml

# Kur panaudoti visi principai ✔️

```bash
  Inkapsuliacija (Encapsulation)
```
UserManager ir ItemManager klasės kapsuliuoja būseną ir elgseną, susijusią su vartotojais ir elementais atitinkamai. Jos pateikia metodus, tokius kaip RentItem, ReturnItem, BuyItem, ir pan., išlaikydamos vartotojų ir elementų sąrašus privačius. Tai užtikrina, kad duomenų vidinė reprezentacija būtų paslėpta nuo išorės, teikiant viešąją sąsają.
```bash
  Abstrakcija (Abstraction)
```
IUserManager ir IItemManager sąsajos pateikia abstrakčias operacijas, kurias galima atlikti nennurodant, kaip šios operacijos yra įgyvendinamos. Ši abstrakcija leidžia turėti skirtingas konkrečius įgyvendinimus, kurie gali būti keičiami nekeičiant likusios sistemos.
```bash
  Paveldėjimas (Inheritance)
```
Paveldęjimas pademonstruotas kodo architektūroje.
```bash
  Polimorfizmas (Polymorphism)
```
Polimorfizmas naudojamas per sąsajas IUserManager ir IItemManager. Tai leidžia HomeWindow sąveikauti su bet kuriuo objektu, kuris įgyvendina šias sąsajas polimorfiškai. Pavyzdžiui, jei IItemManager įgyvendima skirtingus elementų tipus, HomeWindow gali juos keistis tarpusavyje.
```bash
  Vieno Atsakomybės Principas (Single Responsibility Principle)
```
Kiekviena klasė turi vieną atsakomybę. Pavyzdžiui, ItemManager yra atsakingas už daiktų(knygų/žurnalų) valdymą (nuomą, grąžinimą, pirkimą), o UserManager už vartotojų autentifikaciją ir registraciją. Pavyzdžiui LogInWindow yra atsakingas tik už vartotojo sautentifikaciją.
```bash
  Atviro/Uždaro Principas (Open/Closed Principle)
```
Sistema yra atvira plėtrai, bet uždara modifikacijai. Pavyzdžiui, jei yra poreikis palaikyti naują publikuojamo daikto tipą, tai nereikia modifikuoti ItemManager ar HomeWindow klases, nes galima praplėsti IPublishable sąsają ir pridėti naują tipą į sistemą.
```bash
  Liskov Substitucijos Principas (Liskov Substitution Principle)
```
Išvestinės klasės turi būti keičiamos su jų bazinėmis klasėmis. Šis principas taikomas naudojant sąsajas IUserManager ir IItemManager. Bet kuri klasė, įgyvendinanti šias sąsajas, gali būti keičiama be norimų programos savybių pakeitimo.
```bash
  Sąsajų Atskyrimo Principas (Interface Segregation Principle)
```
Klientai yra priversti priklausyti nuo sąsajų. IUserManager sąsajoje yra deklaruojami tik su vartotojų valdymu susiję metodai. Panašiai IItemManager sąsajoje yra tik daiktų valdymo metodai, užtikrinant, kad klases, įgyvendinančias šias sąsajas, tikrai galės teikti atitinkamą funkcionalumą.
```bash
  Priklausomybių Apversimo Principas (Dependency Inversion Principle)
```
Aukšto lygio moduliai neturėtų priklausyti nuo žemo lygio modulių. Abu turėtų priklausyti nuo abstrakcijų. Pavyzdžiui, HomeWindow priklauso nuo IUserManager ir IItemManager sąsajų, o ne konkrečių įgyvendinimų, tai leidžia didesniam atsietumui ir lengvesniam testavimui.
