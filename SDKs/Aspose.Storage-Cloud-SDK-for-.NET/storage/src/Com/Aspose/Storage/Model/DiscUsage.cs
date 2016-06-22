using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Storage.Model {
  public class DiscUsage {
    public long UsedSize { get; set; }

    public long TotalSize { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscUsage {\n");
      sb.Append("  UsedSize: ").Append(UsedSize).Append("\n");
      sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
