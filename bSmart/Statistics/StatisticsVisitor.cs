namespace BSmart.Statistics
{
  using System;

  public class StatisticsVisitor
  {
    public virtual string Visit<T>(StatItem<T> statItem)
    {
      return statItem.Value.ToString();
    }
  }

  public class UpdateStatisticsVisitor
  {
    public virtual void VisitUpdate<T>(StatItem<T> statItem, T newValue)
    {
      statItem.Value = newValue;
    }

    public virtual void VisitAdd<T>(StatItem<T> statItem, T newValue, Action<StatItem<T>, T> adder)
    {
      adder(statItem, newValue);
    }

    public virtual void VisitIncrement<T>(StatItem<T> statItem, Action<StatItem<T>> incrementer)
    {
      incrementer(statItem);
    }
  }
}
