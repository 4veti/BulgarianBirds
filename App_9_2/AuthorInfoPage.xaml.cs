using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_9_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorInfoPage : ContentPage
    {
        public AuthorInfoPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public string QuotesText => "'- 'Който нож вади, той нож има.'\r\n- 'Имало едно време и сега пак го има.'\r\n- 'Голям залък лапни, ама да не е много голям.'\r\n- 'Където е текло, е мокро.'\r\n- 'Капка по капка прави Капка на квадрат.'";
    }
}