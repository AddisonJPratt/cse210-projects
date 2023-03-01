public class Scripture
{
    private string _reference = "";
    private string _text = "";
    private List<Verse> _verses = new List<Verse>();
    // this separates the array of scriptures and creates a new array with the selected scripture seperated by the reference and the verses.
    public Scripture(string scripture)
    {
        string[] scriptSplit = scripture.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
        _reference = scriptSplit[0];
        _text = scriptSplit[1];
        SplitVerse();
    }
    // the splitverse function splits the scripture where there is a new verse detected. It then adds it to a new array of verses.
    private void SplitVerse()
    {
        string[] splitVerses = _text.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        foreach (string verse in splitVerses)
        {
            Verse newVerse = new Verse(verse);
            _verses.Add(newVerse);
        }
    }
    // this method shows the scripture with the reference and its correlated scriptures
    public void ShowScripture()
    {
        Console.Clear();
        Console.WriteLine($"\n{_reference}");
        foreach (Verse verse in _verses)
        {
            verse.ShowVerse();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void HideWords()
    {
        // Console.Clear();
        foreach (Verse verse in _verses)
        {
            verse.HideWords();
            verse.ShowVerse();
            Console.WriteLine();

        }

    }

}

