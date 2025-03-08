
## Projekt
- [ ] Utwórz projekt 2D
- [ ] Dodaj do sceny obiekt `Canvas/TextMeshPro` (pole tekstowe)
- [ ] Ustaw pozycje pola (w Inspektorze) `Transform.position.x` oraz `Transform.position.y` na 0
- [ ] Dodaj nowy skrypt na obiekt pola tekstowego

## Ogólna wiedza - krótki wstęp
- Instrukcje dodawaj w twoim nowym skrypcie w bloku Start() - pomiędzy nawiasami klamrowymi
- ***Każda*** instrukcja kończy się znakiem średnika `;`
- Gdy wprowadzisz jakąkolwiek zmianę w skrypcie, zapisz go `ctrl + s` a następnie uruchom program i sprawdź co się zmieniło

## Zadania
- [ ] Wpisz do pola tekstowego własny tekst np.: `GetComponent<TextMeshProUGUI>().text = "Hello"`
- [ ] Zadeklaruj zmienną typu `string` (tekst) i wpisz do niej coś np.: `string zmTxt = "Hello";`
- [ ] Przypisz wartość zmiennej typu `string` do komponentu pola tekstowego np.:  `GetComponent<TextMeshProUGUI>().text = zmTxt;`
- [ ] Zadeklaruj zmienną typu `int` (liczba całkowita) i przypisz jej liczbę. np.: `int zmInt1 = 10;`
- [ ] Przypisz wartość zmiennej liczbowej do zmiennej typu `string` - korzystając z polecenia zmiennej liczbowej (metody) konwertującego zmienną na tekst: `ToSTring()` -podawana po kropce; np.: `zmTxt = zmInt1.ToString();`
- [ ] Zadeklaruj dodatkowe dwie zmienne typu `int`. Jednej przypisz wartość, a druga ma być wynikiem sumy dwóch pozostałych i wyświetl; np. `int wynik = zmInt1 +zmInt2;`
- [ ] Zadeklaruj zmienną dla liczby dziesiętnej (typ `float` lub `double`) i przypisz jej iloczyn dwóch wcześniej zadeklarowanych liczb i wyświetl wynik
- [ ] Przypisz zmiennej dziesiętnej iloraz liczb i wyświetl wynik - jeżeli wynik nie jest poprawny wykonaj kolejne zadanie ;) 
- [ ] Aby iloraz dwóch liczb całkowitych dał w wyniku liczbę dziesiętną trzeba przekonwertować jedną z liczb na dziesiętną podając przed nią typ dziesiętny w nawiasie np. `double wynikDouble =(double) zmInt2 / zmInt1;`
- [ ] Wypisz całe równanie za pomocą łączenia napisów. np. `zmTxt = zmInt2.ToString() + "/" + zmInt1.ToString() + " =" + wynikDouble.ToString();`
- [ ] Zmień wielkość czcionki  komponentu pola tekstowego ; np. `GetComponent<TextMeshProUGUI>().fontSize = zmInt1 * 10;`
- [ ] Wypisz długość zmiennej tekstowej (korzystając z pola zmiennej tekstowej - `Length`) np. `zmTxt = zmTxt.Length.ToString();`
- [ ] Zmień wielkość czcionki zależnie od długości tekstu (możesz wybrać własny wzór)

## Inspektor - krótki wstęp
- Zmienne widoczne są w blokach, których są deklarowane.
- Jeżeli chcemy widzieć zmienne w całym skrypcie należy je zadeklarować w bloku klasy tzn. w nawiasach klamrowych po deklaracji: `public class NazwaKlasy { }`
- Jeżeli dodamy do deklaracji pola klasy słowo: `public` (zmienna publiczna), wartości zmiennej będą widoczne w Unity (w Inspektorze w polu skryptu) np.: `public string zmSkryptString;`
## Zadania
- [ ] Zadeklaruj zmienną widoczną w całym skrypcie (tzw. pole klasy)  `zmSkryptString` typu `string` 
- [ ] W bloku `Start()` przypisz tekst do zmiennej `zmSkryptString` . Blok `Start()` uruchamiany jest raz na początku.
- [ ] W bloku `Update()` przypisz zmienną  `zmSkryptString` do komponentu pola tekstowego np.: `GetComponent<TextMeshProUGUI>().text = zmSkryptString;` Blok `Update() `uruchamiany jest dla każdej wyświetlanej klatki aplikacji. 
- [ ] Sprawdź działanie metody `Update()`:
- [ ]  Uruchom aplikację
- [ ] Po uruchomieniu aplikacji znajdź zmienną w Unity w Inspektorze i zmień napis (w Inspektorze) na inny.
- [ ] W bloku `Update()` dodaj zwiększanie rozmiaru czcionki zależnie od długości `zmSkryptString` i sprawdź w Unity (wydłużając napis w Inspektorze) jak się zmienia rozmiar tekstu.
- [ ] Przy ustawianiu wielkości czcionki ogranicz wielkość czcionki do ustalonej wartości maksymalnej (np. 120) za pomocą operatora modulo (`%`) który dla dwóch liczb  zwraca resztę z dzielenia -> np.: `int` `fSize =zmSkryptString.Length * 7; fSize = fSize % 120;  GetComponent<TMP_Text>().fontSize = fSize;` Jak teraz się zmienia rozmiar czcionki przy wydłużaniu tekstu?

## Zadania - zmienne logiczne oraz warunki
- [ ] Zadeklaruj dwie PUBLICZNE zmienne logiczne (typu `bool`) i przypisz im wartości logiczne: `true`/`false`
- [ ] W bloku `Update()` za pomocą instrukcji warunkowej `if..else` zmień kolor czcionki - Jeżeli iloczyn logiczny zmiennych jest prawdziwy na czerwony, w pozostałym przypadku na niebieski:
```C#
if (zmBool1 && zmBool2)
{  
    GetComponent<TextMeshProUGUI>().color = Color.red;
}
else
{
	GetComponent<TextMeshProUGUI>().color = Color.blue;
}
```
- [ ] Uruchom aplikację - zmieniaj w inspektorze wartości logiczne i patrz jak się zmienia kolor czcionki.
- [ ] W bloku `Updat()e` za pomocą instrukcji warunkowej `if..else` zmień kolor czcionki - Jeżeli suma logiczna zmiennych (zmBool1 || zmBool2) jest prawdziwa na czerwony, w pozostałym przypadku na niebieski. Zamień poprzedni warunek.
- [ ] Uruchom aplikację - zmieniaj w inspektorze wartości logiczne i patrz jak się zmienia kolor czcionki.
- [ ] Dodaj negację wartości logicznej -> np. `!true`  i przetestuj
- [ ] Dodaj zmienną PUBLICZNĄ typu `int`, przypisz jej dowolną wartość, która jeżeli parzysta ustawia kolor czcionki na biały (`Color.white`) w pozostałych przypadkach decydują wartości zmiennych logicznych (w bloku `else` kolejny warunek `if..else`)  Za pomocą zmienna `% 2 `możemy stwierdzić czy dzielenie przez 2 zwraca resztę czy nie -> czy zmienna jest parzysta/nieparzysta. Operatory porównania: `2==2 -> true; 2!=2 - false`.
- [ ] Jeżeli liczba jest parzysta i większa od zadanej wielkości to zmień kolor na czarny (`Color.black`) w przeciwnym razie biały. Do porównywania mamy operatory: `a>b; a<b; a>=b; a<=b; a==b; a!=b; `

## Zadania dodatkowe
- [ ] Poruszanie polem tekstowym po okręgu - ruch przy zmianie wartości zmiennej publicznej. Przykładowo zmiana położenia pola tekstowego dla zmiennej `float pozycjaY`:
```C#
Transform t = GetComponent<Transform>();
t.position = new Vector2(t.position.x, pozycjaY);	
```




