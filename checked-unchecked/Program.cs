
namespace Checked_Unchecked
{
    class Program
    {
        public static void Main()
        {
            // byte: 0..255
            byte b2, b1 = 244;
            for (int i = 0; i < 22; i++)
            {
                Console.WriteLine("b1 = {0,4}", b1);
                b1++;
            }
            Console.ReadKey(true);
            b1 = 244;
            b2 = 250;
            for (int i = 0; i < 22; i++)
            {
                Console.Write("\nb1 = {0,4}  b2 = {1,4}", b1, b2);
                try
                {
                    checked // застосовуємо перевірку переповнення
                    {
                        b1++; // переповнення по типу byte генеруватиме OverflowException
                        unchecked
                        {
                            b2++;	// переповнення не генеруватиме OverflowException, бо у блоці unchecked
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Write("   ---  overflow! {0}", e.Message);
                    b1 = 244;
                }

            }
            Console.ReadKey(true);

            Console.WriteLine("\n\n ___________ type cast ______________");
            int iVal = 259;
            checked
            {
                byte b4 = unchecked((byte)iVal);
                Console.WriteLine("1    iVal = {0},  b4 = {1}", iVal, b4);
            }
            try
            {
                byte b3 = checked((byte)iVal);
                Console.WriteLine("2    iVal = {0},  b3 = {1}", iVal, b3);
            }
            catch (Exception e)
            {
                Console.WriteLine("2    iVal = {0},  overflow! {1}", iVal, e.Message);
            }
            Console.ReadKey(true);




        }

    }
}
