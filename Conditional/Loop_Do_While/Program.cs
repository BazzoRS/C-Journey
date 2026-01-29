var i = 1;

do
{

    Console.WriteLine($"I = {i}");
    i++;

    if (i == 7)
        break;

}
while (i < +10);

//Do ad while inline

int x = 0;
do
{
 int y = 0;
    do
    {

        Console.WriteLine($"({x},{y}) ");
        y++;

    }

    while (y < 5);
    x++;


}

while (x<5);