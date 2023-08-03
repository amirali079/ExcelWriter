using NPOI.XSSF.Streaming;

// use NPOI last version for write Excel

string filePath = "npoiFileTest.xlsx";
using var stream = new FileStream(filePath, FileMode.Create);

var workbook = new SXSSFWorkbook(2000);
workbook.Write(stream);
