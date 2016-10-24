namespace BSmart.QuizMaster
{
  using System.Diagnostics;
  using System.Collections.Generic;
  using System.Timers;

  class QuizTimer : Timer
  {
    private int m_gameDurationInMilliseconds = 60 * 1000;

    // Corresponds to the GameDurations enum - a really baaad idea
    private static List<int> s_PossibleGameDurations = new List<int>() { 15, 30, 60, 90, 120 };

    public QuizTimer()
    {
      Elapsed += TimedOutEvent;
    }

    public int GameDurationInSeconds
    {
      get { return m_gameDurationInMilliseconds / 1000; }
      set { m_gameDurationInMilliseconds = value * 1000; }
    }

    public static List<int> S_PossibleGameDurations
    {
      get { return s_PossibleGameDurations; }
      private set { /* empty */}
    }

    public void InitTimer()
    {
      Interval = m_gameDurationInMilliseconds;
      AutoReset = false;
      Enabled = false;
    }

    private void TimedOutEvent(object sender, ElapsedEventArgs e)
    {
      Trace.TraceInformation("{0}: The time is up.", System.DateTime.UtcNow);

      Stop();
    }
  }
}
