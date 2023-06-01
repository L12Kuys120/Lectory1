/* Работа с текстом. Дан текст. В тексте все пробелы нужно заменить черточками, 
маленькие буквы "к" заменить большими буквами "К", а большие "С" заменить маленькими "с"*/

string text = "Я думаю, - сказал князь, улыбаясь, - что"
            + "ежели бы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty" символ "е" это  s[2]

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;   //Показывает количество символов в строке
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $" {newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');  //Замена пробелов вертикальными черточками
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(newText, 'к','К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replace(newText1, 'С','с');
Console.WriteLine(newText2);




