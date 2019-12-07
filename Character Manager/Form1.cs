using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Parser.Parser.Init();
            MessageBox.Show(Parser.Parser.GetGearScoreOfPlayer("Крэнц", "Молодая гвардия"));
        }
    }
}
