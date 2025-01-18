using System.Xml.Linq;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter newFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
                newFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
        }
    }

    public void Load(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _date = parts[0];
            string _prompt = parts[1];
            string _entry = parts[2];

            Entry newEntry = new Entry
            {
                _date = _date,
                _prompt = _prompt,
                _entry = _entry
            };

            _entries.Add(newEntry);
        }
    }
}
