namespace BSmart.Exercises
{
  public enum Operations : int
  {
    NOOP = 0,
    ADD = 1,
    SUBSTRACT = 2,
    MULTIPLY = 3,
    DIVIDE = 4,

    NUM_OF_EXERCISES // this must stay the last
  };

  class ExerciseFactory
  {
    public Exercise FabricateNoopExercise()
    {
      return new Noop();
    }

    public Exercise FabricateAdditionExercise()
    {
      return new Addition();
    }

    public Exercise FabricateSubstractionExercise()
    {
      return new Substraction();
    }

    public Exercise FabricateMultiplicationExercise()
    {
      return new Multiplication();
    }

    public Exercise FabricateDivisionExercise()
    {
      return new Division();
    }
  }
}
