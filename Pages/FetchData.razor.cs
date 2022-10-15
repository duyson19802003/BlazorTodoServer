using BlazorTodoServer.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodoServer.Pages
{
    /// <summary>
    /// first way for code behind: using partial class
    /// </summary>
    //public partial class FetchData
    //{
        
    //private WeatherForecast[] forecasts;

    //    //using dependency injection
    //    [Inject] WeatherForecastService ForecastService { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    //    }
    //}

    
    public class FetchDataModel:ComponentBase
    {
        protected WeatherForecast[] forecasts;
        //using dependency injection
        [Inject] WeatherForecastService ForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }

}
