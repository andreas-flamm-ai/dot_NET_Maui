using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutTimers.Lib.ViewModels;

namespace WorkoutTimers.Lib.Services
{
    public class InMemoryIntervalService : IIntervalService
    {
        private static List<RegularIntervalModel> _intervals = new List<RegularIntervalModel>();
        private static List<StaggeredIntervalModel> _staggereds = new List<StaggeredIntervalModel>();

        static InMemoryIntervalService()
        {
            _intervals.Add(new RegularIntervalModel
            {
                Name = "Example",
                Duration = TimeSpan.FromMinutes(1),
                Repetitions = 5
            });
            _intervals.Add(new RegularIntervalModel
            {
                Name = "Burpees",
                Duration = TimeSpan.FromSeconds(30),
                Repetitions = 15
            });
            _intervals.Add(new RegularIntervalModel
            {
                Name = "Jumping Jacks",
                Duration = TimeSpan.FromMinutes(1),
                Repetitions = 10
            });

            _staggereds.Add(new StaggeredIntervalModel
            {
                Name = "Staggered 1",
                Repetitions = 1,
                Durations = new ObservableCollection<IntervalDuration>
                {
                    new IntervalDuration {Duration=TimeSpan.FromMinutes(1) },
                    new IntervalDuration {Duration=TimeSpan.FromSeconds(30) },
                    new IntervalDuration {Duration=TimeSpan.FromMinutes(1) }
                }
            });
        }
        public async Task AddRegularIntervalModel(RegularIntervalModel model)
        {
            _intervals.Add(model);
        }

        public async Task AddStaggeredIntervalModel(StaggeredIntervalModel model)
        {
            _staggereds.Add(model);
        }

        public async Task<List<RegularIntervalModel>> GetRegularIntervalModelsAsync()
        {
            return await Task.FromResult(_intervals);
        }

        public async Task<List<StaggeredIntervalModel>> GetStaggeredIntervalModelsAsync()
        {
            return await Task.FromResult(_staggereds);
        }
    }
}
