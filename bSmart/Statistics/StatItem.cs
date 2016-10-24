namespace BSmart.Statistics
{
  using System;
  using System.Collections.Generic;
  public class StatItem<T>
  {
    private T m_value;

    public StatItem(T newVal)
    {
      m_value = newVal;
    }

    public T Value
    {
      get { return m_value; }

      set { this.m_value = value; }
    }
  }
}
