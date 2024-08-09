// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int score =85;
// char grade;
// if (score >=90)
// {
//     grade = 'A';
// }
// else if (score >=80)
// {
//     grade = 'B';
// }
// else if (score >=60)
// {
//     grade = 'D';
// }
// else 
// {
//     grade = 'F';
// }
// Console.WriteLine("Your Grade Is: "+ grade);

int score = 79;

char grade = score switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F' 
};

Console.WriteLine("Your Grade Is: " + grade);

// int score = 85;
// char grade = (score >= 90) ? 'A' :
//              (score >= 80) ? 'B' :
//              (score >= 60) ? 'D' : 'F';

// Console.WriteLine("Your Grade Is: " + grade);
