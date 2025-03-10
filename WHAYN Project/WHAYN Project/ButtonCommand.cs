using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WHAYN_Project
{
    public class ButtonCommand : ICommand
    {
        private Action _action;
        private Func<bool> _condition;
        public ButtonCommand(Action action, Func<bool> condition = null)
        {
            _action = action;
            _condition = condition;
        }
        public bool CanExecute(object? parameter)
        {
            if (_condition == null) return true;

            return _condition();
               
        }

        public void Execute(object? parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested+= value;
                
            remove =>  CommandManager.RequerySuggested -= value;
   
        }
        
    }
}
