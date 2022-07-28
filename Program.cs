//Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive"

class Consecutive
{
    static void Main()
    {
        Console.WriteLine("--Enter few number eg:(1-2-3-4) --");
        var input = Console.ReadLine();

        var inputList = new List<int>();
        foreach(var item in input.Split('-'))
            inputList.Add(Convert.ToInt32(item));

        inputList.Sort();

        var isConsecutive = true;
        for(int i = 1; i < inputList.Count; i++)
        {
            if (inputList[i] != inputList[i - 1] + 1)
            {
                isConsecutive = false;
                break;

            }
        }
            

        if (isConsecutive == true)
            Console.WriteLine(" numbers are consecutive ");

        else
            Console.WriteLine("numbers are not consecutive ");


    }

}