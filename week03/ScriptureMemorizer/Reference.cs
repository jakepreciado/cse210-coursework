public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string reference;
        if (_endVerse > _verse)
        {
            reference = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return reference;
    }
}

