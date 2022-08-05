//in string bool float double
//int a = 10;
//string = "Hello";
//bool c = true; //false
//float d = 15.4f;
//double e = 15.4f;

while (true)
{
    Console.WriteLine("Введите 1 число");
    //string name = Console.RedLine();
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число");
    //Console.ReadLine() ждём значение из терминала
    //Convert.ToInt32() превращаем значение в число из терминала
    //Создаём переменную и записываем значение туда 
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите оператор +/-/*/:");
    string Operator = Console.ReadLine();
    // = присвоить
    // == сравнить
    // if() {}
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



