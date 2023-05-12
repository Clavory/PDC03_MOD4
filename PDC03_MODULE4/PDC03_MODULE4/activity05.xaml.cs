using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();
            SetupData();
            listView.ItemsSource = contacts;
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Nathaniel Allapitan",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Sync Allapitan",
                Age = 22,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Clavory Allapitan",
                Age = 23,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Niel Allapitan",
                Age = 19,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Nathaniel Allapitan",
                Age = 25,
                Occupation = "Tester",
                Country = "Philippines"

            });
        }
    }
}