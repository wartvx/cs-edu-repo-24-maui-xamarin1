using CommunityToolkit.Mvvm.Input;
using FirstMauiApp.Models;

namespace FirstMauiApp.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}