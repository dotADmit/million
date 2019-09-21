using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace million
{
    struct Question
    {
        public string QuestNumber;
        public string Quiz;
        public string AnswerA;
        public string AnswerB;
        public string AnswerC;
        public string AnswerD;
        public char Key;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> quests = new List<Question>();
            fillDefaultQuest(quests);
            int bank = 6250;

            for (int i = 0; i < 4; i++)
            {
                Console.Clear();
                printQuestView(quests, i, bank);

                Console.Write("Введите правильный ответ: ");
                char answer = Convert.ToChar(Console.ReadLine());

                if (answer != quests[i].Key)
                {
                    Console.Clear();
                    printFinal("Вы проиграли ! И ничего не выиграли !");
                    Console.ReadKey();
                    break;
                }
                if (i == 3)
                {
                    Console.Clear();
                    printFinal($"Поздрaвляем с победой! Приз: {bank} руб.");
                    Console.ReadKey();
                    break;
                }
                Console.Clear();
                printFinal($"Вы выиграли {bank} руб.");
                Console.ReadKey();

                bank *= 2;
            }
        }
        static void printFinal(string str)
        {
            string line = new string('=', 49);
            Console.WriteLine(line);
            Console.WriteLine($"| { str, 45} |");
            Console.WriteLine(line);
        }
        static void printQuestView(List<Question> quests, int number, int bank)
        {
            string line = new string('-', 49);

            Question p = quests[number];

            Console.WriteLine($@"{line}
| {p.QuestNumber,21} | {$"На кону {bank} руб.",21} |
{line}
| {p.Quiz,45} |
{line}
| a){p.AnswerA,19} | b){p.AnswerB,19} |
{line}
| c){p.AnswerC,19} | d){p.AnswerD,19} |
{line}");
        }
        static void fillDefaultQuest(List<Question> quests)
        {
            quests.Add(new Question()
            {
                QuestNumber = "Вопрос #1",
                Quiz = "Столица Японии?",
                AnswerA = "Токио",
                AnswerB = "Осака",
                AnswerC = "Пекин",
                AnswerD = "Гонконг",
                Key = 'a'
            });
            quests.Add(new Question()
            {
                QuestNumber = "Вопрос #2",
                Quiz = "Столица США?",
                AnswerA = "Бостон",
                AnswerB = "Нью-Йорк",
                AnswerC = "Вашингтон",
                AnswerD = "Лондон",
                Key = 'c'
            });
            quests.Add(new Question()
            {
                QuestNumber = "Вопрос #3",
                Quiz = "Сила тока измеряется в ?",
                AnswerA = "Вольтах",
                AnswerB = "Ватах",
                AnswerC = "Амперах",
                AnswerD = "Джоулях",
                Key = 'c'
            });
            quests.Add(new Question()
            {
                QuestNumber = "Вопрос #4",
                Quiz = "Ускорение свободного падения равно:",
                AnswerA = "10 м/с",
                AnswerB = "9.8 м/с",
                AnswerC = "3.14 м/с",
                AnswerD = "1 м/с",
                Key = 'b'
            });

        }

    }

}
