using Microsoft.AspNetCore.Components;
using MyTestBlazor.Models;
using MyTestBlazor.Services;

namespace MyTestBlazor.Pages;

public partial class Counter
{
    private int currentCount = 0;
    [Inject] private SingletontServices _singletontServices { get; set; }
    [Inject] private TransientServices _transientServices { get; set; }
    /*[CascadingParameter(Name = nameof(Color))] public string Color { get; set; }
    [CascadingParameter(Name = nameof(Size))] public string Size { get; set; }*/
    [CascadingParameter] public AppStyle Styles { get; set; }

    private void IncrementCount()
    {
        currentCount++;
        _transientServices.Value++;
        _singletontServices.Value++;
    }
}