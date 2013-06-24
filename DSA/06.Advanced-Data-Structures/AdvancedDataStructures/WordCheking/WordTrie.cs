/* Lesson 6 - Advanced Data Structures
 * Homework 3
 * 
 * Write a program that finds a set of words (e.g. 1000 words) in a 
 * large text (e.g. 100 MB text file). Print how many times each
 * word occurs in the text.
 * Hint: you may find a C# trie in Internet.
 */

namespace WordCheking
{
    public class WordTrie
    {
        private int words;
        private int prefixes;
        private WordTrie[] edges;

        public WordTrie()
        {
            this.edges = new WordTrie[26];
            this.Words = 0;
            this.Prefixes = 0;
        }

        public int Words
        {
            get
            {
                return this.words;
            }

            set
            {
                this.words = value;
            }
        }

        public int Prefixes
        {
            get
            {
                return this.prefixes;
            }

            set
            {
                this.prefixes = value;
            }
        }

        public WordTrie AddWord(WordTrie node, string word)
        {
            return this.AddWord(node, word, 0);
        }

        public void AddOccuranceIfExists(WordTrie node, string word)
        {
            this.AddOccuranceIfExists(node, word, 0);
        }

        public int CountWords(WordTrie node, string word)
        {
            return this.CountWords(node, word, 0);
        }

        public int CountPrefix(WordTrie node, string word)
        {
            return this.CountPrefix(node, word, 0);
        }       

        private void AddOccuranceIfExists(WordTrie node, string word, int indexInWord)
        {
            if (word.Length == indexInWord)
            {
                node.Words += 1;
            }
            else
            {
                int nextCharIndex = word[indexInWord] - 'a';
                indexInWord++;
                node.Prefixes += 1;

                if (node.edges[nextCharIndex] == null)
                {
                    return;
                }
                else
                {
                    this.AddOccuranceIfExists(node.edges[nextCharIndex], word, indexInWord);
                }
            }
        }

        private WordTrie AddWord(WordTrie node, string word, int indexInWord)
        {
            if (word.Length != indexInWord)
            {
                node.Prefixes += 1;
                
                int index = word[indexInWord] - 'a';
                indexInWord++;

                if (node.edges[index] == null)
                {
                    node.edges[index] = new WordTrie();
                }

                node.edges[index] = this.AddWord(node.edges[index], word, indexInWord);
            }

            return node;
        }

        private int CountWords(WordTrie node, string word, int indexInWord)
        {
            if (word.Length == indexInWord)
            {
                return node.words;
            }
            else
            {
                int nextCharIndex = word[indexInWord] - 'a';
                indexInWord++;
                if (node.edges[nextCharIndex] == null)
                {
                    return 0;
                }
                else
                {
                    return this.CountWords(node.edges[nextCharIndex], word, indexInWord);
                }
            }
        }

        private int CountPrefix(WordTrie node, string word, int indexInWord)
        {
            if (word.Length == indexInWord)
            {
                return node.prefixes;
            }
            else
            {
                int nextCharIndex = word[indexInWord] - 'a';
                indexInWord++;
                if (node.edges[nextCharIndex] == null)
                {
                    return 0;
                }
                else
                {
                    return this.CountPrefix(node.edges[nextCharIndex], word, indexInWord);
                }
            }
        }
    }
}