using BusinessLayer.Documents.Models;
using DataLayer.Clients;
using DataLayer.Users;
using DocumentFormat.OpenXml.Packaging;

namespace BusinessLayer.Documents.Services
{
    public class FileService : IFileService
    {
        private readonly IClientDataProvider _clientDataProvider;
        private readonly IUserDataProvider _userDataProvider;

        public FileService(
            IClientDataProvider clientDataProvider,
            IUserDataProvider userDataProvider)
        {
            _clientDataProvider = clientDataProvider;
            _userDataProvider = userDataProvider;
        }

        public async Task<string> CreateProxy(AddNewDocRequest request)
        {
            var sourceFile = $"Files/Templates/TrustDocument.docx";
            var docId = Guid.NewGuid();
            var destFile = $"Files/Proxies/TrustDocument-{docId}.docx";

            File.Copy(sourceFile, destFile);

            using (var wordDoc = WordprocessingDocument.Open(destFile, true))
            {
                string docText;

                using (var sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                var majorClient = await _clientDataProvider.GetClientById(request.MajorClientId);
                var minorClient = await _clientDataProvider.GetClientById(request.MinorClientId);
                var notary = await _userDataProvider.GetNotaryById(request.NotaryId);

                var args = new Dictionary<string, string>()
                {
                    { "docterr", request.Territory },
                    { "docdate", request.DocDate.ToString("dd.MM.yyyy") },
                    { "majorclientfullname", $"{majorClient.LastName} {majorClient.FirstName} {majorClient.MiddleName}" },
                    { "minorclientfullname", $"{minorClient.LastName} {minorClient.FirstName} {minorClient.MiddleName}" },
                    { "majorclientdatebirthdate", majorClient.BirthDate.ToString("dd.MM.yyyy") },
                    { "minorclientdatebirthdate", minorClient.BirthDate.ToString("dd.MM.yyyy") },
                    { "majorclientbirthplace", majorClient.BirthPlace },
                    { "minorclientbirthplace", minorClient.BirthPlace },
                    { "majorclientaddress", majorClient.HomeAddress },
                    { "minorclientaddress", minorClient.HomeAddress },
                    { "majorclientiin", majorClient.IINBIN },
                    { "minorclientiin", minorClient.IINBIN },
                    { "titile", request.ActionTitle },
                    { "desctription", request.ActionDescription },
                    { "datebegin", request.DateBegin.ToString("dd.MM.yyyy")  },
                    { "dateend", request.DateEnd.ToString("dd.MM.yyyy")  },
                    { "notterritory", notary.Territory },
                    { "notfullname", $"{notary.LastName} {notary.FirstName} {notary.MiddleName}" },
                    { "notlicensenumber", notary.LicenseNumber },
                    { "notlicensedate", notary.LicenseDate.ToString("dd.MM.yyyy")  },
                    { "docnumber", request.Number }
                };

                docText = args.Aggregate(docText, (current, value) =>
                    current.Replace(value.Key, value.Value));

                using (var sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }
            }

            return docId.ToString();
        }
    }
}