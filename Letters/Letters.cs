using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Letters
{
    public class LettersExample
    {
        private readonly List<string> _characters = new List<string> { "a", "e", "i", "o", "u", "d", "w", "S", "n" };

        public bool CaseSensitiveReusuableWordFromCharactersChecker(string word)
        {
            var checker = 1;
            var bob = word.ToCharArray();
            foreach (var letter in bob)
            {
                if (checker == 0) return false;

                if (!_characters.Contains(letter.ToString()))
                    checker = 0;
            }

            return checker == 1;
        }

        public bool CaseInsensitiveReusuableWordFromCharactersChecker(string word)
        {
            var checker = 1;
            var bob = word.ToCharArray();
            foreach (var letter in bob)
            {
                if (checker == 0) return false;
                var lowerCaseChars = _characters.Select(x => x.ToLower()).ToList();
                if (!lowerCaseChars.Contains(letter.ToString()))
                    checker = 0;
            }

            return checker == 1;
        }

    }
}
