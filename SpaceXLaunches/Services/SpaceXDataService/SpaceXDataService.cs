using SpaceXLaunches.Dtos;

namespace SpaceXLaunches.Services.SpaceXDataService
{
    public class SpaceXDataService : ISpaceXDataService
    {
        private readonly ISpaceXApi _spaceXApi;

        public SpaceXDataService(ISpaceXApi spaceXApi)
        {
            _spaceXApi = spaceXApi;
        }

        public async Task<LaunchDto[]?> GetLaunchesAsync()
        {
            var launches = await _spaceXApi.GetAllLaunches();
            return launches;
        }
    }
}
