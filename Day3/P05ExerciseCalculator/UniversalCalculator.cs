namespace P05ExerciseCalculator
{
    public class UniversalCalculator
    {
        public OperationType OperationType { get; set; }

        public int? Calculate(int a, int b)
        {
            if (OperationType == OperationType.Add)
            {
                return new AddingCalculator().Add(a, b);
            }
            else if (OperationType == OperationType.Subtract)
            {
                return new SubtractingCalculator().Subtract(a, b);
            }
            else
            {
                return null;
            }
        }
    }
}
