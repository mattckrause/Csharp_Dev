// See https://aka.ms/new-console-template for more information
int Num;
Console.WriteLine("Please enter a day number between 1-7: ");
Num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("That day number is " + getDay(Num));

static string getDay(int dayNum)
{
    string dayName;

    switch (dayNum)
    {
        case 1:
            dayName = "Sunday";
            break;
        case 2:
            dayName = "Monday";
            break;
        case 3:
            dayName = "Tuesday";
            break;
        case 4:
            dayName = "Wednesday";
            break;
        case 5:
            dayName = "Thursday";
            break;
        case 6:
            dayName = "Friday";
            break;
        case 7:
            dayName = "Saturday";
            break;
        default:
            dayName = "Enter a valid day number 0-6";
            break;
    }

    return dayName;
}