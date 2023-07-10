namespace APIMarketPlaceController.Service;

public interface IApiBoxService {
    public Task<ActionResult<Api>> loadInfo();
}