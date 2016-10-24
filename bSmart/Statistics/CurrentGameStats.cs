namespace BSmart.Statistics
{
  public class CurrentGameStats : StatisticsBase
  {
    private StatItem<int> m_numOfCorrectAnswers = new StatItem<int>(0);
    private StatItem<int> m_numOfIncorrectAnswers = new StatItem<int>(0);
    private StatItem<int> m_numOfSpunAnswers = new StatItem<int>(0);

    public StatItem<int> NumOfCorrectAnswers
    {
      get { return m_numOfCorrectAnswers; }
    }

    public StatItem<int> NumOfIncorrectAnswers
    {
      get { return m_numOfIncorrectAnswers; }
    }

    public StatItem<int> NumOfSpunAnswers
    {
      get { return m_numOfSpunAnswers; }
    }
  }
}
