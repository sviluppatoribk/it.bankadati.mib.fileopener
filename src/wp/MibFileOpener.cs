using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Storage;
using Windows.System;
using System.Text;

namespace WPCordovaClassLib.Cordova.Commands
{
    public class MibFileOpener : BaseCommand
    {
        /// <summary>
        /// Apre un file chiamando le API di sistema
        /// NB: Accetta un solo parametro che rappresenta il fileUrl che deve essere nel seguente formato:
        ///     /path/to/folder/file.ext
        /// </summary>
        /// <param name="parameters">Oggetto contenente i parametri ricevuti da cordova</param>
        public async void openFile(string parameters)
        {
            var parametersArray = JSON.JsonHelper.Deserialize<string[]>(parameters);
            if (parametersArray.Length == 0)
            {
                System.Diagnostics.Debug.WriteLine("it.bankadati.mib.fileopener.openFile: Errore durante il parsing dei parametri, non sono presenti parametri");
                this.DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, "it.bankadati.mib.fileopener.openFile: Errore durante il parsing dei parametri, non sono presenti parametri"));
                return;
            }

            /*
             * GET & Sistemazione file url:
             *  "The path cannot be in Uri format (for example, /image.jpg). Check the value of name." -> https://msdn.microsoft.com/en-us/library/windows/apps/windows.storage.storagefolder.getfileasync
            */
            var fileUrl = parametersArray[0];
            if (fileUrl.StartsWith("/")) fileUrl = fileUrl.Substring(1);    //Rimuovo lo slash iniziale che "dà fastidio" alla GetFileAsync
            fileUrl = fileUrl.Replace('/', '\\');

            if (!String.IsNullOrEmpty(fileUrl))
            {
                try
                {
                    var localIsoStorage = Windows.Storage.ApplicationData.Current.LocalFolder;	//Local folder: "//local/"
                    var file = await localIsoStorage.GetFileAsync(fileUrl);

                    if (file != null)
                    {
                        IAsyncOperation<bool> success = Windows.System.Launcher.LaunchFileAsync(file);

                        if (await success)
                        {
                            this.DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "it.bankadati.mib.fileopener.openFile: File aperto correttamente"));
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("it.bankadati.mib.fileopener.openFile: Non è stato possibile aprire l'app associabile al file: " + fileUrl);
                            this.DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, "it.bankadati.mib.fileopener.openFile: Non è stato possibile aprire l'app associabile al file: " + fileUrl));
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("it.bankadati.mib.fileopener.openFile: File non trovato: " + fileUrl);
                        this.DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, "it.bankadati.mib.fileopener.openFile: File non trovato: " + fileUrl));
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("it.bankadati.mib.fileopener.openFile: Exception: " + e.ToString());
                    this.DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, "it.bankadati.mib.fileopener.openFile: Exception: " + e.ToString()));
                }
            }
        }
    }

}
