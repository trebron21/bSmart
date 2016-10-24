namespace BSmart.QuizMaster
{
  interface ISmartGame
  {
    string GiveMeAnExercisePlease();

    bool CheckMySolutionPlease(double usersSolution);

    void IHaveNoClueSpinItPlease();

    void ResetMyEntireGamePlease();

    void ResetMyCurrentRunPlease();
  }
}
