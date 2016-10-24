namespace BSmart.StateMachine
{
  public enum GameStates : int
  {
    STOPPED = 0,
    STARTED = 1,
    GENERATING_EXERCISE = 2,
    WAITING_FOR_SOLUTION = 3,
    EVALUATING_SOLUTION = 4
  }

  public interface IGameState
  {
    GameStates InternalState { get; set; }

    void StartGame();

    void StopGame();

    void GenerateExercise();

    void WaitForSolution();

    void EvaluateSolution();
  }
}
