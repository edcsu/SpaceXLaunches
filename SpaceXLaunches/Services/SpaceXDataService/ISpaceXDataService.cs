using SpaceXLaunches.Dtos;

namespace SpaceXLaunches.Services.SpaceXDataService
{
    public interface ISpaceXDataService
    {
        Task<LaunchDto[]?> GetLaunchesAsync();
    }
}
