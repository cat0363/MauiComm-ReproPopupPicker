namespace MauiComm_ReproPopupPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            var popup = new Popup();
            var view = popup.Content;
            // view.SetBinding(BindingContextProperty, new Binding { Source = popup, Path = BindingContextProperty.PropertyName });
            cvContent.Content = view;
            // cvContent.SetBinding(BindingContextProperty, new Binding { Source = view, Path = BindingContextProperty.PropertyName });
            cvContent.SetBinding(BindingContextProperty, new Binding { Source = popup, Path = BindingContextProperty.PropertyName });
        }
    }
}