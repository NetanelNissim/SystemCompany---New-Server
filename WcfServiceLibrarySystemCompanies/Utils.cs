using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace WcfServiceLibrarySystemCompanies
{
  public class Utils
  {
      public static string ConvertDataTableToXML(DataTable dtBuildSQL, string tableName)
      {
          DataSet dsBuildSQL = new DataSet();
          StringBuilder sbSQL;
          StringWriter swSQL;
          string XMLformat;

          sbSQL = new StringBuilder();
          swSQL = new StringWriter(sbSQL);
          dsBuildSQL.Merge(dtBuildSQL, true, MissingSchemaAction.AddWithKey);
          dsBuildSQL.Tables[0].TableName = tableName;
          foreach (DataColumn col in dsBuildSQL.Tables[0].Columns)
          {
              col.ColumnMapping = MappingType.Attribute;
          }
          dsBuildSQL.WriteXml(swSQL, XmlWriteMode.WriteSchema);

          dsBuildSQL.WriteXml(@"C:\Test2.xml", XmlWriteMode.DiffGram);
          dsBuildSQL.WriteXml(@"C:\Test3.xml", XmlWriteMode.IgnoreSchema);
          dsBuildSQL.WriteXml(@"C:\Test4.xml", XmlWriteMode.WriteSchema);
     // Get a FileStream object
         // StreamWriter xmlDoc = new StreamWriter("C:/"+tableName+"/Testdo.xml");
           // StreamWriter xmlDoc = new StreamWriter("C:/Testdo.xml");
        // Apply the WriteXml method to write an XML document
        //  dsBuildSQL.WriteXml(@"C:\Test1", true);

          XMLformat = sbSQL.ToString();
          return XMLformat;
      }


      public static string ConvertDataTableToString(DataTable dataTable)
      {
          var output = new StringBuilder();

          var columnsWidths = new int[dataTable.Columns.Count];

          // Get column widths
          foreach (DataRow row in dataTable.Rows)
          {
              for (int i = 0; i < dataTable.Columns.Count; i++)
              {
                  var length = row[i].ToString().Length;
                  if (columnsWidths[i] < length)
                      columnsWidths[i] = length;
              }
          }

          // Get Column Titles
          for (int i = 0; i < dataTable.Columns.Count; i++)
          {
              var length = dataTable.Columns[i].ColumnName.Length;
              if (columnsWidths[i] < length)
                  columnsWidths[i] = length;
          }

          // Write Column titles
          for (int i = 0; i < dataTable.Columns.Count; i++)
          {
              var text = dataTable.Columns[i].ColumnName;
              output.Append("|" + PadCenter(text, columnsWidths[i] + 2));
          }
          output.Append("|\n" + new string('=', output.Length) + "\n");

          // Write Rows
          foreach (DataRow row in dataTable.Rows)
          {
              for (int i = 0; i < dataTable.Columns.Count; i++)
              {
                  var text = row[i].ToString();
                  output.Append("|" + PadCenter(text, columnsWidths[i] + 2));
              }
              output.Append("|\n");
          }
          return output.ToString();
      }

      private static string PadCenter(string text, int maxLength)
      {
          int diff = maxLength - text.Length;
          return new string(' ', diff / 2) + text + new string(' ', (int)(diff / 2.0 + 0.5));

      } 


  }
}
