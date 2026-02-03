int[] arr = new int[5]; // масив з 5 елементів 0 0 0 0 0
int ind = 0;
//arr[5] = 10; // викличе виняток IndexOutOfRangeException

try // зовнішній блок try
{
    for (int div = -3; div <= 3; ++div, ++ind) // -3 -2 -1 0 1 2 3
    {
        try // внутрішній блок try
        {
            arr[ind] = 100 / div;
            Console.WriteLine("arr[{0}] = 100 / {1} ----- {2}", ind, div, arr[ind]);

        }
        catch (DivideByZeroException ex) // внутрішній блок catch
        {
            Console.WriteLine(ex.Message);

        }
       
        finally
        {
            Console.WriteLine("\tInner finally");
        }
    }
}
catch (IndexOutOfRangeException ex) // зовнішній блок catch
{
    Console.WriteLine(ex.Message);
}
finally // зовнішній блок finally
{
    Console.WriteLine("\nOutter finally");
}
       