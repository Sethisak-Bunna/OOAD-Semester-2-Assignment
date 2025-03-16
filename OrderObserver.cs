using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern_Project
{
    public interface IOrderObserver
    {
        void Update(string message);
    }

    public class OrderNotifier : IOrderObserver
    {
        public void Update(string message) => MessageBox.Show(message);
    }
}
