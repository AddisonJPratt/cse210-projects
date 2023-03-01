using System;
using System.Collections.Generic;
public class Book
{
    private List<string> _scriptures = new List<string>();
    private string _selectedScripture;
    public Book()
    {
        scriptures();
    }
    //contains array of scriptures
    private void scriptures()
    {
        _scriptures.Add("Romans 8:27-28 | And he that asearcheth the hearts knoweth what is the mind of the Spirit, because he maketh bintercession for the saints according to the will of God. And we know that all things work together for agood to them that love God, to them who are the called according to his purpose.");
        _scriptures.Add("John 3:16 | For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    }
    //pulls random scripture for memorizing
    public void GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        _selectedScripture = _scriptures[index];
    }
    public string getScripture()
    {
        return _selectedScripture;
    }
}