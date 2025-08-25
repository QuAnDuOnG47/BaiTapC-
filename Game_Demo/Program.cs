using System;
using System.Collections.Generic;
using System.Linq;

class HangmanGame
{
    static List<KeyValuePair<string, string>> words = new List<KeyValuePair<string, string>>()
    {
       // Cấp độ dễ (3–5 ký tự)
        new KeyValuePair<string, string>("cat", "Con mèo"),
        new KeyValuePair<string, string>("dog", "Con chó"),
        new KeyValuePair<string, string>("sun", "Mặt trời"),
        new KeyValuePair<string, string>("tree", "Cái cây"),
        new KeyValuePair<string, string>("book", "Cuốn sách"),
        new KeyValuePair<string, string>("fish", "Con cá"),
        new KeyValuePair<string, string>("moon", "Mặt trăng"),

        // Cấp độ trung bình (6–8 ký tự)
        new KeyValuePair<string, string>("orange", "Quả cam"),
        new KeyValuePair<string, string>("banana", "Quả chuối"),
        new KeyValuePair<string, string>("guitar", "Đàn guitar"),
        new KeyValuePair<string, string>("monkey", "Con khỉ"),
        new KeyValuePair<string, string>("village", "Ngôi làng"),
        new KeyValuePair<string, string>("holiday", "Kỳ nghỉ"),
        new KeyValuePair<string, string>("mountain", "Ngọn núi"),

        // Cấp độ khó (> 8 ký tự)
        new KeyValuePair<string, string>("elephant", "Con voi"),
        new KeyValuePair<string, string>("pineapple", "Quả dứa"),
        new KeyValuePair<string, string>("university", "Trường đại học"),
        new KeyValuePair<string, string>("adventure", "Cuộc phiêu lưu"),
        new KeyValuePair<string, string>("television", "Tivi"),
        new KeyValuePair<string, string>("dictionary", "Từ điển"),
        new KeyValuePair<string, string>("astronomy", "Thiên văn học")
    };

    static void Main()
    {
        while (true)
        {
            int level = ChooseLevel();
            var filteredWords = GetWordsByLevel(level);

            if (filteredWords.Count == 0)
            {
                Console.WriteLine("Không có từ nào phù hợp cấp độ này!");
                Console.ReadKey();
                continue;
            }

            PlayGame(filteredWords);

            Console.Write("\nBạn có muốn chơi lại không? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                break;
        }
    }

    // Hàm chọn cấp độ
    static int ChooseLevel()
    {
        int level;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Chọn cấp độ =====");
            Console.WriteLine("1. Dễ (3-5 chữ)");
            Console.WriteLine("2. Trung bình (6-8 chữ)");
            Console.WriteLine("3. Khó (>8 chữ)");
            Console.Write("Nhập cấp độ (1-3): ");

            if (int.TryParse(Console.ReadLine(), out level) && level >= 1 && level <= 3)
                return level;

            Console.WriteLine("Cấp độ không hợp lệ, vui lòng nhập lại!");
            Console.ReadKey();
        }
    }

    // Hàm lọc từ theo cấp độ
    static List<KeyValuePair<string, string>> GetWordsByLevel(int level)
    {
        if (level == 1)
            return words.Where(w => w.Key.Length >= 3 && w.Key.Length <= 5).ToList();
        else if (level == 2)
            return words.Where(w => w.Key.Length >= 6 && w.Key.Length <= 8).ToList();
        else
            return words.Where(w => w.Key.Length > 8).ToList();
    }

    // Hàm chơi game
    static void PlayGame(List<KeyValuePair<string, string>> wordList)
    {
        Random rand = new Random();
        var chosenWord = wordList[rand.Next(wordList.Count)];
        string secretWord = chosenWord.Key.ToLower();
        string meaning = chosenWord.Value;

        List<char> guessedLetters = new List<char>();
        int wrongCount = 0;
        const int maxWrong = 6;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(DrawHangman(wrongCount));
            Console.WriteLine("\nTừ cần đoán: " + GetMaskedWord(secretWord, guessedLetters));
            Console.WriteLine("Chữ đã đoán: " + string.Join(", ", guessedLetters));

            if (wrongCount >= maxWrong)
            {
                Console.WriteLine($"\nBạn thua! Từ đúng là '{secretWord}'. Nghĩa: {meaning}");
                break;
            }

            if (IsWordGuessed(secretWord, guessedLetters))
            {
                Console.WriteLine($"\nChúc mừng! Bạn đã đoán đúng từ '{secretWord}'. Nghĩa: {meaning}");
                break;
            }

            Console.Write("\nNhập 1 chữ cái: ");
            string input = Console.ReadLine().ToLower();

            if (input.Length != 1 || !char.IsLetter(input[0]))
            {
                Console.WriteLine("Nhập 1 chữ cái duy nhất!");
                Console.ReadKey();
                continue;
            }

            char guess = input[0];

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("Bạn đã đoán chữ này rồi!");
                Console.ReadKey();
                continue;
            }

            guessedLetters.Add(guess);

            if (!secretWord.Contains(guess))
                wrongCount++;
        }
    }

    // Vẽ hình treo cổ
    static string DrawHangman(int wrong)
    {
        string[] stages = new string[]
        {
            @"
  +---+
  |   |
      |
      |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
      |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
        };
        return stages[wrong];
    }

    // Hiển thị từ với dấu gạch dưới
    static string GetMaskedWord(string word, List<char> guessedLetters)
    {
        return string.Concat(word.Select(c => guessedLetters.Contains(c) ? c + " " : "_ "));
    }

    // Kiểm tra đã đoán hết từ chưa
    static bool IsWordGuessed(string word, List<char> guessedLetters)
    {
        return word.All(c => guessedLetters.Contains(c));
    }
}
