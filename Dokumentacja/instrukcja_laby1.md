Zajęcia pierwsze - zmienne i operacje logiczne

---
### Spis Treści
1. [Wstęp](##wstęp)
2. [Dokumentacja potrzebna do dzisiejszych zajęć](##dokumentacja)
3. [Zadania](##zadania)
	- zmienne + operatory
	- operacje logiczne
	- dla chętnych
4. [Podpowiedzi](##podpowiedzi)

---
## Wstęp

Na dzisiejszych zajęciach poruszymy trzy kluczowe dla programowania tematy #zmienne, #operatory oraz #operacje-logiczne.
- Zmienne - są to swego rodzaju pudełka na dane. Każde pudełko musi być odpowiednio opisane (mieć swój typ np. `int`, `float`, `string` etc.) oraz mieć swoją nazwę po której będziemy mogli dostać się do zawartości. Więcej o zmiennych dowiesz się w [dokumentacji](##dokumentacja).
  ``` C#
  // Deklarowanie zmiennych
  int mojaZmienna;
  float mojaZmienna2;
  bool mojaZmienna3;

  // Inicjalizacja zmiennych
  int mojaZmienna11 = 12;
  float mojaZmienna12 = 0.3f; // zauważ, że zmienne typu float muszą mieć literkę 'f' na końcu
  bool mojaZmienna13 = false;

  // Ponowne przypisywanie wartości zmiennym
  mojaZmienna = 5 - 2;
  ```

- Operacje logiczne - są to bloki kodu które pozwalają nam wykonywać kod warunkowo. Więcej o operacjach logicznych dowiesz się w [dokumentacji](##dokumentacja). 
```C#
bool maWiecejNiz18Lat = false;
if (maWiecejNiz18Lat == true) // albo można wpisać sam warunek 'if (maWiecejNiz18Lat)'
{
	Debug.Log("Można sprzedać alkohol");
}
else 
{
	Debug.Log("Nie można sprzedać alkoholu");
}
```
- Operatory - są to symbole albo tzw. [słowa kluczowe](https://learn.microsoft.com/pl-pl/dotnet/csharp/language-reference/keywords/) które wykonują operacje na zmiennych. Będziesz korzystał/a z nich właściwie wszędzie, wracaj do [dokumentacji](##dokumentacja) za każdym razem gdy będziesz potrzebował ich użyć.
```C#
// operatory logiczne '&&' '||' '=='
bool czyRowne = 4 == 4; // zwroci true jesli lewa strona (4) jest rowna prawej stronie (5)
bool obaPrawdziwe = true && false; // zwróci true jeśli obie strony są prawdą
bool chociazJednoPrawdziwe = true || false; // zwróci true jeśli choć jedna strona jest prawdą

// operatory arytmetyczne
int dodawanie = 2 + 2;
float mnozenie = 0.5f * 2.2f;
double dzielenie = 1.2 / 0.1;
```

---
## Dokumentacja
- [operatory](dokumentacja_OPERATORY.pdf)
- [zmienne](dokumentacja_ZMIENNE.pdf)
- [operatory warunkowe](dokumentacja_INSTRUKCJE_WARUNKOWE.pdf)

---
## Zadania
- ***Zmienne***
	- [ ] Zauważ, że pociski znikają zaraz po strzeleniu. Wejdź w skrypt **Bullet** i postaraj się naprawić ten błąd, pamiętaj jednak, że pociski powinny rzeczywiście znikać - po czasie.
	- [ ] Pociski poruszają się z tą samą prędkością, nawet gdy w inspektorze zmienimy wartość **movementSpeed**, zauważ, że w skrypcie **Bullet**, do pozycji gracza przypisujemy pozycje przesuniętą w górę o wartość [Time.deltaTime](##podpowiedzi), spróbuj do równania dodać zmienną **movementSpeed**, jak myślisz, lepiej ją dodać czy przemnożyć? Sprawdź! :)
	- [ ] Asteroidy zawsze pojawiają się z wielkością 1, w skrypcie **AsteroidSpawner** w bloku `SpawnAsteroid` jest błąd, losowa wielkość zawsze wychodzi na 1, znajdź i popraw problem, przyjmujemy, że maksymalna wartość asteroidy to 3.
	- [ ] Asteroidy spawnują się w widocznym miejscu, gdy powinny pojawiać się poza ekranem, zauważ, że mamy zmienne **playAreaX** oraz **playerAreaY**, pobaw się tymi wartościami i sprawdź które dają najlepszy rezultat.
	- [ ] W skrypcie **AsteroidSpawner** znajduje się zmienna **currentSpawnRate** która śledzi aktualną ilość asteroid pojawianych na sekundę, zauważ, że nigdy nie rośnie, stwórz nową zmienną publiczną dzięki której pozwolisz na zwiększanie currentSpawnRate tak aby gra była trudniejsza  z sekundy na sekundę.
- ***Operacje Logiczne***
	- [ ] W skrypcie **PlayerMovement** znajduje się parę bloków `if` w których to wykonujemy dodawanie siły do statku, w każdym z tych bloków powinniśmy sprawdzać czy gracz wcisnął odpowiedni przycisk zanim będziemy dodawać siły do statku.
	- [ ]  W skrypcie **PlayerMovement** w bloku kodu `OnTriggerEnter2D` znajduje się kawałek kodu który powinien dziać się tylko gdy tag obiektu `hitObject` odpowiedni (tj. `Enemy`).
	- [ ] W skrypcie **PlayerMovement** w bloku kodu `CheckIfOutOfScene` istnieją dwa bloki `if` zauważ, że odpowiadają one za teleportowanie gracza do przeciwległych pozycji ekranu w osi X, na podstawie tych bloków `if` napisz pozostałe dwa bloki które będą robić to samo w osi Y.
- ***Dla Chętnych***
	- [ ]  W oryginalnej grze statek rusza się nawet jeśli gracz niczego nie klika, spróbuj dodać taką mechanikę.
	- [ ] Gdy gracz wychodzi poza planszę jest teleportowany na przeciwległy koniec, spróbuj napisać podobny system dla asteroid.
	- [ ] Asteroidy ruszają się zawsze tak samo szybko, zrób mechanikę w której prędkość ruchu jest losowana.
## Podpowiedzi
1. Przydatny kod:
	- `Time.deltaTime` -> jeśli przemnożymy to przez na przykład movementSpeed, uzyskamy płynny ruch
	- `Random.Range(0, 5)` -> zwróci losową liczbę od 0 do **4**, oczywiście liczba 0 oraz 4 może zostać zamieniona na dowolną liczbę lub zmienną
	- `Input.GetKeyDown(KeyCode.<code>)` -> zwróci `true` w momencie w którym gracz wciśnie jednorazowo przycisk `<code>` oczywiście za `<code>` wpisujemy odpowiedni kod przycisku, np. `W`, `Space`, `A` etc...
	- `Input.GetKey(KeyCode.<code>)` ->zwraca `true` póki gracz wciska przycisk `<code>` oczywiście za `<code>` wpisujemy odpowiedni kod przycisku, np. `W`, `Space`, `A` etc...