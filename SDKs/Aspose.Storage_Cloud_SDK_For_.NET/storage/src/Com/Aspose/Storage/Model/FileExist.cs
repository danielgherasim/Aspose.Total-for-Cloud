using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Storage.Model {
  public class FileExist {
    public bool IsExist { get; set; }

    public bool IsFolder { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileExist {\n");
      sb.Append("  IsExist: ").Append(IsExist).Append("\n");
      sb.Append("  IsFolder: ").Append(IsFolder).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
