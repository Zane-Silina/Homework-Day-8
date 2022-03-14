Console.WriteLine("Please enter the first value.");
double firstNum = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the operation sign.");
char act = char.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second value.");
double secondNum = double.Parse(Console.ReadLine());

switch (act) {
    case '+':
        Console.WriteLine($"The result is: {firstNum + secondNum}");
        break;
        case '-':
        Console.WriteLine($"The result is: {firstNum - secondNum}");
        break;
    case '*':
        Console.WriteLine($"The result is: {firstNum * secondNum}");
        break;
    case '/':
        Console.WriteLine($"The result is: {firstNum / secondNum}");
        break;
    case '%':
        Console.WriteLine($"The result is: {firstNum % secondNum}");
        break;
    case 'p':
        Console.WriteLine($"Element No.1 = {firstNum}. Element No.2 = {secondNum}");
        break;
    case 'b': 
        if (firstNum < secondNum)
        {
            Console.WriteLine($"The biggest element is: {secondNum}");
}
        else if (firstNum > secondNum) { 
            Console.WriteLine($"The biggest element is: {firstNum}");
        }
        else if (firstNum == secondNum) {
            Console.WriteLine("Both elements are equal");
        }
        break;
    case 's':
        if (firstNum < secondNum)
        {
            Console.WriteLine($"The smallest element is: {firstNum}");
        }
        else if (firstNum > secondNum)
        {
            Console.WriteLine($"The smallest element is: {secondNum}");
        }
        else if (firstNum == secondNum) {
            Console.WriteLine("Both elements are equal");
        }
        break;

    default:
        Console.WriteLine("Invalid input");
        break;
}
