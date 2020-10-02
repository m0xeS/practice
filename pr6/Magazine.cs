using System;
using System.Collections.Generic;
using System.Text;

namespace pr6
{
  class Magazine
  {
    private string m_name;
    private Frequency _frequency;
    private DateTime date_time;
    private int tirazh;
    private List<Article> articles;
    public Magazine(string name, Frequency frec, DateTime m_Date, int num)
    {
      m_name = name;
      _frequency = frec;
      date_time = m_Date;
      tirazh = num;
      articles = new List<Article>;
    }
    public Magazine()
    {
      m_name = "def_name";
      _frequency = Frequency.Monthly;
      date_time = DateTime.Now;
      tirazh = 100;
      articles = new List<Article>();
    }
    public string Mag_Name
    {
      get => m_name;
      set => m_name = value;
    }
    public Frequency frequency
    {
      get => _frequency;
      set => _frequency = value;
    }
    public DateTime Date_Time
    {
      get => date_time;
      set => date_time = value;
    }
    public int num
    {
      get => tirazh;
      set => tirazh = value;
    }
    public List<Article> Articles
    {
      get => articles;
      set => articles = value;
    }
  }
}
