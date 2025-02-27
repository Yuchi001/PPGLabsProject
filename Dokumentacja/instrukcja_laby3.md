Zajęcia drugie - metody i pętle

---
### Spis Treści
1. [Wstęp](##wstęp)
2. [Dokumentacja potrzebna do dzisiejszych zajęć](##dokumentacja)
3. [Zadania](##zadania)
	- komponenty oraz klasy
	- dla chętnych
4. [Podpowiedzi](##podpowiedzi)

---
## Wstęp
Na dzisiejszych zajęciach dowiesz się czym konkretnie są komponenty skrypty oraz obiekty. Dotychczas używałeś/aś wszystkich tych wspomnianych wyżej zagadnień, te zajęcia mają na celu uświadomienie Cię gdzie kiedy i jak z nich korzystasz.
- Komponenty - mogą być dołączane do obiektów na scenie oraz prefabów, pozwalają nam dodawać specyficzne zachowania. Jeśli na pusty obiekt dodamy komponent `Rigidbody2D` sprawi on, że nasz obiekt będzie poddawał się prawom fizyki, zauważ, ze już korzystasz z komponentów, spójrz na obiekt `Player` lub na prefab 'Bullet', wszędzie tam znajdziesz różną gammę komponentów.
- Skrypty - jest to specjalny rodzaj komponentów, umożliwiają pisanie własnych zachowań które można później - tak jak komponenty - dodawać do obiektów na scenie oraz prefabów. Zauważ, że skrypty na których pracowałeś/aś dotychczas to są właśnie te customowe komponenty o których mowa.
- Klasy - zagadnienie bezpośrednio powiązane ze skryptami, każdy skrypt jest klasą, lecz nie każda klasa jest skryptem. Zwykłą klasę od skryptu odróżnia fakt, że klasa która jest skryptem musi "dziedziczyć" po klasie `MonoBehaviour`. Zbyt skomplikowane póki co? Nie przejmuj się, tą wiedzę jeszcze nabędziesz.

---
## Dokumentacja
- [Komponenty, Skrypty oraz Klasy](dokumentacja_KOMPONENTY.pdf)

---
## Zadania
- ***Komponenty***
	- [ ] W plikach projektu w folderze prefabs, znajdziesz specjalny prefab `ExplosionParticles` jest to efekt specjalny który wygląda jak eksplozja. Korzystając z tego prefaba w skrypcie `Asteroid` w metodzie `Hit` dodaj mechanikę pojawiania tego efektu, pamiętaj jednak, że gdy efekt skończy animacje, powinien zostać usunięty ze sceny.
	- [ ] Korzystając z użytego w zadaniu `1` prefabu `ExplosionParticles` w skrypcie `Player` gdy gracz umiera dodaj mechanikę pojawiania efektu, jak powyżej, pamiętaj aby w odpowiednim momencie go usunąć.
	- [ ] Na scenie pod obiektem `Canvas` został utworzony obiekt `scoreText`, posiada on komponent `TextMeshProUGUI` który pozwala na wyświetlanie tekstu na ekranie. Utwórz nową zmienną typu `TextMeshProUGUI` w skrypcie `AsteroidSpawner`, nie zapomnij zainicjować jej w inspektorze. Następnie korzystając z tej zmiennej zmieniaj wartość punktową na aktualną.
	- [ ] W skrypcie `AsteroidSpawner` znajduje się metoda `StopSpawning` gdy gracz umiera powinien użyć tej metody aby zatrzymać pojawianie nowych asteroid.
	- [ ] Na scenie pod obiektem `Canvas` został utworzony obiekt `restartUI`, posiada on komponent `TextMeshProUGUI` który wyświetla wiadomość "Press R to restart the game", gdy gracz umrze obiekt ten powinien zostać włączony, zaś na samym obiekcie powinien być komponent który po wykryciu przycisku 'R' powinien rzeczywiście zrestartować grę.
- ***Dla chętnych***
	- [ ] Wyczyść kod z niepotrzebnych komentarzy, spacji, tabów etc. Zadbaj o jego czytelność. 
	- [ ] W programowaniu mamy pewne konwencje, jedna z nich głosi iż nie powinniśmy zmiennym dawać dostępu publicznego bez wyraźnej potrzeby, zauważ, że gdy chcemy wyświetlić zmienną w inspektorze, to nadajemy jej właśnie publiczny dostęp, co kłóci się z tą konwencją - naprawmy więc ten problem. Jeśli chcemy aby dostęp do zmiennej był prywatny, a jednocześnie chcemy takową zmienną udostępnić na inspektor, wystarczy, że użyjemy tak zwanego [Atrybutu](https://docs.unity3d.com/6000.0/Documentation/Manual/unity-attributes.html). Konkretny atrybut z którego skorzystamy to `SerializeField`. Przejrzyj swój kod, znajdź miejsca w którym zastosowanie tego atrybutu poprawi jego jakość. Oto przykład użycia:
```C#
public class MyClass : MonoBehaviour
{
	// Tak robiłeś/aś dotychczas
	public int testVariableOne;
	// Tak powinno to wyglądać
	[SerializeField] private int testVariableTwo;
}
```

---
## Podpowiedzi
- Jeśli chcesz włączyć/wyłączyć obiekt na scenie, wystarczy, że użyjesz notacji z kropką na `GameObject` który chcesz włączyć/wyłączyć, oto jak to zrobić: `gameObject.SetActive(true) // lub false żeby wyłączyć`
- Aby załadować na nowo startową scenę, wystarczy, że użyjesz tego kodu: `SceneManager.LoadScene(0);` kod ten ładuje scenę o indeksie `0`, jako, że mamy tylko jedną scenę - załaduje tą samą scenę na nowo
- Metoda `Destroy()` może przyjąć dodatkowy parametr - określa on ile czasu ma upłynąć zanim obiekt zostanie rzeczywiście zniszczony, może być to przydatne gdy chcemy zniszczyć obiekt w konkretnym momencie w czasie: `Destroy(gameObject, 3.0f) // zniszczy obiekt w trzy sekundy`
- Aby dostać się do pola `text` w komponencie `TextMeshProUGUI` wystarczy, że użyjesz notacji z kropką 
```C#
public TextMeshProUGUI textField; // nie zapomnij przypisać wartości w inspektorze!

void Start()
{
	textField.text = "Mój cudowny tekst!";
}
```
- Jeśli chcesz użyć metody jakiegoś skryptu z pozycji innego skryptu, wystarczy, że będziesz posiadać referencję obiektu na którym znajduje się ten skrypt (zmienną do której wpiszesz dany obiekt), a następnie użyjesz notacji z kropką np.
```C#
public AsteroidSpawner spawner; // nie zapomnij przypisać wartości w inspektorze!

void Start()
{
	spawner.AddPoints();
}
```