namespace BSmart.QuizMaster
{
  interface ISmartGameStatistics
  {
    string GiveMeTheNumOfCorrectAnswersStr();
    int GiveMeTheNumOfCorrectAnswers();

    string GiveMeTheNumOfIncorrectAnswersStr();
    int GiveMeTheNumOfIncorrectAnswers();

    string GiveMeTheNumOfSpunAnswersStr();
    int GiveMeTheNumOfSpunAnswers();

    string GiveMeTheNumOfGamesPlayedStr();
    int GiveMeTheNumOfGamesPlayed();

    string OverallSumOfCorrectAnswersStr();
    double OverallSumOfCorrectAnswers();

    string OverallSumOfIncorrectAnswersStr();
    double OverallSumOfIncorrectAnswers();

    string OverallSumOfSpunAnswersStr();
    double OverallSumOfSpunAnswers();
  }
}
