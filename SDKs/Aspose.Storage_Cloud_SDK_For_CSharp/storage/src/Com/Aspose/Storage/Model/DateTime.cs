using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Storage.Model {
  public class DateTime {
    public int Year { get; set; }

    public int Month { get; set; }

    public int Day { get; set; }

    public int Hour { get; set; }

    public int Minute { get; set; }

    public int Second { get; set; }

    public int Millisecond { get; set; }

    public string DayOfWeek { get; set; }

    public int DayOfYear { get; set; }

    public string Kind { get; set; }

    public long Ticks { get; set; }

    public string TimeOfDay { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DateTime {\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  Day: ").Append(Day).Append("\n");
      sb.Append("  Hour: ").Append(Hour).Append("\n");
      sb.Append("  Minute: ").Append(Minute).Append("\n");
      sb.Append("  Second: ").Append(Second).Append("\n");
      sb.Append("  Millisecond: ").Append(Millisecond).Append("\n");
      sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
      sb.Append("  DayOfYear: ").Append(DayOfYear).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Ticks: ").Append(Ticks).Append("\n");
      sb.Append("  TimeOfDay: ").Append(TimeOfDay).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
