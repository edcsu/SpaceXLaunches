using Microsoft.AspNetCore.Components;
using SpaceXLaunches.Dtos;
using SpaceXLaunches.Services.SpaceXDataService;

namespace SpaceXLaunches.Pages
{
    public partial class Index
    {
        private LaunchDto[]? launchDtos;

        [Inject]
        ISpaceXDataService? spaceXDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            launchDtos = await spaceXDataService!.GetLaunchesAsync();
        }
    }
}
