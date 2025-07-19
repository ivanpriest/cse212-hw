public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Creating the list for the multiples
        List<double> MultiplesList = new List<double>();
        // Step 2: Using the for loop to for the iteration
        for (int i = 1; i < length + 1; ++i)
        {
            MultiplesList.Add(i * number);
        }
        ;
        // Step 3: return the Array
        return MultiplesList.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
    // Step 1: Calculate the split index
    int splitIndex = data.Count - amount;

    // Step 2: Get the two slices of the list
    List<int> tail = data.GetRange(splitIndex, amount);
    List<int> front = data.GetRange(0, splitIndex);

    // Step 3: Combine the two parts
    List<int> rotated = new List<int>();
    rotated.AddRange(tail);
    rotated.AddRange(front);

    // Step 4: Print the entire list as one string
    Console.WriteLine($"Rotated List: [{string.Join(", ", rotated)}]");
    }

}
