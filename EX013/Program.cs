string text = " - И вот он говорит: выставь мне счет на айфон 13 модели, на что я ответил - хорошо - окей!";
string Replace(string text, char oldv, char newv){

    string result  = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldv)
        {
            result = result + $"{newv}";
        }
        else
        {
            result = result + $"{text[i]}"; 
        }
    }

    return result;
}

string newText = Replace(text, '3', '4');
Console.WriteLine(newText);