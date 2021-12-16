(string name, string surname, byte age, byte pets, byte colorfavnumber ) User;

void ShowCartage(object cartage)
{
    Console.WriteLine($"Вас зовут: {User.name}.");
    Console.WriteLine($"Ваша фамилия: {User.surname}.");
    Console.WriteLine($"Ваш возраст: {User.age}.");
    Console.WriteLine($"У Вас: {User.pets} питомцев.");
    Console.WriteLine($"Вам нравяться: {User.colorfavnumber} цветов.");

}

static string[] PetsCount(byte petscifer)
{
    string[] petsnames = new string[petscifer];
    for (int i = 0; i < petscifer; i++)
    {
        Console.WriteLine($"Введите имя Вашего {i+1} -го питомца: ");
        petsnames[i] = Console.ReadLine();
    }
        return petsnames;
   
}

static string[] FavColorGet(byte colorcifer)
{
    string[] colornames = new string[colorcifer];
    for (int i = 0; i < colorcifer; i++)
    {
        Console.WriteLine($"Введите имя Вашего {i} -го любимого цвета: ");
        colornames[i] = Console.ReadLine();
    }
    return colornames;

}
  
static byte CheckByte(string userenter)
{
    if (!byte.TryParse(userenter, out byte datatouser)|datatouser<1)
    {
       
        Console.WriteLine("Вы ввели некорректные данные! Повторите ввод цифрами больше нуля! ");
        UserDataEnter();

    }
    return datatouser;
    
}
static byte UserDataEnter()
{   Console.WriteLine("Введите Ваш возраст цифрами и нажмите ввод: ");
    return CheckByte(Console.ReadLine());
}
    Console.WriteLine("Пожайлуста, Введите Ваше Имя и нажмите клавишу ввод: ");
    User.name = Console.ReadLine();

    Console.WriteLine("Какая у Вас Фамилия укажите словом и нажмите клавишу ввод: ");
    User.surname = Console.ReadLine();

    User.age = UserDataEnter();

/// <summary>
/// Тут вводит пользователь свой возраст вызывая для этого соответствующую функцию UserAgeEnter, которая и отправляет цифры , введенные пользователем на проверку в метод CheckByte, который 
/// принимает строку введенную пользователем, пытаеться распарсить ее и в случае удачи возвращает приведенное к байтовому типу целое значение методу UserAgeEnter, а в случае если распарсить
/// не удалось повторно вызываеться этот метод ввода данных пользователем, пока не введет корректные значения:
/// </summary>

    //Console.WriteLine("Есть ли у Вас питомец? Введите ниже строкой слова да/нет или yes/no и нажмите ввод: ");
    
    byte petscount;
while (true)
{
    Console.WriteLine("Есть ли у Вас питомец? Введите ниже строкой слова да/нет или yes/no и нажмите ввод: ");
    
    switch (Console.ReadLine())
    {
        case "да": case "yes": case "Да": case "Yes": case "da": case "Da":
            {
                Console.WriteLine("Введите цифрами количество питомцев до 255 штук:");
                petscount = byte.Parse(Console.ReadLine());
                //добавить выше вызов функции проверки введенных цифр на соответствие байтовому типу и не нулевому значению!
                string[] petsnames = new string[petscount];
                petsnames = PetsCount(petscount);
                Console.WriteLine("Вы ввели следующих питомцев:");
                foreach (string pet in petsnames) Console.WriteLine(pet);
            }
                break;
        case "нет": case "no": case "Нет": case "No": case "net": case "Net": case "Но": case "но": case "Ноу": case "ноу":
            {
                Console.WriteLine("Жаль, что у Вас нет домашних питомцев )...");
            }
                 break;
            default:
            Console.WriteLine("Вы ввели некорректные данные! Повторите ввод полжительными цифрами больше нуля!");
            continue;
    }
    break;
}
// Дописать дальше повторный ввод корректных данных либо через континуе в начало свича , либо через вайл оператор условия, либо же аналогично методу ввода данных цифровых,
// проверку ввода данных через метод, может быть с помощью рекурсии?

    Console.WriteLine("Введите цифрами количество любимых цветов 255 штук:");
byte colorscount;
var iscolornull = byte.TryParse(Console.ReadLine(), out colorscount);
    string[] favcolornames = new string[colorscount];

    if (colorscount != 0) favcolornames = FavColorGet(colorscount);
        else Console.WriteLine("Жаль, что у Вас нет любимых цветов, как бы это двусмысленно не звучало )...");

    //Дописать сюда вывод полученного кортежа на экран.




