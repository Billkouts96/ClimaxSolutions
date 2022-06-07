using System;
using System.Collections.Generic;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using LiveCharts;
using Climax_trial.MVVM.Model;

namespace Climax_trial.Services
{
    class ChartsService
    {
        public static SeriesCollection CreateSeriesCollection(Dictionary<string, float> categories)
        {
            SeriesCollection collection = new SeriesCollection();
            foreach (var category in categories)
            {
                collection.Add(new PieSeries
                {
                    Title = category.Key,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(category.Value) },
                    LabelPoint = chartPoint => String.Format("{0}", category.Value),
                    DataLabels = true
                });
            }
            return collection;
        }
    }
}

