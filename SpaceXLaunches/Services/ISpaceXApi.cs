using Refit;
using SpaceXLaunches.Dtos;

namespace SpaceXLaunches.Services
{
    public interface ISpaceXApi
    {
        [Get("/rest/launches")]
        Task<LaunchDto[]?> GetAllLaunches();
    }
}
