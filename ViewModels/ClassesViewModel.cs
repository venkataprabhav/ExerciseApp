namespace _6002CEM_BohdanYermakov.ViewModels;
using _6002CEM_BohdanYermakov.Models;
using System.Windows.Input;

public class ClassesViewModel
{
    public ObservableCollection<ClassInfo> Classes { get; set; }
    public ICommand GetStartedCommand { get; private set; }

    public ClassesViewModel()
    {
        InitializeClasses();
    }

    private void InitializeClasses()
    {
        Classes = new ObservableCollection<ClassInfo>
            {
                new ClassInfo
                {
                    Title = "Swimming",
                    Schedule = "Every Tuesday 9-11:00",
                    Description = "Use the power of your body and water to improve the health of your back.",
                    ImageSource = "swimming.png",
                    AdditionalInfoImage = "swimming_details.png",
                    CautionImage = "caution.png"
                },
                new ClassInfo
                {
                    Title = "Yoga",
                    Schedule = "Every Monday and Thursday 19-21:30",
                    Description = "Get to the world of different stretches that would improve your muscle's health.",
                    ImageSource = "yoga.png",
                    AdditionalInfoImage = "yoga_details.png",
                    CautionImage = "caution.png"
                },
                new ClassInfo
                {
                    Title = "Boxing",
                    Schedule = "Every Friday 19-20:30 and Saturday 16:30-18:00",
                    Description = "Get to know how to protect yourself.",
                    ImageSource = "boxing.png",
                    AdditionalInfoImage = "boxing_details.png",
                    CautionImage = "caution.png"
                },
                new ClassInfo
                {
                    Title = "Pilates",
                    Schedule = "Every Wednesday 17-18:50",
                    Description = "Explore how you could improve the flexibility of your body in different ways.",
                    ImageSource = "pilates.png",
                    AdditionalInfoImage = "pilates_details.png",
                    CautionImage = "caution.png"
                },
                new ClassInfo
                {
                    Title = "CrossFit",
                    Schedule = "Every Friday 15-17:00",
                    Description = "Train hard in a group CrossFit to figure out how far you can go.",
                    ImageSource = "crossfit.png",
                    AdditionalInfoImage = "crossfit_details.png",
                    CautionImage = "caution.png"
                }
            };
    }

}
