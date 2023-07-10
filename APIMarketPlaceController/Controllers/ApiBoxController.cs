namespace APIMarketPlaceController.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiBoxController : ControllerBase {
    private IApiBoxService service;

    public ApiBoxController(IApiBoxService _service) {
        service = _service;
    }
    [HttpGet("LoadInfo")]
    public async Task<ActionResult<Api>> loadInfo() {
        return await service.loadInfo();
    }
    
}
