using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace SilverlightForumQ
{
    public partial class QuestionsPage : Page
    {
        public QuestionsPage()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }

    public class Question
    {
        public string Title { get; set; }
        public Uri QuestionURL { get; set; }
        public string Answer { get; set; }
    }

    public class QuestionCollection: List<Question>
    {

    }
}
