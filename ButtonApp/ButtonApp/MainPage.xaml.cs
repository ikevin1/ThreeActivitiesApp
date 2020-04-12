using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/*
 * Changed the app icon in [MainActivity.cs]
 */


namespace ButtonApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

        }

      
        int index = 0;

        public List<string> questions = new List<String>

        {

            "Spanish is Espanol","The sky is blue.", "Jesus was baptized by John D' Baptise", "Waukesha is a county in Wisconsin", "Wisconsin is the business capital of the US."

        };

        public void trueButton(object sender, EventArgs args)
            {
            showQuiz.Text = questions[index++];

            if (index >= questions.Count())

            {

                index = 0;

            }
        }

            public void falseButton(object sender, EventArgs args)
            {
            showQuiz.Text = questions[index--];

            if (index <= questions.Count())

            {

                index = questions.Count - 1;

            }
        }        
    }
}
