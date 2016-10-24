namespace BSmart.StateMachine
{
  class EvaluatingSolution : IGameState
  {
    GameStateMachine gameStateMachine;

    public EvaluatingSolution(GameStateMachine gsm)
    {
      gameStateMachine = gsm;
    }

    public GameStates InternalState
    {
      get { return GameStates.EVALUATING_SOLUTION; }
      set { /* empty */ }
    }

    public void StartGame()
    { /* empty */ }

    public void StopGame()
    {
      gameStateMachine.SetNewGameState(gameStateMachine.GameIsNotRunning);
    }

    public void GenerateExercise()
    {
      gameStateMachine.SetNewGameState(gameStateMachine.GeneratingExercise);
    }

    public void WaitForSolution()
    { /* empty */ }

    public void EvaluateSolution()
    { /* empty */ }
  }
}
