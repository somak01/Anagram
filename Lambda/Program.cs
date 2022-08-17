class Program
{
    public static void Main(string[] args)
    {
        string word1 = "danger";
        string word2 = "garden";
        char[] w1 = word1.ToCharArray();
        char[] w2 = word2.ToCharArray();

        sort(ref w1);
        sort(ref w2);

        if (w1.SequenceEqual(w2))
        {
            Console.WriteLine("The two words are anagrams");
        }
        else { Console.WriteLine("The two words are not anagrams!"); }

    }
    public static void sort (ref char[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}
