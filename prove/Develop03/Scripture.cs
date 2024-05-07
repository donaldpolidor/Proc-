public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;
    private int _hiddenWordIndex;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        InitializeWords();
        _hiddenWordIndex = 0;
    }

    public void HideNextWord()
    {
        if (_hiddenWordIndex < _words.Count)
        {
            _words[_hiddenWordIndex].Hide();
            _hiddenWordIndex++;
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + ": ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.TrimEnd(); // Remove trailing space
    }

    public bool IsCompletelyHidden()
    {
        return _hiddenWordIndex >= _words.Count;
    }

    private void InitializeWords()
    {
        _words = new List<Word>();
        string[] words = _text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
}