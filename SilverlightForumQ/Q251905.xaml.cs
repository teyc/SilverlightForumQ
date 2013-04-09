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
using System.ServiceModel.DomainServices.Client;

namespace SilverlightForumQ
{
    public partial class Q251905 : Page
    {
        public Q251905()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LoadData();
        }

        Web.Services.Q251905Context ctx = new Web.Services.Q251905Context();
        protected void LoadData()
        {
            ctx.Load(ctx.GetFormatModelsQuery(), LoadedData, null);
            ctx.Load(ctx.GetFormatFieldModelsQuery());
            
        }

        protected void LoadedData(LoadOperation loadOp)
        {
            DataContext = ctx.FormatModels.First();
        }
    }
}
