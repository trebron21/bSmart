namespace BSmart.Statistics
{
  public class OverallStats : StatisticsBase
  {
    private StatItem<int> m_numOfGamesPlayed = new StatItem<int>(0);
    private StatItem<double> m_avgOfCorrectAnswers = new StatItem<double>(0);
    private StatItem<double> m_avgOfIncorrectAnswers = new StatItem<double>(0);
    private StatItem<double> m_avgOfSpunAnswers = new StatItem<double>(0);

    public StatItem<int> NumOfGamesPlayed
    {
      get { return m_numOfGamesPlayed; }
    }

    public StatItem<double> AvgOfCorrectAnswers
    {
      get { return m_avgOfCorrectAnswers; }
    }

    public StatItem<double> AvgOfIncorrectAnswers
    {
      get { return m_avgOfIncorrectAnswers; }
    }

    public StatItem<double> AvgOfSpunAnswers
    {
      get { return m_avgOfSpunAnswers; }
    }

    public double GetOverallCorrectInPercentile()
    {
      double sumOfAvgs = m_avgOfCorrectAnswers.Value + m_avgOfIncorrectAnswers.Value + m_avgOfSpunAnswers.Value;
      return (sumOfAvgs / m_numOfGamesPlayed.Value);
    }
  }
}
