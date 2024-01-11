using Explorer.MVVM.Model;
using Microsoft.Maui.Platform;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CultureViewModel
    {
        public List<Culture_History_Model> Culture { get; set; } = new List<Culture_History_Model>();
        public CultureViewModel()
        {
            Culture_History_Model culture_Model = new Culture_History_Model()
            {
                Id = 1,
                Name = "Test",
                Description = "test des"
            };

            Culture.Add(culture_Model);
            Culture.Add(culture_Model);
            Culture.Add(culture_Model);
            Culture.Add(culture_Model);
            Culture.Add(culture_Model);
        }
    }
}
