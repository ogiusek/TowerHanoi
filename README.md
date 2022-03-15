# **Wieża Hanoi**
## **Jak wygląda gra ?**
### Gra jest złożona z trzech kołków na których są ułożone krążki.
### Krązki są ułożone od największych do najmniejszych.
### W aplikacji konsolowej są od lewej do prawej ,
### A na mojej [stronie internetowej](http://hanoi.simplecreator.pl/) od dołu do góry.
## **Zasady**
- ### Celem gry jest przełożenie wszystkich krążków na inny kołek
- ### Krążki mogą być tylko na większych od siebie krążkach
- ### Można przełożyć tylko jeden krążek na raz
## **Sposób użycia**
### Na stronie internetwej
#### Po włączeniu strony widzimy stronę o takim wyglądnie
#### ![Wygląd strony](https://user-images.githubusercontent.com/100357263/158378197-98005b82-f973-4316-9be1-cd2ad7733dc6.PNG)
#### Jeśli tak nie wygląda to powinna zacząć działać po włączeniu strony w oknie incognito
#### Aby przenieść krążek należy kliknąć na kołek z którego chcemy przenieść krążek
#### ![Jak wybrać skąd](https://user-images.githubusercontent.com/100357263/158378199-e685c32c-e6bf-4927-9ba0-49699a113b85.PNG)
#### Jak widać kołek powinien się podświetlić na zielono teraz możemy wybrać gdzie chcemy przenieść krążek
#### ![Po przeniesieniu](https://user-images.githubusercontent.com/100357263/158378187-02383abe-1feb-40d1-8058-47f7fab61544.PNG)
#### Jak widać wszystko działa
#### W celu dostania podpowiedzi klikamy "automatycznie"
#### Krążek powinien się przenieść w miejsce ,które pozwoli najszybciej ułożyć całą wieże na trzecim kołku
#### Jeśli ktoś jest zainteresowany kodem strony internetowej wystarczy kliknąć f12
### W konsoli
#### Aby przełożyć z jednego kołka na drugi podajemy ich numery
#### przykładowo:
##### Przed przeniesieniem podałem wartość skąd dokąd czyli z pierwszego kołka na trzeci
##### ![Przed przeniesieniem](https://user-images.githubusercontent.com/100357263/158376429-baaa7b64-fb52-4698-baab-3b5f17aa91e8.PNG) 
##### Jak widać najmniejszy krążek został przeniesiony na trzeci kołek
##### ![Po przeniesieniu](https://user-images.githubusercontent.com/100357263/158376425-ba6f5495-191e-44da-82d7-0784180dbaa2.PNG)
##### Aby dostać podpowiedź należy napisać: a, ai albo zostawić puste
##### Kod jest pod plikiem Program.cs
## **Jak działa Ai**
### Metoda przyjmuje dwie informacje który krążek ma przenieść i na który kołek
### Jeśli krążek jest na kołku na którym powinien być wywołuje samą siebie i każe przenieść mniejszy krążek na siebie
### Jeśli nie sprawdza czy może coś przenieść krążek na kołek i jeśli może to przenosi
### W przeciwnym wypadku wywołuje się z mniejszym kołkiem i innym kołkiem
