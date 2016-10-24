namespace BSmart.QuizMaster
{
  using System;
  using System.Diagnostics;
  using System.Collections.Generic;
  using System.Text;
  using System.Timers;
  using BSmart.StateMachine;
  using BSmart.Exercises;

  public enum GameDurations : int
  {
    _15_ = 0,
    _30_ = 1,
    _60_ = 2,
    _90_ = 3,
    _120_ = 4
  }

  public class TheQuizMaster : GameStateMachine, ISmartGame, ISmartGameStatistics
  {
    private Exercises.Exercise m_currentExercise;
    private Exercises.ExerciseFactory m_exerciseFactory = new Exercises.ExerciseFactory();

    private Statistics.StatisticsVisitor m_statisticsVisitor = new Statistics.StatisticsVisitor();
    private Statistics.UpdateStatisticsVisitor m_updateStatisticsVisitor = new Statistics.UpdateStatisticsVisitor();
    private Statistics.CurrentGameStats m_currentGameStats = new Statistics.CurrentGameStats();
    private Statistics.OverallStats m_overallStats = new Statistics.OverallStats();

    /**
     * The QuizMaster handles the timer
     */
    QuizTimer smartTimer = new QuizTimer();

    public TheQuizMaster()
    {
    }

    public int GameDurationInSeconds
    {
      get { return smartTimer.GameDurationInSeconds; }
      set { smartTimer.GameDurationInSeconds = value; }
    }

    public Exercise CurrentExercise
    {
      get { return m_currentExercise; }
      set { m_currentExercise = value; }
    }

    private void StopIt(object sender, ElapsedEventArgs e)
    {
      this.StopGame();
    }



    /**
     * Internal methods for reseting statistics
     */
    private void ResetCurrentStatistics()
    {
      m_currentGameStats.AcceptUpdate(m_updateStatisticsVisitor, m_currentGameStats.NumOfCorrectAnswers, 0);
      m_currentGameStats.AcceptUpdate(m_updateStatisticsVisitor, m_currentGameStats.NumOfIncorrectAnswers, 0);
      m_currentGameStats.AcceptUpdate(m_updateStatisticsVisitor, m_currentGameStats.NumOfSpunAnswers, 0);
    }

    private void ResetOverallStatistics()
    {
      m_overallStats.AcceptUpdate(m_updateStatisticsVisitor, m_overallStats.NumOfGamesPlayed, 0);
      m_overallStats.AcceptUpdate(m_updateStatisticsVisitor, m_overallStats.AvgOfCorrectAnswers, 0);
      m_overallStats.AcceptUpdate(m_updateStatisticsVisitor, m_overallStats.AvgOfIncorrectAnswers, 0);
      m_overallStats.AcceptUpdate(m_updateStatisticsVisitor, m_overallStats.AvgOfSpunAnswers, 0);
    }



    /**
     * Interface methods for UI to gain access to StatisticsVisitor
     */
    public string GiveMeTheNumOfCorrectAnswersStr()
    {
      return m_currentGameStats.Accept(m_statisticsVisitor, m_currentGameStats.NumOfCorrectAnswers);
    }
    public int GiveMeTheNumOfCorrectAnswers()
    {
      return m_currentGameStats.NumOfCorrectAnswers.Value;
    }

    public string GiveMeTheNumOfIncorrectAnswersStr()
    {
      return m_currentGameStats.Accept(m_statisticsVisitor, m_currentGameStats.NumOfIncorrectAnswers);
    }
    public int GiveMeTheNumOfIncorrectAnswers()
    {
      return m_currentGameStats.NumOfIncorrectAnswers.Value;
    }

    public string GiveMeTheNumOfSpunAnswersStr()
    {
      return m_currentGameStats.Accept(m_statisticsVisitor, m_currentGameStats.NumOfSpunAnswers);
    }
    public int GiveMeTheNumOfSpunAnswers()
    {
      return m_currentGameStats.NumOfSpunAnswers.Value;
    }

    public string GiveMeTheNumOfGamesPlayedStr()
    {
      return m_overallStats.Accept(m_statisticsVisitor, m_overallStats.NumOfGamesPlayed);
    }
    public int GiveMeTheNumOfGamesPlayed()
    {
      return m_overallStats.NumOfGamesPlayed.Value;
    }

    public string OverallSumOfCorrectAnswersStr()
    {
      return m_overallStats.Accept(m_statisticsVisitor, m_overallStats.AvgOfCorrectAnswers);
    }
    public double OverallSumOfCorrectAnswers()
    {
      return m_overallStats.AvgOfCorrectAnswers.Value;
    }

    public string OverallSumOfIncorrectAnswersStr()
    {
      return m_overallStats.Accept(m_statisticsVisitor, m_overallStats.AvgOfIncorrectAnswers);
    }
    public double OverallSumOfIncorrectAnswers()
    {
      return m_overallStats.AvgOfIncorrectAnswers.Value;
    }

    public string OverallSumOfSpunAnswersStr()
    {
      return m_overallStats.Accept(m_statisticsVisitor, m_overallStats.AvgOfSpunAnswers);
    }
    public double OverallSumOfSpunAnswers()
    {
      return m_overallStats.AvgOfSpunAnswers.Value;
    }



    /**
     * Gamestate influencing interface methods
     */
    public override void StartGame()
    {
      base.StartGame();
      //base.GenerateExercise();

      smartTimer.InitTimer();
      smartTimer.Elapsed += StopIt;
      smartTimer.Start();
    }

    public override void StopGame()
    {
      smartTimer.Elapsed -= StopIt;

      if (smartTimer.Enabled) // The user (UI) stopped the game
      {
        smartTimer.Stop();
        return;
      }

      m_overallStats.AcceptIncrement(m_updateStatisticsVisitor, m_overallStats.NumOfGamesPlayed, Incrementer);

      m_overallStats.AcceptAdd(m_updateStatisticsVisitor, m_overallStats.AvgOfCorrectAnswers,
                               GiveMeTheNumOfCorrectAnswers(), Adder);
      m_overallStats.AcceptAdd(m_updateStatisticsVisitor, m_overallStats.AvgOfIncorrectAnswers,
                               GiveMeTheNumOfIncorrectAnswers(), Adder);
      m_overallStats.AcceptAdd(m_updateStatisticsVisitor, m_overallStats.AvgOfSpunAnswers,
                               GiveMeTheNumOfSpunAnswers(), Adder);

      base.StopGame();
    }

    public void IHaveNoClueSpinItPlease()
    {
      base.EvaluateSolution();

      m_currentGameStats.AcceptIncrement(m_updateStatisticsVisitor, m_currentGameStats.NumOfSpunAnswers, Incrementer);
    }

    public bool CheckMySolutionPlease(double usersSolution)
    {
      base.EvaluateSolution();

      if (usersSolution == CurrentExercise.GetSmartSolution())
      {
        m_currentGameStats.AcceptIncrement(m_updateStatisticsVisitor,
                                           m_currentGameStats.NumOfCorrectAnswers, Incrementer);
        return true;
      }

      m_currentGameStats.AcceptIncrement(m_updateStatisticsVisitor,
                                         m_currentGameStats.NumOfIncorrectAnswers, Incrementer);
      return false;
    }

    public void ResetMyEntireGamePlease()
    {
      CurrentExercise = m_exerciseFactory.FabricateNoopExercise();

      ResetCurrentStatistics();
      ResetOverallStatistics();
    }

    public void ResetMyCurrentRunPlease()
    {
      CurrentExercise = m_exerciseFactory.FabricateNoopExercise();
      ResetCurrentStatistics();
    }

    public string GiveMeAnExercisePlease()
    {
      base.GenerateExercise();

      Exercises.Exercise smartExercise = m_exerciseFactory.FabricateNoopExercise();

      Random random = new Random();

      switch ( (random.Next(1000) % (int)(Exercises.Operations.NUM_OF_EXERCISES-1)) + 1 )
      {
        case (int)Exercises.Operations.ADD:
        {
          smartExercise = m_exerciseFactory.FabricateAdditionExercise();
          break;
        }
        case (int)Exercises.Operations.SUBSTRACT:
        {
          smartExercise = m_exerciseFactory.FabricateSubstractionExercise();
          break;
        }
        case (int)Exercises.Operations.MULTIPLY:
        {
          smartExercise = m_exerciseFactory.FabricateMultiplicationExercise();
          break;
        }
        case (int)Exercises.Operations.DIVIDE:
        {
          smartExercise = m_exerciseFactory.FabricateDivisionExercise();
          break;
        }
        default:
          break;
      }

      CurrentExercise = smartExercise;

      base.WaitForSolution();

      return (smartExercise.GetLeftOperandAsString() + ' ' +
              smartExercise.OperatorAsString + ' ' +
              smartExercise.GetRightOperandAsString());
    }



    /**
     * Helper methods for StatisticsVisitor
     */
    public static void Adder(Statistics.StatItem<int> item, int value) { item.Value += value; }
    public static void Adder(Statistics.StatItem<double> item, double value) { item.Value += value; }

    public static void Incrementer(Statistics.StatItem<int> item) { ++item.Value; }
    public static void Incrementer(Statistics.StatItem<double> item) { ++item.Value; }
  }
}
