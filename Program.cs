public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string output = "";
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < text.Length; i++)
        {      //Check if the letter exists in the alphabet 
            if (alphabet.IndexOf(text.ToLower()[i]) >= 0)
            {
                output += (alphabet.IndexOf(text.ToLower()[i]) + 1) + " ";
            }
        }
        //Check if the output is empty
        return output.Length == 0 ? output : output.Substring(0, output.Length - 1);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
    }
}
