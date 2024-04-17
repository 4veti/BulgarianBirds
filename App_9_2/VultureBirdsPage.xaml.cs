using App_9_2.Models.BirdsInfo;
using App_9_2.Models.Contracts;
using App_9_2.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_9_2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VultureBirdsPage : ContentPage
    {
        private const double ScaleWith = 0.3;
        private int zoomLevel = 1;
        private double currentScale = 1;

        public VultureBirdsPage()
        {
            InitializeComponent();
            List<IBird> birds = BirdsInfo.GetVultureBirds();
            BindingContext = new BirdViewModel(birds);
            ZoomedImage.IsEnabled = false;
            ZoomedImage.IsVisible = false;
            ZoomedModeDarkening.IsEnabled = false;
            ZoomedModeDarkening.IsVisible = false;
        }

        /// <summary>
        ///     Pan ZoomedImage. If pan reaches a certain value of the Y axis,
        ///     set 'zoomLevel' to 1 and go to the method for hiding the ZoomedImage.
        /// </summary>
        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            ZoomedImage.TranslationX += e.TotalX;
            ZoomedImage.TranslationY += e.TotalY;

            if (ZoomedImage.TranslationY > 270 * (zoomLevel * 0.7))
            {
                zoomLevel = 1;
                TapGestureRecognizer_Tapped_ZoomedImage(sender, e);
            }
        }

        /// <summary>
        ///     Zoom the 'ZoomedImage' element by scaling it. New scale is calculated and applied.
        ///     Also increments 'zoomLevel' by 1.
        /// </summary>
        private void TapGestureRecognizer_Tapped_ZoomedImage_Twice(object sender, EventArgs e)
        {
            if (zoomLevel <= 5)
            {
                currentScale += ScaleWith * (zoomLevel * 2);
                ZoomedImage.ScaleTo(currentScale, 150, Easing.CubicIn);
                zoomLevel++;
            }
        }

        /// <summary>
        ///     Return 'ZoomedImage' to original scale if it's already zoomed.
        ///     Hide and disable it if it's not already zoomed.
        /// </summary>
        private void TapGestureRecognizer_Tapped_ZoomedImage(object sender, EventArgs e)
        {
            if (zoomLevel > 1)
            {
                ZoomedImage.ScaleTo(1, 150, Easing.CubicIn);
                ZoomedImage.TranslateTo(0, 0, 150, Easing.Linear);
                zoomLevel = 1;
            }
            else
            {
                ZoomedImage.TranslateTo(0, 0, 250);
                ZoomedImage.ScaleTo(1, 250);
                ZoomedImage.IsEnabled = false;
                ZoomedImage.IsVisible = false;
                ZoomedModeDarkening.IsEnabled = false;
                ZoomedModeDarkening.IsVisible = false;
            }

            currentScale = 1;
        }

        /// <summary>
        ///     Show and enable 'ZoomedImage'.
        /// </summary>
        private void TapGestureRecognizer_Tapped_PreviewImage(object sender, EventArgs e)
        {
            ZoomedImage.Source = (sender as Image).Source;
            ZoomedImage.IsEnabled = true;
            ZoomedImage.IsVisible = true;
            ZoomedModeDarkening.IsEnabled = true;
            ZoomedModeDarkening.IsVisible = true;
        }
    }
}