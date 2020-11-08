using BlazorAppClient.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


/// <summary>
/// state class manages state of the application
/// it is a singleton injected into all the places wher it is needed
/// https://stackoverflow.com/questions/61153706/blazor-passing-listt-between-components
/// https://chrissainty.com/3-ways-to-communicate-between-components-in-blazor/
/// </summary>
public class State
{
    //
    public event Action OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();

    //
    public MCourse course { get; private set; } = new MCourse();
    public List<MUsersAnswers> answers { get; private set; } = new List<MUsersAnswers>();

    public void SetCourse(MCourse course)
    {
        this.course = course;
        NotifyStateChanged();
    }

    public void SetAnswer(MUsersAnswers answer)
    {
        this.answers.Add(answer);
        NotifyStateChanged();
    }

    public void SetAnswers(List<MUsersAnswers> answers)
    {
        this.answers = answers;
        NotifyStateChanged();
    }
}
