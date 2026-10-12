
// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter name: ");
//string name = "+";
//int age = 30;
//char gender = 'm';
//Console.WriteLine($"{name} {age} {gender}");
//int name=Convert
//byte a = 4;
//byte b = (byte)(a + 70);
//Console.WriteLine($"{a} {b}");
//byte a = 4;
//int b = a + 70;
//Console.WriteLine(a);


/*int a = 4;
byte b = a + 70;
Console.WriteLine(b);*/

/*string name="Victor";
if(name=="Alex")
    Console.WriteLine("Вас зовут Tomas");
else if (name=="Bob")
    Console.WriteLine("Вас зовут Vasya");
else 
   Console.WriteLine(name);*/


/*Console.WriteLine("Введите сумму вклада:");
double a=Convert.ToDouble(Console.ReadLine());
if(a<100)
{
    a += a * 0.05;
}
else if(a<200)
{
    a += a * 0.07;
}
else 
{
    a += a * 0.1;
} 
Console.WriteLine(a);*/


/*double a=Convert.ToDouble(Console.ReadLine());
switch(a)
{
    case 100:
        a += a * 0.04;
        break;
    case 200:
        a += a * 0.05;
        break;
    case 300:
        a += a * 0.06;
        break;
    case 400:
        a += a * 0.07;
        break;
    default:
        a+=a * 0.08;
        break;
}
Console.WriteLine(a);*/

       
        /*Console.Write("Введите число a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine(a + b);
                break;
            case "-":
                Console.WriteLine(a - b);
                break;
            case "*":
                Console.WriteLine(a * b);
                break;
            case "/":
                if (b != 0)
                    Console.WriteLine(a / b);
                else
                    Console.WriteLine("Ошибка: деление на ноль.");
                break;
            default:
                Console.WriteLine("Неверная операция.");
                break;
        }

        Console.WriteLine($"a = {a}");

        string name = "Aboba";
for (int i=0;i<10;i++)
    Console.WriteLine(name);
    */

            
        
/*string name = "Aboba";
foreach (var i in name)
{
    Console.WriteLine(i);
}*/


/*string name = "Aboba";
int i = 0;
while (i<10)
{
  Console.WriteLine(name);
  i++;
}*/


/*string name = "Aboba";
int i = 0;
do
{
    Console.WriteLine(name);
    i++;
} while (i > 10);*/


/*string name = "Aboba";

for (int i = 0;i<10;i++)

{
    if (i == 5)
        continue;
    Console.WriteLine(i);
    
}*/

/*int[]a=new int[10];
double[] b=new double[15];
Console.WriteLine(a);
Console.WriteLine(b);*/
        
/*string name = "Aboba";
int[] massiv = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
Console.WriteLine(massiv);
Console.WriteLine(massiv.Length);
Console.WriteLine(massiv[1]);*/

/*string name = "Aboba";
int[] massiv = new int[5];
for (int i = 0; i < 5; i++)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (var elem in massiv)
{
    Console.WriteLine("--------");
    Console.WriteLine(elem);
}*/

/*string name = "Aboba";
Random random = new Random();
int[] massiv = new int[5];
for (int i = 0; i < 5; i++)
{
    massiv[i] = random.Next(1,10);
}

foreach (var elem in massiv)
{
    Console.WriteLine("--------");
    Console.WriteLine(elem);
}
Console.WriteLine(Array.IndexOf(massiv, 1,5));*/

/*string name = "Aboba";
Random random = new Random();
int[] massiv = new int[5];
for (int i = 0; i < 5; i++)
{
    massiv[i] = random.Next(1,10);
}

foreach (var elem in massiv)
{
    Console.WriteLine("--------");
    Console.WriteLine(elem);
}
Console.WriteLine(massiv.Length);*/

/*Random rand=new Random();
Console.WriteLine(rand.Next(0, 10));

List<string> words=new List<string> ();
words.Add ("Простые слова");
words.Add ("Ничего");
words.Add ("Как дела");
Console.WriteLine(words.Count);

List<int> massiv=new List<int> ();
massiv.Add (1); 
massiv.Add (3);
massiv.Add (4);
Console.WriteLine(massiv.Count);*/



/*class Program
{
    static void Main()
    {
        // Создаём список и сразу добавляем 5 имён
        List<string> names = new List<string>
        {
            "Анна",
            "Борис",
            "Виктория",
            "Глеб",
            "Дарья"
        };

        Console.WriteLine("Список после создания (5 имён):");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Добавляем ещё 5 имён в конец списка
        names.Add("Евгений");
        names.Add("Жанна");
        names.Add("Игорь");
        names.Add("Кира");
        names.Add("Лев");

        Console.WriteLine("\nСписок после добавления ещё 5 имён:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        Console.ReadKey(); // Чтобы консоль не закрывалась сразу
    }
}*/


/*class Program
{
    static void Main()
    {
        // Создаём список с 5 именами
        var names = new List<string> { "Анна", "Борис", "Виктория", "Глеб", "Дарья" };

        Console.WriteLine("Список после создания (5 имён):");
        foreach (var name in names)
            Console.WriteLine(name);

        // Добавляем сразу 5 имён одним разом
        names.AddRange(new[] { "Евгений", "Жанна", "Игорь", "Кира", "Лев" });

        Console.WriteLine("\nСписок после добавления ещё 5 имён:");
        foreach (var name in names)
            Console.WriteLine(name);

        Console.ReadKey();
    }
}
*/

/*class Program
{
    static void Main()
    {
        // 1. Создаём список с 5 именами
        var names = new List<string> { "Анна", "Борис", "Виктория", "Глеб", "Дарья" };

        PrintList("После создания (5 имён):", names);

        // 2. Добавляем сразу 5 имён одним разом
        names.AddRange(new[] { "Евгений", "Жанна", "Игорь", "Кира", "Лев" });
        PrintList("\nПосле добавления ещё 5 имён:", names);

        // 3. Удаление по одному по выбранному индексу
        Console.Write("\nВведите индекс имени для удаления (0–9): ");
        if (int.TryParse(Console.ReadLine(), out int indexToRemove) &&
            indexToRemove >= 0 && indexToRemove < names.Count)
        {
            string removed = names[indexToRemove];
            names.RemoveAt(indexToRemove);
            Console.WriteLine($"Удалено имя по индексу {indexToRemove}: {removed}");
            PrintList("Список после удаления одного имени:", names);
        }
        else
        {
            Console.WriteLine("Неверный индекс, удаление не выполнено.");
        }

        // 4. Удаление сразу нескольких имён по индексам
        Console.Write("\nВведите индексы для удаления через пробел (например: 2 4 7): ");
        string? input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            var indicesToRemove = new List<int>();
            foreach (var part in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.TryParse(part, out int idx) && idx >= 0 && idx < names.Count)
                {
                    indicesToRemove.Add(idx);
                }
                else
                {
                    Console.WriteLine($"Пропущен неверный индекс: {part}");
                }
            }

            // Удаляем в порядке убывания индексов, чтобы не «съезжали» позиции
            foreach (int idx in indicesToRemove.OrderByDescending(x => x))
            {
                string removed = names[idx];
                names.RemoveAt(idx);
                Console.WriteLine($"Удалено имя по индексу {idx}: {removed}");
            }

            PrintList("\nСписок после удаления нескольких имён:", names);
        }

        Console.ReadKey();
    }

    static void PrintList(string title, List<string> list)
    {
        Console.WriteLine(title);
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i}: {list[i]}");
        }
    }
}*/

      
/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var numbers = new List<int>();
        var random = new Random();

        int count = 20;
        for (int i = 0; i < count; i++)
        {
            numbers.Add(random.Next(1, 11));
        }

        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(", ", numbers));

        // Подсчёт количества вхождений
        var counts = new Dictionary<int, int>();
        foreach (var n in numbers)
        {
            if (counts.ContainsKey(n))
                counts[n]++;
            else
                counts[n] = 1;
        }

        // Элементы, которые встречаются ровно 1 раз
        var uniqueOnce = new List<int>();
        foreach (var kvp in counts)
        {
            if (kvp.Value == 1)
                uniqueOnce.Add(kvp.Key);
        }

        Console.WriteLine("\nЭлементы, которые встречаются ровно 1 раз:");
        if (uniqueOnce.Count == 0)
            Console.WriteLine("Таких элементов нет.");
        else
            Console.WriteLine(string.Join(", ", uniqueOnce));

        // Все уникальные значения (distinct)
        var distinctValues = new List<int>();
        var seen = new HashSet<int>();
        foreach (var n in numbers)
        {
            if (!seen.Contains(n))
            {
                seen.Add(n);
                distinctValues.Add(n);
            }
        }

        Console.WriteLine("\nВсе уникальные значения:");
        Console.WriteLine(string.Join(", ", distinctValues));
    }
}*/

/*Random rand=new Random();

List<int> numbers=new List<int>();
List<int> numbers1=new List<int>();
for (int i = 0; i < 20; i++)
{
    numbers.Add(rand.Next(1,20));
}
Console.WriteLine("Имена массива");
foreach (var name in numbers)
{
  Console.WriteLine(name+" ");  
}


for (int i=0;i<numbers.Count; i++)
{
    int count=0;
    for (int j=0;j<numbers.Count;j++)
    {
        if (numbers[i] == numbers[j])
        {
            count++;
        }
    }
    if (count==1)
    {
        numbers1.Add(numbers[i]);
    }
}
Console.WriteLine("Новый массив");
       
foreach (var num in numbers1)
{
 Console.Write(num+"");
}*/


/*
        using System;
        using System.Collections.Generic;

        class Program
        {
            static void Main()
            {
                Random rand = new Random();
                List<int> numbers = new List<int>();
                List<int> uniqueOnce = new List<int>(); // элементы, которые встречаются ровно 1 раз

                // Заполняем 20 числами от 1 до 20 (Next(1, 21) → значения 1..20)
                for (int i = 0; i < 20; i++)
                {
                    numbers.Add(rand.Next(1, 21));
                }

                Console.WriteLine("Исходный массив:");
                foreach (var n in numbers)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();

                // Ищем элементы, которые встречаются ровно 1 раз (двойной цикл)
                for (int i = 0; i < numbers.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            count++;
                        }
                    }

                    if (count == 1)
                    {
                        uniqueOnce.Add(numbers[i]);
                    }
                }

                Console.WriteLine("\nЭлементы, которые встречаются ровно 1 раз:");
                if (uniqueOnce.Count == 0)
                {
                    Console.WriteLine("Таких элементов нет.");
                }
                else
                {
                    foreach (var value in uniqueOnce)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine();
                }
            }
        }


*/
/*
Console.WriteLine("Hello, World!");
string? name=Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
*/


/*
Console.Write("Введите имя: ");
string? name= Console.ReadLine();

Console.Write("Введите возраст: ");
int age=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
double height=Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary=Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name} Возраст: {age} Рост:{height} Зарплата:{salary} ");
*/

/*
string name="Tom";
int age=10;
double height=1.5;
Console.WriteLine($"Имя:  {name}  Возраст: {age}   Рост: {height}");*/

/*
Console.Write("Введите количество: ");      // курсор остаётся после двоеточия
int quantity = int.Parse(Console.ReadLine());

Console.WriteLine($"Итого: {quantity * 100}"); // вывод с переходом на новую строку
*/

/*
string name = Console.ReadLine(); // ждёт, пока пользователь введёт текст и нажмёт Enter
*/

/*
int quantity = int.Parse(Console.ReadLine()); 
// или безопаснее:
if (int.TryParse(Console.ReadLine(), out int qty)) {  }
*/

/*
int code = Console.Read(); // например, ввёл «A» → вернёт 65
char ch = (char)code;
Console.WriteLine(ch);
Console.WriteLine(code);
*/

/*
var key = Console.ReadKey(); // реагирует сразу на нажатие любой клавиши
char c = key.KeyChar;        // символ (если есть)
ConsoleKey k = key.Key;      // код клавиши (например, ConsoleKey.Enter)
*/

/*
Console.WriteLine("Меню:");
Console.WriteLine("1 — Добавить товар");
Console.WriteLine("2 — Показать корзину");
Console.Write("Выберите пункт (нажмите цифру): ");

var key = Console.ReadKey(intercept: true); // intercept: true скрывает символ в консоли

switch (key.Key)
        {
            case ConsoleKey.D1:
                AddProduct();
                break;
            case ConsoleKey.D2:
                ShowCart();
                break;
        }
*/

/*
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Заказ успешно оформлен!");
Console.ResetColor(); // вернуть стандартный цвет
*/

/*

using System;
using System.Collections.Generic;
using System.Linq;

// Интерфейс ICalculable
public interface ICalculable
{
    decimal Calculate();
}

// Класс Product
public class Product : ICalculable
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public decimal Calculate() => Price;
}

// Класс OrderItem
public class OrderItem : ICalculable
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal Calculate() => Product.Price * Quantity;
}

class Program
{
    // Список доступных товаров
    private static List<Product> availableProducts = new List<Product>
    {
        new Product("Ноутбук", 55000m),
        new Product("Кроссовки", 2990m),
        new Product("Рюкзак", 1500m),
        new Product("Наушники", 3500m),
        new Product("Чайник", 1200m)
    };

    // Корзина
    private static List<OrderItem> cart = new List<OrderItem>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Система заказов ===");
            Console.WriteLine("1 — Добавить товар");
            Console.WriteLine("2 — Показать корзину");
            Console.WriteLine("3 — Оформить заказ");
            Console.WriteLine("0 — Выход");
            Console.Write("Ваш выбор: ");

            var key = Console.ReadKey(intercept: true);
            Console.WriteLine();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    AddProduct();
                    break;
                case ConsoleKey.D2:
                    ShowCart();
                    break;
                case ConsoleKey.D3:
                    Checkout();
                    break;
                case ConsoleKey.D0:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.WriteLine("\n=== Доступные товары ===");
        for (int i = 0; i < availableProducts.Count; i++)
        {
            var p = availableProducts[i];
            Console.WriteLine($"{i + 1} — {p.Name}  ({p.Price:F2} руб.)");
        }

        Console.Write("\nВыберите номер товара: ");
        if (!int.TryParse(Console.ReadLine(), out int productIndex) ||
            productIndex < 1 || productIndex > availableProducts.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверный номер товара.");
            Console.ResetColor();
            Console.ReadKey();
            return;
        }

        Console.Write("Введите количество: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Некорректное количество.");
            Console.ResetColor();
            Console.ReadKey();
            return;
        }

        var selectedProduct = availableProducts[productIndex - 1];

        // Проверяем, есть ли уже такой товар в корзине
        var existing = cart.FirstOrDefault(item => item.Product.Name == selectedProduct.Name);
        if (existing != null)
        {
            existing.Quantity += quantity;
        }
        else
        {
            cart.Add(new OrderItem(selectedProduct, quantity));
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Товар «{selectedProduct.Name}» добавлен в корзину (×{quantity}).");
        Console.ResetColor();
        Console.ReadKey();
    }

    static void ShowCart()
    {
        Console.WriteLine("\n=== Корзина ===");

        if (cart.Count == 0)
        {
            Console.WriteLine("Корзина пуста.");
            Console.ReadKey();
            return;
        }

        decimal total = 0;
        foreach (var item in cart)
        {
            decimal itemTotal = item.Calculate();
            total += itemTotal;
            Console.WriteLine($"{item.Product.Name}  ×{item.Quantity}  —  {itemTotal:F2} руб.");
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Итого: {total:F2} руб.");
        Console.ReadKey();
    }

    static void Checkout()
    {
        Console.WriteLine("\n=== Оформление заказа ===");

        if (cart.Count == 0)
        {
            Console.WriteLine("Корзина пуста — нечего оформлять.");
            Console.ReadKey();
            return;
        }

        decimal total = cart.Sum(item => item.Calculate());

        Console.WriteLine($"Товаров в заказе: {cart.Count}");
        Console.WriteLine($"Сумма заказа: {total:F2} руб.");
        Console.Write("\nПодтвердить заказ? ( Нажмите клавишу-Y): ");

        var confirm = Console.ReadKey(intercept: true);
        Console.WriteLine();

        if (confirm.Key == ConsoleKey.Y)
        {
            cart.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Заказ успешно оформлен! Корзина очищена.");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Оформление отменено.");
        }

        Console.ReadKey();
    }
}
*/


/*
using System;
using System.Collections.Generic;
using System.Linq;
 
//Интерфейс ICalulable

public interface ICalculable
{
      
      decimal Schitaty();
}

// Класс Sport

public class Sport : ICalculable
{
    public string Imya { get; set; }
    public decimal Cena {get; set; }
    
    public Sport(string imya, decimal cena)
    {
        Imya=imya;
        Cena=cena;
    } 
    
    public decimal Schitaty() => Cena;
}

public class Zanyatie:ICalculable
{
    public Sport Sport { get; set; }
    public int Kolvo { get; set; }
    
    public Zanyatie (Sport sport, int kolvo)
    {
    Sport=sport;
    Kolvo=kolvo;
    }
    
    public decimal Schitaty() => Sport.Cena* Kolvo;
    
}

class Program
{
    //Список доступных товаров
    private static List<Sport> spisokSports= new List<Sport>
    {
        new Sport("Бокс",2200m),
        new Sport("Борьба",2400m),
        new Sport("Плавание",2250m),
        new Sport("Леегкая атлетика",2205m),
        new Sport("Гимнастика",4200m),
        new Sport("Шахматы",2270m)
    };
    
    //Выбор
    private static List<Zanyatie> vibor= new List<Zanyatie>();
    
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n===Система заказов===");
            Console.WriteLine("1-Добавить секцию");
            Console.WriteLine("2-Показать выбор");
            Console.WriteLine("3-Оформить выбор");
            Console.WriteLine("0-Выход");
        
            var priem= Console.ReadKey(intercept: true);
            Console.WriteLine();
        
            switch (priem.Key)
            {
                case ConsoleKey.D1:
                    DobSport();
                    break;
                case ConsoleKey.D2:
                    PokVibor();
                    break;
                case ConsoleKey.D3:
                    Prinyaty();
                    break;
                case ConsoleKey.D0:
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный выбор, побробуйте снова.");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
            
            }
        }
    }
    
    static void DobSport()
    {
        Console.WriteLine("\n===Доступные секции===");
        for (int i=0;i<spisokSports.Count; i++)
        {
            var s=spisokSports[i];
            Console.WriteLine($"{i + 1}-{s.Imya}  ({s.Cena:F2} руб)");
        }
        
        Console.Write("\nВыберите номер секции: ");
        if (!int.TryParse(Console.ReadLine(), out int sportIndex) ||
            sportIndex <1 || sportIndex > spisokSports.Count)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Неверный номер товара.");
            Console.ResetColor();
            Console.ReadKey();
            return;
        }
        
        Console.Write("Введите количество спортсменов: ");
        if (!int.TryParse(Console.ReadLine(), out int kolvo) || kolvo<1)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Некорректное количество.");
            Console.ResetColor();
            Console.ReadKey();
            return;
        }
        
        var viborSports=spisokSports[sportIndex-1];
        
        //Проверяемся тренируемся мы в такой секции уже
        var uprajnenie=vibor.FirstOrDefault(deystvie => deystvie.Sport.Imya==viborSports.Imya);
        if (uprajnenie !=null)
        {
            uprajnenie.Kolvo +=kolvo;
        }
        else
        {
            vibor.Add(new Zanyatie(viborSports,kolvo));
        }
        
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine($"Секция {viborSports.Imya} добавлен в список (*{kolvo}).");
        Console.ResetColor();
        Console.ReadKey();
    }
    
    static void PokVibor()
    {
        Console.WriteLine("\n===Выбор===");
        
        if (vibor.Count == 0)
        {
            Console.WriteLine("Выбор не сделан.");
            Console.ReadKey();
            return;
        }
        
        decimal obshiy=0;
        foreach (var vib in vibor)
        {
            decimal viborObshiy=vib.Schitaty();
            obshiy += viborObshiy;
            Console.WriteLine($"{vib.Sport.Imya} * {vib.Kolvo} - {viborObshiy:F2} руб.");
        }
        
        Console.WriteLine(new string('-',30));
        Console.WriteLine($"Итого:  {obshiy:F2} руб.");
        Console.ReadKey();
       
    }

    static void Prinyaty()
    {
        Console.WriteLine("\n===Принять в секцию===");

        if (vibor.Count == 0)
        {
            Console.WriteLine("В секцию не взяли - некого оформлять.");
            Console.ReadKey();
            return;
        }

        decimal obshiy = vibor.Sum(vib => vib.Schitaty());

        Console.WriteLine($"Спортсменов в секции: {vibor.Count}");
        Console.WriteLine($"Сумма оплаты:  {obshiy:F2} руб.");
        Console.Write("\nПодтвердить выбор секции? (Нажмите клавишу -Y): ");

        var info = Console.ReadKey(intercept: true);
        Console.WriteLine();

        if (info.Key == ConsoleKey.Y)
        {
            vibor.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("На секцию приняли - зовите друзей. ");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Не приняли - приходите в следующий раз.");
        }

        Console.ReadKey();
    }
    
}
*/

/*
var hello="Hello to world";
Console.WriteLine(hello);
var c=23;
Console.WriteLine(c);
*/

/*
int a;
a=20;
Console.WriteLine(a);
*/
/*
var c;
c=20;
Console.WriteLine(c);
*/

/*
string hello="Привет мир";
Console.WriteLine(hello);
Console.WriteLine("Добро пожаловать в с#!");
Console.WriteLine("Пока мир...");
Console.WriteLine(24.5);
*/

/*
Console.Write("Введите свое имя: ");
string? name = Console.ReadLine();
Console.WriteLine($"Привет {name}");
*/

/*
byte a=4;
int b=a+455;
Console.WriteLine(a);
Console.WriteLine(b);
*/

/*
byte a=4;
byte b=a+495;
Console.WriteLine(a);
Console.WriteLine(b);
*/

/*
byte a=4;
ushort b=a;
Console.WriteLine(a);
Console.WriteLine(b);
*/

/*
ushort a=4;
byte b=(byte)a;
Console.WriteLine(a);
Console.WriteLine(b);*/

/*
int a=4;
int b=5;
byte c=(byte)(a+b);
Console.WriteLine(c);
*/

/*
string? name=Console.ReadLine();
if (name=="Tom")

    Console.WriteLine("Вас зовут Tomas");

else if (name=="Bod")
    Console.WriteLine("Вас зовут Robert");
else if(name=="John")
    Console.WriteLine("Вас зовут Jonathan");
else
    Console.WriteLine("Неизвестное имя");
*/

/*
int x = 3444;
int y = 56;

int z = x < y ? (x + y) : (x - y);
Console.WriteLine(z);  
*/


/*
Console.Write("Введите сумму вклада: ");
decimal a=Convert.ToDecimal(Console.ReadLine());
 

if (a < 100)
{
    a = a * 0.95m+15m;
}
else if (a < 200)
{
    a = a * 0.9m+15m;
}
else
{
    a = a * 0.85m+15m;
}    
Console.WriteLine($"Итоговая сумма: {a}");
*/


/*
Console.Write("Введите число: ");
int? number=Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("case 1");
        goto case 5;
        break;
    case 3:
        Console.WriteLine("case 3");
        break;
    case 5:
        Console.WriteLine("case 5");
        break;
    default:
        Console.WriteLine("default case");
        break;
}
*/


        /*Console.Write("Введите сумму вклада: ");
        decimal a = Convert.ToDecimal(Console.ReadLine());

        decimal z = a < 100 
            ? a * 0.95m 
            : (a < 200 
                ? a * 0.97m 
                : (a < 300 
                    ? a * 0.98m 
                    : a));

        Console.WriteLine($"Итоговая сумма: {z}");*/

/*
Console.Write("Введите сумму вклада: ");
decimal a=Convert.ToDecimal(Console.ReadLine());
decimal z = a < 100
    ? a * 0.98m
    : (a < 200
        ? a * 0.95m
        : (a < 300
            ? a * 0.93m
            : (a < 400
                ? a * 0.9m
                : a)));
Console.WriteLine($"Итоговая сумма: {z}");
*/

/*
for (int i=1; i<4;i++)
    Console.WriteLine(i);
*/

/*
for (int i=1;i<12;i++)
    Console.WriteLine(i);
*/    
    
/*
int i = 6;
do
{
    Console.WriteLine(i);
    i++
        ;
}
while (i < 0);
*/

/*
int i = 6;
do
{
   Console.WriteLine(i);
   i--;
} 
while (i<0);
*/

/*
int i=6;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}
*/

/*
int i = 7;
while (i>0)
{
    Console.WriteLine(i);
    i--;
}
*/

/*
foreach(var c in "Ivan")
{
    Console.WriteLine(c);
}
*/

/*
foreach (var s in "colombo")
{
       Console.WriteLine(s);     
} 
*/   

/*
for (int i = 0; i < 9; i++)
{
       if (i==5)
           break;
       Console.WriteLine(i);
}
*/

/*
for (int c = 2; c < 12; c++)
{
    if (c == 5) 
        break;
    Console.WriteLine(c);
} 
*/   

/*
for (int i = 0; i < 9; i++)
{
      if (i==5)
          continue;
      Console.WriteLine(i);
}
*/

/*
for (int d = 3; d <= 123; d++)
{
     if (d==3 || d==67 || d==78 )
         continue;
     else if (d==86)
         break;
     Console.WriteLine(d);
}
*/

/*
Console.Write("Введите число: ");
decimal a=decimal.Parse(Console.ReadLine());
decimal z;
if(a>100 && a<300)
{
    
    z=a*0.95m;
}
else
{
    z = a;
}
Console.WriteLine(z);
*/

/*
Console.Write("Введите число: ");
decimal a = decimal.Parse(Console.ReadLine());
decimal c=(a>100 && a<300)?a*0.95m:a;
Console.WriteLine(c);
*/

/*
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        if (!decimal.TryParse(input, out decimal a))
        {
            Console.WriteLine("Некорректное число.");
            return;
        }

        decimal z;
        if (a > 100 && a <= 300)
        {
            z = a * 0.95m;
        }
        else
        {
            z = a;
        }
        Console.WriteLine(z);
*/

/*
Console.WriteLine("Введите число: ");
decimal a=Convert.ToDecimal(Console.ReadLine());
decimal b=a<=100 && a>50?a*0.95m:
a<=200?a*0.9m:
a<=300?a*0.85m:
a<=400?a*0.8m:
a>400?a*0.75m:a;
Console.WriteLine(b);
*/
/*
        using System.Collections.Generic;

        var discounts = new Dictionary<decimal, decimal>
        {
            [100] = 0.90m,
            [200] = 0.85m,
            [300] = 0.80m,
            [400] = 0.75m
        };

        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        if (!decimal.TryParse(input, out decimal a))
        {
            Console.WriteLine("Некорректное число.");
            return;
        }

        decimal z = discounts.TryGetValue(a, out var factor) ? a * factor : a;

        Console.WriteLine(z);*/

/*
        using System.Collections.Generic;

// Правило: от (включительно) до (не включительно), коэффициент
        var rules = new List<(decimal From, decimal To, decimal Factor)>
        {
            (0, 100, 0.95m),    // [0, 100) → 0.95
            (100, 200, 0.90m),  // [100, 200) → 0.90
            (200, 300, 0.85m),  // [200, 300) → 0.85
            (300, 401, 0.80m)   // [300, 401) → 0.80 (т.е. до 400 включительно)
        };

        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        if (!decimal.TryParse(input, out decimal a))
        {
            Console.WriteLine("Некорректное число.");
            return;
        }

        decimal factor = 1.0m; // по умолчанию без скидки
        bool found = false;

        foreach (var rule in rules)
        {
            if (a >= rule.From && a < rule.To)
            {
                factor = rule.Factor;
                found = true;
                break;
            }
        }

        decimal z = a * factor;
        Console.WriteLine(z);
        */

/*
using System.Collections.Generic;
using System.Data;

var rules = new List<(decimal From, decimal To, decimal Factor)>
{
    (0, 100m, 0.95m),
    (101m, 200m, 0.9m),
    (201m, 300m, 0.85m),
    (301m, 400m, 0.8m),
    (401m, 500m, 0.75m),
};
Console.Write("Введите число: ");
string input = Console.ReadLine();
if(!decimal.TryParse(input, out decimal result))
{
    Console.WriteLine("Некоректное число, введите снова.");
    return;
}

decimal factor = 1.0m;
bool found = false;
foreach (var rule in rules)
{
    if (rule.From <= result && result <= rule.To)
    {
        factor = rule.Factor;
        found = true;
        break;
    } 
}
decimal z=result*factor;
Console.WriteLine(z);
*/      
/*
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        try
        {
            decimal a = decimal.Parse(input);
            Console.WriteLine($"Вы ввели число: {a}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Введено не число, попробуйте снова");
        }
        catch (Exception ex)
        {
            // На всякий случай ловим другие ошибки
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
      */ 

/*
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        if (!decimal.TryParse(input, out decimal a))
        {
            Console.WriteLine("Некорректное число");
            return;
        }

        Console.WriteLine($"Вы ввели число: {a}");
*/

/*
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        decimal? a = null;
        bool ok = decimal.TryParse(input, out var temp);

        if (ok)
        {
            a = temp;
            Console.WriteLine($"Вы ввели число: {a}");
        }
        else
        {
            Console.WriteLine("Некорректное число");
            return;
        }

// Дальше можно безопасно проверять: if (a.HasValue) { ... }
*/

/*
        decimal a;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out a))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Некорректное число, попробуйте снова.");
            }
        }

        Console.WriteLine($"Вы ввели: {a}");
*/
/*
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal a))  // ✅ объявляем и сразу используем
            {
                Console.WriteLine($"Вы ввели: {a}");
                isValid = true;
            }
            else
            {
                Console.WriteLine("Некорректное число, попробуйте снова.");
            }
        }
        decimal a = 0m;          // ✅ сразу присваиваем значение (компилятор спокоен)
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out a))  // ✅ передаём уже инициализированную переменную
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Некорректное число, попробуйте снова.");
            }
        }

        Console.WriteLine($"Вы ввели: {a}");     // ✅ теперь тут a точно есть

*/
/*
        string choice;
        do
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Рассчитать скидку");
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // логика расчёта
                Console.WriteLine("Расчёт скидки...");
            }
        } while (choice != "0");
*/

     /*   var rules = new List<(decimal From, decimal To, decimal Factor)>
        {
            (0, 100, 0.95m),
            (100, 200, 0.90m),
            (200, 300, 0.85m),
            (300, 401, 0.80m)
        };

        string choice;
        decimal a = 0m;
        do
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Показать правила скидок");
            Console.WriteLine("2. Рассчитать итоговую сумму");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите пункт: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                foreach (var rule in rules)
                {
                    Console.WriteLine($"[{rule.From}, {rule.To}) → {rule.Factor:P2}");
                }
            }
            else if (choice == "2")
            {
                
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write("Введите сумму: ");
                    string input = Console.ReadLine();
                    if (decimal.TryParse(input, out a))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите корректное число.");
                    }
                }

                decimal factor = 1.0m;
                foreach (var rule in rules)
                {
                    if (a >= rule.From && a < rule.To)
                    {
                        factor = rule.Factor;
                        break;
                    }
                }

                Console.WriteLine($"Итоговая сумма: {a * factor}");
            }
        } while (choice != "0");

        Console.WriteLine("Программа завершена.");
*/
/*
     class Program
     {
         static void Main()
         { 
             Console.Write("Введите N (>2): ");
             
                 if (!int.TryParse(Console.ReadLine(), out int n) || n <= 2)
                 {
                     Console.WriteLine("N должно быть больше 2.");
                     return;
                 }

                 int[] fib = new int[n];
                 fib[0] = 1;
                 fib[1] = 1;

                 for (int k = 2; k < n; k++)
                 {
                     fib[k] = fib[k - 2] + fib[k - 1];
                 }

                 Console.WriteLine($"Первые {n} чисел Фибоначи: ");
                 PrintArray(fib);
             
         }

         static void PrintArray(int[] arr)
         {
             foreach (var value in arr)
             {
                 Console.Write(value + " ");
                 
             }
             Console.WriteLine();
         }
     }
     */
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N (>2): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 2)
        {
            Console.WriteLine("N должно быть целым числом больше 2.");
            return;
        }
        
        Console.Write(" Введите число A: ");
        int.TryParse(Console.ReadLine(),out int a);
        
        Console.Write("Введите число B: ");
        int.TryParse(Console.ReadLine(), out int b);

        int[] arr = new int [n];
        arr[0] = a;
        arr[1] = b;

        long sum = (long)a + b;

        for (int k = 2; k < n; k++)
        {
            arr[k] = (int)sum;
            sum += arr[k];
        }
        Console.WriteLine($"Массив размера {n}, A={a}, B={b}: ");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
*/

/*
using System;


class Program
{
    static void Main()
    {
        const int rows = 4;
        const int cols=4;
        int[,] arr = new int[rows, cols];
        var random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = random.Next(11) - 5;
            }
        }
        
        Console.WriteLine("Исходный массив: ");
        PrintArray(arr, rows, cols);

        int minOriginal = arr[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr[i, j] < minOriginal)
                {
                    minOriginal = arr[i, j];
                }
            }
        }
        Console.WriteLine($"Миниальный элемент исходного массива {minOriginal}");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr[i, j] % 2 == 0)
                {
                    arr[i, j] *= 2;
                }
                else
                {
                    arr[i, j] *= 3;
                }
            }
        }
        
        Console.WriteLine("\nИзменненый массив:");
        PrintArray(arr, rows, cols);

        int minNew = arr[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr[i, j] < minNew)
                {
                    minNew = arr[i, j];
                }
            }
        }

        Console.WriteLine($"Миниальный элемент изменненого массива {minNew}");

    }

    static void PrintArray(int[,] arr, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"{arr[i,j],4}");
            }
            Console.WriteLine();
        }
    }
}
*/    

/*
using System;

class Program
{
    static void Main()
    {
        Console.Write(" Введите размерность массива (N>0): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Ошибка нужно ввести целое число больше 0");
            return;
        }

        int[] arr = new int [n];
        var random = new Random();
        const int min = -13;
        const int max = 11;

        int rangeLenght = max - min + 1;

        long sum = 0;
        
        Console.WriteLine($"\nМассив ({n} элементов ) в диапозоне [{min};{max}]: ");

        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(rangeLenght) + min;
            sum += arr[i];
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine(($"Сумма элементов массива: {sum}"));
    }
}

*/


/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размерность массива (N>0): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Ошибка нужно ввести целое число больше 0");
            return;
        }

        int[] arr = new int [n];
        var random = new Random();
        const int min = -19;
        const int max = 25;

        int rangeLenght = max - min + 1;
        
        Console.WriteLine($"Массив ({n} элементов в диапазоне [{min};{max}:");

        for (int i = 0; i < n; i++)
        {
            arr[i]=random.Next(rangeLenght)+min;
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();

        long product = 1;
        bool hasOddPosition = false;

        for (int i = 0; i < n; i += 2)
        {
            product *= arr[i];
            hasOddPosition = true;
        }
        
        if (hasOddPosition)
            {
                Console.WriteLine($"Произведение элементов с нечетными номерами :{product}");
            }
        else
        {
            Console.WriteLine("В массиве нет элементов с нечетными номерами");
        }
    }
}
*/

/*
using System;

struct Point
{
    public int x, y;
}

class Program
{
    static void Main()
    {
        //Примитив: копия значения
        int x = 10;
        int y = x;
        y = 99;
        Console.WriteLine($"int:x={x}, y={y}"); //x=10, y=99
        
        //Структура: тоже копия (value type)
        var p1 = new Point { x = 1, y = 2 };
        var p2 = p1;
        p2.x = 99;
        
        Console.WriteLine($"struct:p1.x={p1.x}, p1.y={p1.y}, p2.x={p2.x}, p2.y={p2.y}");
    }
}
*/

/*
using System;

class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        var a = new Person{Name="Alice", Age=30};
        var b = a; //это ссылка на тот же обьект

        b.Age = 40;
        
        Console.WriteLine($"class: a.Age={a.Age}, b.Age={b.Age}");//оба 40
        Console.WriteLine($"a и b ссылаются на один и тот же обьект: {ReferenceEquals(a,b)}");
    }
}
*/

/*
using System;

class Person
{
    public string Name;
    public int Age;
    
    public Person(string name, int age)
        {
        Name = name;
        Age = age;
        }
    public Person(Person other)
        {
        Name = other.Name;
        Age = other.Age;
        }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new Person("Alice", 30);
        var b = new Person(a);//Настоящая копия

        b.Age = 40;
        Console.WriteLine($"copy constructor: a.Age={a.Age}, b.Age={b.Age}");
        Console.WriteLine($"a и b разные обьекты : {ReferenceEquals(a,b)}");
    }
}
*/

/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = list1;
        list2.Add(99);
        
        Console.WriteLine("После list2.Add(99) через ссылку:");
        Console.WriteLine($"list1: [{string.Join(", ", list1)}]");//1,2
        Console.WriteLine($"list2: [{string.Join(", ", list2)}]");
        
        var list3 = new List<int> { 10, 20, 30 };
        var list4=new List<int> (list3);//копия элементов
        list4.Add(999);
        
        Console.WriteLine("\nПосле list4.Add(999) с копией:");
        Console.WriteLine($"list3: [{string.Join(", ", list3)}]");//10,20,30
        Console.WriteLine($"list4: [{string.Join(", ", list4)}]");//10,20,30,999
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        int[][] arr1 = new int [2][];
        arr1[0]=new[] { 1, 2, 3 };
        arr1[1]=new[] { 4, 5, 6 };
        
        //Просте присваивание - это ссылки на строки
        int[][] arr2 = arr1;
        arr2[0][0] = 999;
        
        Console.WriteLine("arr1 после изменения через arr2( прорстое присваивание:)");
        PrintJagget(arr1);//[999,2,3][4,5,6]
        
        //Правильная копия :цикл +Array.Copy  для каждой строки
        int [][] arr3=new int [arr1.Length][];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr3[i]=new int [arr1[i].Length];
            Array.Copy(arr1[i], arr3[i], arr1[i].Length);
        }
        
        arr3[0][0]=777;
        
        Console.WriteLine("\narri и arr3 после изменения копии: ");
        Console.Write("arr1: ");
        PrintJagget(arr1);
        Console.Write("arr3: ");
        PrintJagget(arr3);
    }

    static void PrintJagget(int[][] arr)
    {
        foreach (var row in arr)
        {
            Console.Write($"[{string.Join(", ", row)}]");
        }
        Console.WriteLine();
    }
}
*/

/*
using System;
using System.Security.Cryptography;

class Program
 {
     static void Main()
     {
         string s1 = "Hello";
         string s2 = s1;

         s2 = s2 + " world";
         Console.WriteLine($"s1=\"{s1}\"");//Hello
         Console.WriteLine($"s2=\"{s2}\"");//Hello world
         Console.WriteLine($"s1 и s2 - разные обьекты : {ReferenceEquals(s1, s2)}");
     }
 }
*/

/*
     using System;

     class Program
     {
         static void Main()
         {
             int[][] arr1 = new int[3][];
             arr1[0] = new[] { 1, 2, 3 };
             arr1[1] = new[] { 4, 5, 6 };
             arr1[2] = new[] { 7, 8, 9 };

             // Копируем только 2 строки из 3, и в каждой строке — только 2 элемента из 3
             int rowsToCopy = 2;
             int elemsToCopy = 2;

             int[][] arr3 = new int[rowsToCopy][];
             for (int i = 0; i < rowsToCopy; i++)
             {
                 arr3[i] = new int[elemsToCopy];
                 Array.Copy(arr1[i], arr3[i], elemsToCopy);
             }

             Console.WriteLine("Исходный массив:");
             PrintJagged(arr1);

             Console.WriteLine("\nЧастичная копия (2 строки по 2 элемента):");
             PrintJagged(arr3);

             // Проверка независимости
             arr3[0][0] = 999;
             Console.WriteLine("\nПосле arr3[0][0] = 999:");
             Console.Write("arr1: ");
             PrintJagged(arr1);
             Console.Write("arr3: ");
             PrintJagged(arr3);
         }

         static void PrintJagged(int[][] arr)
         {
             foreach (var row in arr)
             {
                 Console.Write($"[{string.Join(", ", row)}] ");
             }
             Console.WriteLine();
         }
     }
*/

/*
using System;

class Program
{
    static void Main()
    {
        // Исходный массив — 3 строки разной длины
        int[][] arr1 = new int[3][];
        arr1[0] = new[] { 1, 2, 3, 4 };
        arr1[1] = new[] { 5, 6, 7 };
        arr1[2] = new[] { 8, 9 };

        Console.WriteLine("=== Исходный массив ===");
        PrintJagged("arr1", arr1);

        // ============================================
        // ВАРИАНТ 1: Копируем только N строк (полностью)
        // ============================================
        Console.WriteLine("\n=== Вариант 1: только 1 строку (первую) ===");

        int rowsToCopy1 = 1;

        int[][] arr3_1 = new int[rowsToCopy1][];
        for (int i = 0; i < rowsToCopy1; i++)
        {
            arr3_1[i] = new int[arr1[i].Length];
            Array.Copy(arr1[i], arr3_1[i], arr1[i].Length);
        }

        PrintJagged("arr3_1", arr3_1);

        // проверка независимости
        arr3_1[0][0] = 999;
        Console.WriteLine("После arr3_1[0][0] = 999:");
        PrintJagged("arr1  ", arr1);
        PrintJagged("arr3_1", arr3_1);

        // ============================================
        // ВАРИАНТ 2: Все строки, но только первый элемент из каждой
        // ============================================
        Console.WriteLine("\n=== Вариант 2: все строки, по 1 элементу из каждой ===");

        int[][] arr3_2 = new int[arr1.Length][];
        for (int i = 0; i < arr1.Length; i++)
        {
            int elementsToCopy = 1;
            arr3_2[i] = new int[elementsToCopy];
            Array.Copy(arr1[i], arr3_2[i], elementsToCopy);
        }

        PrintJagged("arr3_2", arr3_2);

        // проверка независимости
        arr3_2[0][0] = 777;
        Console.WriteLine("После arr3_2[0][0] = 777:");
        PrintJagged("arr1  ", arr1);
        PrintJagged("arr3_2", arr3_2);

        // ============================================
        // ВАРИАНТ 3: Копируем строки начиная с заданной
        // ============================================
        Console.WriteLine("\n=== Вариант 3: 1 строку начиная со 2-й (индекс 1) ===");

        int startRow = 1;
        int countRows = 1;

        int[][] arr3_3 = new int[countRows][];
        for (int i = 0; i < countRows; i++)
        {
            int srcIndex = startRow + i;
            arr3_3[i] = new int[arr1[srcIndex].Length];
            Array.Copy(arr1[srcIndex], arr3_3[i], arr1[srcIndex].Length);
        }

        PrintJagged("arr3_3", arr3_3);

        // проверка независимости
        arr3_3[0][0] = 555;
        Console.WriteLine("После arr3_3[0][0] = 555:");
        PrintJagged("arr1  ", arr1);
        PrintJagged("arr3_3", arr3_3);

        // ============================================
        // ВАРИАНТ 4: Все строки, но элементы начиная со 2-го
        // ============================================
        Console.WriteLine("\n=== Вариант 4: все строки, элементы со 2-го (индекс 1) ===");

        int[][] arr3_4 = new int[arr1.Length][];
        for (int i = 0; i < arr1.Length; i++)
        {
            int startElem = 1;
            int countElem = arr1[i].Length - startElem;

            arr3_4[i] = new int[countElem];
            Array.Copy(arr1[i], startElem, arr3_4[i], 0, countElem);
        }

        PrintJagged("arr3_4", arr3_4);

        // проверка независимости
        arr3_4[0][0] = 444;
        Console.WriteLine("После arr3_4[0][0] = 444:");
        PrintJagged("arr1  ", arr1);
        PrintJagged("arr3_4", arr3_4);
    }

    static void PrintJagged(string name, int[][] arr)
    {
        Console.Write($"{name}: ");
        foreach (var row in arr)
        {
            Console.Write($"[{string.Join(", ", row)}] ");
        }
        Console.WriteLine();
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива N: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Размер должен быть положительным числом.");
            return;
        }
        
        int[] arr = new int[n];
        
        // Заполняем массив (можно вручную или случайными числами)
        for (int i=0;i<n;i++)
            {
                Console.Write($"Элемент [{i}]: ");
                int.TryParse(Console.ReadLine(),out arr[i]) ;
            }

        int zeroCount = 0;
        for (int i= 0;i<arr.Length;i++)
        {
            if (arr[i] == 0)
                {
                zeroCount++;
                }
        }
        Console.WriteLine($"Количество нулей: {zeroCount}");

    }
}
*/

/*
int[] arr = { 1, 0, 3, 0, 5, 0, 7 };
int zeroCount = 0;
foreach (var value in arr)
{
    if (value == 0)
        {
        zeroCount++;
        }
}
Console.WriteLine($"Количество нулей {zeroCount}");
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива N: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Размер должен быть положительным числом.");
            return;
        }
        
        //Создаем генератор случайных чисел
        Random random = new Random();
        
        int[] arr = new int[n];
        
        //Заполняем массив случайными числами, например, в диапозоне [-5;6]
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(-5,6); //Next(min,max) -max не включенно
        }
        
        // Выводим массив, чтобы было видно, что там есть нули
        Console.Write("Массив: ");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
         
        }
        Console.WriteLine();
        
        // Считаем количество нулей
        int zeroCount = 0;
        foreach (var value in arr)
        {
            if (value == 0)
                {
                zeroCount++;
                }
        }
        Console.WriteLine($"Количество нулей: {zeroCount}");
    }
}
*/

/*
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива N: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Размер должен быть положительным числом");
            return;
        }
        
        Random random = new Random();
        int [] arr =new int[n];
         
        // Заполняем случайными числами (например, от -10 до 10)
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(-10,11);
        }
        
        //Вывод массива
        Console.Write("Массив: ");
        foreach (var value in arr)
            {
            Console.Write(value + " ");
            }
        Console.WriteLine();
        
        //Подсчёт нулей через LINQ
        int zeroCount = arr.Count(x => x == 0);
        
        Console.WriteLine($"Количество нулей: {zeroCount}");

    }
}
*/

/*
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        //Создаём пустой динамический список
        List<int> numbers = new List<int>();
        
        //Добавляем элементы (размер меняется автоматически)
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        
        Console.WriteLine("После добавления 3 элементов");
        foreach (var n in numbers)
            {
            Console.WriteLine(n + " ");
            }
            Console.WriteLine();//Перевод строки
            
            //Вставляем элемент по индексу (сдвигает остальные)
            numbers.Insert(1,15);//[10,15,20,30]
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($" {numbers[i]}");
            }
            
            Console.WriteLine();
            
            //Удаляем по значению (удаляет первое вхождение)
            numbers.Remove(20);//[10,15,30]
            
            Console.WriteLine("После Remove(20):");
            Console.WriteLine(string.Join(" ", numbers));// удобный вывод чисел
            
            // Можно сразу создать из массива
            int[] staticArr = { 100, 200, 300 };
            List<int> fromArray = new List<int>(staticArr);
            
            Console.WriteLine("Из статического массива:");
            Console.WriteLine(string.Join(", ", fromArray));
    }       
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректный размер.");
            return;
        }
        
        //Размер известен только в момент выполнения
        int[] arr = new int[n];
        
        //Заполняем случайными числами
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(1, 101);//от 1 до 100
        }
        
        // Вывод в консоль
        Console.Write("Массив: ");
        foreach (var x in arr)
            {
            Console.Write(x + " ");
            }
        Console.WriteLine();
        
        //Если нужно "увеличить" такой массив - делают новый и копируют
        int[] bigger = new int[arr.Length+5];
        Array.Copy(arr,bigger, arr.Length);
        
        Console.Write("Увеличенный массив (остальные нули): ");
        foreach (var x in bigger)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        int rows = 3;
        int[][] jagged = new int[rows][];
        
        //Каждая строка может быть своего размера
        jagged[0] = new int[]{ 1,  2, 3 };
        jagged[1] = new int[] { 4, 5 };
        jagged[2] = new int[] { 6, 7, 8, 9 };
        
        Console.WriteLine("Зубчатый массив");
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Строка {i} ");
            foreach (var val in jagged[i])
            {
                Console.Write( val + " " );
            }
            Console.WriteLine();

        }
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        //1.Создаем пустой динамический список (аналог динамического массива)
        List<int> numbers = new List<int>();

        Console.WriteLine("=== Начальное состояние ===");
        PrintList(numbers);
        
        //2.Add - добавление в конец списка
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        Console.WriteLine("\n=== После Add(10),Add(20),Add(30) ===");
        PrintList(numbers);
        
        //3. Insert - вставка по индексу (сдвигает остальные элементы)
        numbers.Insert(1,15);
        Console.WriteLine("\n=== После  Insert(1,15) ===");
        PrintList(numbers);
        
        //4.AddRange - добавление сразу нескольких элементов (из массива)
        int[] moreNumbers = { 40, 50, 60 };
        numbers.AddRange(moreNumbers);
        Console.WriteLine("\n=== После AddRange([40, 50, 60]) ===");
        PrintList(new List<int>(numbers));
        
        //5.InsertRange - вставка диапозона по индексу
        List<int> rangeToInsert = new List<int>{ 99, 98 };
        numbers.InsertRange(3, rangeToInsert);//Вставляем начиная с индекса 3
        Console.WriteLine("\n=== После InsertRange(3, [99, 98]) ===");
        PrintList(numbers);
        
        //6.Remove - удаление по значению (удаляем первое найденное вхождение)
        bool removed = numbers.Remove(99);//удаляем (99)
        Console.WriteLine($"\n=== После Remove(99) (удалено: {removed})");
        PrintList(numbers);
        
        //7. Removeat - удаляет по индексу
        numbers.RemoveAt(0);
        Console.WriteLine("\n=== После RemoveAt(0) ===");
        PrintList(numbers);
        
        //8. Clear - полная очистка списка
        numbers.Clear();
        Console.WriteLine("\n=== После Clear() ===");
        PrintList(numbers);
        
        //Добавим немного данных снова, чтобы показать RemoveAll (бонус часто нужен)
        numbers.AddRange(new[]{ 5, 10, 15, 10, 20});
        Console.WriteLine("\n=== Временный список для RemoveAll ===");
        PrintList(numbers);
        
        //RemoveAll - удаление всех элементов, подходящих под условие( например все 10)
        int removedCount = numbers.RemoveAll(x => x == 10);
        Console.WriteLine($"\n=== После RemoveAll(x=> x == 10) удалено 10");
        PrintList(numbers);
    }

    static void PrintList(List<int> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("Список пуст.");
            return;
        }
        
        //Вывод в виде: [10, 15, 20]
        string content = string.Join(", ", list);
        Console.WriteLine($"[{content}]");
        Console.WriteLine($"Count: {list.Count}");
        
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Пример с ref увеличение значения ===");
        int x = 5;
        Console.WriteLine($"До: {x}");
        Increase(ref x);
        Console.WriteLine($"После: {x}\n");
        
        Console.WriteLine("=== Пример с ref: обмен значения (swap) ===");
        int p = 1, q = 2;
        Console.WriteLine($"До swap:p={p}, q={q}");
        Swap(ref p, ref q);
        Console.WriteLine($"После swap:p={p}, q={q}\n");
        
        Console.WriteLine("=== Пример со структурой  и ref ===");
        var pt = new Point { X = 0, Y = 0 };
        Console.WriteLine($"До Move: ({pt.X},{pt.Y})\n");
        Move(ref pt,10, 20);
        Console.WriteLine($"После Move: ({pt.X}, {pt.Y})\n");
        
        Console.WriteLine("=== Пример с out: TryDivide ===");
        int res;
        if (TryDivide(10, 2, out res))
            Console.WriteLine($"Деление успешно Divide: ({res})");
        else
            Console.WriteLine("Деление не удалось");

        if (TryDivide(10, 0, out res))
        {
            Console.WriteLine($"Деление успешно: {res}");
        }
        else
        {
            Console.WriteLine("Деление не удалось(деление на ноль)\n");
        }
        
        Console.WriteLine("=== Пример с out: int.TryParse ===");
        string inputValid = "123";
        string inputInValid = "abc";

        if (int.TryParse(inputValid, out int numeralValid))
        {
            Console.WriteLine($"{inputValid} -> число: {numeralValid}, умножение на 2: {numeralValid*2}");
        }

        if (int.TryParse(inputInValid, out int numeralInvalid))
        {
            Console.WriteLine($"{inputInValid} -> число: {numeralInvalid}");
        }
        else
        {
            Console.WriteLine($"{inputInValid}  -> не удалось распарсить \n");
        }
        
        Console.WriteLine("=== Альтернатива: возврат кортежа вместо ref/out ===");
        var (quotient, success) = Divide(10, 3);
        if (success)
        {
            Console.WriteLine($"Кортеж: результат деления 10 /3 = {quotient}");
        }
        else
        {
            Console.WriteLine("Кортеж: деление на ноль не удалось");
        }

        var (qZero, sZero) = Divide(10, 0);
        if (sZero)
        {
            Console.WriteLine($"Кортеж : результат деления 10/0 = {qZero}");
        }
        else
        {
            Console.WriteLine("Кортеж: деление на 0 не удалось\n");
        }
    }
    
    //ref:можно читать и менять существующее значение
    static void Increase(ref int value)
    {
        Console.WriteLine($"Внутри Increase: текущее значение = {value}");
        value+=10;
    }
    
    //ref: классический пример swap (обмен)
    static void Swap(ref int a,ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    
    //ref: работа со структурой (без ref  была бы копия)
    struct Point
    {
        public int X, Y;
    }

    static void Move(ref Point p, int dx, int dy)
    {
        p.X += dx;
        p.Y += dy;
    }
    
    //out: метод обязан присвоить значение, удобно для паттерна Try
    static bool TryDivide(int a, int b, out int result)
    {
        if (b ==  0)
        {
            result = 0;
            return false;
        }
        result = a / b;
        return true;
    }
    
    // Кортеж как современная альтернатива ref/out  для возврата нескольких значений
    static (int quotient, bool success) Divide(int a, int b)
    {
        if (b == 0)
        {
            return (0, false);
        }
        else
        {
            return (a / b, true);
        }
    }
}
*/

/*
//Кортеж
using System;

class Program
{
    static void Main()
    {
        var result = GetUserInfo();
        Console.WriteLine($"Имя: {result.Name}, Возраст: {result.Age}");
        // Вывод: Имя :Alex, Возраст: 27
    }

    static (string Name, int Age) GetUserInfo()
    {
        return ("Alex", 27);
    }
}
*/

/*
var t = (City: "Moscow", Population: 13000000, IsCapital: true);

Console.WriteLine(t.City);         //Moscow
Console.WriteLine(t.Population);   //13000000
Console.WriteLine(t.IsCapital);    //True  

Console.WriteLine(t.Item1);        //Moscow
Console.WriteLine(t.Item2);        //13000000
Console.WriteLine(t.Item3);        //True
*/

/*
var (city, pop, isCap) = (City: "Saint Peterburg", Population: 5400000, IsCapital: false);

Console.WriteLine($"{city},население: {pop},столица: {isCap}");
// Saint Petersburg, население: 5400000, столица: False
*/

/*
using static System.Console;

class Program
{
    static void Main()
    {
        var (quotient, success) = Divide(10, 3);
        if (success)
            Console.WriteLine($"Результат: {quotient}");
        else
            Console.WriteLine("Деление не удалось");

        var (qZero, sZero) = Divide(10, 0);
        if (sZero)
            Console.WriteLine($"Результат: {qZero}");
        else
            Console.WriteLine("Деление на ноль — не удалось");
    }

    static (int Result, bool Success) Divide(int a, int b)
    {
        if (b == 0)
            return (0, false);
        return (a / b, true);
    }

}
*/

/*
using System;

class Program
{
    static void PrintPoint((int X, int Y) point)
    {
        Console.WriteLine($"Точка: X={point.X}, Y={point.Y}");
    }

    static void Main()
    {
        var p = (X: 10, Y: 20);
        PrintPoint(p);
    }
}
*/

/*
var users = new List<(string Name, int Age)>
{
    ("Anna", 25),
    ("Boris", 30),
    ("Cara", 28)
};

foreach (var u in users)
{
    Console.WriteLine($"{u.Name} - {u.Age} лет");
}
*/  

/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Кортеж: возрат нескольких значений ===");
        var (name, age, isMember) = getUserStatus();
        Console.WriteLine($"Пользователь: {name}, возраст: {age},участник клуба: {isMember}\n");
        
        Console.WriteLine("=== Кортеж результат операции ===");
        var (sum, product, count) = CalculateStats(new[] { 2, 4, 6 });
        Console.WriteLine($"Сумма: {sum}, Произведение: {product}, количество: {count}\n");
        
        Console.WriteLine("=== Кортеж в коллекции ===");
        var points = new List<(int X, int Y)>
        {
            (0, 0),
            (3, 4),
            (5, 12)
        };
        foreach (var p in points)
        {
            Console.WriteLine($"Точка ({p.X}, {p.Y})");
        }
        Console.WriteLine();
        
        Console.WriteLine("=== Передача кортежа в метод ===");
        ShowLocation(("Сочи", 435000));
        ShowLocation(("Сочи", 435000));
        ShowLocation(("Сочи", 435000));
        ShowLocation(("Сочи", 435000));
        ShowLocation(("Сочи", 435000));
    }

    static (string Name, int Age, bool Member) getUserStatus()
    {
        return ("Elena", 33, true);
    }

    static (int Sum, int Product, int Count) CalculateStats(int[] arr)
    {
        int sum = 0,
        product = 1;
        foreach (var x in arr)
        {
            sum += x;
            product *= x;
        }
        return (sum, product, arr.Length);
    }

    static void ShowLocation((string City, int Population) loc)
    {
        Console.WriteLine($"Город: {loc.City}, население: {loc.Population}");
    }
}
*/

/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var users = GetUserStatus();

        foreach (var u in   users)
        {
            Console.WriteLine($"Имя: {u.Name}, Возраст: {u.Age}, Участник: {u.IsMember}");
            
        }
    }

    static List<(string Name, int Age, bool IsMember)> GetUserStatus()
    {
        return new List<(string, int, bool)>
        {
            ("Elena", 33, true),
            ("Ivan", 24, false),
            ("Maria", 20, false),
            ("Sergey", 19, false),
            ("Alexey", 54, true)
        };
    }
}
*/

/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var users = GetUserStatus();
        for (int i = 0; i < users.Length; i++)
        {
            var u = users[i];
            Console.WriteLine($"{i+1}. {u.Name} ({u.Age}) - {(u.IsMember ? "участник" : "не участник")}");
            
        }
    }

    static (string Name, int Age, bool IsMember)[]GetUserStatus()
    {
        return new[]
        {
            ("Elena", 33, true),
            ("Ivan", 34, false),
            ("Alexey", 45, true),
            ("Sergey", 23, true)
        };
    }
}
*/

/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var users = GenerateUsers(19);
        foreach (var u in   users)
        {
           Console.WriteLine($"{u.Name,-10} | {u.Age,3} | {(u.IsMember ? "Да" : "Нет")} ");
        }
    }

    static List<(string Name, int Age, bool IsMember)> GenerateUsers(int count)
    {
        var names = new[] { "Elena", "Ivan", "Maria", "Dmitriy", "Oleg", "Sergey", "Alexey", "Olga", "Victor" };
        var result = new List<(string, int, bool)>();
        var rng = new Random();

        for (int i = 0; i < count; i++)
        {
            string name = names[rng.Next(names.Length)];
            int age = rng.Next(18, 65);
            bool isMember = rng.NextDouble() > 0.5; //50% шанс

            result.Add((name, age, isMember));
        }

        return result;
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Статические и экземплярные методы ===");
        
        // Статический - вызывается через класс, без обьекта
        int sum = MathHelper.Add(3, 7);
        Console.WriteLine($"MathHelper.Add(3, 7) = {sum}");
        
        //Экземплярный - нужен обьект
        var calk = new Calculator();
        int diff = calk.Subtract(10, 4);
        Console.WriteLine($"calk.Subtract(10, 4) = {diff}");
    }
}
static class MathHelper
{
    public static int Add(int a, int b) => a + b;
}

class Calculator
{
    public int Subtract(int a, int b) => a + b;
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Перегрузка методов ===");
        
        Console.WriteLine(Show(42));
        Console.WriteLine(Show(42,99));
        Console.WriteLine(Show("Hello"));
    }
     //Одинаковые имена - разные параметры

     static string Show(int x) => $"Int: {x}";
     static int Show(int x, int y) => x + y;
     static string Show(string x) => $"String: {x}";
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Необязательные параметры ===");
        
        Console.WriteLine(Greet("Ivan"));
        Console.WriteLine(Greet("Maria","Dr"));
        Console.WriteLine(Greet("Petr","Mr","!!!"));
    }
    
    //title и punct имеют значения по умолчанию
    static string Greet(string name, string title = "", string punct = ".")
    {
        return $"Hello {title} {name}! {punct}";
    }
    
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Статический и экземплярный метод ===");
        
        //Статический метод
        int sum = MathOper.Add(3, 87);
        Console.WriteLine($"MathOper.Add(3, 87) = {sum}");
        
        //Экземплярный метод
        var minus = new Minus();
        int razn = minus.Otn(12, 4);
        Console.WriteLine($"minus.Otn(12, 4) = {razn}");
    }
    
    static class MathOper
        {
        public static int Add(int a, int b)=> a + b;
        }
    
    class Minus
        {
        public int Otn(int a, int b)=> a - b;
        }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Перегрузка методов ===");
        
        Console.WriteLine(Show(32));
        Console.WriteLine(Show(23,45,26));
        Console.WriteLine(Show("Hello World"));
    }
    
    int sum = 0;
    static string Show(int a) => $"Int: {a}";

    static string Show(int a, int b, int c)
    {
        int sum = a + b + c;
        return $"Int: {sum}";
    }
    static string Show(string a) => $"String: {a}";
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Необязательные параметры ===");
        
        Console.WriteLine(Priv("Oleg"));
        Console.WriteLine(Priv("Katya","Krasotka"));
        Console.WriteLine(Priv("Vitya","Brat","!!!"));
    }

    static string Priv(string imya, string zvan = "", string punct = ".")
    {
        return $"Privet,{zvan} {imya}{punct}";
    }
}
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Именованые аргументы ===");
        
        Console.WriteLine(Dan(sila:46,imya:"Kolya", gorod:"Kaluga"));
        Console.WriteLine(Dan(sila:16, gorod:"Lugansk",imya:"Olya"));
        Console.WriteLine(Dan(imya:"Oleg",sila:26, gorod:"Lug"));
    }

    static string Dan(int sila, string gorod, string imya)
    {
        return $"{sila} loiadey,{gorod} gorod, {imya}.";
    }
}
*/


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Метод ref и out ===");

        int sum = 9;
        Console.WriteLine($"До UseRef {sum}");
        UseRef(ref sum);
        Console.WriteLine($"После UseRef {sum}");
        
         
        TryParseOut("100",out int parsed);
        Console.WriteLine($"TryparseOut(\"100\")=>{parsed}");
        TryParseOut("abc",out int failed);
        Console.WriteLine($"TryparseOut(\"abc\")=>{failed} (Не распарсился)");
    }
    static void UseRef(ref int x) =>  x *= 10;

    static void TryParseOut(string s, out int result)
    {
        if(int.TryParse(s, out result))
            Console.WriteLine($"Успех {result}");
        else
        {
            result = -1;
            Console.WriteLine("Присвоено -1");
        }
    }
   
}

