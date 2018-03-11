namespace KriptoLaba1
{
    public class Vigenera
    {
        private static string RusAlphabet = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string EncryptionGronsfeld(string key, string inputText)
        {
            inputText = inputText.ToLower();
            key = key.ToLower();
            string ciphertext = null;
            int keyIndex = 0;
            foreach (char symbol in inputText)
            {
                int indexLetter = (RusAlphabet.IndexOf(symbol) + RusAlphabet.IndexOf(key[keyIndex])) % RusAlphabet.Length;
                ciphertext += RusAlphabet[indexLetter];
                keyIndex++;
                if ((keyIndex + 1) == key.Length)
                    keyIndex = 0;
            }

            return ciphertext;
        }

        public static string Decryption(string key, string inputText)
        {
            inputText = inputText.ToLower();
            key = key.ToLower();
            string decipheredText = null;
            int keyIndex = 0;
            foreach (char symbol in inputText)
            {
                int indexLetter = (RusAlphabet.IndexOf(symbol) + RusAlphabet.Length - RusAlphabet.IndexOf(key[keyIndex])) % RusAlphabet.Length;
                decipheredText += RusAlphabet[indexLetter];
                keyIndex++;
                if ((keyIndex + 1) == key.Length)
                    keyIndex = 0;
            }
            return decipheredText;
        }
    }
}