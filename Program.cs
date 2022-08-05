//in string bool float double
//int a = 10;
//string = "Hello";
//bool c = true; //false
//float d = 15.4f;
//double e = 15.4f;
//string name = Console.RedLine();
//Console.ReadLine() ждём значение из терминала
//Convert.ToInt32() превращаем значение в число из терминала
//Создаём переменную и записываем значение туда 
// = присвоить
// == сравнить
// if() {}

while (true)
{
    Console.WriteLine("Введите оператор +/-/*/: или end для выхода");
    string Operator = Console.ReadLine();
    if (Operator == "end")
    {
        break;
    } 
    Console.WriteLine("Введите 1 число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (Operator == "+")
    {
        Console.WriteLine("Числа сложены, Иван Алексеевич!");
        Console.WriteLine(number1 + number2);
    }
    else if (Operator == "-")
    {
        Console.WriteLine("Числа вычтены, Иван Алексеевич!");
        Console.WriteLine(number1 - number2);
    }
    else if (Operator == "*")
    {
        Console.WriteLine("Числа умножены, Иван Алексеевич!");
        Console.WriteLine(number1 * number2);
    }
    else if (Operator == "/")
    {
        Console.WriteLine("Числа разделены, Иван Алексеевич!");
        Console.WriteLine(number1 / number2);
    }
}