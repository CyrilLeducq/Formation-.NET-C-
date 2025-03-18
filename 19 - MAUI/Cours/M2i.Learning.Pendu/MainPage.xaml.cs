using System.Diagnostics;
using M2i.LEarning.Pendu.ViewModels;

namespace M2i.LEarning.Pendu
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void btnLetter_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;
            var letter = button.Text;
            Debug.WriteLine(letter);
        }
    }

}
