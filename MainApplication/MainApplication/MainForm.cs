using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class MainForm : Form
    {
        //now lets first create the selection
        //done, we now created a selection using the keyword enum
        public enum TransactionModes { New, Edit, Delete };

        private TransactionModes _TransactionMode;
        //now lets create the variable
        //we can also create a getter and setter, why?
        public TransactionModes TransactionMode
        {
            get { return _TransactionMode; }
            set
            {
                _TransactionMode = value;

                //Because whenever we changed the value
                //it will ensure that the following code
                //will be executed
                if (value == TransactionModes.New)
                    ExecuteNew();
                else if (value == TransactionModes.Edit)
                    ExecuteEdit();
                else if (value == TransactionModes.Delete)
                    ExecuteDelete();
            }
        }

        //Now were done

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void ExecuteNew()
        { 
        }

        private void ExecuteEdit()
        { 
        }

        private void ExecuteDelete()
        { 
        }
    }
}
