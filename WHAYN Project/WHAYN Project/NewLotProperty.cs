using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WHAYN_Project
{
    public class NewLotProperty
    {
        private readonly Action _saveLotAction;
        public NewLotProperty(Action saveLotAction)
        {
            _saveLotAction = saveLotAction;
        }

        public Lots NewLot { get; set; } = new Lots();
        public bool IsSaved { get; set; }

        public ICommand SaveLotComand => new ButtonCommand(SaveLot);

        private void SaveLot()
        {
            IsSaved= true;
        }

        

    }
}
