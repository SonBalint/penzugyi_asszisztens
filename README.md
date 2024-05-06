# P�nz�gyi Asszsitens
## Absztrakt
A program egy p�nz�gyi asszisztens, amely seg�ts�get ny�jt a felhaszn�l�knak a p�nz�gyeik kezel�s�ben.

## Funkci�k
- Sz�mla l�trehoz�sa
- Sz�mla t�rl�se
- Sz�mla egyenleg�nek lek�rdez�se
- Tranzakci�k lek�rdez�se
- Kiad�sok/Bev�telek hozz�ad�sa
- Kiad�sok/Bev�telek t�rl�se

## Haszn�lat
Az asszisztens egy konzolos fel�leten kereszt�l kommunik�l a felhaszn�l�val. A futtat�s ut�n a program men�pontokat k�n�l a felhaszn�l�nak, amelyek seg�ts�g�vel a felhaszn�l� elv�gezheti a k�v�nt m�veleteket.
```
1. Sz�mla hozz�ad�sa
2. Kiad�s hozz�ad�sa
3. Bev�tel hozz�ad�sa
4. Sz�mla egyenleg�nek lek�rdez�se
5. Kiad�s elt�vol�t�sa
6. Bev�tel elt�vol�t�sa
7. Sz�mla elt�vol�t�sa
8. Tranzakci�k list�z�sa
9. Kil�p�s
```

A men�pontok k�z�tti navig�l�st a megfelel� sz�mjegy be�r�s�val lehet elv�gezni.

### 1. Sz�mla hozz�ad�sa
A szoftver bek�r egy sz�mla nevet �s egy kezd� egyenleget, majd l�trehoz egy �j sz�ml�t.
```
Add meg a sz�mla nev�t: <sz�mla neve>
Add meg a kezd� egyenleget: <kezd� egyenleg>
```

### 2. Kiad�s hozz�ad�sa
A szoftver bek�r egy sz�mla nevet, majd egy kiad�s �sszeg�t �s le�r�s�t, ez ut�n pedig hozz�adja a kiad�st a megadott sz�ml�hoz.
```
Add meg a sz�mla nev�t: <sz�mla neve>
Add meg az �sszeget: <kiad�s �sszege>
Add meg a le�r�st: <kiad�s le�r�sa>
```

### 3. Bev�tel hozz�ad�sa
A szoftver bek�r egy sz�mla nevet, majd egy bev�tel �sszeg�t �s le�r�s�t, ez ut�n pedig hozz�adja a bev�telt a megadott sz�ml�hoz.
```
Add meg a sz�mla nev�t: <sz�mla neve>
Add meg az �sszeget: <bev�tel �sszege>
Add meg a le�r�st: <bev�tel le�r�sa>
```

### 4. Sz�mla egyenleg�nek lek�rdez�se
A szoftver bek�r egy sz�mla nevet, majd ki�rja a megadott sz�mla egyenleg�t.
```
Add meg a sz�mla nev�t: <sz�mla neve>
A(z) <sz�mla neve> egyenlege: <egyenleg>
```

### 5. Kiad�s elt�vol�t�sa
A szoftver bek�r egy sz�mla nevet, majd egy kiad�s sorsz�m�t (ez a 8-as, Transzakci�k list�z�sa men�ponttal lek�rdezhet�), majd t�rli a megadott kiad�st a megadott sz�ml�r�l.
```
Add meg a sz�mla nev�t, ahol a kiad�st elt�vol�tani k�v�nod: <sz�mla neve>
Add meg a kiad�s sorsz�m�t: <kiad�s sorsz�ma>
```

### 6. Bev�tel elt�vol�t�sa
A szoftver bek�r egy sz�mla nevet, majd egy bev�tel sorsz�m�t (ez a 8-as, Transzakci�k list�z�sa men�ponttal lek�rdezhet�), majd t�rli a megadott bev�telt a megadott sz�ml�r�l.
```
Add meg a sz�mla nev�t, ahol a bev�telt elt�vol�tani k�v�nod: <sz�mla neve>
Add meg a bev�tel sorsz�m�t: <bev�tel sorsz�ma>
```

### 7. Sz�mla elt�vol�t�sa
A szoftver bek�r egy sz�mla nevet, majd t�rli a megadott sz�ml�t.
```
Add meg az elt�vol�tand� sz�mla nev�t: <sz�mla neve>
```

### 8. Tranzakci�k list�z�sa
A szoftver bek�r egy sz�mla nevet, majd ki�rja a megadott sz�mla �sszes tranzakci�j�t.
```
Tranzakci�k a(z) '<sz�mla neve>' sz�ml�n:
<Bev�tel/Kiad�s> [<sorsz�m>] - �sszeg: <�sszeg>, Le�r�s: <le�r�s>, D�tum: <d�tum>
```

### 9. Kil�p�s
A program kil�p.

## Adatok Ment�se
A szoftver a sz�ml�k �s a tranzakci�k adatait minden egyes m�velet ut�n egy `penzugyek.txt` f�jlba menti el a futtathat� f�j� mell�, amely a program k�vetkez� ind�t�sakor bet�lt�dik.

## K�vetelm�nyek
A szoftver k�pes b�rmilyen Windows oper�ci�s rendszert haszn�l� sz�m�t�g�pen futni.

## Telep�t�s
A program futtat�s�hoz nincs sz�ks�g telep�t�sre. A program futtathat� f�jlj�t el�g csak elind�tani.

## Fejleszt�k
- [Sonkoly B�lint](https://github.com/SonBalint)