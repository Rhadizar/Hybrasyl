using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Squirrel;

namespace Launcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static async Task Main()
        {
            using (var mgr = new UpdateManager("https://www.hybrasyl.com/launcher/releases"))
            {
                await mgr.UpdateApp();
            }
        }
    }
}
