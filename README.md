# OzonContestJan25
Основной раунд Route 256: Middle C#-разработчик, Январь 2025

<details><summary>Результаты решений на Ozon Techpoint:</summary>
<img src="https://github.com/user-attachments/assets/8b8f0bdf-f4bc-43db-91ec-77744b800db9">
 </details>

 <p>Все тесты (из открытого доступа) находятся в папке Tests</p>
 
<h3>Задания:</h3>
<details>
<summary>1. Dark room</summary>
<h2 dir="auto">
<p dir="auto" align="center">1. Dark room</p></h2>
<p dir="auto" align="center">За частичное решение можно получить 5 баллов, за полное — 11 баллов</p>
<p dir="auto" align="center"> ограничение по времени на тест: 1.000 Мс</p>
<p dir="auto" align="center"> ограничение по памяти на тест: 256 мегабайт</p>

<h3 dir="auto">Условие задачи</h3>
<p dir="auto">У Коли дома отключился свет, а он очень боится темноты, но, к счастью, с помощью фонариков можно осветить комнату. Помогите Коле узнать, сколько нужно фонариков и их координаты и направление, чтобы комната Коли была полностью освещена?

Вам даётся комната размером n в длину и m в ширину. Вам нужно ввести минимальное количество необходимых фонариков, а на следующих строках — их координаты и направление для полного освещения. В одной координате не может быть больше одного фонарика.

Координата в данной системе может быть охарактеризована в виде пары (x,y), где:
x — координата по оси X, которая направлена вертикально вниз  от 1 до n;
y — координата по оси Y, которая направлена горизонтально вправо от 1 до m;

Если фонарик находится в координате (i,j), он освещает эту начальную координату.
Затем, в зависимости от направления фонарика, рекурсивно освещает координаты:
<ul>
<li>Если фонарик направлен вниз (D), освещаются координаты: (i+1,j-1), (i+1, j), (i+1, j+1).</li>
<li>Если фонарик направлен вверх (U), освещаются координаты: (i-1, j-1), (i-1, j), (i-1, j+1).</li>
<li>Если фонарик направлен влево (L), освещаются координаты: (i-1, j-1), (i, j-1), (i+1, j-1).</li>
<li>Если фонарик направлен вправо (R), освещаются координаты: (i-1, j+1), (i, j+1), (i+1, j+1).</li>
</ul>
Освещение фонарика двигается рекурсивно в том же направлении, пока луч не достигает стены.</p>

<h3 dir="auto">Входные данные</h3>

<p dir="auto">Первая строка содержит целое число t (1≤t≤100) — количество наборов входных данных.</p>
<p dir="auto">Целые числа n, m (1≤n,m≤10<sup>9</sup>) — размер комнаты.</p>

<h3 dir="auto">Выходные данные</h3>
<p dir="auto">n — количество фонариков;
x, y, d — координата и направление.

Если существует несколько возможных ответов, вы можете вывести любой.</p>

<h3 dir="auto">Пример</h3>
<p dir="auto"><strong>Входные данные</strong></p>

```
3
3 4
1 4
3 3
```

<p dir="auto"><strong>Выходные данные</strong></p>

```
2
1 1 D
3 4 U
1
1 1 R
2
1 1 R
3 3 L
```
</details>
<details>
<summary>2. Валидация</summary>
<h2 dir="auto">
<p dir="auto" align="center">2. Валидация</p></h2>
<p dir="auto" align="center">За частичное решение можно получить 8 баллов, за полное — 17 баллов</p>
<p dir="auto" align="center"> ограничение по времени на тест: 2.000 Мс</p>
<p dir="auto" align="center"> ограничение по памяти на тест: 256 мегабайт</p>

<h3 dir="auto">Условие задачи</h3>
<p dir="auto">
Ваш коллега получил задачу:

Дан список товаров. У каждого товара есть:
<ul>
<li>название — непустая строка, состоящая из не более чем 10 строчных латинских букв;</li>
<li>цена — целое число от 1 до 10<sup>9</sup>.</li>
</ul>

Все названия товаров уникальны.

По этому списку строится строчка, в которой перечислены названия товаров с ценами в любом порядке, но не должно быть двух товаров с одинаковой ценой. Например, если в исходном списке есть 2 или более товаров с одинаковой ценой, то в результирующей строке должен быть ровно один из этих товаров. Если в списке есть товар с уникальной ценой, он обязательно должен быть перечислен в результирующей строке.

Требования к оформлению:
<ul>
<li>товары в строке должны быть разделены символом , (запятая);</li>
<li>название и цена каждого товара должны быть разделены символом : (двоеточие);</li>
<li>пробелы и иные символы недопустимы;</li>
<li>цена товара не содержит ведущих нулей.</li>
</ul>

Ваша задача — по исходному списку и строке определить, соответствует ли строка списку.
</p>

<h3 dir="auto">Входные данные</h3>
<p dir="auto">Каждый тест состоит из нескольких наборов входных данных.</p>
<p dir="auto">Первая строка содержит целое число t (1≤t≤10<sup>5</sup>) — количество наборов входных данных.</p>
<p dir="auto">
Далее следуют описания наборов входных данных.

Первая строка каждого набора входных данных содержит целое число n (1≤n≤10<sup>5</sup>) — количество товаров в списке.

Следующие n строк каждого набора входных данных содержат строку name<sub>i</sub> и целое число price<sub>i</sub>, разделенные пробелом — название и стоимость товара. Название товара непустое, состоит из не более чем 10 строчных латинских букв. Стоимость товара положительная и не превосходит 10<sup>9</sup>. Все названия товаров уникальны.

Последняя строка каждого набора входных данных содержит строку, которую сгенерировал ваш коллега. Гарантируется, что эта строка непустая и содержит только цифры, строчные латинские буквы, запятые и двоеточия.

Гарантируется, что сумма n по всем наборам входных данных не превосходит 10<sup>5</sup>. Гарантируется, что сумма длин всех сгенерированных строк не больше 3 Мб.</p>

<h3 dir="auto">Выходные данные</h3>
<p dir="auto">Выведите t строк, i-я из них должна содержать ответ на i-й набор входных данных — YES или NO.

В третьем наборе входных данных в строке нет товара с ценой 1.
В четвертом наборе входных данных в строке нет товара с ценой 2.
В пятом наборе входных данных в строке есть несуществующий товар b с ценой 1.
В шестом наборе входных данных в строке есть несуществующий товар d с ценой 4.
В седьмом наборе входных данных строка не соответствует формату.
В восьмом наборе входных данных в строке нет товара с ценой 1.
В девятом наборе входных данных в строке цена товара abc содержит ведущие нули.</p>

<h3 dir="auto">Пример</h3>
<p dir="auto"><strong>Входные данные</strong></p>

```
9
3
a 1
b 2
c 3
a:1,c:3,b:2
3
a 1
b 2
c 2
c:2,a:1
3
a 1
b 2
c 2
b:2,c:2
3
a 1
b 2
c 2
a:1,a:1,a:1,a:1
3
a 1
b 2
c 2
b:1
3
a 1
b 2
c 2
d:4,a:1,c:2
3
a 1
b 2
c 2
abcdef
3
a 1
b 2
c 2
a:12345678901234567890,c:2
1
abc 123
abc:0123
```

<p dir="auto"><strong>Выходные данные</strong></p>

```
YES
YES
NO
NO
NO
NO
NO
NO
NO
```
</details>
<details>
<summary>3. Похожие строки</summary>
<h2 dir="auto">
<p dir="auto" align="center">3. Похожие строки</p></h2>
<p dir="auto" align="center">За частичное решение можно получить 7 или 14 баллов, за полное — 19 баллов</p>
<p dir="auto" align="center"> ограничение по времени на тест: 2.000 Мс</p>
<p dir="auto" align="center"> ограничение по памяти на тест: 256 мегабайт</p>

<h3 dir="auto">Условие задачи</h3>
<p dir="auto">
Маркетологам компании «Ozion» поступило задание — придумать уникальный слоган для новой рекламной компании.

У компании очень большая и креативная команда, поэтому слоган решили собирать из слов. Для этого каждый сотрудник должен предложить какое-то слово для слогана.

Вы работает программистом в компании «Ozion» и хотите помочь. Маркетологам интересно, как много похожих слов они вам прислали.

Вам дается число t — общее количество наборов со строками.

Каждый набор содержит N строк. Назовём 2 строки похожими, если у них совпадают все буквы на чётных позициях или все буквы на нечётных.

Ваша задача — помочь креативным маркетологам найти количество пар похожих строк.</p>

<h3 dir="auto">Входные данные</h3>
<p dir="auto">Каждый тест состоит из нескольких наборов входных данных.</p>
<p dir="auto">Первая строка содержит целое число t (1≤t≤100) — количество наборов входных данных.</p>
<p dir="auto">Вторая строка каждого набора входных данных содержит целое число число n — количество строк, (1≤n≤10<sup>6</sup>).

Следующие n строк каждого набора входных данных содержат множество строк s<sub>i</sub> (1≤∣s<sub>i</sub>∣≤10<sup>6</sup>). Строки состоят из строчных латинских букв.

Гарантируется, что сумма n по всем наборам входных данных не больше 10<sup>6</sup>. Гарантируется, что сумма длин всех строк по всем наборам входных данных не больше 10<sup>6</sup>.</p>

<h3 dir="auto">Выходные данные</h3>
<p dir="auto">Для каждого набора входных данных выведите количество пар похожих строк.

Похожие пары: abcde и adcbe, abcde и xbxde</p>

<h3 dir="auto">Пример</h3>
<p dir="auto"><strong>Входные данные</strong></p>

```
7
3
ababa
ababa
ababa
3
asd
das
sda
2
abca
abc
4
aaaa
aaaa
aaaa
aaa
2
aa
aa
2
a
a
2
a
b
```

<p dir="auto"><strong>Выходные данные</strong></p>

```
3
0
1
6
1
1
0
```
</details>
<details>
<summary>4. Коробки. Коробки. Коробки</summary>
<h2 dir="auto">
<p dir="auto" align="center">4. Коробки. Коробки. Коробки</p></h2>
<p dir="auto" align="center">За частичное решение можно получить 11 баллов, за полное — 23 балла</p>
<p dir="auto" align="center"> ограничение по времени на тест: 2.000 Мс</p>
<p dir="auto" align="center"> ограничение по памяти на тест: 256 мегабайт</p>

<h3 dir="auto">Условие задачи</h3>
<p dir="auto">
Вы работаете в компании, занимающейся логистикой и доставкой товаров. Ваша задача — разработать систему для отслеживания перемещения коробок внутри склада.

Коробка размером a на b представлена в матрице из ASCII-символов в виде прямоугольника, где a символов в ширину и b символов в длину (см. пример). Коробки также могут быть вложены друг в друга для удобства транспортировки и хранения. Каждая коробка в левом верхнем углу имеет уникальный номер, состоящий из букв латинского алфавита и цифр, длиной не больше 3 символов.

Чтобы было удобнее хранить данные о перемещении коробок, представьте все коробки, учитывая их вложенность друг в друга, в формате JSON. А для коробок, в которых нет вложенных коробок, выведите их площадь (см.пример).</p>

<h3 dir="auto">Входные данные</h3>
<p dir="auto">Каждый тест состоит из нескольких наборов входных данных.</p>
<p dir="auto">Первая строка содержит целое число t (1≤t≤10<sup>4</sup>) — количество наборов входных данных.</p>
<p dir="auto">Первая строка каждого набора входных данных состоит из двух целых чисел N и M. (3≤N,M≤3⋅10<sup>5</sup>). Гарантируется, что сумма N⋅M по всем тестам не больше 10<sup>6</sup>.

Далее описана матрица из N строк по M символов каждая.

Матрица состоит из символов «.», «+», «-», «|» для описания коробок, а также латинских символов и цифр для описания названий коробок. Коробки не пересекаются и не совпадают по своим границам.</p>

<h3 dir="auto">Выходные данные</h3>
<p dir="auto">Выведите структуру коробок в формате JSON, где для коробок без вложенности представлена их площадь. Порядок вывода коробок внутри одной коробки не имеет значения.

Размер выходных данных не должен превосходить 20МБ.</p>

<h3 dir="auto">Пример</h3>
<p dir="auto"><strong>Входные данные</strong></p>

```
5
11 12
+----------+
|A+---+....|
|.|B52|....|
|.+---+....|
|+-------+.|
||r9.+--+|.|
||+-+|Ip||.|
|||7||..||.|
||+-++--+|.|
|+-------+.|
+----------+
3 3
...
...
...
3 5
+---+
|I63|
+---+
8 9
+------+.
|256...|.
|......|.
|......|.
+------+.
....+---+
....|R..|
....+---+
3 9
+-++-++-+
|2||5||6|
+-++-++-+
```

<p dir="auto"><strong>Выходные данные</strong></p>

```
[
  {
    "A": {
      "B52": 3,
      "r9": {
        "7": 1,
        "Ip": 4
      }
    }
  },
  {},
  {
    "I63": 3
  },
  {
    "256": 18,
    "R": 3
  },
  {
    "2": 1,
    "5": 1,
    "6": 1
  }
]
```
</details>
