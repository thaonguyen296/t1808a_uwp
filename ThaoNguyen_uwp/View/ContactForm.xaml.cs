using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ThaoNguyen_uwp.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ThaoNguyen_uwp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactForm : Page
    {
        private ContactModel contactModel;
        static int Id;

        public ContactForm()
        {
            this.InitializeComponent();
            this.contactModel = new ContactModel();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Entity.Contact contact = new Entity.Contact()
            {
                Name = name.Text,
                PhoneNumber = phoneNumber.Text
            };
            contactModel.Insert(contact);
        }
        private void ButtonSearch_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SearchContact));
        }
    }
}
