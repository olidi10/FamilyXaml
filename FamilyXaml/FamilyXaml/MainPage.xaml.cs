using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FamilyXaml
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        //public ImageSource 
            
        //Image = new FamilyXaml.ImageSource
        //{
        //    Source FamilyXaml.ImageSource.FromMultiResource(),
        //};
           
        //[ContentProperty("Source")]
        //public class ImageResourceExtension : IMarkupExtension
        //{
        //    public string Source { get; set;}

        //    public object ProvideValue (IServiceProvider serviceProvider)
        //    {
        //        if (Source == null)
        //        {
        //            return null;
        //        }

        //        var imageSource = ImageSource.FromResource(Source);

        //        return imageSource;
        //    }
        //}
    }
}
