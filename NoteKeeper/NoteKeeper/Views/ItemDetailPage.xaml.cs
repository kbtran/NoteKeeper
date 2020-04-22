using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections.Generic;

namespace NoteKeeper.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public Note Note { get; set; }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();

            BindingContext = Note;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();

            BindingContext = Note;
        }

        public void InitializeData()
        {
            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for a test note" 
            };
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Cancel option", "Cancel was selected", "Button 1", "Button 2");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save option", "Save was clicked", "Button 1", "Button 2");
        }
    }
}