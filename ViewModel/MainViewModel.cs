using PSSchemeUpdated.Model;
using PSSchemeUpdated.Model.Events;
using PSSchemeUpdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PSSchemeUpdated.ViewModel
{
    public class MainViewModel : Notify
    {
        #region ContentSwitch
        
        private ContentControl? myContentControl;
        public ContentControl MyContentControl
        {
            get
            {
                if (myContentControl == null) { myContentControl = new Main_View(); }
                return myContentControl;
            }
            set
            {
                myContentControl = value;
                OnPropertyChanged("MyContentControl");
            }
        }
        private RelayCommand? setObject;

        public RelayCommand SetObject
        {
            get
            {
                return setObject ?? (setObject = new RelayCommand(obj =>
                {
                    if ((obj as string) == "GPU_View") MyContentControl = new GPU_View();
                    if ((obj as string) == "CPU_View") MyContentControl = new CPU_View();
                    if ((obj as string) == "Storage_View") MyContentControl = new Storage_View();
                    if ((obj as string) == "Ram_View") MyContentControl = new Ram_View();
                    if ((obj as string) == "PU_View") MyContentControl = new PU_View();
                    if ((obj as string) == "Motherboard_View") MyContentControl = new Motherboard_View();
                }));
            }
        }
        #endregion
    }
}
