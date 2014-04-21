using System;
using System.Drawing;
using RegistrationAngular.Models;

namespace RegistrationAngular.Service
{
    public interface ISubjectService
    {
        PeriodModel[][] GetAll();
    }

    public class SubjectService : ISubjectService
    {
        public PeriodModel[][] GetAll()
        {
            var chemistry = new Subject { Name = "Chemistry", BgColour = Color.Red, };
            var maths = new Subject { Name = "Maths", BgColour = Color.Blue, };
            var physics = new Subject { Name = "Physics", BgColour = Color.Green };
            var economics = new Subject { Name = "Economics", BgColour = Color.Purple };
            var geography = new Subject { Name = "Geography", BgColour = Color.Yellow };
            var english = new Subject { Name = "English", BgColour = Color.Brown };

            var freePeriod = new PeriodModel { Subject = new Subject(), Blocks = 1 };

            var classDays = new[]
            {
                new[]
                {
                    new PeriodModel { Subject = new Subject { Name = DayOfWeek.Monday.ToString().Substring(0, 3), BgColour = Color.Transparent }, Blocks = 1 },
                    freePeriod,
                    new PeriodModel {Subject = chemistry, Blocks = 3},
                    new PeriodModel{Subject = geography, Blocks = 2}, 
                    new PeriodModel{ Subject = economics, Blocks = 2}, 
                },
                new[]
                {
                    new PeriodModel { Subject = new Subject { Name = DayOfWeek.Tuesday.ToString().Substring(0, 3), BgColour = Color.Transparent }, Blocks = 1 },
                    new PeriodModel {Subject = english, Blocks = 2},
                    new PeriodModel {Subject = physics, Blocks = 2},
                    freePeriod,
                    new PeriodModel {Subject = maths, Blocks = 3},
                },
                new[]
                {
                    new PeriodModel { Subject = new Subject { Name = DayOfWeek.Wednesday.ToString().Substring(0, 3), BgColour = Color.Transparent }, Blocks = 1 },
                    new PeriodModel {Subject = english, Blocks = 2},
                    new PeriodModel {Subject = physics, Blocks = 2},
                    new PeriodModel{ Subject = economics, Blocks = 1}, 
                    new PeriodModel {Subject = maths, Blocks = 3},
                },
                new[]
                {
                    new PeriodModel { Subject = new Subject { Name = DayOfWeek.Thursday.ToString().Substring(0, 3), BgColour = Color.Transparent }, Blocks = 1 },
                    new PeriodModel {Subject = english, Blocks = 2},
                    new PeriodModel {Subject = physics, Blocks = 2},
                    new PeriodModel {Subject = economics, Blocks = 2},
                    new PeriodModel {Subject = geography, Blocks = 2},
                },
                new[]
                {
                    new PeriodModel { Subject = new Subject { Name = DayOfWeek.Friday.ToString().Substring(0, 3), BgColour = Color.Transparent }, Blocks = 1 }, 
                    new PeriodModel {Subject = maths, Blocks = 2},
                    new PeriodModel {Subject = chemistry, Blocks = 4},
                    new PeriodModel {Subject = geography, Blocks = 2},
                }
            };

            return classDays;
        }
    }
}