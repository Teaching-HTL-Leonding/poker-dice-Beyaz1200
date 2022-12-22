Console.Clear();

int dice1 = 0;
int dice2 = 0;
int dice3 = 0;
int dice4 = 0;
int dice5 = 0;

bool fixed1 = false;
bool fixed2 = false;
bool fixed3 = false;
bool fixed4 = false;
bool fixed5 = false;





void Rolldice()
{
    if (fixed1 == false) { dice1 = Random.Shared.Next(1, 6); }
    if (fixed2 == false) { dice2 = Random.Shared.Next(1, 6); }
    if (fixed3 == false) { dice3 = Random.Shared.Next(1, 6); }
    if (fixed4 == false) { dice4 = Random.Shared.Next(1, 6); }
    if (fixed5 == false) { dice5 = Random.Shared.Next(1, 6); }
}

void Printdice()
{
    Console.WriteLine("Which dice do you want to fix/unfix? (1-5, or 'r' to roll the dice");
    Console.ReadLine();

    Console.WriteLine($"{dice1} {dice2} {dice3} {dice4} {dice5}");
}

void FixDice()
{
    fixed1 = fixed2 = fixed3 = fixed4 = fixed5 = false;
    System.Console.WriteLine("Wich Dice do u want to fix/unfix? (1-5) or r to roll");
    
    //Variant Readline//
    string input;
    do
    {
        input = (Console.ReadLine()!);
    
    switch (input)
    {
        case "1": fixed1 = !fixed1; break;
        case "2": fixed2 = !fixed2; break;
        case "3": fixed3 = !fixed3; break;
        case "4": fixed4 = !fixed4; break;
        case "5": fixed5 = !fixed5; break;
        case "r": break;
        default: Console.WriteLine("WHAT?"); break;
    }
    }while (input != "r");

    Console.Write("Fixed: ");
    if (fixed1) {Console.Write("1 ");}
    if (fixed2) {Console.Write("2 ");}
    if (fixed3) {Console.Write("3 ");}
    if (fixed4) {Console.Write("4 ");}
    if (fixed5) {Console.Write("5 ");}


    input = Console.ReadLine()!;
}

Rolldice();
Printdice();
FixDice();