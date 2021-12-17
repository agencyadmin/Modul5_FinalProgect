/// <summary>
/// Объявляем кортеж имя, фамилия, сколько лет, количество любимых животных, количество любимых цветов, массив имен питомцев, массив названий цветов.
/// </summary>
(string name, string surname, byte age, byte petscount, byte colorfavnumber, string[] petsnames, string[] favcolornames) User;
//если нужно добавить в кортеж массивы животных и цветов для последующего вывода на экран через кортеж.


/// <summary>
/// PetsCount() функция метод возвращающая МАССИВ petsnames любимых животных, при отправке в нее проверенного на 0 и тип байт значения количества питомцев, введенного пользователем с клавиатуры.
/// </summary>
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
/// <summary>
/// PetsCount() функция метод возвращающая МАССИВ colornames любимых цветов, при отправке в нее проверенного на 0 и тип байт значения количества цветов, введенного пользователем с клавиатуры.
/// </summary>
static string[] FavColorGet(byte colorcifer)
{
    string[] colornames = new string[colorcifer];
    for (int i = 0; i < colorcifer; i++)
    {
        Console.WriteLine($"Введите имя Вашего {i+1} -го любимого цвета: ");
        colornames[i] = Console.ReadLine();
    }
    return colornames;

}
  // Дописать ниже передачу по ссылке в метод проверки на байт переменную байт через которую будет возвращаться корректно введенное значение байт проверяемым данным пользователя,
  // а именно возраст, количество животных, количество цветов, для каждого объявить переменную байтовую для принятия значения из метода чек, которое может быть нулевым, что нужно
  //тоже исключить проверкой на нулевое значение.

/// <summary>
/// Ниже функция проверки значения на байт и ноль
/// </summary>
/// 
static byte CheckByte(string userenter)
{
    if (!(byte.TryParse(userenter, out byte datatouser)&&datatouser>1)) // Также короче это условие: (!byte.TryParse(userenter, out byte datatouser)^datatouser<1)) 
    {
       
        Console.WriteLine("Проверка на 0 и \"-\" :Вы ввели некорректные данные! Повторите ввод цифрами больше нуля! ");
        UserDataEnter();

    }
    return datatouser;
    
}
/// <summary>
/// Метод для ввода первичных данных пользователя имени, фамилии и возраста.
/// </summary>
static byte UserDataEnter()

{  
    Console.WriteLine("Введите Ваши данные цифрами и нажмите ввод: ");
    return CheckByte(Console.ReadLine());
}

/// <summary>
/// Метод для ввода первичных данных пользователя имени, фамилии и возраста.
/// </summary>  

void UserNameAgeEnter()
{
    Console.WriteLine("Пожайлуста, Введите Ваше Имя и нажмите клавишу ввод: ↓ ◄┘ ");
    User.name = Console.ReadLine();
    Console.WriteLine("Какая у Вас Фамилия укажите словом и нажмите клавишу ввод: \u2642 ");
    User.surname = Console.ReadLine();
    Console.WriteLine("Введите свой возраст в формате и образом указанном ниже \u8626 ");
    User.age = UserDataEnter();
}

/// <summary>
/// Тут вводит пользователь свой возраст вызывая для этого соответствующую функцию UserAgeEnter, которая и отправляет цифры , введенные пользователем на проверку в метод CheckByte, который 
/// принимает строку введенную пользователем, пытаеться распарсить ее и в случае удачи возвращает приведенное к байтовому типу целое значение методу UserAgeEnter, а в случае если распарсить
/// не удалось повторно вызываеться этот метод ввода данных пользователем, пока не введет корректные значения:
/// </summary>

UserNameAgeEnter();


/// Тут вводит пользователь есть ли у него питомцы и их количество, в случае если они есть.  

while (true)
{
    Console.WriteLine("Есть ли у Вас питомец? Введите ниже строкой слова да/нет или yes/no и нажмите ввод: ");
    
    switch (Console.ReadLine())
    {
        case "да": case "yes": case "Да": case "Yes": case "da": case "Da":
            {
                Console.WriteLine("Введите цифрами количество питомцев до 255 штук:");
                User.petscount = UserDataEnter();
                //добавить выше вызов функции проверки введенных цифр на соответствие байтовому типу и не нулевому значению!
                User.petsnames = PetsCount(User.petscount);
                Console.WriteLine("Вы ввели следующих питомцев:"); ///  тут идет вывод имен введеннх питомцев
                foreach (string pet in User.petsnames) Console.WriteLine(pet);
            }
                break;
        case "нет": case "no": case "Нет": case "No": case "net": case "Net": case "Но": case "но": case "Ноу": case "ноу":
            {
                Console.WriteLine("Жаль, что у Вас нет домашних питомцев )...");
                User.petscount = 0;
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

    Console.WriteLine("Введите цифрами количество любимых цветов до 255 штук:");
    User.colorfavnumber = UserDataEnter();
    User.favcolornames = FavColorGet(User.colorfavnumber);
    foreach (string color in User.favcolornames) Console.WriteLine(color);

//Возможен ли вывод полученного кортежа на экран возможно foreach?
//ShowCartage(User); - почему то ошибка вызова метода.

Console.WriteLine($"Вас зовут: { User.name}.");
Console.WriteLine($"Ваша фамилия: {User.surname}.");
Console.WriteLine($"Ваш возраст: {User.age}.");
Console.WriteLine($"У Вас: {User.petscount} питомцев."); 
Console.WriteLine($"Вам нравяться: {User.colorfavnumber} цвета.");

//возможно на инт поменять байтовые значения что бы точно соответствовать выданному заданию, но byte более лучший тип для поставленной задачи.
