namespace BSmart.Statistics
{
  using System;

  public class StatisticsBase
  {
    public string Accept<T>(StatisticsVisitor sv, StatItem<T> si)
    {
      return sv.Visit(si);
    }

    public void AcceptUpdate<T>(UpdateStatisticsVisitor usv, StatItem<T> si, T value)
    {
      usv.VisitUpdate(si, value);
    }

    public void AcceptAdd<T>(UpdateStatisticsVisitor usv, StatItem<T> si, T value, Action<StatItem<T>, T> adder)
    {
      usv.VisitAdd(si, value, adder);
    }

    public void AcceptIncrement<T>(UpdateStatisticsVisitor usv, StatItem<T> si, Action<StatItem<T>> incrementer)
    {
      usv.VisitIncrement(si, incrementer);
    }
  }
}
