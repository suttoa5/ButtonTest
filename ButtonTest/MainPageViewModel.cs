using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonTest
{
    public partial class MainPageViewModel : ObservableObject
    {

        [RelayCommand]
        static async Task GoAddPage()
        {

            await Shell.Current.GoToAsync("AddPage");
            Console.WriteLine("test");

        }
    } 
}
