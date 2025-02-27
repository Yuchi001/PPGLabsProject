Zajęcia drugie - metody i pętle

---
### Spis Treści
1. [Wstęp](##wstęp)
2. [Dokumentacja potrzebna do dzisiejszych zajęć](##dokumentacja)
3. [Zadania](##zadania)
	- pętle
	- metody
	- dla chętnych
4. [Podpowiedzi](##podpowiedzi)

---
## Wstęp

Na dzisiejszych zajęciach poruszymy kolejne ważne zagadnienia #metody oraz #pętle.
- Metody - są to wydzielone bloki kodu które możemy zapisywać a potem wielokrotnie wykonywać, pomyśl o tym jak o maszyniście którego jednorazowo uczymy prowadzić pociąg a potem wielokrotnie prosimy go o prowadzenie tego pociągu - logicznym więc jest że nie chcemy uczyć kogoś na nowo prowadzić pociąg za każdym razem gdy dany pociąg powinien gdzieś jechać. Tak samo jest z metodami, zapisujemy pewien zestaw instrukcji jednokrotnie aby później móc z niego korzystać wielokrotnie. Więcej o metodach znajdziesz w [dokumentacji](##dokumentacja).
```C#
// jest to metoda typu void, więc nic nie zwraca
private void PrintHello()
{
	Debug.Log("Hello!");
}

// jest to metoda typu int, musi więc zwrócić wynik typu int przy użyciu słówka 'return'
private int PowerOfTwo(int n) 
{
	return n * n;
}

// to jest metoda w unity, wykonuje się ona raz gdy obiekt pojawia się na scenie
private void Start()
{
	// wypisze trzy razy 'Hello!'
	PrintHello();
	PrintHello();
	PrintHello();

	// do zmiennej test wpiszemy wynik metody 'PowerOfTwo' - w tym wypadku 121
	int test = PowerOfTwo(11);
}
```
- Pętle - są to bloki kodu które pozwalają wielokrotnie wykonywać dane instrukcje, dzisiaj poznasz w praktyce trzy takie pętle: 
	- `for` -> wykonuje pętle 'n' razy
	- `foreach` -> pozwala przechodzić po liście elementów
	- `while` -> wykonuje kod dopóki określony warunek jest spełniony
```C#
List<int> lista = new List<int>()
{
	4,
	1,
	7,
	5,
	3
}

for (int i = 0; i < lista.Count; i++) 
{
	Debug.Log("Kolejny element listy: " + lista[i]);
}

foreach (int element in lista) // zauważ, że element jest tego samego typu co lista
{
	Debug.Log("Kolejny element listy: " + element);
}

int index = 0;
while (index < lista.Count) 
{
	Debug.Log("Kolejny element listy: " + lista[index]);
	index++;
}

// zauważ, że wszystkie trzy pętle wypisują wszystkie elementy listy
```

---
## Dokumentacja
- [Metody](dokumentacja_METODY.pdf)
- [Pętle](dokumentacja_PETLE.pdf)

---
## Zadania
- ***Metody***
	- [ ] Asteroidy zawsze pojawiają się na bokach planszy, na bazie metody `GetVerticalSpawnPosition` napisz własną metodę `GetHorizontalSpawnPosition` która będzie pojawiać asteroidy na górze lub dole planszy.
	- [ ] W Skrypcie `PlayerMovement` w metodzie `Update` są różne kawałki kodu odpowiedzialne za różne rzeczy, pomyśl jak można wydzielić funkcjonalności na różne funkcje, a następnie zaimplementuj zmiany.
	- [ ] W skrypcie `Asteroid` w metodzie `Hit` pojawiamy trzy asteroidy, jak widzisz powtarzamy kod co wymaga inicjowania nowych zmiennych, wydziel pojawianie pojedynczej asteroidy do osobnej funkcji, a następnie wywołaj ją trzy razy w funkcji `Hit`.
- ***Pętle***
	- [ ] W skrypcie `AsteroidSpawner` w metodzie `Update` na końcu gdy timer osiągnie odpowiednią wartość pojawiamy na planszy parę asteroid korzystając z metody `SpawnAsteroid`, spróbuj zamiast powtarzania wywołania tej metody, użyć jednej ze znanych Ci pętli aby pojawić `x` asteroid, może warto zrobić zmienną która będzie umożliwiała zmianę `x`?
	- [ ] Przy użyciu wcześniej napisanej metody z zadania `3` z sekcji metod, w funkcji `Hit` podmień potrójne wywołanie twojej metody na wybraną przez Ciebie pętle która pojawi `x` asteroid, może tu także warto pozwolić na zmianę `x`?
- ***Dla chętnych*** - w tej sekcji wrócimy na chwile do poprzednich zajęć
	- [ ] Przejrzyj skrypt `Bullet`, czy są tam jakieś liczby które mogłyby być przechowywane w publicznej zmiennej? Jeśli tak, wydziel te zmienne, dzięki temu będziesz mógł kontrolować te zmienne przy użyciu inspektora!
	- [ ] Powtórz ten sam proces dla skryptu `AsteroidSpawner`, `Asteroid` oraz `PlayerMovement`
	- [ ] W skrypcie `Asteroid` każda asteroida w metodzie `Setup` ma ustawiany ten sam `Sprite`, napisz metodę która zwróci `Sprite` z pozycji tablicy w zależności od parametru `size` przekazanego w metodzie `Setup`. Pamiętaj, żeby zabezpieczyć program na wypadek gdy w liście nie ma elementu który mógłby zostać przypisany dla danego `size`.
```C#
public void Setup(AsteroidSpawner spawner, int size, bool randomRotation)
{
	spriteRenderer.sprite = GetSpriteBySize(size);
}

private void GetSpriteBySize(int size) 
{
	// dla `size` = 2 zwróć element w `asteroidSpriteList` znajdujący się na miejscu `1`
	// dla 'size' = 1 zwróć element w `asteroidSpriteList` znajdujący się na miejscu `0`
	// etc...
}
```

---
## Podpowiedzi
- gdy wydzielasz funkcje staraj się zwracać uwagę na to za co każdy element kodu jest odpowiedzialny
- gdy iterujesz po liście, najlepiej korzystać z pętli `foreach`
- metody powinny być zwięzłe i idealistycznie robić jedną rzecz