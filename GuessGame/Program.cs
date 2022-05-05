// See https://aka.ms/new-console-template for more information

string word = "guess";
string guess = "";
int guessCount = 1;
bool correct = false;

Console.WriteLine("Welcome to the word guess game. \nThe word is 5 characters long.\nYou will have 5 attempts... Good Luck!");


while(word != guess && guessCount <= 5)
{
    Console.Write("Enter guess " + guessCount + ": ");
    guess= Console.ReadLine().ToLower() ;
    Console.WriteLine(checker(guess));
    guessCount++;
}

if(correct)
{
    Console.Write("Congrats, you win!");
}
else
{
    Console.Write("Sorry, you lose...");
}

// Method to check our guess and provide feedback/hints
static string checker(string guess)
{
    Console.Write("checking guess...");
    string checkAnswer = "asdf";
    return checkAnswer;
}