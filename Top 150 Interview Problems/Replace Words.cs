public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        var words = sentence.Split(' ');

        // Iterate through each word in the sentence
        for (int i = 0; i < words.Length; i++)
        {
            // Check each word against the roots in the dictionary
            foreach (var root in dictionary)
            {
                // If the word starts with the root, replace it
                if (words[i].StartsWith(root))
                {
                    words[i] = root;
                    break; // Since we want the shortest root, we can break here
                }
            }
        }

        // Reconstruct the sentence
        return string.Join(" ", words);
    }
}
