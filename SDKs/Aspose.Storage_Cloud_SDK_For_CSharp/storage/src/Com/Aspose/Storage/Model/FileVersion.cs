using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Storage.Model {
  public class FileVersion {
    public string VersionId { get; set; }

    public bool IsLatest { get; set; }

    public string Name { get; set; }

    public bool IsFolder { get; set; }

    public DateTime ModifiedDate { get; set; }

    public long Size { get; set; }

    public string Path { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileVersion {\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  IsFolder: ").Append(IsFolder).Append("\n");
      sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
