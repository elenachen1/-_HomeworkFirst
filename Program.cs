Console.WriteLine("Введите номер задачи от 1 до 5 включительно. Для завершения работы введите 0 ");
int task = int.Parse(Console.ReadLine()); 

while (task != 0){
    if (task == 1){
    /*
    Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
    */

    Console.Write("Введите первое число ");
    int numberFirst = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число ");
    int numberSecound = int.Parse(Console.ReadLine());
    int max = 0;

        if(numberFirst > numberSecound ){
            max = numberFirst;
        }

        else{
            max = numberSecound;
        }

    Console.WriteLine($"max = {max}");
    }

    if (task == 2){
        /*
        Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        2, 3, 7 -> 7
        44 5 78 -> 78
        22 3 9 -> 22
        */

        Console.Write("Введите первое число ");
        int numberFirst = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число ");
        int numberSecound = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число ");
        int numberThirth = int.Parse(Console.ReadLine());
        int max = numberFirst;

        if (max < numberSecound ){
        max = numberSecound;
        }

        if (max < numberThirth ){
        max = numberThirth;
        }

        Console.WriteLine($"max = {max}");
    }

    if(task == 3){
        /*
        Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        4 -> да
        -3 -> нет
        7 -> нет
        */

        Console.Write("Введите число ");
        int number = int.Parse(Console.ReadLine());
        
        if (number % 2 == 0){
            Console.WriteLine("Число является четным");
        }

        else{
            Console.WriteLine("Число является нечетным");
        }
    }

    if (task == 4){
        /*
        Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        5 -> 2, 4
        8 -> 2, 4, 6, 8
        */

        Console.Write("Введите число ");
        int N = int.Parse(Console.ReadLine());

        for(int i = 1; i <= N; i++){
            if( i % 2 == 0 ){
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine( );
    }

    if (task == 5){
        /*
        Задача повышенной сложности
        Напишите программу.
        Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
        На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
        Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19.
        */

        Console.WriteLine("Введите количество элементов массива ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите массив число массива");
        int[] numbers = new int[a];
        int i = 0;
        int sum1 = 0;
        int sum2 = 0;
        while( i < a){
            Console.WriteLine("Введите массив число массива");
            numbers[i] = int.Parse(Console.ReadLine());
            i++;
        }

         Console.WriteLine("Введите переменную с номером деления массива ");
         int k = int.Parse(Console.ReadLine());

         for (int t = 0; t <= k ; t++){
            sum1 += numbers[t];
         }

        for (int t = k+1; t < a ; t++){
            sum2 += numbers[t];
         }

        if (sum1 > sum2){
            Console.WriteLine("Первая часть");
        }

        else{
            Console.WriteLine("Вторая часть");
        }
    }

    else{
        Console.WriteLine("Не корректный ввод данных!!");
    }

    Console.WriteLine("Введите номер задачи от 1 до 5 включительно. Для завершения работы введите 0 ");
    task = int.Parse(Console.ReadLine()); 

    
}
