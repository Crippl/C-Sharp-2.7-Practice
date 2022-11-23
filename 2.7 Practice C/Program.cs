using static System.Console;

namespace _2._7_Practice_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Роман Геннадьевич";
            string email = "romka150495@gmail.com";
            string averageScoreFormated;
            byte age = 27;
            float programmingScore = 9.3f;
            float mathScore = 7.8f;
            float physicsScore = 3.1f;
            float sumScore;
            float averageScore;
            sumScore = programmingScore + mathScore + physicsScore;
            averageScore = sumScore / 3;
            averageScoreFormated = averageScore.ToString("#.##");
            WriteLine($"Ф.И.О.: {fullName,43} \nВозраст: {age,20} \nEmail: {email,41} \nБаллы по программированию: {programmingScore,2} \nБаллы по математике: {mathScore,9} \nБаллы по физике: {physicsScore,13}");
            WriteLine("Для продолжения нажмите любую клавишу");
            ReadKey();
            WriteLine($"Средний балл: {averageScoreFormated}");
            WriteLine("Для закрытия программы нажмите любую клавищу");
            ReadKey();
        }
    }
}
