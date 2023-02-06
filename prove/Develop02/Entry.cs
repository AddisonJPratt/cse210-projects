public class Entry
{
    public string Date = "";
    public string Prompt = "";
    public string Text = "";

    public void addPrompt()
    {
        PromptGenerator p = new PromptGenerator();
        Prompt = p.RandomPrompt();

    }






}

// public class Entry
// {
//     public string Date = "";
//     public string Prompt = "";
//     public string Text = "";
// }