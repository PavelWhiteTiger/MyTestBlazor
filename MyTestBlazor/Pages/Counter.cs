using Microsoft.AspNetCore.Components;
using MyTestBlazor.Services;

namespace MyTestBlazor.Pages;

public partial class Counter
{
    private int currentCount = 0;
    [Inject] private SingletontServices _singletontServices { get; set; }
    [Inject] private TransientServices _transientServices { get; set; } 

    private void IncrementCount()
    {
        currentCount++;
        _transientServices.Value++;
        _singletontServices.Value++;
    }
}