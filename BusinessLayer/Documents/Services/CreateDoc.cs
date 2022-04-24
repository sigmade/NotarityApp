using BusinessLayer.Documents.Models;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace BusinessLayer.Documents.Services
{
    public static class CreateDoc
    {
        private static string filepath = @"c:\Users\Public\Documents\";
        public static void CreateProxy(AddNewDocRequest request)
        {
            try
            {
                var filename = $"{filepath}Proxy-{Guid.NewGuid()}.docx";
                using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filename, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());
                    Paragraph para = body.AppendChild(new Paragraph());
                    Run run = para.AppendChild(new Run());
                    run.AppendChild(new Text(request.ActionDescription));
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
