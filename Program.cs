using System;
using System.IO;
string[] firstQuestions = {"Сколько основных цветов в классической радуге?", "Как зовут гениального изобретателя и миллиардера, скрывающегося под маской Железного человека?", "Какой океан является самым большим и глубоким на Земле?", "Какого цвета рождаются птенцы фламинго?", "Сколько планет официально входит в нашу Солнечную систему?", "Какую форму имеет знаменитый шрам на лбу у Гарри Поттера?","Какая страна является родиной кенгуру и коал, а её столица — Канберра, а не Сидней?"};
string[] secondQuestions = {"Кто написал знаменитую загадочную картину «Мона Лиза» (Джоконда)?", "Какая европейская страна по своей форме на карте мира напоминает сапог с высоким каблуком?", "На чём на самом деле растут бананы в дикой природе и на плантациях?","Какого цвета шерсть у белого медведя на самом деле?", "Сколько времени летит лучик света от Солнца до Земли?", "Из чего делают знаменитый десерт птичье молоко?", "Зачем пираты часто носили повязку на одном глазу?"};
string[] firstAnswers = new string[firstQuestions.Length];
for (int i = 0; i<firstQuestions.Length; i++)
{
    Console.Write(firstQuestions[i]+" ");
    firstAnswers[i] = Console.ReadLine();

}
File.WriteAllLines("responsesPlayerOne.txt", firstAnswers);
string[] correctAnswersPlayerOne=File.ReadAllLines("AnswersPlayerOne.txt");







string[] secondAnswers = new string[secondQuestions.Length];
for (int i = 0; i<secondQuestions.Length; i++)
{
    Console.Write(secondQuestions[i]+" ");
    secondAnswers[i] = Console.ReadLine();

}
File.WriteAllLines("responsesPlayerTwo.txt", secondAnswers);
string[] correctAnswersPlayerTwo=File.ReadAllLines("AnswersPlayerTwo.txt");
int CheckAnswers(string[] playerAnswers, string[] correctAnswers)
{
    int scoresPlayer = 0;
    for (int i = 0; i < playerAnswers.Length; i++)
    {
        if (playerAnswers[i] == correctAnswers[i])
        {
            scoresPlayer+=10;
        }
    }
    return scoresPlayer;
}
int scorePlayerOne = CheckAnswers(firstAnswers,correctAnswersPlayerOne) ;
Console.WriteLine($"Игрок 1 набрал {scorePlayerOne} очков");
int scorePlayerTwo = CheckAnswers(secondAnswers,correctAnswersPlayerTwo) ;
Console.WriteLine($"Игрок 2 набрал {scorePlayerTwo} очков");
if (scorePlayerOne > scorePlayerTwo)
{
    Console.WriteLine("Игрок 1 Побеждает!");
}
else if (scorePlayerTwo > scorePlayerOne)
{
    Console.WriteLine("Игрок 2 Побеждает!");
}
else
{
    Console.WriteLine("Ничья!");
}