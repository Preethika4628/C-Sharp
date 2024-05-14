using System;
using System.Collections.Generic;
using System.Linq;
using LinqExercise;
namespace LinqExcerise;
class Program
{
    public static void Main(string[] args)
    {
        TraineeData traineeData = new TraineeData();
        List<TraineeDetails> traineeList = traineeData.GetTraineeDetails();
        
        Console.WriteLine("Press 1 to Show the list of Trainee Id ");
        Console.WriteLine("Press 2 to Show the first 3 Trainee Id using Take");
        Console.WriteLine("Press 3 to show the last 2 Trainee Id using Skip");
        Console.WriteLine("Press 4 to show the count of Trainee");
        Console.WriteLine("Press 5 to show the Trainee Name who are all passed out 2019 or later");
        Console.WriteLine("Press 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee name.");
        Console.WriteLine("Press 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark");
        Console.WriteLine("Press 8 to show the unique passed out year using distinct");
        Console.WriteLine("Press 9 to show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message");
        Console.WriteLine("Press 10 to show the first Trainee Id and Trainee Name");
        Console.WriteLine("Press 11 to show the last Trainee Id and Trainee Name");
        Console.WriteLine("Press 12 to print the total score of each trainee");
        Console.WriteLine("Press 13 to show the maximum total score");
        Console.WriteLine("Press 14 to show the minimum total score");
        Console.WriteLine("Press 15 to show the average of total score");
        Console.WriteLine("Press 16 to show true or false if any one has the more than 40 score using any()");
        Console.WriteLine("Press 17 to show true of false if all of them has the more than 20 using all()");
        Console.WriteLine("Press 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    // Show the list of Trainee Id
                    foreach (var trainee in traineeList)
                    {
                        Console.WriteLine(trainee.TraineeId);
                    }
                    break;
                }
            case 2:
                {
                    // Show the first 3 Trainee Id using Take
                    var result = from trainee in traineeList select trainee.TraineeId;
                    foreach (var id in result.Take(3))
                    {
                        Console.WriteLine(id);
                    }
                    break;
                }
            case 3:
                {
                    // show the last 2 Trainee Id using Skip
                    foreach (var trainee in traineeList.Skip(3).Take(2))
                    {
                        Console.WriteLine(trainee.TraineeId);
                    }
                    break;
                }
            case 4:
                {
                    // show the count of Trainee
                    var count = traineeList.Count;
                    Console.WriteLine(count);
                    break;
                }
            case 5:
                {
                    // show the Trainee Name who are all passed out 2019 or later
                    var result = from trainee in traineeList where trainee.YearPassedOut >= 2019 select trainee.TraineeName;
                    foreach (var name in result)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }

            case 6:
                {
                    // show the Trainee Id and Trainee Name by alphabetic order of the trainee name.
                    var result = traineeList.OrderBy(traineeName => traineeName.TraineeName);
                    foreach (var trainee in result)
                    {
                        Console.WriteLine(trainee.TraineeId + " - " + trainee.TraineeName);
                    }
                    break;
                }
            case 7:
                {
                    // show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark
                    var result = traineeList.SelectMany(trainee => trainee.ScoreDetails.Where(score => score.Mark >= 4).Select(trainee1 => new { trainee.TraineeName, trainee.TraineeId, trainee1.TopicName, trainee1.ExerciseName, trainee1.Mark }));
                    foreach (var trainee in result)
                    {
                        Console.WriteLine($"{trainee.TraineeId,-10} | {trainee.TraineeName,-10} | {trainee.TopicName,-10} | {trainee.ExerciseName,-20} | {trainee.Mark}");
                    }
                    break;
                }
            case 8:
                {
                    // show the unique passed out year using distinct
                    var years = traineeList.Select(trainee => trainee.YearPassedOut).Distinct();
                    foreach (var year in years)
                    {
                        Console.WriteLine(year);
                    }
                    break;
                }
            case 9:
                {
                    // show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message
                    Console.Write("Enter the TraineeID: ");
                    string traineeID = Console.ReadLine();
                    var result = traineeList.FirstOrDefault(trainee => trainee.TraineeId == traineeID);
                    if (result != null)
                    {
                        int totalScore = result.ScoreDetails.Sum(total => total.Mark);
                        Console.WriteLine("Score: " + totalScore);
                    }
                    break;
                }
            case 10:
                {
                    // show the first Trainee Id and Trainee Name
                    var trainee = traineeList.First();
                    Console.WriteLine($"{trainee.TraineeId}  |  {trainee.TraineeName}");
                    break;
                }
            case 11:
                {
                    // show the last Trainee Id and Trainee Name
                    var trainee = traineeList.Last();
                    Console.WriteLine($"{trainee.TraineeId}  |  {trainee.TraineeName}");
                    break;
                }
            case 12:
                {
                    // print the total score of each trainee
                    foreach (var trainee in traineeList)
                    {
                        int totalScore = trainee.ScoreDetails.Sum(total => total.Mark);
                        Console.WriteLine($"{trainee.TraineeId}  |  {totalScore}");
                    }
                    break;
                }
            case 13:
                {
                    // show the maximum total score
                    var totalScore = traineeList.Max(trainee => trainee.ScoreDetails.Sum(total => total.Mark));
                    Console.WriteLine($"{totalScore}");
                    break;
                }
            case 14:
                {
                    // show the minimum total score
                    var totalScore = traineeList.Min(trainee => trainee.ScoreDetails.Sum(total => total.Mark));
                    Console.WriteLine($"{totalScore}");
                    break;
                }
            case 15:
                {
                    // show the average of total score
                    var averageScore = traineeList.Average(trainee => trainee.ScoreDetails.Sum(total => total.Mark));
                    Console.WriteLine($"{averageScore}");
                    break;
                }
            case 16:
                {
                    // show true or false if any one has the more than 40 score using any()
                    bool result = traineeList.Any(trainee => trainee.ScoreDetails.Sum(total => total.Mark) > 40);
                    Console.WriteLine(result);
                    break;
                }
            case 17:
                {
                    // show true of false if all of them has the more than 20 using all()
                    bool result = traineeList.All(trainee => trainee.ScoreDetails.Sum(total => total.Mark) < 20);
                    Console.WriteLine(result);
                    break;
                }
            case 18:
                {
                    // show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.
                    var result = traineeList.SelectMany(trainee => trainee.ScoreDetails.Select(score => new {trainee.TraineeId, trainee.TraineeName, score.TopicName, score.ExerciseName, score.Mark})).OrderByDescending(traineeName => traineeName.TraineeName).ThenByDescending(score => score.Mark);
                    foreach (var trainee in result)
                    {
                        Console.WriteLine($"{trainee.TraineeId,-10}  |  {trainee.TraineeName,-15}  | {trainee.TopicName,-20}  |  {trainee.ExerciseName,-20}  |  {trainee.Mark}");
                    }
                    break;
                }
            default:
            {
                Console.WriteLine("InValid number. Enter number between 1 to 18");
                break;
            }
        }
    }
}