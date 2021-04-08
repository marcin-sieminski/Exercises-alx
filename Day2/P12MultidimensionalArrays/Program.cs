namespace P12MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] twoDimensionalArray = new string[3, 4];

            twoDimensionalArray[0, 0] = "01";
            twoDimensionalArray[1, 0] = "02";
            twoDimensionalArray[2, 0] = "03";

            twoDimensionalArray[0, 1] = "04";
            twoDimensionalArray[1, 1] = "05";
            twoDimensionalArray[2, 1] = "06";

            twoDimensionalArray[0, 2] = "07";
            twoDimensionalArray[1, 2] = "08";
            twoDimensionalArray[2, 2] = "09";

            twoDimensionalArray[0, 3] = "10";
            twoDimensionalArray[1, 3] = "11";
            twoDimensionalArray[2, 3] = "12";

            int arrayLength = twoDimensionalArray.Length; // 3*4

            int a1Length = twoDimensionalArray.GetLength(0); //3
            int a2Length = twoDimensionalArray.GetLength(1); //4

            int[,,] threeDimensionalArray = new int[2, 1, 3];
        }
    }
}
