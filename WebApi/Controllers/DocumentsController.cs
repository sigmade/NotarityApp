using BusinessLayer.Documents.Models;
using BusinessLayer.Documents.Services;
using Microsoft.AspNetCore.Mvc;
using WebApi.monitoring.Errors;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IErrorHandler _error;
        private readonly IWebHostEnvironment _appEnvironment;

        public DocumentsController(
            IDocumentService documentService,
            IErrorHandler error,
            IWebHostEnvironment appEnvironment)
        {
            _documentService = documentService;
            _error = error;
            _appEnvironment = appEnvironment;
        }

        [HttpPost]
        [ProducesResponseType(500)]
        [ProducesResponseType(503)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> AddNewDocument(AddNewDocRequest request)
        {
            string docId;
            try
            {
                request.UserId = 1; // TODO: Определять юзера по токену
                docId = await _documentService.AddProxy(request);
            }
            catch (Exception ex)
            {
                return StatusCode(500, _error.DefaultHandle(nameof(AddNewDocument), ex));
            }

            return Ok(docId);
        }
    }
}