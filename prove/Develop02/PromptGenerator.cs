public class PromptGenerator
{
    public List<string>_prompts;
    public Random RandomPrompts;
    public PromptGenerator()
    {
        RandomPrompts = new Random{};
        _prompts = new List<string>{};
        
        _prompts.Add("Who was the most interesting person I ineracted with today?");
        _prompts.Add("what was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today what would it be?");
        _prompts.Add("What did you eat today?");
    }
    public string DisplayRandomPrompt()
    {
        int RandomChoice = RandomPrompts.Next(6);
        return _prompts.ElementAt(RandomChoice);
    }

}