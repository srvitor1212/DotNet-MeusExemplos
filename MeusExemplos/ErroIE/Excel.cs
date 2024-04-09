using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace InventarioEletronicoUtils.Tools
{
    public class Excel
    {
        public void ConvertCsvToXlsx(string pathName)
        {
            string csvPath = pathName;
            string xlsxPath = pathName.Replace("csv", "xlsx");

            var format = new ExcelTextFormat();
            format.Delimiter = ';';
            format.EOL = "\r\n";
            format.TextQualifier = '"';
            format.Encoding = Encoding.Default;

            using (ExcelPackage package = new ExcelPackage(new FileInfo(xlsxPath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(xlsxPath);
                /*TRATAMENTO PARA RELATORIOS ESPECIFICOS QUE VEM DO PROMAX*/
                if (xlsxPath.Contains("02_05_02"))
                {
                    format.DataTypes = new eDataTypes[] {
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.Number,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String
                    };
                }

                if (xlsxPath.Contains("02_02_20"))
                {
                    format.DataTypes = new eDataTypes[] {
                        eDataTypes.Number,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String

                    };
                }

                if (xlsxPath.Contains("02_05_18"))
                {
                    format.DataTypes = new eDataTypes[] {
                        eDataTypes.Number,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String,
                        eDataTypes.String

                    };
                }

                worksheet.Cells["A1"].LoadFromText(new FileInfo(csvPath), format, OfficeOpenXml.Table.TableStyles.None, false);
                package.Save();
            }
        }
    }
}
