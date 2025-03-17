## Projekt
- [ ] Utwórz projekt 2D
- [ ] Dodaj do sceny obiekt `Canvas/TextMeshPro` (pole tekstowe)
- [ ] Ustaw pozycje pola (w Inspektorze) `Transform.position.x` oraz `Transform.position.y` na 0
- [ ] Dodaj do sceny obiekt `Canvas/Button` (przycisk)
- [ ] Utwórz swój skrypt i dodaj go jako komponent jednego z obiektów na scenę (np do przycisku)
- [ ] W skrypcie utwórz zmienną dla tekstu `public TextMeshProUGUI zmiennaTekstowa;` oraz zmienną dla przycisku `public Button zmiennaPrzycisku;`
- [ ] W inspektorze po wybraniu obiektu z twoim skryptem, przeciągnij obiekt z polem tekstowym do zmiennej `Zmienna Tekstowa` oraz przeciągnij obiekt z przyciskiem do zmiennej `Zmienna Przycisku`
- [ ] W twoim skrypcie utwórz nowy blok kodu `public void DoWhenClicked(){  }` między tymi klamrami będziesz pisał kod który wykonany zostanie gdy klikniesz przycisk, ale o tym zaraz...
- [ ] W inspektorze otwórz obiekt z dodanym przyciskiem, dodaj nowy wpis do `OnClickEvent`, przeciągnij tam swój obiekt z dołączonym skryptem który stworzyłeś

## Ogólna wiedza - krótki wstęp
- Wszystkie instrukcje które mają wykonać się w pętli, muszą być między klamrami tej pętli!
- Instrukcje dodawaj w bloku `DoWhenClicked(){ }` który dodałeś wcześniej do swojego skryptu
- Od teraz kod będzie wykonywał się tylko po wciśnięciu przycisku
- Jeśli polecenie każe Ci wypisać np. listę wyświetl ją w polu tekstowym, korzystając w poniższych podpowiedzi :)
- Jeśli polecenie wyraźnie mówi aby pisać kod w bloku `Update(){ }` - pisz kod w tym bloku, będzie on wykonywał się co klatkę!
- Pamiętaj aby przed każdym zadaniem w bloku `Start() { }` drukować aktualną zawartość listy
- Poniżej masz także pokazany przykład prywatnej i publicznej listy oraz sposób na zapełnianie listy losowymi liczbami, twoim wyborem jest czy do zadań będziesz korzystać z listy losowych liczb czy z listy liczb które wpiszesz w inspektorze.
```C#
private List<int> twoja_lista_private = new List<int>(); // jest słowo 'private' więc nie zobaczysz listy w inspektorze
public List<int> twoja_lista_public; // jest słowo 'public' więc będziesz mógł dodać elementy w inspektorze

public TextMeshProUGUI zmienna_tekstowa; // nie zapomnij przeciągnąć w inspektorze!
public Button zmienna_przycisku; // nie zapomnij przeciągnąć w inspektorze!

void Start() 
{
	// wrzucanie randomowych list z przedziału do listy
	int ilosc_elementow = 100;
	for (int i = 0; i < ilosc_elementow; i++) 
	{
		int losowa_liczba = Random.Range(0, 100); // liczby między 0 a 99
		twoja_lista_private.Add(losowa_liczba);
	}

	// wpisywanie zawartości listy do zmiennej zmienna_tekstowa
	string lista_jako_tekst = ""; // pusty tekst
	zmienna_tekstowa.text = ""; // czyścimy pole tekstowe
	foreach (int element in twoja_lista_private) 
	{
		lista_jako_tekst += element.ToString() + " ";
	}
	zmienna_tekstowa.text = lista_jako_tekst;
}

public void DoWhenClicked()
{
	// Kod gdy gracz wciśnie przycisk
}
```

## Zadania - pętle `for`
```C#
// segment do pierwszego średnika inicjalizuje `i` - czyli tworzy zmienną i w pętli for i ustawia jej wartośc - w tym wypadku na 0
// segment do drugiego średnika to warunek który jest sprawdzany przed każdym wywołaniem pętli - póki warunek się spełnia, pętla jest kontynuowana - w tym wypadku sprawdzamy czy `i` jest mniejsze od 10
// segment na końcu to inkrementacja `i`, dzieje się ona zawsze na końcu każdego wywołania pętli - w tym wypadku dodajemy do `i` 1

for (int i = 0; i < 10; i++) 
{
	Debug.Log("I jest rowne = " + i); // wypisze do konsoli aktualną wartość i
}
```
- [ ] Napisz program który wypisze liczby od 0 do `public int x` włącznie. 
- [ ] Napisz program który wypisze tylko liczby parzyste w zakresie 0 do `public int x`. 
- [ ] Napisz program który wypisze tylko liczby podzielne przez `public int y` w zakresie 0 do `public int x`. 
- [ ] Napisz program który wypisze liczby w kolejności od `public int x` do 0. 
- [ ] Napisz program który wypisze liczby od 0 do - `public int x`. 
- [ ] Napisz program który wyświetli wszystkie elementy listy.

## Zadania - pętle `while`
```C#
// jedyny segment w pętli `while` to warunek - sprawdzany on jest przed wywołaniem każdego przejścia pętli - innymi słowy, pętla będzie się wykonywać póki warunek będzie prawdziwy, stąd ważne jest aby mieć pewność, że dany warunek w końcu przestanie być prawdziwy - w innym przypadku program może nam się zawiesić!

string tekst = "";
while (tekst.Length < 5) 
{
	Debug.Log("Warunek nadal jest prawdziwy!");
	tekst += "a";
}
```
- [ ] Napisz program który wypisze wszystkie elementy listy. Pamiętaj aby sprawdzać czy nie wykraczasz poza rozmiar listy.
- [ ] Napisz program który będzie wypisywał liczby z listy dopóki nie napotka liczby `public int x`.
- [ ] Napisz program który będzie wypisywał liczby z listy dopóki nie napotka liczby podzielnej przez `public int x` bez reszty. 
- [ ] Napisz program który będzie wypisywał liczby z listy do póki nie napotka liczby większej od `public int x`. 

## Zadania - pętle `foreach`
```C#
// jedyny segment pętli `foreach` składa się z przypisywania do zmiennej - w tym wypadku - "element" kolejnych wartości pętli. Innymi słowy co przejście pętli do zmiennej "element" wpisywany jest kolejny element listy "lista". Zauważ, że typ zmiennej element jest taki sam jak typ naszej listy!

List<int> lista = new List<int>();
lista.Add(1);
lista.Add(5);
lista.Add(2);
foreach(int element in lista)
{
	Debug.Log("Kolejny element listy: " + element);
}
```
- [ ] Napisz program który wypisze wszystkie elementy listy. 
- [ ] Napisz program który wyświetli wszystkie elementy listy o parzystej wartości. 
- [ ] Napisz program który przejdzie przez każdy element w zmiennej typu string. 
- [ ] Napisz program który zsumuje wszystkie elementy tablicy.

## Zadania zaawansowane - dowolne pętle
- [ ] Napisz program który wpisze elementy listy A do listy B oraz elementy listy B do listy A. 
- [ ] Napisz program który dla listy składającej się z ocen (1-6) wyświetli średnią arytmetyczną, najwyższą ocenę, najniższą ocenę i komunikat czy dla danych ocen możliwe jest uzyskanie zaliczenia. Zakładamy, że zaliczenie jest od oceny 2.0 wzwyż. 
- [ ] Napisz program który zsumuje elementy listy. 
- [ ] Napisz program który odwróci listę. 
- [ ] Napisz program który posortuje listę. 
- [ ] Napisz program który dla listy A utworzy dwie listy :
	1. PARZYSTE do których wpisze wszystkie liczby parzyste z listy A oraz 
	2. NIEPARZYSTE do której wpisze wszystkie liczby nieparzyste z listy A. 
- [ ] Napisz program który dla listy A usunie wszystkie duplikaty. 
- [ ] Napisz program który pozwoli dodać przy przyciśnięciu wcześniej stworzonego przycisku,  losową liczbę do listy, za każdym razem wypisz na nowo listę na ekran