
static string[] PetsCount(byte petscifer)
{
    string[] petsnames = new string[petscifer];
    for (int i = 0; i < petscifer - 1; i++)
    {
        Console.WriteLine($"Введите имя Вашего {i} -го питомца: ");
        petsnames[i] = Console.ReadLine();
    }
        return petsnames;
   
}

Console.WriteLine("Имя: ");

Console.WriteLine("Фамилия: ");

Console.WriteLine("Возраст: ");

Console.WriteLine("Есть ли у Вас питомец? Введите да/нет или yes/no");
string ispet = Console.ReadLine();
byte petscount;
switch (ispet)
{
    case "да":
        case "yes":
            case "Да":
                case "Yes":
                {
                Console.WriteLine("Введите цифрами количество питомцев до 255 штук:");
                petscount = byte.Parse(Console.ReadLine());
                PetsCount(petscount);
                }
                break;
default: 
    break;
}


Console.WriteLine(" ");

Console.WriteLine(" ");




Console.WriteLine(" ");