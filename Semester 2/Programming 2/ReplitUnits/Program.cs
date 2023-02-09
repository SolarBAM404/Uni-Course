// See https://aka.ms/new-console-template for more information

using ReplitUnits.Week1;

void ToConsole(String msg)
{
    Console.WriteLine(msg);
}

ToConsole("Enter a Week (1-4)");
int weekNum = Int32.Parse(Console.ReadLine());

ToConsole("Enter number of the unit");
int unitNum = Int32.Parse(Console.ReadLine());

switch (weekNum)
{
    case (1):
        switch (unitNum)
        {
            case (1) :
                HelloCS.Main_hellocs();
                break;
            case (2):
                Objects_Etc.Main_objects();
                break;
            case(3):
                Comments.Main_comments();
                break;
            case (4):
                Errors.Main_errors();
                break;
            case (5):
                Style.Main_style();
                break;
            case (6):
                Input.Main_input();
                break;
            case (7):
                SimpleIO.Main_simpleIO();
                break;
            case (8):
                Ex1.Main_ex1();
                break;
            case (9):
                Ex2.Main_ex2();
                break;
            default:
                ToConsole("Not an available unit!");
                break;
        }
        break;
    
    default:
        ToConsole("Not an available Week!");
        break;
}
