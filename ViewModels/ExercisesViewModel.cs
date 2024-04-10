namespace _6002CEM_BohdanYermakov.ViewModels;
using _6002CEM_BohdanYermakov.Models;

public class ExercisesViewModel
{
    public ObservableCollection<Exercise> Exercises { get; set; }

    public ExercisesViewModel()
    {
        Exercises = new ObservableCollection<Exercise>
        {
            new Exercise
            {
                Name = "Arm Circles",
                Reps = "Reps - 3x15",
                Description = "Make circular movements with your arms to improve joint function.",
                ImageSource = "arm_circles.png"
            },
            new Exercise
            {
                Name = "Lunges",
                Reps = "Reps - 3x10",
                Description = "The lunge targets the quadriceps and the hamstring muscles in the thigh, the gluteal muscles in the buttock, and to a lesser extent, the lower leg muscles.",
                ImageSource = "lunges.png" 
            },
            new Exercise
            {
                Name = "Planks",
                Reps = "Reps - 3x1 minute",
                Description = "Held in a push-up-like position, with the body's weight borne on forearms, elbows, and toes.",
                ImageSource = "planks.png" 
            },
            new Exercise
            {
                Name = "Sit-ups",
                Reps = "Reps - 3x12",
                Description = "Use your body weight to strengthen and tone the core-stabilizing abdominal muscles.",
                ImageSource = "situps.png"
            },
            new Exercise
            {
                Name = "Bicycle Crunches",
                Reps = "Reps - 2x25",
                Description = "Raising your legs, you also engage the transverse abdominis, which is the deep ab muscle that is difficult to target.",
                ImageSource = "bicycle_crunches.png" 
            }
        };
    }
}
