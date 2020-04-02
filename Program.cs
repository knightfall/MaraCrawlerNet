using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace MaraCrawlerNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Mara mara = JsonConvert.DeserializeObject<Mara>(File.ReadAllText("../../../mara.json"));
            
            int i = 0;

            List<ResultClass> asd = new List<ResultClass>();
            List<ShortResult> shortResults = new List<ShortResult>();
            int x = 0;
            int y = 0;
            for (int a = 0; a < mara.Result.Count; a++)
            {
                if (mara.Result[a].DisplaySanctionedDate != null && mara.Result[a].DisplayCeasedDate == "01 Jan 0001")
                {
                    if (mara.Result[a].PrimaryBusiness == null && mara.Result[a].DisplayBusiness!= null)
                    {
                        shortResults.Add(new ShortResult
                        {
                            ABN = mara.Result[a].DisplayBusiness.Abn,
                            MARN = mara.Result[a].Marn,
                            Salutation = mara.Result[a].Name.Salutation,
                            GivenName = mara.Result[a].Name.GivenName,
                            FamilyName = mara.Result[a].Name.FamilyName,
                            Role = mara.Result[a].DisplayBusiness.Relationship,
                            Classfication = mara.Result[a].DisplayBusiness.BusinessClassification,
                            Type = mara.Result[a].DisplayBusiness.BusinessType,
                            EntityName = mara.Result[a].DisplayBusiness.EntityName,
                            BusinessName = mara.Result[a].DisplayBusiness.Name,
                            Phone = mara.Result[a].DisplayBusiness.Contact.Phone.FullNumber,
                            Phone2 = "",
                            Email1 = mara.Result[a].DisplayBusiness.Contact.EmailAddress1,
                            Address = string.Join(" ", Regex.Split(mara.Result[a].DisplayBusiness.Address.FullAddress, @"(?:\r\n|\n|\r)")),
                            Suburb = mara.Result[a].DisplayBusiness.Address.Suburb,
                            State = mara.Result[a].DisplayBusiness.Address.State,
                            Country = mara.Result[a].DisplayBusiness.Address.Country,
                            IsNoFee = mara.Result[a].IsNoFee.ToString(),
                            Secondary = mara.Result[a].SecondaryBusinesses.Count
                        });
                    }
                    else if (mara.Result[a].PrimaryBusiness != null)
                    {
                        shortResults.Add(new ShortResult
                        {
                            ABN = mara.Result[a].PrimaryBusiness.Abn,
                            MARN = mara.Result[a].Marn,
                            Salutation = mara.Result[a].Name.Salutation,
                            GivenName = mara.Result[a].Name.GivenName,
                            FamilyName = mara.Result[a].Name.FamilyName,
                            Role = mara.Result[a].PrimaryBusiness.Relationship,
                            Classfication = mara.Result[a].PrimaryBusiness.BusinessClassification,
                            Type = mara.Result[a].PrimaryBusiness.BusinessType,
                            EntityName = mara.Result[a].PrimaryBusiness.EntityName,
                            BusinessName = mara.Result[a].PrimaryBusiness.Name,
                            Phone = mara.Result[a].PrimaryBusiness.Contact.Phone.FullNumber,
                            Phone2 = "",
                            Email1 = mara.Result[a].PrimaryBusiness.Contact.EmailAddress1,
                            Address = string.Join(" ", Regex.Split(mara.Result[a].DisplayBusiness.Address.FullAddress, @"(?:\r\n|\n|\r)")),
                            Suburb = mara.Result[a].PrimaryBusiness.Address.Suburb,
                            State = mara.Result[a].PrimaryBusiness.Address.State,
                            Country = mara.Result[a].PrimaryBusiness.Address.Country,
                            IsNoFee = mara.Result[a].IsNoFee.ToString(),
                            Secondary = mara.Result[a].SecondaryBusinesses.Count
                        });
                    }
                }
            }
            int f = 0;
            string ddd = JsonConvert.SerializeObject(shortResults);
            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(shortResults), (typeof(DataTable)));
            using (SpreadsheetDocument document = SpreadsheetDocument.Create("TestNewData.xlsx", SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                var sheetData = new SheetData();
                worksheetPart.Worksheet = new Worksheet(sheetData);

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };

                sheets.Append(sheet);

                Row headerRow = new Row();

                List<String> columns = new List<string>();
                foreach (System.Data.DataColumn column in table.Columns)
                {
                    columns.Add(column.ColumnName);

                    Cell cell = new Cell();
                    cell.DataType = CellValues.String;
                    cell.CellValue = new CellValue(column.ColumnName);
                    headerRow.AppendChild(cell);
                }

                sheetData.AppendChild(headerRow);

                foreach (DataRow dsrow in table.Rows)
                {
                    Row newRow = new Row();
                    foreach (String col in columns)
                    {
                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;
                        cell.CellValue = new CellValue(dsrow[col].ToString());
                        newRow.AppendChild(cell);
                    }

                    sheetData.AppendChild(newRow);
                }

                workbookPart.Workbook.Save();
            }

        }
    }
}
