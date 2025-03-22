## Projekt
- [ ] Utwórz projekt 2D
- [ ] Dodaj na scenę nowy obiekt 2D na przykład koło lub kwadrat
- [ ] Stwórz nowy skrypt i dodaj go na wcześniejszy obiekt

## Ogólna wiedza - krótki wstęp
- Na dzisiejszych zajęciach będziesz pisać własne funkcje, a właściwie to dowiesz się, że już je pisałeś :)
- Kod będziesz pisać we własnych wydzielonych blokach zwanych właśnie funkcjami (lub metodami)
- Dowiesz się także jak odczytywać Input gracza oraz zrobimy sobie szybką powtórkę
- O tym czym jest funkcja dowiesz się z [dokumentacji poświęconej funkcjom](dokumentacja_METODY.pdf)
- Tutaj prosty przykład tego jak wygląda definiowanie funkcji i jak z niej korzystać
```csharp

// [dostep (public/private)] [typ (np. void/int/float)] [nazwa] ([parametry]) 
//{
 // ciało funkcji
//}

// deklaracja funkcji
public void WydrukujTekst(string text) 
{
	Debug.Log(text); 
}

// uzycie funkcji
WydrukujTekst("Witaj świecie!");

```
- Zauważ, że w twoim skrypcie dostępne masz bazowo dwie funkcje `Start` oraz `Update`, wiesz już jak działają i wiesz już, że są to funkcje, co prawda nie widać gdzie są wywoływane - tym zajmuje się już sam silnik Unity.
- Możesz łatwo sprawdzić czy gracz kliknął któryś przycisk dzięki metodzie `Input.GetKeyDown(KeyCode.<keycode>)` gdzie pod `<keycode>` wstaw nazwę przycisku np. `W` lub `A` itp.
```csharp
void Update() 
{
	if (Input.GetKeyDown(KeyCode.A)) // sprawdza czy A zostało wciśnięte
	{
		Debug.Log("Gracz wcisnął przycisk A!");
	}

	if (Input.GetKeyUp(KeyCode.A)) // sprawdza czy A zostało puszczone
	{
		Debug.Log("Gracz puścił przycisk A!");
	}

	if (Input.GetKey(KeyCode.A)) // sprawdza czy A jest cały czas wciśnięte
	{
		Debug.Log("Gracz wciska przycisk A!");
	}
}
```
- Do poruszania obiektu możesz skorzystać z komponentu `Transform`, każdy obiekt go posiada, zauważ, że ma on pole `position`, możesz do tego pola wpisać nową pozycję, to sprawi że pozycja obiektu się zmieni, jeśli nowa pozycja będzie wystarczająco niedaleko i często będziesz aktualizował tą pozycję - uzyskasz płynny ruch, oto jak to zrobić:
```csharp
float newXPosition = transform.position + (2 * Time.deltaTime); // gracz będzie poruszał się z prędkością 2
transform.position = new Vector2(newXPosition, transform.position.y);
```
## Zadania - funkcje
- [ ] Napisz funkcję która będzie przesuwać wcześniej stworzony obiekt do góry gdy gracz wciśnie `W`
```csharp

void Update() {
	// ten kod dzieje się co klatkę, tutaj wywołuj swoją funkcję!
}
```
- [ ] Do wcześniej zrobionej funkcji dodaj mechanikę poruszania gracza dla reszty kierunków
- [ ] Stwórz zmienną typu `float` która będzie kontrolowała prędkość poruszania się obiektu
- [ ] Do twojej funkcji dopisz sprawdzanie pozycji obiektu tak, aby nie można było przesunąć obiektu poza ekran, możesz tworzyć zmienne które będą miały w sobie informacje o maksymalnej pozycji X oraz Y dla obiektu na scenie
- [ ] Utwórz zmienną typu `SpriteRenderer` i korzystając z pola `color` w tej zmiennej, zmieniaj kolor obiektu w zależności czy obiekt znajduje się z lewej (niebieski) czy z prawej (czerwony)
- [ ] Wydziel każdy z powyższych punktów na osobne funkcje, sam zdecyduj co powinno znajdować się w jakiej funkcji oraz jak te funkcje nazwać
- [ ] Utwórz listę kolorów (zmienna typu `List<Color>`) i utwórz funkcję która jako parametr będzie przyjmowała liczbę typu `int`, a zwracać będzie `Color`. Wymyśl algorytm który w zależności od numeru będzie zwracał odpowiedni kolor z listy. Np dla parzystych zwracaj czerwony a dla nieparzystych niebieski.

## Specjalne funkcje w unity
Korzystałeś już z funkcji `Start` oraz funkcji `Update` ale w Unity mamy także inne funkcje, jedną z nich jest `OnTriggerEnter2D(Collider2D col)` oraz `OnCollisionEnter2D(Collision2D col)`. Są to metody których kod wywołuje się gdy dany komponent wejdzie w kolizje z innym obiektem. Warto zaznaczyć że oba obiektu muszą mieć na sobie komponent `Collider2D` i chociaż jeden komponent powinien mieć komponent `Rigidbody2D`.

## Zadania - kolizje
- [ ] Dodaj do twojego obiektu komponenty `Rigidbody2D` oraz `Collider2D`. Pamiętaj, aby wyłączyć grawitacje w opcjach komponentu `Rigidbody2D`.
- [ ] W twoim skrypcie dodaj metodę `OnCollisionEnter2D(Collision2D col)` kod tej metody wykona się gdy dany obiekt wejdzie w kolizję z innym.
- [ ] Dodaj na sceny nowe obiekty 2D Square. Do każdego z nich dodaj komponent `BoxCollider2D`, ułóż z tych obiektów labirynt.
- [ ] Do metody `OnCollisionEnter2D(Collision2D col)` dodaj kod który będzie usuwał gracza z gry `Destroy(gameObject)`. Teraz gdy gracz dotknie ścian labiryntu, zostanie usunięty z gry.
- [ ] Utwórz nowy tag "Wall" do wszystkich ścian w labiryncie dodaj ten tag. 
- [ ] Utwórz nowy obiekt 2D Circle i dodaj do niego komponent `CircleCollider2D` zmień kolor tego obiektu na zielony, możesz utworzyć ich więcej i porozmieszczać je po labiryncie
- [ ] Utwórz nowy tag "Point" i dodaj go do wszystkich obiektów kółek
- [ ] Do metody `OnCollisionEnter2D(Collision2D col)` dopisz logikę sprawdzającą tag obiektu z którym się kolidowało, jeśli tag jest równy "Wall" powinniśmy nadal usuwać gracza z planszy, jeśli tag jest równy "Point" powinniśmy usuwać obiekt z którym kolidowaliśmy
- [ ] Utwórz zmienną która będzie przetrzymywała aktualny stan punktów gracza, zwiększaj tą zmienną w metodzie `OnCollisionEnter2D(Collision2D col)` gdy kolidujesz z kółkiem, będą to nasze punkty
- [ ] Utwórz nowy obiekt na scenie typu tekstowego `Canvas/Text`, następnie w swoim skrypcie utwórz nową zmienną typu `TextMeshProUGUI` i przeciągnij do niej w inspektorze obiekt z textem który wcześniej stworzyłeś
- [ ] Wpisuj do stworzonej zmiennej stan punktów za każdym razem gdy zostanie on zmieniony
- [ ] Spójrz na swój kod, czy możesz wydzielić jakieś jego części na osobne funkcje? Jeśli tak to spróbuj!

## Zadania - prefaby
Prefaby to specjalne pliki które pozwalają zapisać w projekcie obiekty które normalnie trzymamy na scenie. Prefaby tworzymy przeciągając obiekt ze sceny do plików projektowych, w ten oto sposób możemy tworzyć gotowe do przyszłego użycia obiekty. Aby taki prefab użyć, wystarczy, że w swoim skrypcie utworzysz zmienną typu `GameObject`, możesz następnie do tej zmiennej w inspektorze przeciągnąć dany prefab. Następnie dzięki metodzie `Instantiate` możesz pojawić dany prefab na scenę.
- [ ] Dodaj na scenę nowy obiekt 2D Circle, dodaj do tego obiektu komponent `CircleCollider2D` oraz ustaw wcześniej stworzony tag `Point`
- [ ] Przeciągnij utworzony obiekt do plików projektu, możesz następnie usunąć ten obiekt ze sceny (masz go teraz zapisanego w plikach gry)
- [ ] Utwórz nowy obiekt i nazwij go na przykład "spawner" dodaj do tego obiektu nowy customowy skrypt
- [ ] W skrypcie utwórz zmienną typu `GameObject`, w inspektorze przeciągnij twój prefab z plików do okienka z tą zmienną
- [ ] Przy uzyciu metody `Instantiate` utwórz metodę która będzie pojawiać twój prefab w losowych miejscach na planszy co `float x` sekund
```csharp
public GameObject pointPrefab;

void Update()
{
	Vector2 spawnPosition = new Vector2(0,0);
	Quaterion spawnRotation = Quaternion.identity;
	// pojawi obiekt "pointPrefab" w pozycji 0, 0
	Instantiate(pointPrefab, spawnPosition, spawnRotation);
	// pamiętaj, że ten kod będzie pojawiał obiekt co klatkę, a chcemy co parę sekund!
}
```

## Dla chętnych
Jeśli tu dotarłeś, to znaczy, że jesteś już uzbrojony w najważniejszą wiedzę potrzebną abyś mógł stworzyć własną grę. Spróbuj zrobić klona jednej z wylistowanych niżej gier.
### Pong (2D) 

**Działanie: **
- każdy gracz ma paletkę którą kontroluje ruszając nią góra/dół 
- w grze jest piłeczka która lata od bramki do bramki 
- zadaniem każdego gracza jest odbijanie piłki tak aby wbić gola przeciwnikowi 

**Wskazówki: **
- poruszaj paletkami modyfikując komponent transform 
- obsługuj zderzenie piłeczki z paletką/ścianą przy użyciu OnCollisionEnter2D 

**Kroki implementacji: **
- ruch paletki (dla obu graczy) 
- ruch piłeczki 
- obsługa kolizji z różnymi elementami gry (ściany/paletki/bramki) 
- obliczanie i wyświetlanie punktów !dla chętnych! - resetowanie gry 
- ograniczenie punktów do danej wartości (np 3) oraz wyświetlanie` "wygrał gracz nr <wygrany gracz>!"` gdy któryś z graczy osiągnie odpowiednią liczbę punktów 
### Combo clicker (2D) 

**Działanie: **
- na ekranie pojawiają się losowo kwadraty z jednym z czterech znaków (Q, W, E oraz R) 
- gdy gracz wciśnie przycisk wypisany na jednym z kwadratów, dany kwadrat znika 
- kwadraty dają ilość punktów zależną od szybkości reakcji 
- kwadrat znika gdy gracz przez x sekund nie wciśnie odpowiedniego przycisku 

**Wskazówki: **
- ustaw timer w kwadracie aby wiedzieć ile czasu minęło odkąd kwadrat znalazł się na planszy 
- utwórz prefab "kwadrat" aby ułatwić dalsze działanie gry 

**Kroki implementacji: **
- utworzenie prefabu kwadrat 
- skrypt "Square" obsługujący wybieranie losowego przycisku / rejestrowania odpowiedniego kliknięcia / badania ilości punktów 
- skrypt "SquareManager" obsługujący pojawianie się kwadratów 
- obliczanie punktów !dla chętnych! 
- wyświetlanie w jakiś sposób jak długo dany kwadrat znajduje się już na planszy (np zmieniając jego wielkość) - możliwość resetowania gry 
- wyświetlanie punktów na bierząco 
### Łapanie owoców 

**Działanie: **
- gracz steruje koszykiem 
- od góry planszy spadają owoce oraz inne przedmioty 
- celem gracza jest łapanie tylko owoców do swojego koszyka 

**Wskazówki: **
- ruszaj koszykiem modyfikując komponent transform 
- owoce mogą spadać przy użyciu komponentu RigidBody2D 

**Kroki Implementacji: **
- stwórz prefab "Fruit" który będzie przechowywał informację o tym czy jest to owoc czy nie, oraz będzie posiadał logikę spadku
- stwórz skrypt "FruitManager" który będzie pojawiał owoce na stałej wysokości i losowej szerokości 
- stwórz skrypt do obsługi ruchu koszyka oraz kolizji z owocami !dla chętnych! 
- zaimplementuj obliczanie i wyświetlanie punktów na ekranie 
- dodaj mechanikę która będzie karać gracza negatywnymi punktami za upuszczanie owoców, oraz łapanie obiektów nie będących owocami 
### Spadające bloki 

**Działanie: **
- gracz może ruszać się w każdą stronę 
- od góry do dołu lecą bloki
- zetknięcie się gracza z blokiem powoduje jego śmierć 

**Wskazówki: **
- obsługuj kolizję przy użyciu OnCollisionEnter2D 
- bloki jak i poruszanie się gracza może zostać napisane poprzez użycie komponentu transform

**Kroki implementacji: **
- skrypt do poruszania się gracza 
- skrypt do poruszania się bloku 
- prefab danego bloku 
- skrypt do pojawiania bloków 

WYZWANIA DLA CHĘTNYCH 
- Klon Flappy Bird 
- Klon Asteroids