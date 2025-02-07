
Console.WriteLine(DetectCapitalUse("USA"));
Console.WriteLine(DetectCapitalUse("leetcode"));
Console.WriteLine(DetectCapitalUse("FlaG"));

static bool DetectCapitalUse(string word)
{
    if (string.IsNullOrEmpty(word)) throw new Exception("Error, you must write something...");
    if (!OnlyEnglish(word)) throw new Exception("Erro, only English letters");

    return word.Length == 1 ? true : Detecting(word);
}

static bool Detecting(string word)
{
    if (IsUpperLetter(word[0]) && IsUpperLetter(word[1]))
        return Validate(word, true);

    if (IsNotUpper(word[0])) return Validate(word, false);

    var builderWord = BuilderLetter(word);
    var ola = builderWord[1];

    return Validate(builderWord, false);
}

static bool Validate(string word, bool isUpper)
{
    for (var i = 0; i < word.Length; i++)
    {
        if (isUpper)
            if (!IsUpperLetter(word[i])) return false;

        if (!isUpper)
            if (!IsNotUpper(word[i])) return false;
    }

    return true;
}

static string BuilderLetter(string word)
{
    string response = string.Empty;

    for (var i = 1; i < word.Length; i++)
    {
        response = response + word[i];
    }

    return response;
}

static bool OnlyEnglish(string word)
{
    foreach (char c in word)
    {
        if (!char.IsLetter(c)) return false;
    }

    return true;
}

static bool IsUpperLetter(char letter)
    => char.IsUpper(letter);

static bool IsNotUpper(char letter)
    => !char.IsUpper(letter);