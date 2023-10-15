namespace CTools;
public class ArrayInt
{
    public static int ValueIndex(int[] array, string type)
    {
        type.ToLower();
        if(type == "max")
        {
            int maxIndex = 0;
            for(int i=0; i<array.Length; i++)
            {
                if(i == 0){ continue; }
                else
                {
                    if(array[i] > array[maxIndex]){
                        maxIndex = i;
                    }
                }    
            }
            return maxIndex;
        }
        else if(type == "min")
        {
            int minIndex = 0;
            for(int i=0; i<array.Length; i++)
            {
                if(i == 0){ continue; }
                else
                {
                    if(array[i] < array[minIndex]){
                        minIndex = i;
                    }
                }    
            }
            return minIndex;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(" ValueIndex Command: Error - Invalid type for second parameter "+
                "pass either max or min.");
            return -1;
        }
    }
    public static int Value(int[] array, string type)
    {
        type.ToLower();
        if(type == "max")
        {
            int maxIndex = 0;
            for(int i=0; i<array.Length; i++)
            {
                if(i == 0){ continue; }
                else
                {
                    if(array[i] > array[maxIndex]){
                        maxIndex = i;
                    }
                }    
            }
            return array[maxIndex];
        }
        else if(type == "min")
        {
            int minIndex = 0;
            for(int i=0; i<array.Length; i++)
            {
                if(i == 0){ continue; }
                else
                {
                    if(array[i] < array[minIndex]){
                        minIndex = i;
                    }
                }    
            }
            return array[minIndex];
        }
        else
        {
            Console.Clear();
            Console.WriteLine(" Value Command: Error - Invalid type for second parameter "+
                "pass either max or min.");
            return -1;
        }
    }
    public static int Sum(int[] array)
    {
        int sum = 0;
        for(int i=0; i<array.Length; i++){
            sum += array[i];
        }
        return sum;
    }
    public static double Average(int[] array)
    {
        int length = array.Length;
        int sum = 0;

        for(int i=0; i<length; i++){
            sum += array[i];
        }
        return Convert.ToDouble(sum) / length;
    }
}
