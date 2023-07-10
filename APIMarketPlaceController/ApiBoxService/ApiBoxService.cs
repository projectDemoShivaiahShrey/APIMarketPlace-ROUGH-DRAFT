namespace APIMarketPlaceController.Service;

public class ApiBoxService : IApiBoxService {
    private DataContext _context;
    public ApiBoxService(DataContext context) {
        _context = context;
    }
    public async Task<ActionResult<Api>> loadInfo() {
        var dbApi = await _context.Apis.FirstAsync();
        return dbApi;
    }
}