using Microsoft.AspNetCore.Components;
using MudBlazor;
using SpaceXLaunches.Components.Launches;
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

        private void OpenLaunchDialog(LaunchDto launch)
        {
            var parameters = new DialogParameters { { "model", launch } };

            var options = new DialogOptions { CloseOnEscapeKey = true, FullWidth = true, MaxWidth = MaxWidth.Large, CloseButton = true, };

            DialogService.Show<View>("Launch details", parameters, options);
        }
    }
}
