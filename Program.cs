using System.Reflection.Metadata;
using System.Text.Json.Serialization;

Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");

Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter; // char можно неявно превратить в int — это код символа в таблице Unicode

Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20;        // компилятор вывел int
var gpa = 4.75;             // компилятор вывел double
var fullName = "Смирнова А.С.";  // компилятор вывел string

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse:      {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.Write("Введите количество прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");

Console.WriteLine();
Console.WriteLine("=== Анкета ===");

Console.Write("Введите имя и фамилию: ");
string Name = Console.ReadLine();

Console.Write("Введите группу: ");
string Group = Console.ReadLine();

Console.Write("Введите год рождения: ");
string birthday = Console.ReadLine();

Console.Write("Введите средний балл: ");
double averageScore = double.Parse(Console.ReadLine());

Console.Write("Введите любимую букву: ");
char favoriteLetter = Console.ReadLine()[0];

bool isHighScore = averageScore >= 4.0;

Console.WriteLine();
Console.WriteLine("  Анкета");
Console.WriteLine($"{Name}, группа {Group}");
Console.WriteLine($"Год рождения: {birthday} (в 2030 будет {2030 - birthYearConvert} год)");
Console.WriteLine($"Средний балл: {averageScore}");
Console.WriteLine($"Балл >= 4.0: {isHighScore}");

Console.Write("Введите рост в метрах (1,70): ");
double height = double.Parse(Console.ReadLine());

Console.Write("Введите вес в килограммах (60): ");
double weight = double.Parse(Console.ReadLine());

double bmi = weight / (height * height);

Console.WriteLine($"ИМТ: {bmi:F2}");