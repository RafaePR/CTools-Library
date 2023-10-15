namespace CTools;
public class ArrayDouble
{
    public static int ValueIndex(double[] array, string type)
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
    public static double Value(double[] array, string type)
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
    public static double Sum(double[] array)
    {
        double sum = 0;
        
        for(int i=0; i<array.Length; i++){
            sum += array[i];
        }
        return sum;
    }
    public static double Average(double[] array)
    {
        int length = array.Length;
        double sum = 0;

        for(int i=0; i<length; i++){
            sum += array[i];
        }
        return sum / length;
    }
}
