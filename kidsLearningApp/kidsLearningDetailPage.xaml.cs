namespace kidsLearningApp;

public partial class kidsLearningDetailPage : ContentPage
{
	public kidsLearningDetailPage(string categoryName)
	{
		InitializeComponent();
		DisplayLearningResult(categoryName);
		Title = categoryName;
	}

	private void DisplayLearningResult(string categoryName)
	{
		LearningData learningdata = new LearningData();
		switch (categoryName) {             
		            case "Letters":
		                CvKids.ItemsSource = learningdata.Letters;
		                break;
		            case "Numbers":
		                CvKids.ItemsSource = learningdata.Numbers;
		                break;
		            case "Shapes":
		                CvKids.ItemsSource = learningdata.Shapes;
		                break;
		            case "Colors":
		                CvKids.ItemsSource = learningdata.Colors;
		                break;
<<<<<<< HEAD
            case "Fruits":
                CvKids.ItemsSource = learningdata.Fruits;
                break;
            case "Animals":
                CvKids.ItemsSource = learningdata.Animals;
                break;
            default:
		                break;


=======
		            default:
		                break;
>>>>>>> 9f1dcee85340aef2cc8c9848454b3a0e0b7159a7
		        }
	}

    private async void CvKids_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var selectedItem = e.CurrentSelection.FirstOrDefault() as LearningItem;
		await TextToSpeech.SpeakAsync(selectedItem.Name);
    }
}
