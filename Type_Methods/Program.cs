/// Вид 1. Методы ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Autor.....");
}
//Method1();

// Вид 2. Методы ничего не возвращают, но принимают какие то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текстовое сообщение");  

//Примеры ввода аргументов
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }    
}
//Method21("Текстовое сообщение", 10);
//Method21(msg: "Текстовое сообщение", count: 10); //Именованные аргументы, порядок не важен.


// Вид 3. Методы что то возвращают и ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); //Что бы вызвать метод нужно создать переменную
//Console.WriteLine(year);

// Вид 4. Методы что то возвращают и что то принимают
/*string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; //аналог  = "";

    while(i < count)
    {
       result = result + text;
        i++;
    }
    return result; 
}  
string res = Method4(10, "Добрый день!!!"); //Что бы вызвать метод нужно создать переменную и указать аргуметы по порядку
Console.WriteLine(res);*/

//То же с циклом for
string Method4(int count, string text)
{
    
    string result = string.Empty; //аналог  = "";

    for(int i =0; i < count; i++)
    {
       result = result + text;
       
    }
    return result; 
}  
string res = Method4(10, "Добрый день!!!"); //Что бы вызвать метод нужно создать переменную и указать аргуметы по порядку
Console.WriteLine(res);