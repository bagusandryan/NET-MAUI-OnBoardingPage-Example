using System.ComponentModel;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using GetEmDone.Models;

namespace GetEmDone.Views;

public partial class OnBoardingPage : ContentPage, INotifyPropertyChanged
{
    private List<OnBoardingItem> _onBoardingItems = new List<OnBoardingItem>(3);

    public List<OnBoardingItem> OnBoardingItems
    {
        get => _onBoardingItems;
        set
        {
            if (_onBoardingItems != value)
            {
                _onBoardingItems = value;
                OnPropertyChanged();
            }
        }
    }

    public OnBoardingPage()
	{
		InitializeComponent();

        //var rd = App.Current.Resources.MergedDictionaries.First();
        //this.Behaviors.Add(new StatusBarBehavior
        //{
        //    StatusBarColor = (Color)rd[""],
        //    StatusBarStyle = StatusBarStyle.DarkContent
        //});

        OnBoardingItems.Add(new OnBoardingItem("Welcome to Toodist",
            "A to-do list app that will help you stay organised and on top of your tasks.",
            "onboarding1.png"));
        OnBoardingItems.Add(new OnBoardingItem("Adding items to your list is easy!",
            " Simply tap the “+” button and enter the text of your new to-do item. Then, tap the “Add” button to add it to your list.",
            "onboarding2.png"));
        OnBoardingItems.Add(new OnBoardingItem("Marking items done is easy!",
            "A to-do list app that will help you stay organised and on top of your tasks.",
            "onboarding3.png",
            "onboarding3a.png"));
    }

    //Show the next item in OnBoardingItems list
    void NextButton_Clicked(System.Object sender, System.EventArgs e)
    {
        if(OnBoardingCarouselView.CurrentItem is OnBoardingItem onBoardingItem)
        {
            int index = OnBoardingItems.IndexOf(onBoardingItem);
            int nextIndex = index + 1;

            //We will only show the next item if the current item is not the last one
            if(nextIndex < OnBoardingItems.Count)
            {
                //Workaround since Position and CurrentItem is officially broken
                //https://github.com/dotnet/maui/issues/9749#issuecomment-1295083252 
                OnBoardingCarouselView.Position = nextIndex;
                OnBoardingCarouselView.Position = index;
                OnBoardingCarouselView.Position = nextIndex;
            }
        }
    }
}
