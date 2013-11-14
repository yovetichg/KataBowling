namespace KataBowling
{
    public class Parser
    {
        public string Input { get; set; }
        public Parser(string rolls)
        {
            Input = rolls;
        }

        public bool IsValidInput()
        {
            return false;
        }
    }
}