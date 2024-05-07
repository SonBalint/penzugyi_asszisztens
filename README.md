# Pénzügyi Asszisztens
## Absztrakt
A program egy pénzügyi asszisztens, amely segítséget nyújt a felhasználóknak a pénzügyeik kezelésében.

## Funkciók
- Számla létrehozása
- Számla törlése
- Számla egyenlegének lekérdezése
- Tranzakciók lekérdezése
- Kiadások/Bevételek hozzáadása
- Kiadások/Bevételek törlése

## Használat
Az asszisztens egy konzolos felületen keresztül kommunikál a felhasználóval. A futtatás után a program menüpontokat kínál a felhasználónak, amelyek segítségével a felhasználó elvégezheti a kívánt műveleteket.
```
1. Számla hozzáadása
2. Kiadás hozzáadása
3. Bevétel hozzáadása
4. Számla egyenlegének lekérdezése
5. Kiadás eltávolítása
6. Bevétel eltávolítása
7. Számla eltávolítása
8. Tranzakciók listázása
9. Kilépés
```

A menüpontok közötti navigálást a megfelelő számjegy beírásával lehet elvégezni.

### 1. Számla hozzáadása
A szoftver bekér egy számla nevet és egy kezdő egyenleget, majd létrehoz egy új számlát.
```
Add meg a számla nevét: <számla neve>
Add meg a kezdő egyenleget: <kezdő egyenleg>
```

### 2. Kiadás hozzáadása
A szoftver bekér egy számla nevet, majd egy kiadás összegét és leírását, ez után pedig hozzáadja a kiadást a megadott számlához.
```
Add meg a számla nevét: <számla neve>
Add meg az összeget: <kiadás összege>
Add meg a leírást: <kiadás leírása>
```

### 3. Bevétel hozzáadása
A szoftver bekér egy számla nevet, majd egy bevétel összegét és leírását, ez után pedig hozzáadja a bevételt a megadott számlához.
```
Add meg a számla nevét: <számla neve>
Add meg az összeget: <bevétel összege>
Add meg a leírást: <bevétel leírása>
```

### 4. Számla egyenlegének lekérdezése
A szoftver bekér egy számla nevet, majd kiírja a megadott számla egyenlegét.
```
Add meg a számla nevét: <számla neve>
A(z) <számla neve> egyenlege: <egyenleg>
```

### 5. Kiadás eltávolítása
A szoftver bekér egy számla nevet, majd egy kiadás sorszámát (ez a 8-as, Transzakciók listázása menüponttal lekérdezhető), majd törli a megadott kiadást a megadott számláról.
```
Add meg a számla nevét, ahol a kiadást eltávolítani kívánod: <számla neve>
Add meg a kiadás sorszámát: <kiadás sorszáma>
```

### 6. Bevétel eltávolítása
A szoftver bekér egy számla nevet, majd egy bevétel sorszámát (ez a 8-as, Transzakciók listázása menüponttal lekérdezhető), majd törli a megadott bevételt a megadott számláról.
```
Add meg a számla nevét, ahol a bevételt eltávolítani kívánod: <számla neve>
Add meg a bevétel sorszámát: <bevétel sorszáma>
```

### 7. Számla eltávolítása
A szoftver bekér egy számla nevet, majd törli a megadott számlát.
```
Add meg az eltávolítandó számla nevét: <számla neve>
```

### 8. Tranzakciók listázása
A szoftver bekér egy számla nevet, majd kiírja a megadott számla összes tranzakcióját.
```
Tranzakciók a(z) '<számla neve>' számlán:
<Bevétel/Kiadás> [<sorszám>] - Összeg: <összeg>, Leírás: <leírás>, Dátum: <dátum>
```

### 9. Kilépés
A program kilép.

## Adatok Mentése
A szoftver a számlák és a tranzakciók adatait minden egyes művelet után egy `penzugyek.txt` fájlba menti el a futtatható fájé mellé, amely a program következő indításakor betöltődik.

## Követelmények
A szoftver képes bármilyen Windows operációs rendszert használó számítógépen futni.

## Telepítés
A program futtatásához nincs szükség telepítésre. A program futtatható fájlját elég csak elindítani.

## Fejlesztők
- [Sonkoly Bálint](https://github.com/SonBalint)
